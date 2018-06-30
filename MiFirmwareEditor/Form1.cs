using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiFirmwareEditor
{

    public partial class Form1 : Form
    {

        /*  TODO:
         *  - error handling!
         *  - import of bitmaps as sources
         *  - "dragging" mouse down over squares marks them all
         *  - multiple sized "tips" for mouse
         *  - warning in the beginning
         */

        vars extVariable = new vars();

        Boolean[,] drawingAreaBuffer = new Boolean[40, 40];

        int currentEditorWidth = 40; //FIX NAMING BECAUSE ITS ALL FLIPPED SOMEHOW!!!
        int currentEditorHeight = 36;
        int editorOffsetX = 20;
        int editorOffsetY = 70;
        int drawingRectangleSize = 15;

        private Graphics z;
        private Pen stift = new Pen(Color.Black);
        private SolidBrush pinsel = new SolidBrush(Color.Black);

        String[,] versions = new String[,] {
            { "1.0.1.54 Mili_pro.fw", "pro_1.0.1.54" },
            { "1.0.1.81 Mili_pro.fw", "pro_1.0.1.81" }
        };

        private String tempFilePath = null;
        String currentVersion = "pro_1.0.1.54";
        bool firmwareLoaded = false;

        bool editorModeAddPixel = true;
        int editorBrushWidth = 1;

        int editorMouseDownLastX = -1;
        int editorMouseDownLastY = -1;

        int editorLastHoverPixelX = -1;
        int editorLastHoverPixelY = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Draw Notification Editor
            z = CreateGraphics();

            //Setup of Dropdown Box:
            for (int i = 0; i < versions.GetLength(0); i++)
            {
                comboBoxVersionSelect.Items.Add(versions[i, 0]);
            }
            
            for (int i = 0; i < extVariable.getCategories(currentVersion).Length; i++)
            {
                cbCategory.Items.Add(extVariable.getCategories(currentVersion)[i]);
            }

            comboBoxVersionSelect.SelectedIndex = 0;
            currentVersion = versions[comboBoxVersionSelect.SelectedIndex, 1];

            //Initialize editor buffer
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    drawingAreaBuffer[i, j] = false;
                }
            }

           

            //Setup Temp file location
            tempFilePath = Path.GetTempFileName();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curIndex = cbCategory.SelectedIndex;

            cbEditItem.Items.Clear();

            switch (curIndex)
            {
                case 0:
                    Console.WriteLine(extVariable.getNotificationNames(currentVersion).GetLength(0));
                    for (int i = 0; i < extVariable.getNotificationNames(currentVersion).GetLength(0); i++)
                    {
                        cbEditItem.Items.Add(extVariable.getNotificationNames(currentVersion)[i, 0]);
                    }
                    break;
                case 1:
                    for (int i = 0; i < extVariable.getMediumNumberNames(currentVersion).GetLength(0); i++)
                    {
                        cbEditItem.Items.Add(extVariable.getMediumNumberNames(currentVersion)[i, 0]);
                    }
                    break;
                case 2:
                    for (int i = 0; i < extVariable.getSmallDateTextAndWidths(currentVersion).GetLength(0); i++)
                    {
                        cbEditItem.Items.Add(extVariable.getSmallDateTextAndWidths(currentVersion)[i, 0]);
                    }
                    break;
            }

            cbEditItem.SelectedIndex = 0;
        }

        private void drawEditorArea(int width, int height)
        {

            int offsetX = editorOffsetX;
            int offsetY = editorOffsetY;
            int xPosition = offsetX;
            int yPosition = offsetY;

            //Draw empty rectangle first to clear area!
            pinsel.Color = BackColor;
            z.FillRectangle(pinsel, xPosition, yPosition, drawingRectangleSize * 41, drawingRectangleSize * 41);
            pinsel.Color = Color.Black;

            //Draw grid
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (drawingAreaBuffer[j, i] == true)
                    {
                        z.FillRectangle(pinsel, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                    }

                    else
                    {
                        pinsel.Color = BackColor;
                        z.FillRectangle(pinsel, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                        pinsel.Color = Color.Black;
                        z.DrawRectangle(stift, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                    }
                    xPosition += drawingRectangleSize;
                }
                xPosition = offsetX;
                yPosition += drawingRectangleSize;
            }
        }

        private void Form1_Shown_1(object sender, EventArgs e)
        {
            buttonFirmwareSave.Enabled = false;

            MessageBox.Show("Your warranty is now probably void. I am not responsible for any bricked devices, do this at your own risk!", "DISCLAIMER",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            cbCategory.SelectedIndex = 0;
            //drawEditorArea(currentEditorWidth, currentEditorHeight);
        }

        private void buttonFillRectangle_Click(object sender, EventArgs e)
        {
            int xpos = Convert.ToInt16(tbXPos.Text);
            int ypos = Convert.ToInt16(tbYPos.Text);
            int width = Convert.ToInt16(tbWidth.Text);
            int height = Convert.ToInt16(tbHeight.Text);

            if (xpos > currentEditorHeight || ypos > currentEditorWidth) //NAMING OF VARIABLES IS FLIPPED!!!
            {
                //Error startposition out of bounds
            }
            else if ((xpos + width) > currentEditorHeight || (ypos + height) > currentEditorWidth)
            {
                //Error rectangle out of bounds
            }
            else
            {
                for (int i = xpos; i < (xpos + width); i++)
                {
                    for (int j = ypos; j < (ypos + height); j++)
                    {
                        drawingAreaBuffer[i, j] = true;
                    }
                }
                drawEditorArea(currentEditorWidth, currentEditorHeight);
            }
        }

        private void buttonredrawEditor_Click(object sender, EventArgs e)
        {
            drawEditorArea(currentEditorWidth, currentEditorHeight);
        }

        private void buttonInvertRectangle_Click(object sender, EventArgs e)
        {
            int xpos = Convert.ToInt16(tbXPos.Text);
            int ypos = Convert.ToInt16(tbYPos.Text);
            int width = Convert.ToInt16(tbWidth.Text);
            int height = Convert.ToInt16(tbHeight.Text);

            if (xpos > currentEditorHeight || ypos > currentEditorWidth)
            {
                //Error startposition out of bounds
            }
            else if ((xpos + width) > currentEditorHeight || (ypos + height) > currentEditorWidth)
            {
                //Error rectangle out of bounds
            }
            else
            {
                for (int i = xpos; i < (xpos + width); i++)
                {
                    for (int j = ypos; j < (ypos + height); j++)
                    {
                        drawingAreaBuffer[i, j] = !drawingAreaBuffer[i, j];
                    }
                }
                drawEditorArea(currentEditorWidth, currentEditorHeight);
            }
        }

        private void buttonUnfillRectangle_Click(object sender, EventArgs e)
        {
            int xpos = Convert.ToInt16(tbXPos.Text);
            int ypos = Convert.ToInt16(tbYPos.Text);
            int width = Convert.ToInt16(tbWidth.Text);
            int height = Convert.ToInt16(tbHeight.Text);

            if (xpos > currentEditorHeight || ypos > currentEditorWidth)
            {
                //Error startposition out of bounds
            }
            else if ((xpos + width) > currentEditorHeight || (ypos + height) > currentEditorWidth)
            {
                //Error rectangle out of bounds
            }
            else
            {
                for (int i = xpos; i < (xpos + width); i++)
                {
                    for (int j = ypos; j < (ypos + height); j++)
                    {
                        drawingAreaBuffer[i, j] = false;
                    }
                }
                drawEditorArea(currentEditorWidth, currentEditorHeight);
            }
        }

        //Generates the code from the data of the editor for notifications
        private int[] generateNotificationBinaryCode(int columns, int rows)
        {

            int[] dataArray = new int[1600]; //biggest possible size
            int dataArrayPointer = 0;

            for (int row = 7; row < rows; row += 8)
            {
                for (int column = 0; column < columns; column++)
                {
                    int curRowPos = row;
                    int curWordValue = 0;

                    //Lower half of byterow
                    if (drawingAreaBuffer[column, curRowPos] == true) curWordValue += 128;
                    curRowPos--;
                    if (drawingAreaBuffer[column, curRowPos] == true) curWordValue += 64;
                    curRowPos--;
                    if (drawingAreaBuffer[column, curRowPos] == true) curWordValue += 32;
                    curRowPos--;
                    if (drawingAreaBuffer[column, curRowPos] == true) curWordValue += 16;
                    curRowPos--;

                    //Upper half of byterow
                    if (drawingAreaBuffer[column, curRowPos] == true) curWordValue += 8;
                    curRowPos--;
                    if (drawingAreaBuffer[column, curRowPos] == true) curWordValue += 4;
                    curRowPos--;
                    if (drawingAreaBuffer[column, curRowPos] == true) curWordValue += 2;
                    curRowPos--;
                    if (drawingAreaBuffer[column, curRowPos] == true) curWordValue += 1;

                    dataArray[dataArrayPointer] = curWordValue;
                    dataArrayPointer++;
                }
            }

            dataArray[1599] = dataArrayPointer; //Last point in Array to show max. length of array!

            return dataArray;


        }

        private String wordToHex(int input, Boolean uppercase)
        {
            String currentWordValueHex = "0";

            if (input < 10)
            {
                currentWordValueHex = input.ToString();
            }
            else if (input == 10)
            {
                currentWordValueHex = "a";
            }
            else if (input == 11)
            {
                currentWordValueHex = "b";
            }
            else if (input == 12)
            {
                currentWordValueHex = "c";
            }
            else if (input == 13)
            {
                currentWordValueHex = "d";
            }
            else if (input == 14)
            {
                currentWordValueHex = "e";
            }
            else if (input == 15)
            {
                currentWordValueHex = "f";
            }

            if (uppercase)
            {
                currentWordValueHex = currentWordValueHex.ToUpper();
            }

            return currentWordValueHex;
        }
        
        private String longWortToHex(int input, Boolean uppercase = false)
        {

            String currentWordValueHex = "0";
            int limit = 240;

            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "f";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "e";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "d";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "c";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "b";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "a";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "9";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "8";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "7";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "6";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "5";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "4";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "3";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "2";
            }
            limit -= 16;
            if (input >= limit)
            {
                input -= limit;
                currentWordValueHex = "1";
            }

            if (input < 10)
            {
                currentWordValueHex += input.ToString();
            }
            else if (input == 10)
            {
                currentWordValueHex += "a";
            }
            else if (input == 11)
            {
                currentWordValueHex += "b";
            }
            else if (input == 12)
            {
                currentWordValueHex += "c";
            }
            else if (input == 13)
            {
                currentWordValueHex += "d";
            }
            else if (input == 14)
            {
                currentWordValueHex += "e";
            }
            else if (input == 15)
            {
                currentWordValueHex += "f";
            }


            if (uppercase)
            {
                currentWordValueHex = currentWordValueHex.ToUpper();
            }

            return currentWordValueHex;
        }

        private void loadSymbolFromTemp(int startPosition, int length)
        {
            if (firmwareLoaded)
            {
                BinaryReader temp = new BinaryReader(File.Open(tempFilePath, FileMode.Open));
                temp.BaseStream.Position = startPosition;

                for (int row = 7; row < currentEditorWidth; row += 8)
                {
                    for (int column = 0; column < currentEditorHeight; column++)
                    {
                        int curRowPos = row;
                        int curByteVal = temp.ReadByte();

                        //Lower half of byterow
                        if (curByteVal >= 128) drawingAreaBuffer[column, curRowPos] = true;
                        else drawingAreaBuffer[column, curRowPos] = false;
                        curByteVal = curByteVal % 128;

                        if (curByteVal >= 64) drawingAreaBuffer[column, curRowPos - 1] = true;
                        else drawingAreaBuffer[column, curRowPos - 1] = false;
                        curByteVal = curByteVal % 64;

                        if (curByteVal >= 32) drawingAreaBuffer[column, curRowPos - 2] = true;
                        else drawingAreaBuffer[column, curRowPos - 2] = false;
                        curByteVal = curByteVal % 32;

                        if (curByteVal >= 16) drawingAreaBuffer[column, curRowPos - 3] = true;
                        else drawingAreaBuffer[column, curRowPos - 3] = false;
                        curByteVal = curByteVal % 16;

                        //Upper half of byterow

                        if (curByteVal >= 8) drawingAreaBuffer[column, curRowPos - 4] = true;
                        else drawingAreaBuffer[column, curRowPos - 4] = false;
                        curByteVal = curByteVal % 8;

                        if (curByteVal >= 4) drawingAreaBuffer[column, curRowPos - 5] = true;
                        else drawingAreaBuffer[column, curRowPos - 5] = false;
                        curByteVal = curByteVal % 4;

                        if (curByteVal >= 2) drawingAreaBuffer[column, curRowPos - 6] = true;
                        else drawingAreaBuffer[column, curRowPos - 6] = false;
                        curByteVal = curByteVal % 2;

                        if (curByteVal >= 1) drawingAreaBuffer[column, curRowPos - 7] = true;
                        else drawingAreaBuffer[column, curRowPos - 7] = false;
                        curByteVal = curByteVal % 1;
                    }
                }

                temp.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //generateNotificationBinaryCode(currentEditorHeight, currentEditorWidth);
            //Console.WriteLine(Convert.ToInt32("28aae", 16));
            for (int i = 0; i < extVariable.getSmallDateTextAndWidths(currentVersion).GetLength(0); i++)
            {
                Int32 start = Convert.ToInt32(extVariable.getSmallDateTextAndWidths(currentVersion)[i, 2], 16);
                Int32 end = Convert.ToInt32(extVariable.getSmallDateTextAndWidths(currentVersion)[i, 3], 16);
                Int32 length = end - start + 1;
                Console.Write(length + " width: " + extVariable.getSmallDateTextAndWidths(currentVersion)[i, 1]);

            }
        }

        private void buttonFirmwareLoad_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();

            Form.ActiveForm.Enabled = false;

            BinaryReader firmwareFile = new BinaryReader(File.Open(ofd.FileName, FileMode.Open));
            BinaryWriter tempFile = new BinaryWriter(File.Open(tempFilePath, FileMode.Open));

            firmwareFile.BaseStream.Position = 0;
            tempFile.BaseStream.Position = 0;

            for (int i = 0; i < firmwareFile.BaseStream.Length; i++)
            {
                tempFile.Write(firmwareFile.ReadByte());
            }


            firmwareFile.Close();
            tempFile.Close();

            firmwareLoaded = true;
            Form.ActiveForm.Enabled = true;
            buttonFirmwareSave.Enabled = true;

            currentItemChanged();
        }

        private void buttonFirmwareSave_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();

            Form.ActiveForm.Enabled = false;

            BinaryReader tempFile = new BinaryReader(File.Open(tempFilePath, FileMode.Open));
            BinaryWriter newFirmwareFile = new BinaryWriter(File.Open(sfd.FileName, FileMode.Create));

            tempFile.BaseStream.Position = 0;
            newFirmwareFile.BaseStream.Position = 0;

            for (int i = 0; i < tempFile.BaseStream.Length; i++)
            {
                //firmwareFile.BaseStream.Position = i;
                newFirmwareFile.Write(tempFile.ReadByte());

                //Console.Write(firmwareFile.ReadByte() + " ");
            }

            tempFile.Close();
            newFirmwareFile.Close();

            Form.ActiveForm.Enabled = true;
        }

        private void buttonEditorSave_Click(object sender, EventArgs e)
        {
            int curCategoryIndex = cbCategory.SelectedIndex;
            int curItemIndex = cbEditItem.SelectedIndex;

            BinaryWriter tempFile = new BinaryWriter(File.Open(tempFilePath, FileMode.Open));
            
            int startPosition = 0;

            int[] data = generateNotificationBinaryCode(currentEditorHeight, currentEditorWidth);


            switch (curCategoryIndex)
            {
                case 0: //Notifications
                    startPosition = Convert.ToInt32(extVariable.getNotificationNames(currentVersion)[curItemIndex, 1], 16);
                    break;
                case 1: //Medium Time
                    startPosition = Convert.ToInt32(extVariable.getMediumNumberNames(currentVersion)[curItemIndex, 1], 16);
                    break;
                case 2: //Small Date Letters
                    startPosition = Convert.ToInt32(extVariable.getSmallDateTextAndWidths(currentVersion)[curItemIndex, 2], 16);
                    break;
            }

            tempFile.BaseStream.Position = startPosition;

            for (int i = 0; i < data[1599]; i++)
            {  
                tempFile.Write(Convert.ToByte(data[i]));
            }

            tempFile.Close();
        }

        private void currentItemChanged()
        {
            int curCategoryIndex = cbCategory.SelectedIndex;
            int curItemIndex = cbEditItem.SelectedIndex;
            int startPosition = 0;
            int length = 0;

            //empty data buffer
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    drawingAreaBuffer[i, j] = false;
                }
            }

            switch (curCategoryIndex)
            {
                case 0: //Notifications
                    currentEditorHeight = 36;
                    currentEditorWidth = 40;
                    startPosition = Convert.ToInt32(extVariable.getNotificationNames(currentVersion)[curItemIndex, 1], 16);
                    length = 1440;
                    break;
                case 1: //Medium Time
                    currentEditorHeight = 12;
                    currentEditorWidth = 24;
                    startPosition = Convert.ToInt32(extVariable.getMediumNumberNames(currentVersion)[curItemIndex, 1], 16);
                    length = 288;
                    break;
                case 2: //Small Date Letters
                    currentEditorHeight = Convert.ToInt32(extVariable.getSmallDateTextAndWidths(currentVersion)[curItemIndex, 1]);
                    currentEditorWidth = 16;
                    startPosition = Convert.ToInt32(extVariable.getSmallDateTextAndWidths(currentVersion)[curItemIndex, 2], 16);
                    break;
            }

            length = currentEditorHeight * currentEditorWidth;

            loadSymbolFromTemp(startPosition, length);

            drawEditorArea(currentEditorWidth, currentEditorHeight);
        }

        private void cbEditItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentItemChanged();
        }

        private void buttonEditorDiscard_Click(object sender, EventArgs e)
        {
            currentItemChanged();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timerMouseDown.Enabled = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            editorMouseDownLastX = -1;
            editorMouseDownLastY = -1;
            timerMouseDown.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            editorModeAddPixel = checkBox1.Checked;

            if (editorModeAddPixel)
            {
                checkBox1.Text = "Current Editormode: Add pixel";
            }
            else
            {
                checkBox1.Text = "Current Editormode: Remove pixel";
            }
        }

        private void timerMouseDown_Tick(object sender, EventArgs e)
        {
            int mouseX = this.PointToClient(Cursor.Position).X; //SHIT IS FLIPPED!
            int mouseY = this.PointToClient(Cursor.Position).Y; //SHIT IS FLIPPED!

            int offsetX = editorOffsetX;
            int offsetY = editorOffsetY;
            int xPixelPosition = offsetX;
            int yPixelPosition = offsetY;
            int xPosition, yPosition;

            //Test is it actually inside the drawing area:
            if (mouseX > offsetX && mouseX < (offsetX + drawingRectangleSize * currentEditorHeight) && mouseY > offsetY && mouseY < (offsetY + drawingRectangleSize * currentEditorWidth))
            {
                xPixelPosition = (int)(mouseX - offsetX) / drawingRectangleSize;
                yPixelPosition = (int)(mouseY - offsetY) / drawingRectangleSize;

                if (editorMouseDownLastX == -1 || editorMouseDownLastY == -1)
                {
                    editorMouseDownLastX = xPixelPosition;
                    editorMouseDownLastY = yPixelPosition;
                }

                if (xPixelPosition != editorMouseDownLastX || yPixelPosition != editorMouseDownLastY)
                {
                    //Fill new Data
                    for (int i = 0; i < editorBrushWidth; i++)
                    {
                        for (int j = 0; j < editorBrushWidth; j++)
                        {
                            if ((xPixelPosition + i) >= currentEditorHeight) break;
                            if ((yPixelPosition + j) >= currentEditorWidth) break;

                            drawingAreaBuffer[(xPixelPosition + i), (yPixelPosition + j)] = editorModeAddPixel;

                            xPosition = offsetX + drawingRectangleSize * (xPixelPosition + i);
                            yPosition = offsetY + drawingRectangleSize * (yPixelPosition + j);

                            if (editorModeAddPixel)
                            {
                                z.FillRectangle(pinsel, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                            }
                            else
                            {
                                pinsel.Color = BackColor;
                                z.FillRectangle(pinsel, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                                pinsel.Color = Color.Black;
                                z.DrawRectangle(stift, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                            }
                            
                        }
                    }



                    editorMouseDownLastX = xPixelPosition;
                    editorMouseDownLastY = yPixelPosition;

                }
            }
            /*
            int mouseX = this.PointToClient(Cursor.Position).X; //SHIT IS FLIPPED!
            int mouseY = this.PointToClient(Cursor.Position).Y; //SHIT IS FLIPPED!

            int offsetX = editorOffsetX;
            int offsetY = editorOffsetY;
            int xPosition = offsetX;
            int yPosition = offsetY;

            for (int i = 0; i < currentEditorWidth; i++) //SHIT IS FLIPPED!
            {
                for (int j = 0; j < currentEditorHeight; j++) //SHIT IS FLIPPED!
                {
                    //Checks if Mouseclick was within boundaries of that "pixel"
                    if (xPosition < mouseX && yPosition < mouseY && (xPosition + drawingRectangleSize) > mouseX && (yPosition + drawingRectangleSize) > mouseY)
                    {
                        //Console.WriteLine("Clicked! On Field X: " + j + " and Y: " + i + " | " + editorMouseDownLastX + " " + editorMouseDownLastY);

                        if (j != editorMouseDownLastX || i != editorMouseDownLastY)
                        {
                            if (editorModeAddPixel)
                            {
                                drawingAreaBuffer[j, i] = true;
                                z.FillRectangle(pinsel, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                            }

                            else
                            {
                                drawingAreaBuffer[j, i] = false;
                                pinsel.Color = BackColor;
                                z.FillRectangle(pinsel, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                                pinsel.Color = Color.Black;
                                z.DrawRectangle(stift, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                            }

                            editorMouseDownLastX = j;
                            editorMouseDownLastY = i;

                        }
                    }


                    xPosition += drawingRectangleSize;
                }
                xPosition = offsetX;
                yPosition += drawingRectangleSize;
            }
            */
        }

        //draw a small red border around the pixel the mouse if hovering over

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (editorMouseDownLastX == -1) //Test if its not pressed. -1 is standard for not clicked
            {
                int mouseX = this.PointToClient(Cursor.Position).X; //SHIT IS FLIPPED!
                int mouseY = this.PointToClient(Cursor.Position).Y; //SHIT IS FLIPPED!

                int offsetX = editorOffsetX;
                int offsetY = editorOffsetY;
                int xPixelPosition = 0;
                int yPixelPosition = 0;
                int xPosition, yPosition;

                //Test is it actually inside the drawing area:
                if (mouseX > offsetX && mouseX < (offsetX + drawingRectangleSize * currentEditorHeight) && mouseY > offsetY && mouseY < (offsetY + drawingRectangleSize * currentEditorWidth))
                {
                    xPixelPosition = (int)(mouseX - offsetX) / drawingRectangleSize;
                    yPixelPosition = (int)(mouseY - offsetY) / drawingRectangleSize;

                    if (editorLastHoverPixelX == -1 || editorLastHoverPixelY == -1)
                    {
                        editorLastHoverPixelX = xPixelPosition;
                        editorLastHoverPixelY = yPixelPosition;
                    }

                    if (xPixelPosition != editorLastHoverPixelX || yPixelPosition != editorLastHoverPixelY)
                    {
                        
                        //remove old red border
                        for (int i = 0; i < editorBrushWidth; i++)
                        {
                            for (int j = 0; j < editorBrushWidth; j++)
                            {
                                if ((editorLastHoverPixelX + i) >= currentEditorHeight) break;
                                if ((editorLastHoverPixelY + j) >= currentEditorWidth) break;

                                xPosition = offsetX + drawingRectangleSize * (editorLastHoverPixelX + i);
                                yPosition = offsetY + drawingRectangleSize * (editorLastHoverPixelY + j);

                                z.DrawRectangle(stift, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                            }
                        }

                        //Draw new red border
                        for (int i = 0; i < editorBrushWidth; i++)
                        {
                            for (int j = 0; j < editorBrushWidth; j++)
                            {
                                if ((xPixelPosition + i) >= currentEditorHeight) break;
                                if ((yPixelPosition + j) >= currentEditorWidth) break;

                                xPosition = offsetX + drawingRectangleSize * (xPixelPosition + i);
                                yPosition = offsetY + drawingRectangleSize * (yPixelPosition + j);

                                stift.Color = Color.Red;
                                z.DrawRectangle(stift, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                                stift.Color = Color.Black;
                            }
                        }

                        

                        editorLastHoverPixelX = xPixelPosition;
                        editorLastHoverPixelY = yPixelPosition;

                    }
                }

            }
            else if (editorLastHoverPixelX != -1 || editorLastHoverPixelY != -1)
            {
                //remove old red border
                for (int i = 0; i < editorBrushWidth; i++)
                {
                    for (int j = 0; j < editorBrushWidth; j++)
                    {
                        if ((editorLastHoverPixelX + i) >= currentEditorHeight) break;
                        if ((editorLastHoverPixelY + j) >= currentEditorWidth) break;

                        int xPosition = editorOffsetX + drawingRectangleSize * (editorLastHoverPixelX + i);
                        int yPosition = editorOffsetY + drawingRectangleSize * (editorLastHoverPixelY + j);

                        z.DrawRectangle(stift, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                    }
                }

                editorLastHoverPixelX = -1;
                editorLastHoverPixelY = -1;
            }
        }

        private void numericUpDownBrushWidth_ValueChanged(object sender, EventArgs e)
        {
            editorBrushWidth = Convert.ToInt32(numericUpDownBrushWidth.Value);
        }

        private void comboBoxVersionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentVersion = versions[comboBoxVersionSelect.SelectedIndex, 1];
            cbCategory.SelectedIndex = 0;
        }
    }
}
