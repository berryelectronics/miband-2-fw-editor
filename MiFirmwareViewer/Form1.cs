using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        Boolean[,] drawingAreaBuffer = new Boolean[600, 600];

        int currentEditorWidth = 40; //FIX NAMING BECAUSE ITS ALL FLIPPED SOMEHOW!!!
        int currentEditorHeight = 36;
        int editorOffsetX = 250;
        int editorOffsetY = 20;
        int drawingRectangleSize = 10;

        private Graphics z;
        private Pen stift = new Pen(Color.Black);
        private SolidBrush pinsel = new SolidBrush(Color.Black);

        private String tempFilePath = null;
        bool firmwareLoaded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Draw Notification Editor
            z = CreateGraphics();

            //Initialize editor buffer
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 600; j++)
                {
                    drawingAreaBuffer[i, j] = false;
                }
            }

            cbDecodeMode.Items.Add("Standard Notification Icon");
            cbDecodeMode.SelectedIndex = 0;

            //Setup Temp file location
            tempFilePath = Path.GetTempFileName();
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

        private void drawEditorArea2(int width, int height)
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
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            // Vertical Lines
            for (int i = 0; i < height + 1; i++)
            {
                z.DrawLine(pen, xPosition, yPosition, xPosition, yPosition + drawingRectangleSize * width);
                xPosition = xPosition + drawingRectangleSize;
            }
            xPosition = offsetX;
            // Horizontal Lines
            for (int i = 0; i < width + 1; i++)
            {
                z.DrawLine(pen, xPosition, yPosition, xPosition + drawingRectangleSize * height, yPosition); 
                yPosition = yPosition + drawingRectangleSize;
            }
            yPosition = offsetY;

            // Fill only the needed squares
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (drawingAreaBuffer[j, i] == true)
                    {
                        z.FillRectangle(pinsel, xPosition, yPosition, drawingRectangleSize, drawingRectangleSize);
                    }
                    xPosition += drawingRectangleSize;
                }
                xPosition = offsetX;
                yPosition += drawingRectangleSize;
            }

            xPosition = offsetX;
            yPosition = offsetY;

            //Draw Red Lines over it
            // Vertical Lines
            for (int i = 0; i < height + 1; i++)
            {

                if (i == 0 || (i % 8) == 0)
                {
                    pen.Color = Color.FromArgb(255, 255, 0, 0);
                }
                else if (i == 1 || (i % 8) == 1)
                {
                    pen.Color = Color.FromArgb(255, 0, 0, 0);
                }

                z.DrawLine(pen, xPosition, yPosition, xPosition, yPosition + drawingRectangleSize * width);
                xPosition = xPosition + drawingRectangleSize;
            }
            xPosition = offsetX;
            // Horizontal Lines
            for (int i = 0; i < width + 1; i++)
            {
                if (i == 0 || (i % 8) == 0)
                {
                    pen.Color = Color.FromArgb(255, 255, 0, 0);
                }
                else if (i == 1 || (i % 8) == 1)
                {
                    pen.Color = Color.FromArgb(255, 0, 0, 0);
                }

                z.DrawLine(pen, xPosition, yPosition, xPosition + drawingRectangleSize * height, yPosition);
                yPosition = yPosition + drawingRectangleSize;
            }
            yPosition = offsetY;

        }
        

        private void drawEditor()
        {
            currentItemChanged();
            clearEditor();
            drawEditorArea2(currentEditorWidth, currentEditorHeight);
        }

        private void buttondrawEditor_Click(object sender, EventArgs e)
        {
            drawEditor();
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
        }

        private void currentItemChanged()
        {
            int curCategoryIndex = cbDecodeMode.SelectedIndex;
            int startPos = Convert.ToInt32(tbStartPos.Value);
            int endPos = Convert.ToInt32(tbEndPos.Value);
            int width = 40;
            int length = 0;

            if (width > 40) width = 40;

            //empty data buffer
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 600; j++)
                {
                    drawingAreaBuffer[i, j] = false;
                }
            }

            switch (curCategoryIndex)
            {
                case 0: //Notifications
                    currentEditorWidth = Convert.ToInt32(Math.Round((endPos - startPos) / 40.0 * 8, 0));
                    currentEditorHeight = Convert.ToInt32(tbWidth.Text);
                    width = 40;
                    length = endPos - startPos;
                    break;
                    /*
                case 1: //Medium Time
                    currentEditorHeight = 12;
                    currentEditorWidth = 24;
                    length = 288;
                    break;
                case 2: //Small Date Letters
                    currentEditorHeight = Convert.ToInt32(extVariable.getSmallDateTextAndWidths(currentVersion)[curItemIndex, 1]);
                    currentEditorWidth = 16;
                    break;
                    */
            }

            drawingRectangleSize = Convert.ToInt32(tbPixelSize.Text);

            length = currentEditorHeight * currentEditorWidth;

            Console.WriteLine("start: " + startPos + " | end: " + endPos + " | height: " + currentEditorHeight + " | length: " + length);

            loadSymbolFromTemp(startPos, length);
        }

        private void clearEditor()
        {
            pinsel.Color = BackColor;
            z.FillRectangle(pinsel, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            pinsel.Color = Color.Black;
        }

        private void buttonClearEditor_Click(object sender, EventArgs e)
        {
            clearEditor();
        }

        private void buttonIncreaseByWidth_Click(object sender, EventArgs e)
        {
            UInt64 startPos = Convert.ToUInt64(tbStartPos.Value);
            UInt64 endPos = Convert.ToUInt64(tbEndPos.Value);
            UInt64 width = Convert.ToUInt64(tbWidth.Value);
            Console.WriteLine("Start: " + startPos.ToString() + " | End: " + endPos.ToString() + " | width: " + width.ToString());
            startPos = startPos + width;
            endPos = endPos + width;

            tbStartPos.Value = startPos;
            tbEndPos.Value = endPos;

            drawEditor();
        }

        private void buttonDecreaseByWidth_Click(object sender, EventArgs e)
        {
            UInt64 startPos = Convert.ToUInt64(tbStartPos.Value);
            UInt64 endPos = Convert.ToUInt64(tbEndPos.Value);
            UInt64 width = Convert.ToUInt64(tbWidth.Value);
            startPos = startPos - width;
            endPos = endPos - width;

            tbStartPos.Value = startPos;
            tbEndPos.Value = endPos;

            drawEditor();
        }

        private void buttonIncreaseByOne_Click(object sender, EventArgs e)
        {
            int startPos = Convert.ToInt32(tbStartPos.Value);
            int endPos = Convert.ToInt32(tbEndPos.Value);
            int increaseBy = Convert.ToInt32(numIncreaseBy.Value);

            startPos = startPos + increaseBy;
            endPos = endPos + increaseBy;

            tbStartPos.Value = startPos;
            tbEndPos.Value = endPos;

            drawEditor();
        }

        private void buttonDecreaseByOne_Click(object sender, EventArgs e)
        {
            int startPos = Convert.ToInt32(tbStartPos.Value);
            int endPos = Convert.ToInt32(tbEndPos.Value);
            int decreaseBy = Convert.ToInt32(numDecreaseBy.Value);

            startPos = startPos - decreaseBy;
            endPos = endPos - decreaseBy;

            tbStartPos.Value = startPos;
            tbEndPos.Value = endPos;

            drawEditor();
        }

        private void buttonDecreaseWidthOne_Click(object sender, EventArgs e)
        {
            tbWidth.Value = tbWidth.Value - 1;
            drawEditor();
        }

        private void buttonIncreaseWidthOne_Click(object sender, EventArgs e)
        {
            tbWidth.Value = tbWidth.Value + 1;
            drawEditor();
        }

        private void buttonGenerateIconCode_Click(object sender, EventArgs e)
        {
            UInt64 codeGenHeight = Convert.ToUInt64(tbCodeGenHeight.Value);
            String codeGenName = tBCodeGenName.Text;
            UInt64 codeGenStart = Convert.ToUInt64(tbStartPos.Value);
            UInt64 codeGenWidth = Convert.ToUInt64(tbWidth.Text);
            UInt64 codeGenEnd = codeGenStart + (codeGenHeight * codeGenWidth - 1);
            codeGenHeight = codeGenHeight * 8;

            String codeGenOutput = "";
            // Example: { "Walk Animation Frame 1 (???)",  "14", "28653", "28661", "24"},
            codeGenOutput = "{ \"" + codeGenName + "\", \"" + codeGenWidth.ToString();
            codeGenOutput += "\", \"" + codeGenStart.ToString("X") + "\", \"" + codeGenEnd.ToString("X");
            codeGenOutput += "\", \"" + codeGenHeight.ToString() + "\"},";

            tBCodeGenOutput.Text = codeGenOutput;
            // Also copy to clipboard
            Clipboard.SetText(codeGenOutput);
        }
    }
}
