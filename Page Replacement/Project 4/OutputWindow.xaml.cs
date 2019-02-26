using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project_4
{
    /// <summary>
    /// Interaction logic for OutputWindow.xaml
    /// </summary>
    public partial class OutputWindow : Window
    {
        public OutputWindow(string[,] outputArray1, char[] referenceString1, int slots1, string[,] outputArray2, char[] referenceString2, int slots2, string[,] outputArray3, char[] referenceString3, int slots3, string[,] outputArray4, char[] referenceString4, int slots4)
        {
            InitializeComponent();
            changeTextToOutput(outputArray1, referenceString1, slots1, outputArray2, referenceString2, slots2, outputArray3, referenceString3, slots3, outputArray4, referenceString4, slots4);
        }

        private void txtOutput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public void changeTextToOutput (string[,] outputArray1, char[] referenceString1, int slots1, string[,] outputArray2, char[] referenceString2, int slots2, string[,] outputArray3, char[] referenceString3, int slots3, string[,] outputArray4, char[] referenceString4, int slots4)
        {
            string testOutput = "";

                    testOutput = formatTextFIFO(outputArray1, referenceString1, slots1);
                    txtOutput.Text += testOutput;
                    testOutput = formatTextLRU(outputArray2, referenceString2, slots2);
                    txtOutput.Text += testOutput;
                    testOutput = formatTextMIN(outputArray3, referenceString3, slots3);
                    txtOutput.Text += testOutput;
                    testOutput = formatTextRAND(outputArray4, referenceString4, slots4);
                    txtOutput.Text += testOutput;
                    testOutput = formatTextSTATS(MainWindow.HitsFIFO,MainWindow.HitsLRU,MainWindow.HitsMIN,MainWindow.HitsRAND, referenceString1.Length);
                    txtOutput.Text += testOutput;
        }
        public string formatTextFIFO(string[,] outputArray, char[] referenceString, int slots)
        {
            txtOutput.Text += "---------------------------------------------------------\n" + "FIFO" + "\n---------------------------------------------------------\n";
            txtOutput.Text += "Ref Str: |";
            string output = "";
            foreach (char thing in referenceString)
            {
                txtOutput.Text += "-" + thing + "-|";
            }
            txtOutput.Text += "\n";
            int counter = 0;
            for (int i = 0; i < slots; i++)
            {
                output += "FIFO " + counter + ": ";
                for (int j = 0; j < referenceString.Length; j++)
                {

                    if (outputArray[j, i] == null)
                    {
                        outputArray[j, i] = " ";
                    }
                    output += "   " + outputArray[j, i];
                }
                counter += 1;
                output += '\n';
            }
            return output;
        }
        public string formatTextLRU(string[,] outputArray, char[] referenceString, int slots)
        {
            txtOutput.Text += "\n---------------------------------------------------------\n" + "LRU " + "\n---------------------------------------------------------\n";
            txtOutput.Text += "Ref Str: |";
            string output = "";
            foreach (char thing in referenceString)
            {
                txtOutput.Text += "-" + thing + "-|";
            }
            txtOutput.Text += "\n";
            int counter = 0;
            for (int i = 0; i < slots; i++)
            {
                output += "LRU  " + counter + ": ";
                for (int j = 0; j < referenceString.Length; j++)
                {

                    if (outputArray[j, i] == null)
                    {
                        outputArray[j, i] = " ";
                    }
                    output += "   " + outputArray[j, i];
                }
                counter += 1;
                output += '\n';
            }
            return output;
        }
        public string formatTextMIN(string[,] outputArray, char[] referenceString, int slots)
        {
            txtOutput.Text += "\n---------------------------------------------------------\n" + "MIN " + "\n---------------------------------------------------------\n";
            txtOutput.Text += "Ref Str: |";
            string output = "";
            foreach (char thing in referenceString)
            {
                txtOutput.Text += "-" + thing + "-|";
            }
            txtOutput.Text += "\n";
            int counter = 0;
            for (int i = 0; i < slots; i++)
            {
                output += "MIN  " + counter + ": ";
                for (int j = 0; j < referenceString.Length; j++)
                {

                    if (outputArray[j, i] == null)
                    {
                        outputArray[j, i] = " ";
                    }
                    output += "   " + outputArray[j, i];
                }
                counter += 1;
                output += '\n';
            }
            return output;
        }
        public string formatTextRAND(string[,] outputArray, char[] referenceString, int slots)
        {
            txtOutput.Text += "\n---------------------------------------------------------\n" + "RAND" + "\n---------------------------------------------------------\n";
            txtOutput.Text += "Ref Str: |";
            string output = "";
            foreach (char thing in referenceString)
            {
                txtOutput.Text += "-" + thing + "-|";
            }
            txtOutput.Text += "\n";
            int counter = 0;
            for (int i = 0; i < slots; i++)
            {
                output += "RAND " + counter + ": ";
                for (int j = 0; j < referenceString.Length; j++)
                {

                    if (outputArray[j, i] == null)
                    {
                        outputArray[j, i] = " ";
                    }
                    output += "   " + outputArray[j, i];
                }
                counter += 1;
                output += '\n';
            }
            return output;
        }
        public string formatTextSTATS(int HitsFIFO, int HitsLRU, int HitsMIN, int HitsRAND, int refString)
        {
            double LowestPercentage = 0;
            double HighestPercentage = 0;
            double PercFIFO = (double)HitsFIFO / (double)refString;
            double PercLRU = (double)HitsLRU / (double)refString;
            double PercMIN = (double)HitsMIN / (double)refString;
            double PercRAND = (double)HitsRAND / (double)refString;
            double[] Percentages = new double[4];
            Percentages[0] = PercFIFO;
            Percentages[1] = PercLRU;
            Percentages[2] = PercMIN;
            Percentages[3] = PercRAND;
            HighestPercentage = Percentages.Max();
            int HighIndex = Array.IndexOf(Percentages, HighestPercentage);
            LowestPercentage = Percentages.Min();
            int LowIndex = Array.IndexOf(Percentages, LowestPercentage);
            string[] ListForBestWorst = new string[4];
            ListForBestWorst[0] = "FIFO";
            ListForBestWorst[1] = "LRU";
            ListForBestWorst[2] = "MIN";
            ListForBestWorst[3] = "RAND";

            txtOutput.Text += "\n" + "----------STATS----------" + "\n";
            txtOutput.Text += "FIFO Hits: " + HitsFIFO + " of " + refString + " = " + PercFIFO + "\n";
            txtOutput.Text += "LRU Hits: " + HitsLRU + " of " + refString + " = " + PercLRU + "\n";
            txtOutput.Text += "MIN Hits: " + HitsMIN + " of " + refString + " = " + PercMIN + "\n";
            txtOutput.Text += "RAND Hits: " + HitsRAND + " of " + refString + " = " + PercRAND + "\n";
            txtOutput.Text += "BEST: " + ListForBestWorst[HighIndex] + "\n";
            txtOutput.Text += "WORST: " + ListForBestWorst[LowIndex];
            string output = "";
            return output;
        }
    }
}
