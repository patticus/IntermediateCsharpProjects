using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; //LINQ stands for language integrated query, it is a syntax for manipulating data. Could be used to modify strings
using System.Text; //Text could be used for string manipulation
using System.Threading.Tasks;
using System.Windows.Forms; //This is for using the GUI form windows

namespace String_Input_Form 

    /*This program will allow the user to input text into a textbox and dynamically count the following as the user types:
     -Number of each letter of the alphabet
     -Number of words
     -Number of spaces
     -Number of characters not including spaces*/
        
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Nothing particularly interesting happens on form load.
            //Could have split this up into two form windows, but decided to do it all in one. If there was another form window, there would be code in the Form2_Load section for that window
        }

        private void txtAllStrings_TextChanged(object sender, EventArgs e) // All changes made from user input to this Rich Text Box will automatically update any code within this method
        {
            string randomText = txtAllStrings.Text.ToLower();// creates a string variable out of the text that is input in to this Rich Text Box
                                                             //ToLower() method ensures that data will be gathered from the string regardless of character case
            char[] delimiters = new char[] { ' ', '\r', '\n' }; //creating a variable that will exclude spaces and line breaks in the word count
            int numberOfWords = randomText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length; // variable that counts words
            int numberOfSpaces = randomText.Split(' ').Length -1; // variable that counts the number of spaces
                                                                  // an alternative to this is to use .Count Whitespace, however this also includes line breaks in the count
            int numberOfCharacters = randomText.Count(); // variable that counts the number of characters
            /*string alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            string[] alphabetArray = alphabet.Split(' ');*/ //was going to do something with this alphabet array but decided not to
            int countA = randomText.Split('a').Length -1;
            int countB = randomText.Split('b').Length -1;
            int countC = randomText.Split('c').Length -1;
            int countD = randomText.Split('d').Length -1;
            int countE = randomText.Split('e').Length -1;
            int countF = randomText.Split('f').Length -1;
            int countG = randomText.Split('g').Length -1;
            int countH = randomText.Split('h').Length -1;
            int countI = randomText.Split('i').Length -1;
            int countJ = randomText.Split('j').Length -1;
            int countK = randomText.Split('k').Length -1;
            int countL = randomText.Split('l').Length -1;
            int countM = randomText.Split('m').Length -1;
            int countN = randomText.Split('n').Length -1;
            int countO = randomText.Split('o').Length -1;
            int countP = randomText.Split('p').Length -1;
            int countQ = randomText.Split('q').Length -1;
            int countR = randomText.Split('r').Length -1;
            int countS = randomText.Split('s').Length -1;
            int countT = randomText.Split('t').Length -1;
            int countU = randomText.Split('u').Length -1;
            int countV = randomText.Split('v').Length -1;
            int countW = randomText.Split('w').Length -1;
            int countX = randomText.Split('x').Length -1;
            int countY = randomText.Split('y').Length -1;
            int countZ = randomText.Split('z').Length -1;// created an interger variable for each letter to use as a counter in the output label
                                                         // an alternative to this would be to create an array and for loop. The way I used is simpler and more straightforward but requires more manual coding

            lblLetterCount.Text = "A - "+countA + "     " + "B - "+ countB + "\r\n" + "C - " + countC + "     " + "D - " + countD + "\r\n" + "E - " + countE + "     " + "F - " + countF + "\r\n" + "G - " + countG + "     " + "H - " + countH + "\r\n" + "I - " + countI + "     " + "J - " + countJ + "\r\n" + "K - " + countK + "     " + "L - " + countL + "\r\n" + "M - " + countM + "     " + "N - " + countN + "\r\n" + "O - " + countO + "     " + "P - " + countP + "\r\n" + "Q - " + countQ + "     " + "R - " + countR + "\r\n" + "S - " + countS + "     " + "T - " + countT + "\r\n" + "U - " + countU + "     " + "V - " + countV + "\r\n" + "W - " + countW + "     " + "X - " + countX + "\r\n" + "Y - " + countY + "     " + "Z - " + countZ;
                //created a label which takes the input of the number of each letter of the alphabet and displays it dynamically

            lblSpacesCount.Text = ""+ numberOfSpaces; //outputs in the label the number of spaces

            lblWordCount.Text = ""+numberOfWords; //outputs in the label the number of words

            lblCharacterCount.Text = ""+(numberOfCharacters - numberOfSpaces); // will display the number of characters discluding the number of spaces
        }
    }
}
