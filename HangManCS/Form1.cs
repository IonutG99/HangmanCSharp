using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string labelWord;
        List<string> wordList = new List<string>();
        string newWord;
        Random rndm = new Random(0);
        private void Form1_Load(object sender, EventArgs e)
        {
           CreateWordList();
           disableLetters();
        }

        void CreateWordList()
        {
            wordList.Add("Location");
            wordList.Add("Invocation");
            wordList.Add("Education");
            wordList.Add("Country");
            wordList.Add("National");
            wordList.Add("Computer");
            wordList.Add("Calculator");
            wordList.Add("Transmission");
            wordList.Add("Continental");
            wordList.Add("Fashionable");
            wordList.Add("Operation");
            wordList.Add("Seasonal");
            wordList.Add("Tomorrow");
            wordList.Add("Yesterday");
            wordList.Add("Perfume");
        }

        void disableLetters()
        {
            letterA.Enabled = false;
            letterB.Enabled = false;
            letterC.Enabled = false;
            letterD.Enabled = false;
            letterE.Enabled = false;
            letterF.Enabled = false;
            letterG.Enabled = false;
            letterH.Enabled = false;
            letterI.Enabled = false;
            letterJ.Enabled = false;
            letterK.Enabled = false;
            letterL.Enabled = false;
            letterM.Enabled = false;
            letterN.Enabled = false;
            letterO.Enabled = false;
            letterP.Enabled = false;
            letterQ.Enabled = false;
            letterR.Enabled = false;
            letterS.Enabled = false;
            letterT.Enabled = false;
            letterU.Enabled = false;
            letterV.Enabled = false;
            letterW.Enabled = false;
            letterX.Enabled = false;
            letterY.Enabled = false;
            letterZ.Enabled = false;
        }

        void enableLetters()
        {
            letterA.Enabled = true;
            letterB.Enabled = true;
            letterC.Enabled = true;
            letterD.Enabled = true;
            letterE.Enabled = true;
            letterF.Enabled = true;
            letterG.Enabled = true;
            letterH.Enabled = true;
            letterI.Enabled = true;
            letterJ.Enabled = true;
            letterK.Enabled = true;
            letterL.Enabled = true;
            letterM.Enabled = true;
            letterN.Enabled = true;
            letterO.Enabled = true;
            letterP.Enabled = true;
            letterQ.Enabled = true;
            letterR.Enabled = true;
            letterS.Enabled = true;
            letterT.Enabled = true;
            letterU.Enabled = true;
            letterV.Enabled = true;
            letterW.Enabled = true;
            letterX.Enabled = true;
            letterY.Enabled = true;
            letterZ.Enabled = true;

        }

   
private void getNewWord_Click(object sender, EventArgs e)
{
    int index = rndm.Next();
   index = index % wordList.Count;
   newWord = wordList[index];
   enableLetters();
   getNewWord.Enabled = false;
   textBox3.Text =newWord.Length.ToString();
    label_Word.Text = "";

    for (int i = 0; i < newWord.Length; i++)
            {
                label_Word.Text += "*";
            }

}

private void letterA_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterA.Text, letterA);
}

private void letterT_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterT.Text, letterT);
}

private void letterC_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterC.Text, letterC);
}

private void letterV_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterV.Text, letterV);
}

private void letterY_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterY.Text, letterY);
}

private void letterZ_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterZ.Text, letterZ);
}

private void letterB_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterB.Text, letterB);
}

private void letterD_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterD.Text, letterD);
}

private void letterE_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterE.Text, letterE);
}

private void letterF_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterF.Text, letterF);
}

private void letterG_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterG.Text, letterG);
}

private void letterH_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterH.Text, letterH);
}

private void letterI_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterI.Text, letterI);
}

private void letterJ_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterJ.Text, letterJ);
}

private void letterK_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterK.Text, letterK);
}

private void letterL_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterL.Text, letterL);
}

private void letterM_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterM.Text, letterM);
}

private void letterN_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterN.Text, letterN);
}

private void letterO_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterO.Text, letterO);
}

private void letterP_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterP.Text, letterP);
}

private void letterQ_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterQ.Text, letterQ);
}

private void letterR_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterR.Text, letterR);
}

private void letterS_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterS.Text, letterS);
}

private void letterU_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterU.Text, letterU);
}

private void letterW_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterW.Text, letterW);
}

private void letterX_Click(object sender, EventArgs e)
{
   checkGuessedLetter(newWord.ToUpper(), letterX.Text, letterX);
}

private void checkGuessedLetter(string wordToGuess, string guessedLetter, Button butName)
{
   labelWord = label_Word.Text;             

   int strLen = wordToGuess.Length;       

   int guessesLeft = int.Parse(textBox3.Text); 

   int result = 0;
   int counter = 0;
   int foundLen = 0;
   string newChar = "";
   int guessedCorrectlyCounter = 0;


   for (int i = 0; i < strLen; i++)
   {
       result = wordToGuess.IndexOf(guessedLetter, foundLen, strLen - foundLen);

       if (result != -1)
       {
           foundLen = result + 1;
           counter++;

           newChar = wordToGuess.Substring((result), 1);   

           labelWord =labelWord.Remove(result, 1);             

          labelWord= labelWord.Insert(result, newChar);   
           guessedCorrectlyCounter++;
       }
   }

   if (guessedCorrectlyCounter == 0)
   {
       guessesLeft = guessesLeft - 1;
       textBox3.Text = guessesLeft.ToString();
   }

   if (guessesLeft == 0)
   {
       MessageBox.Show("You Lost. The word was " + wordToGuess);
       disableLetters();
       getNewWord.Enabled = true;
   }
   else
   {

       label_Word.Text = labelWord;

       if (labelWord == wordToGuess) 
       {
           MessageBox.Show("You Won - Well Done!");
           disableLetters();
           getNewWord.Enabled = true;
       }

   }

   //=================================================================================
   //      THIS IS WHERE WE USE THE BUTTON OBJECT THAT WE PASSED OVER TO THE METHOD.
   //      ALL WE'RE DOING IS SWITCHING THE LETTER BUTTON OFF
   //=================================================================================
   butName.Enabled = false;
}

    }
}
