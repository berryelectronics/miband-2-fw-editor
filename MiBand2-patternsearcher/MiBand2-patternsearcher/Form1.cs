using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBand2_patternsearcher
{
    public partial class Form1 : Form
    {

        vars extVariable = new vars();

        String patternFileName = null;
        String firmwareFileName = null;

        bool patternLoaded = false;
        bool firmwareLoaded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTypeOfVariables.Items.Add("Small Numbers and Characters");
            comboBoxTypeOfVariables.Items.Add("Huge Numbers");
            comboBoxTypeOfVariables.Items.Add("Miscellaneous Icons");
            comboBoxTypeOfVariables.SelectedIndex = 0;
        }

        private void clearText()
        {
            tBStartPosDec.Text = "";
            tBEndPosDec.Text = "";
            tBLengthDec.Text = "";
            tBStartPosHex.Text = "";
            tBEndPosHex.Text = "";
            tBLengthHex.Text = "";

            buttonCopyStartHex.BackColor = Color.Gray;
            buttonCopyEndHex.BackColor = Color.Gray;
        }

        private void buttonLoadPattern_Click(object sender, EventArgs e)
        {
            openPattern.ShowDialog();

            patternFileName = openPattern.FileName;
            patternLoaded = true;
            labelPatternPath.Text = patternFileName;
            clearText();
        }

        private void buttonLoadFirmware_Click(object sender, EventArgs e)
        {
            openFirmware.ShowDialog();

            firmwareFileName = openFirmware.FileName;
            firmwareLoaded = true;
            labelFirmwarePath.Text = firmwareFileName;
            clearText();
        }

        private void searchPattern_Lists(String pPatternFileName = null, String pFirmwareFileName = null)
        {
            //Console.WriteLine("STARTING SEARCH WITH LISTS..."); //DEBUG
            Stopwatch sw = Stopwatch.StartNew(); //DEBUG

            if (patternLoaded && firmwareLoaded)
            {
                if (pPatternFileName == pFirmwareFileName)
                {
                    MessageBox.Show("Pattern File and Firmware File are identical", "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Console.WriteLine("FILES ARE LOADED..."); //DEBUG

                BinaryReader patternFile = new BinaryReader(File.Open(pPatternFileName, FileMode.Open));
                BinaryReader firmwareFile = new BinaryReader(File.Open(pFirmwareFileName, FileMode.Open));

                IList<byte> patternFileList = new List<byte>();
                IList<byte> firmwareFileList = new List<byte>();

                long patternLen = patternFile.BaseStream.Length;
                long firmwareLen = firmwareFile.BaseStream.Length;

                long startPos = 0;
                long endPos = 0;

                bool rightStartPosFound = false;

                if ((firmwareLen - patternLen) < 0)
                {
                    MessageBox.Show("Pattern File is bigger than the firmware File", "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Copy Files Content to Lists
                patternFile.BaseStream.Position = 0;
                firmwareFile.BaseStream.Position = 0;

                for(long i = 0; i < patternLen; i++)
                {
                    patternFileList.Add(patternFile.ReadByte());
                }

                for (long i = 0; i < firmwareLen; i++)
                {
                    firmwareFileList.Add(firmwareFile.ReadByte());
                }

                patternFile.Close();
                firmwareFile.Close();

                // Search for the pattern

                for (long currentFWPos = 0; currentFWPos < (firmwareLen - patternLen); currentFWPos++)
                {
                    //Console.WriteLine("currentFWPos: " + currentFWPos.ToString("X")); //DEBUG

                    for (long currentPatternPos = 0; currentPatternPos < patternLen; currentPatternPos++)
                    {
                        //Console.WriteLine("currentPatternPos: " + currentPatternPos.ToString("X")); //DEBUG

                        rightStartPosFound = true;

                        if (patternFileList[(int)currentPatternPos] != firmwareFileList[(int)(currentFWPos + currentPatternPos)])
                        {
                            //Console.WriteLine("DOESNT MATCH PATTERN!"); //DEBUG
                            rightStartPosFound = false;
                            break;
                        }
                    }

                    if (rightStartPosFound)
                    {
                        //Console.WriteLine("WE HAVE GOT A MATCH!"); //DEBUG

                        startPos = currentFWPos;
                        endPos = currentFWPos + patternLen - 1;
                        break;
                    }

                }

                //Present results in textboxes
                if (rightStartPosFound)
                {
                    //Console.WriteLine("OUTPUTTING MATCH!"); //DEBUG

                    string startPosDec = startPos.ToString();
                    string endPosDec = endPos.ToString();
                    string lengthDec = patternLen.ToString();
                    string startPosHex = startPos.ToString("X");
                    string endPosHex = endPos.ToString("X");
                    string lengthHex = patternLen.ToString("X");

                    //Console.WriteLine("startPosDec: " + startPosDec + " | endPosDec: " + endPosDec + " | lengthDec: " + lengthDec);
                    //Console.WriteLine("startPosHex: " + startPosHex + " | endPosHex: " + endPosHex + " | lengthhex: " + lengthHex);

                    tBStartPosDec.Text = startPosDec;
                    tBEndPosDec.Text = endPosDec;
                    tBLengthDec.Text = lengthDec;
                    tBStartPosHex.Text = startPosHex;
                    tBEndPosHex.Text = endPosHex;
                    tBLengthHex.Text = lengthHex;
                } else
                {
                    MessageBox.Show("The pattern hasnt been found in the firmware file.", "No result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearText();
                    return;
                }

            }

            //Console.WriteLine("SEARCH ENDED"); //DEBUG
            sw.Stop(); //DEBUG
            //Console.WriteLine("TIME: " + sw.ElapsedMilliseconds.ToString() + " ms");
        }

        private void buttonSearchPattern_Click(object sender, EventArgs e)
        {
            searchPattern_Lists(patternFileName, firmwareFileName);
        }

        private void buttonCopyStartHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tBStartPosHex.Text);
            buttonCopyStartHex.BackColor = Color.Green;
        }

        private void buttonCopyEndHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tBEndPosHex.Text);
            buttonCopyEndHex.BackColor = Color.Green;
        }

        private void searchPattern_Variables(String pPatternFileName = null, String pFirmwareFileName = null, UInt64 whichNoHit = 1)
        {
            //Console.WriteLine("STARTING SEARCH WITH LISTS..."); //DEBUG
            Stopwatch sw = Stopwatch.StartNew(); //DEBUG

            if (patternLoaded && firmwareLoaded)
            {
                if (pPatternFileName == pFirmwareFileName)
                {
                    MessageBox.Show("Pattern File and Firmware File are identical", "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Console.WriteLine("FILES ARE LOADED..."); //DEBUG

                BinaryReader patternFile = new BinaryReader(File.Open(pPatternFileName, FileMode.Open));
                BinaryReader firmwareFile = new BinaryReader(File.Open(pFirmwareFileName, FileMode.Open));

                IList<byte> patternFileList = new List<byte>();
                IList<byte> firmwareFileList = new List<byte>();

                long patternLen = patternFile.BaseStream.Length;
                long firmwareLen = firmwareFile.BaseStream.Length;

                long startPos = 0;
                long endPos = 0;

                bool rightStartPosFound = false;

                if ((firmwareLen - patternLen) < 0)
                {
                    MessageBox.Show("Pattern File is bigger than the firmware File", "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Copy Files Content to Lists
                patternFile.BaseStream.Position = 0;
                firmwareFile.BaseStream.Position = 0;

                for (long i = 0; i < patternLen; i++)
                {
                    patternFileList.Add(patternFile.ReadByte());
                }

                for (long i = 0; i < firmwareLen; i++)
                {
                    firmwareFileList.Add(firmwareFile.ReadByte());
                }

                patternFile.Close();
                firmwareFile.Close();

                // Search for the pattern

                for (long currentFWPos = 0; currentFWPos < (firmwareLen - patternLen); currentFWPos++)
                {
                    //Console.WriteLine("currentFWPos: " + currentFWPos.ToString("X")); //DEBUG

                    for (long currentPatternPos = 0; currentPatternPos < patternLen; currentPatternPos++)
                    {
                        //Console.WriteLine("currentPatternPos: " + currentPatternPos.ToString("X")); //DEBUG

                        rightStartPosFound = true;

                        if (patternFileList[(int)currentPatternPos] != firmwareFileList[(int)(currentFWPos + currentPatternPos)])
                        {
                            //Console.WriteLine("DOESNT MATCH PATTERN!"); //DEBUG
                            rightStartPosFound = false;
                            break;
                        }
                    }

                    //Check if this is not the correct number of Match (whichNoHit != 1)
                    if (rightStartPosFound && whichNoHit != 1)
                    {
                        rightStartPosFound = false;
                        whichNoHit--;
                    }

                    //This only happens if this is the correct number of hit (whichNoHit == 1)
                    if (rightStartPosFound)
                    {
                        //Console.WriteLine("WE HAVE GOT A MATCH!"); //DEBUG

                        startPos = currentFWPos;
                        endPos = currentFWPos + patternLen - 1;
                        break;
                    }

                }

                //Present results in textboxes
                if (rightStartPosFound)
                {
                    //Console.WriteLine("OUTPUTTING MATCH!"); //DEBUG

                    string startPosDec = startPos.ToString();
                    string endPosDec = endPos.ToString();
                    string lengthDec = patternLen.ToString();
                    string startPosHex = startPos.ToString("X");
                    string endPosHex = endPos.ToString("X");
                    string lengthHex = patternLen.ToString("X");

                    //Console.WriteLine("startPosDec: " + startPosDec + " | endPosDec: " + endPosDec + " | lengthDec: " + lengthDec);
                    //Console.WriteLine("startPosHex: " + startPosHex + " | endPosHex: " + endPosHex + " | lengthhex: " + lengthHex);

                    tBStartPosDec.Text = startPosDec;
                    tBEndPosDec.Text = endPosDec;
                    tBLengthDec.Text = lengthDec;
                    tBStartPosHex.Text = startPosHex;
                    tBEndPosHex.Text = endPosHex;
                    tBLengthHex.Text = lengthHex;
                }
                else
                {
                    //MessageBox.Show("The pattern hasnt been found in the firmware file. It will be commented out", "No result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearText();
                    return;
                }

            }

            //Console.WriteLine("SEARCH ENDED"); //DEBUG
            sw.Stop(); //DEBUG
            //Console.WriteLine("TIME: " + sw.ElapsedMilliseconds.ToString() + " ms");
        }

        private void generateVarialesHugeNumbers()
        {
            var rawIconData = extVariable.getCategories("hugeNumbers");

            var output = "public String[,] " + textBoxVariableName.Text + " = new string[,]\r\n";
            output += "\t\t{\r\n";

            for (int i = 0; i < rawIconData.GetLength(0); i++)
            {
                //Temporary Write Icon Data to file
                var path = Path.GetTempPath();
                var fileName = Guid.NewGuid().ToString() + ".fw";
                var tempfilepath = Path.Combine(path, fileName);
                BinaryWriter tempFile = new BinaryWriter(File.Open(tempfilepath, FileMode.CreateNew));
                tempFile.BaseStream.Position = 0;

                for (int j = 0; j < (rawIconData[i, 1].Length); j += 2)
                {
                    var tempIconByte = Convert.ToByte((rawIconData[i, 1][j].ToString() + rawIconData[i, 1][j + 1].ToString()), 16);
                    tempFile.Write(tempIconByte);
                    //Console.WriteLine((rawIconData[i, 1][j].ToString() + rawIconData[i, 1][j+1].ToString()) + " | " + tempIconByte); // DEBUG
                }

                tempFile.Close();
                //Console.WriteLine(tempfilepath); // DEBUG
                tempFile = null;

                patternFileName = tempfilepath;
                patternLoaded = true;
                labelPatternPath.Text = patternFileName;
                clearText();

                searchPattern_Variables(tempfilepath, firmwareFileName);
                var outputDebug = rawIconData[i, 0].ToString() + " | " + tBStartPosHex.Text.ToString() + " | " + tBEndPosHex.Text.ToString();
                //Console.WriteLine(outputDebug); // DEBUG

                output += "\t\t\t{ \"" + rawIconData[i, 0] + "\", \"" + tBStartPosHex.Text.ToString() + "\", \"" + tBEndPosHex.Text.ToString() + "\"},\r\n";
            }
            output = output.Remove(output.Length - 3) + "\r\n";
            output += "\t\t};";

            textBoxVariablesOutput.Text = output;
        }

        private void generateVariablesMisc()
        {
            var rawIconData = extVariable.getCategories("miscellaneousIcons");

            var output = "public String[,] " + textBoxVariableName.Text + " = new string[,]\r\n";
            output += "\t\t{\r\n";

            for (int i = 0; i < rawIconData.GetLength(0); i++)
            {
                //Temporary Write Icon Data to file
                var path = Path.GetTempPath();
                var fileName = Guid.NewGuid().ToString() + ".fw";
                var tempfilepath = Path.Combine(path, fileName);
                BinaryWriter tempFile = new BinaryWriter(File.Open(tempfilepath, FileMode.CreateNew));
                tempFile.BaseStream.Position = 0;

                for (int j = 0; j < (rawIconData[i, 3].Length); j += 2)
                {
                    var tempIconByte = Convert.ToByte((rawIconData[i, 3][j].ToString() + rawIconData[i, 3][j + 1].ToString()), 16);
                    tempFile.Write(tempIconByte);
                    //Console.WriteLine((rawIconData[i, 3][j].ToString() + rawIconData[i, 3][j+1].ToString()) + " | " + tempIconByte); // DEBUG
                }

                tempFile.Close();
                //Console.WriteLine(tempfilepath); // DEBUG
                tempFile = null;

                patternFileName = tempfilepath;
                patternLoaded = true;
                labelPatternPath.Text = patternFileName;
                clearText();


                if (rawIconData[i, 4] == "2")
                {
                    searchPattern_Variables(tempfilepath, firmwareFileName, 2);
                }
                else if (rawIconData[i, 4] == "3")
                {
                    searchPattern_Variables(tempfilepath, firmwareFileName, 3);
                }
                else
                {
                    searchPattern_Variables(tempfilepath, firmwareFileName);
                }

                //Check if pattern has been found or not
                var outputDebug = "";
                if (tBStartPosHex.Text.ToString() != "")
                {
                    outputDebug = rawIconData[i, 0].ToString() + " | " + tBStartPosHex.Text.ToString() + " | " + tBEndPosHex.Text.ToString();
                    output += "\t\t\t{ \"" + rawIconData[i, 0] + "\", \"" + rawIconData[i, 1] + "\", \"" + tBStartPosHex.Text.ToString() + "\", \"" + tBEndPosHex.Text.ToString() + "\", \"" + rawIconData[i, 2] + "\"},\r\n";
                }
                else
                {
                    outputDebug = "// " + rawIconData[i, 0].ToString() + " | " + tBStartPosHex.Text.ToString() + " | " + tBEndPosHex.Text.ToString();
                    output += "\t\t\t// { \"" + rawIconData[i, 0] + "\", \"" + rawIconData[i, 1] + "\", \"" + tBStartPosHex.Text.ToString() + "\", \"" + tBEndPosHex.Text.ToString() + "\", \"" + rawIconData[i, 2] + "\"},\r\n";
                }

                //Console.WriteLine(outputDebug); // DEBUG

               
            }
            output = output.Remove(output.Length - 3) + "\r\n";
            output += "\t\t};";

            textBoxVariablesOutput.Text = output;
        }

        private void buttonGenerateVariables_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeOfVariables.SelectedIndex == 1) // huge Numbers
            {
                generateVarialesHugeNumbers();
            }
            else if (comboBoxTypeOfVariables.SelectedIndex == 2) //misc
            {
                generateVariablesMisc();
            }
        }
    }
}
