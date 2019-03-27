using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dex
{
    public partial class Dex : Form
    {
        public String userInput;
        public char[] amountOfChar;
        public char[] newSentence;

        public Dex()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInput = textBox1.Text;
            Console.WriteLine("user input: " + userInput);

            amountOfChar = userInput.ToCharArray();
            newSentence = userInput.ToCharArray();

            for (int j = 0; j < userInput.Length; j = j + 2)
                newSentence[j] = char.ToUpper(amountOfChar[j]);

            label3.Text = new string(newSentence);
            Clipboard.SetText(new string(newSentence));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
