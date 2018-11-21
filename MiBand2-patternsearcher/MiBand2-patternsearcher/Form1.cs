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

        private void searchPattern_Lists()
        {
            Console.WriteLine("STARTING SEARCH WITH LISTS..."); //DEBUG
            Stopwatch sw = Stopwatch.StartNew(); //DEBUG

            if (patternLoaded && firmwareLoaded)
            {
                if (patternFileName == firmwareFileName)
                {
                    MessageBox.Show("Pattern File and Firmware File are identical", "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Console.WriteLine("FILES ARE LOADED..."); //DEBUG

                BinaryReader patternFile = new BinaryReader(File.Open(patternFileName, FileMode.Open));
                BinaryReader firmwareFile = new BinaryReader(File.Open(firmwareFileName, FileMode.Open));

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
                        Console.WriteLine("WE HAVE GOT A MATCH!"); //DEBUG

                        startPos = currentFWPos;
                        endPos = currentFWPos + patternLen - 1;
                        break;
                    }

                }

                //Present results in textboxes
                if (rightStartPosFound)
                {
                    Console.WriteLine("OUTPUTTING MATCH!"); //DEBUG

                    string startPosDec = startPos.ToString();
                    string endPosDec = endPos.ToString();
                    string lengthDec = patternLen.ToString();
                    string startPosHex = startPos.ToString("X");
                    string endPosHex = endPos.ToString("X");
                    string lengthHex = patternLen.ToString("X");

                    Console.WriteLine("startPosDec: " + startPosDec + " | endPosDec: " + endPosDec + " | lengthDec: " + lengthDec);
                    Console.WriteLine("startPosHex: " + startPosHex + " | endPosHex: " + endPosHex + " | lengthhex: " + lengthHex);

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

            Console.WriteLine("SEARCH ENDED"); //DEBUG
            sw.Stop(); //DEBUG
            Console.WriteLine("TIME: " + sw.ElapsedMilliseconds.ToString() + " ms");
        }

        private void buttonSearchPattern_Click(object sender, EventArgs e)
        {
            searchPattern_Lists();
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
    }
}
