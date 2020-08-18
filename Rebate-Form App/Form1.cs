///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Author : Srivastchavan Rengarajan
// NetID : sxr190067
// Created Date : 20 Feb 2020
// Description :  Evaluation tool for rebate form application to maintain a file of data with rebate information of various users 
//                which are processed by a company. This program analyzes the data file and writes the following things to a text file and to the screen.
// Requirements :   a.The number of records (should be 10.)
//                  b.The minimum, maximum, and average time to enter a single record.Remember that records written by the program contain the start and stop time for that record.Times should be in MM:SS format.
//                  c.The minimum, maximum, and average time between finishing entering a record and starting the next one.
//                  d.The total time from starting to enter the first record to finishing the last one.
//                  e.The number of times the user presses the “backspace” key while entering all 10 records.To do this you will have to modify your original program to count the backspace key and put the count at the end of the existing record.  At the form level, there is a way to capture every keystroke, and you can look for character hex 08.
//
//
// Data file name :  CS6326Asg3.txt

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg3_sxr190067
{
    public partial class Form1 : Form
    {
        double minEntryTime = 0.0;
        double maxEntryTime = 0.0;
        double avgEntryTime = 0.0;
        double minIntRecTime = 0.0;
        double maxIntRecTime = 0.0;
        double avgIntRecTime = 0.0;
        double totalTime = 0.0;
        int bkSpcCount = 0;
        int totalRecs = 0;

        double[] timeForOneRec = new double[10];
        double[] timeBetTwoRec = new double[9];
        DateTime[] startTimes = new DateTime[10];
        DateTime[] endTimes = new DateTime[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Open File Dialog on click of Browse button.
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\"; 
            ofd.Title = "SELECT ANY .txt File";
            ofd.Filter = "Text Files|*.txt"; 
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true; 
            if (ofd.ShowDialog() == DialogResult.OK)
                txtFilePath.Text = ofd.FileName;
        }

        // Read data from file and calculate required data and display on the screen as well save on file on click of Analyze
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            setDefaultValForFields();
            readDataFromFile(txtFilePath.Text);
            calculateTimeTaken();
            populateListView(txtFilePath.Text);
            populateTextBoxes();
            resultToTextFile();
        }

        // Clear all fields on click of Clear data button
        private void btnClearData_Click(object sender, EventArgs e)
        {
            clearAllTextBoxes(this);
            setDefaultValForFields();
        }

        private void clearAllTextBoxes(Control control)
        {
            foreach (Control cont in control.Controls)
            {
                if (cont is TextBox)
                    ((TextBox)cont).Clear();
                else
                    clearAllTextBoxes(cont);
            }
        }


        // set default values for all the variables
        private void setDefaultValForFields()
        {
            minEntryTime = 0;
            maxEntryTime = 0;
            avgEntryTime = 0;
            minIntRecTime = 0;
            maxIntRecTime = 0;
            avgIntRecTime = 0;
            totalTime = 0;
            bkSpcCount = 0;
            totalRecs = 0;
            Array.Clear(timeForOneRec, 0, timeForOneRec.Length);
            Array.Clear(timeBetTwoRec, 0, timeBetTwoRec.Length);
            Array.Clear(startTimes, 0, startTimes.Length);
            Array.Clear(endTimes, 0, endTimes.Length);

            lvResultData.Items.Clear();
        }

        // open the file and read the data from it
        private void readDataFromFile(string fileName)
        {
            try
            {
                StreamReader sReader = new StreamReader(fileName, true);
                string data;
                int index = 0;
                while ((data = sReader.ReadLine()) != null)
                {
                    string[] items = data.Split('\t');
                    DateTime start_time = DateTime.ParseExact(items[14], "HH:mm:ss", CultureInfo.InvariantCulture);
                    DateTime end_time = DateTime.ParseExact(items[15], "HH:mm:ss", CultureInfo.InvariantCulture);
                    startTimes[index] = start_time;
                    endTimes[index] = end_time;
                    bkSpcCount += Convert.ToInt32(items[16]);
                    index++;
                }
                sReader.Close();
                totalRecs = index;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        
        // Calculate min and max times as per requirement
        void calculateTimeTaken()
        {
            int i = 0;
            while ((i < totalRecs) && (i < startTimes.Length))
            {
                timeForOneRec[i] = endTimes[i].Subtract(startTimes[i]).TotalSeconds;
                totalTime += timeForOneRec[i];
                i++;
            }
            maxEntryTime = timeForOneRec.Max();
            minEntryTime = timeForOneRec.Min();
            avgEntryTime = getAverage(timeForOneRec);
        
            int j = 0;

            while ((j < totalRecs) && (j < (startTimes.Length - 1)))
            {
                timeBetTwoRec[j] = startTimes[j + 1].Subtract(endTimes[j]).TotalSeconds;
                totalTime += timeBetTwoRec[j];
                j++;
            }
            maxIntRecTime = timeBetTwoRec.Max();
            minIntRecTime = timeBetTwoRec.Min();
            avgIntRecTime = getAverage(timeBetTwoRec);
        }

        // Find average time
        double getAverage(double[] time)
        {
            double sum = 0.0;
            double avg = 0.0;
            for (int i = 0; i < time.Length; i++)
            {
                sum += time[i];
            }
            avg = sum / time.Length;
            return avg;
        }

        // Populate list view from the data from the file
        private void populateListView(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader fileData = new StreamReader(fileName, true);
                string data;
                int i = 0;

                while ((data = fileData.ReadLine()) != null)
                {
                    try
                    {
                        string[] split_line_item = data.Split('\t');
                        string[] displayList = new string[2];
                        displayList[0] = split_line_item[1] + " " + split_line_item[3] + " " + split_line_item[2];
                        displayList[1] = TimeSpan.FromSeconds(timeForOneRec[i]).ToString(@"mm\:ss");
                        ListViewItem li = new ListViewItem(displayList);
                        li.Tag = split_line_item[0];
                        lvResultData.Items.Add(li);
                        i++;
                    }
                    catch (Exception e)
                    {
                        fileData.Close();
                        MessageBox.Show(e.Message);
                        return;
                    }
                }
                fileData.Close();
            }
        }
        
        // populate text boxes with data from the file 
        private void populateTextBoxes()
        {
            txtNoOfRec.Text = Convert.ToString(totalRecs);
            txtBkSpcCount.Text = Convert.ToString(bkSpcCount);
            txtMinEntryTIme.Text = TimeSpan.FromSeconds(minEntryTime).ToString(@"mm\:ss");
            txtMaxEntryTime.Text = TimeSpan.FromSeconds(maxEntryTime).ToString(@"mm\:ss");
            txtAvgEntryTime.Text = TimeSpan.FromSeconds(avgEntryTime).ToString(@"mm\:ss");
            txtMinIntRecTime.Text = TimeSpan.FromSeconds(minIntRecTime).ToString(@"mm\:ss");
            txtMaxIntRecTime.Text = TimeSpan.FromSeconds(maxIntRecTime).ToString(@"mm\:ss");
            txtAvgIntRecTime.Text = TimeSpan.FromSeconds(avgIntRecTime).ToString(@"mm\:ss");
            txtTotalTime.Text = TimeSpan.FromSeconds(totalTime).ToString(@"mm\:ss");
        }

        // write the resultant calculations into text file 
        private void resultToTextFile()
        {
            StreamWriter strWriter = new System.IO.StreamWriter("CS6326Asg3.txt", false);
            strWriter.WriteLine("Number of records: " + txtNoOfRec.Text);
            strWriter.WriteLine("Minimum entry time: " + txtMinEntryTIme.Text);
            strWriter.WriteLine("Maximum entry time: " + txtMaxEntryTime.Text);
            strWriter.WriteLine("Average entry time: " + txtAvgEntryTime.Text);
            strWriter.WriteLine("Minimum inter-record time: " + txtMinIntRecTime.Text);
            strWriter.WriteLine("Maximum inter-record time: " + txtMaxIntRecTime.Text);
            strWriter.WriteLine("Average inter-record time: " + txtAvgIntRecTime.Text);
            strWriter.WriteLine("Total time: " + txtTotalTime.Text);
            strWriter.WriteLine("Backspace Count: " + txtBkSpcCount.Text);
            strWriter.Close();
        }


        private void lblMinEntryTime_Click(object sender, EventArgs e)
        {

        }
    }
}
