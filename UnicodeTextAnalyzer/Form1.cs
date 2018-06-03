using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace UnicodeTextAnalyzer
{
    public partial class Form1 : Form
    {

        //all public data goes here
        int[] mainCharArray = new int[1000];
        String[] charTypeArray = new String[1000];
        int[] indexArray = new int[1000];

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
            label4.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //the functionality for the analyze text button
        private void button6_Click(object sender, EventArgs e)
        {
            String analyzeString = "";

            //always clear out msg box 2
            richTextBox1.Text = "";

            if (textBox1.Text == "")
            {
                MessageBox.Show("There is no text input", "Error");
            }
            else
            {
                analyzeString = textBox1.Text;
            }

            //Now populate the arrays with null values


            //populate the main character Array
            for (int x = 0; x < 1000; x++)
            {
                int temp = 0;
                if (x < analyzeString.Length)
                {
                    temp = (int)analyzeString[x];
                }

                mainCharArray[x] = temp;
            }

            //now populate the index array
            for (int x = 0; x < mainCharArray.Length; x++)
            {
                indexArray[x] = textTypes.charValuetoIndex(mainCharArray[x]);
            }

            //now the user will get the number of different types of characters
            //for exaple a typical Japanese text will have 3 character types
            //hiragana katakana and kanji
            int numberOfCharacterTypes = countCharacterTypes(indexArray);

            String s = textTypes.getCharacterType(mainCharArray[0]);


            richTextBox1.Text = analyzeString;


            //setup the output string
            label4.Refresh();
            label4.Text = "";
            String statsOutputString = "Number of Character Types: " + numberOfCharacterTypes;
            String StatsString = generateStatistics(indexArray);
            label4.Text = statsOutputString + "\n" + StatsString;

            int z = 0;
        }

        private string generateStatistics(int[] indexArray)
        {
            String returnString = "";
            //loop through the indexes of the array
            for (int x = 0; x < indexArray.Length; x++)
            {

                int currentCharacterIndex = indexArray[x];
                int nextCharIndex = -999;
                //check the next char just to be sure
                if (x < indexArray.Length - 1)
                {
                    nextCharIndex = indexArray[x + 1];
                }

                //in the case it is a character we have not hit yet
                if (currentCharacterIndex != -999 && currentCharacterIndex != 0)
                {
                    String currentLine = textTypes.indexToCharacterType(currentCharacterIndex);
                    int currentCharacterCount = 1;

                    //make sure the internal itterator is not at the end
                    if (x + 1 < indexArray.Length)
                    {
                        for (int y = x + 1; y < indexArray.Length; y++)
                        {
                            //in the case where there is a match
                            if (currentCharacterIndex == indexArray[y] && indexArray[y] != 999 && indexArray[y] != 0)
                            {
                                currentCharacterCount++;
                                indexArray[y] = -999;
                            }

                        }
                        currentLine = currentCharacterCount + " - " + currentLine + "\n";
                        returnString = returnString + currentLine;
                    }
                    else
                    {
                        currentLine = "1 - " + currentLine;
                    }

                }
            }


            return returnString;
        }

        //this function counts the number of different
        //character types in an array by taking in an array
        //of indexes
        private int countCharacterTypes(int[] indexArray)
        {
            int[] typesArray = new int[1000];
            int typesArrayIndex = 0;
            int numberOfCharacterTypes = 0;
            //populate the types array with -999s
            for (int x = 0; x < 1000; x++)
            {
                typesArray[x] = -999;
            }

            //now parse over the index array counting up the unique elements

            for (int x = 0; x < indexArray.Length; x++)
            {
                bool inTypesArray = false;
                int currentElement = indexArray[x];

                //if x = 1 put it in the array
                if (x == 0)
                {
                    typesArray[0] = indexArray[0];
                    typesArrayIndex++;
                }
                else
                {
                    //now loop over the types array to see if the
                    //element was already found
                    int itterator = 0;
                    while (typesArray[itterator] != -999)
                    {

                        if (typesArray[itterator] == currentElement)
                        {
                            inTypesArray = true;
                        }

                        itterator++;
                    }
                }

                if (inTypesArray == false)
                {
                    typesArray[typesArrayIndex] = currentElement;
                    typesArrayIndex++;
                    numberOfCharacterTypes++;
                }
            }


            return numberOfCharacterTypes - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("There is no text input", "Error");
            }

            String tempString = richTextBox1.Text;

            for (int x = 0; x < tempString.Length; x++)
            {
                richTextBox1.Select(x, 1);
                richTextBox1.SelectionColor = textTypes.GetColor((int)tempString[x]);
            }

        }



        private void button8_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Input text into the input text box of any sort, click 'Output Text Stats' to see\n what the text contains, even generate color coded text", "Help");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string pathToFile = "";
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(theDialog.FileName.ToString());
                pathToFile = theDialog.FileName;//doesn't need .tostring because .filename returns a string// saves the location of the selected object

            }
            string text = "";
            if (File.Exists(pathToFile))// only executes if the file at pathtofile exists//you need to add the using System.IO reference at the top of te code to use this
            {


                //method2
                
                using (StreamReader sr = new StreamReader(pathToFile))
                {
                    text = sr.ReadToEnd();//all text wil be saved in text enters are also saved
                }
            }

            textBox1.Text = text;
        }






    }
}

