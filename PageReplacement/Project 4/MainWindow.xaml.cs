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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int HitsFIFO = 0;
        public static int HitsLRU = 0;
        public static int HitsMIN = 0;
        public static int HitsRAND = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {

            string[,] outputArray = new string[,] { };
            string[,] outputArrayFIFO = new string[,] { };
            string[,] outputArrayLRU = new string[,] { };
            string[,] outputArrayMIN = new string[,] { };
            string[,] outputArrayRAND = new string[,] { };
            char[] referenceString = new char[] { };
            HitsFIFO = 0;
            HitsLRU = 0;
            HitsMIN = 0;
            HitsRAND = 0;

            int refPattern = Convert.ToInt32(txtPatternLength.Text);
            char[] slots = new char[Convert.ToInt32(txtNumOfSlots.Text)];
            int uniquePages = Convert.ToInt32(txtNumOfUniquePages.Text);

            referenceString = referenceSetter(refPattern, uniquePages);

            //things are commented out below until they are implimented. Uncomment as necessary

            outputArray = FIFO(referenceString, slots); //Mother of Celestia, this looks simple, but it isnt, dont be fooled!
            outputArrayFIFO = outputArray;
            outputArray = LRU(referenceString, slots);
            outputArrayLRU = outputArray;
            outputArray = MIN(referenceString, slots);
            outputArrayMIN = outputArray;
            outputArray = RAND(referenceString, slots);
            outputArrayRAND = outputArray;
            new OutputWindow(outputArrayFIFO, referenceString, slots.Length, outputArrayLRU, referenceString, slots.Length, outputArrayMIN, referenceString, slots.Length, outputArrayRAND, referenceString, slots.Length).Show();

        }
        public string[,] FIFO(char[] referencePattern, char[] slots)
        {
            string[,] output = new string[referencePattern.Length, slots.Count()];
            string[] trackerList = new string[slots.Length];

            int x = 0;
            int first = 0; // Keeps track of the first inserted index in
            foreach (char reference in referencePattern) //for each character reference in the refrencePattern array
            {
                int index = 0; //set index to 0
                bool hit = false; //set hit to false
                if (trackerList.Contains(reference.ToString())) //if the trackerlist contains the current character reference
                {
                    index = Array.FindIndex(trackerList, row => row == reference.ToString()); //set the index variable to the character's current index
                    hit = true; //set hit to true
                }
                else
                {
                    if (trackerList.Contains(null)) //else if trackerlist contains any null value
                    {
                        index = Array.FindIndex(trackerList, row => row == null); //set the index variable to the first null index
                    }
                    else //else if it doesnt contain any null values
                    {
                        index = first; //set index variable to the first-in variable
                        first += 1; //increment the first in variable to keep track
                        if (first >= trackerList.Count()) //if the first-in variable ever reaches a number higher than the amount of slots
                        {
                            first = 0; //set first to 0, resetting the cycle. 
                        }
                    }
                }
                trackerList[index] = reference.ToString(); //set trackerlist at the current index variable equal to whatever the reference bariable is

                // The below is the same as the if/else statement
                //string outp = (hit) ? "+" : reference.ToString();

                string outp; //new test outp string
                if (hit) //if hit is true
                {
                    outp = "+"; //mark outp as a hit
                    HitsFIFO++;
                }
                else //otherwise
                {
                    outp = reference.ToString(); //set outp equal to the current reference
                }
                output[x, index] = outp; //set output at coordinate [x, index] equal to whatever outp is (Marks if hit or replacement)

                x += 1; //increment x variable

            }

            return output;
        }
        public string[,] LRU(char[] referencePattern, char[] slots)
        {
            string[,] output = new string[referencePattern.Length, slots.Count()];
            string[] trackerList = new string[slots.Length];
            int[] oldest = new int[slots.Length];


            int x = 0;
            foreach (int slot in oldest)
            {
                oldest[x] = 200;
            }
            int index = 0;
            foreach (char reference in referencePattern)
            {
                index = Array.FindIndex(oldest, row => row == oldest.Max());
                string outp = reference.ToString();

                if (trackerList.Contains(reference.ToString()))
                {
                    index = Array.FindIndex(trackerList, row => row == reference.ToString());
                    outp = "+";
                    HitsLRU++;
                }
                else if (trackerList.Contains(null))
                {
                    index = Array.FindIndex(trackerList, row => row == null);

                }
               
                trackerList[index] = reference.ToString();

                output[x, index] = outp;
                oldest[index] = 0;
                for (int i = 0; i < oldest.Length; i++)
                {
                    oldest[i]++;
                }

                x += 1;

            }
            return output;
        }
        public string[,] MIN(char[] referencePattern, char[] slots)
        {
            string[,] output = new string[referencePattern.Length, slots.Count()];
            string[] trackerList = new string[slots.Length];
            int[] distTrack = new int[slots.Length];

            //General logoc framework
            
            //Foreach reference in the pattern
                //if the reference doesnt exist in the tracked list
                    //Add to array at index var
                //else if it does exist
                    //Set index
                    //Set outp = "+"

            int x = 0;
            int index = 0;
            foreach (char reference in referencePattern)
            {
                string outp = reference.ToString();
                if (trackerList.Contains(reference.ToString()))
                {
                    index = Array.FindIndex(trackerList, row => row == reference.ToString());
                    outp = "+";
                    HitsMIN++;
                }
                else if (trackerList.Contains(null))
                {
                    index = Array.FindIndex(trackerList, row => row == null);
                }
                else
                {
                    for (int i = 0; i < slots.Length; i++)
                    {
                        char toFind = trackerList[i].ToCharArray()[0];
                        distTrack[i] = (Array.FindIndex(referencePattern.Skip(x).ToArray(), row => row == toFind));
                        if (distTrack[i] == -1)
                        {
                            distTrack[i] = 1000009000;
                        }
                    }
                    index = Array.FindIndex(distTrack, row => row == distTrack.Max());
                }
                trackerList[index] = reference.ToString();
                output[x, index] = outp;
                x++;
            }
            return output;
        }

        public string[,] RAND(char[] referencePattern, char[] slots)
        {
            //slots has a number of things, as does referencePattern
            string[,] output = new string[referencePattern.Length, slots.Count()];
            string[] trackerList = new string[slots.Length];
            Random rnd = new Random();
            int x = 0;
            foreach (char reference in referencePattern)
            {
                int index = 0;
                bool hit = false;
                if (trackerList.Contains(reference.ToString()))
                {
                    index = Array.FindIndex(trackerList, row => row == reference.ToString());
                    hit = true;
                }
                else
                {
                    if (trackerList.Contains(null))
                    {
                        index = Array.FindIndex(trackerList, row => row == null);
                    }
                    else
                    {
                        int replaceSlot = rnd.Next(slots.Count()); //If the slots are full, randomly picks one to be replaced
                        index = replaceSlot;
                    }
                }
                trackerList[index] = reference.ToString();

                // The below is the same as the if/else statement
                //string outp = (hit) ? "+" : reference.ToString();

                string outp;
                if (hit)
                {
                    outp = "+";
                    HitsRAND++;
                }
                else
                {
                    outp = reference.ToString();
                }
                output[x, index] = outp;

                x += 1;

            }

            return output;
        }
        public char[] referenceSetter(int refPattern, int uniquePages)
        {
            char[] reference = new char[refPattern];

            Random random = new Random();
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char chosen;
            int x = 0;
            while (x < refPattern)
            {
                chosen = chars[random.Next(0, uniquePages - 1)];
                reference[x] = chosen;
                x += 1;
            }
            return reference;
        }
    }
}
