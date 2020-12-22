using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathematical_Operations
{
    public partial class Form1 : Form
    {
        public Form1() // Constructer Method  
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            String firstNumberText = number1.Text;
            String secondNumberText = number2.Text;
            int firstNumber = Convert.ToInt32(firstNumberText);
            int secondNumber = Convert.ToInt32(secondNumberText);

            //String result2 = (firstNumber + secondNumber).ToString(); // İkisi de aynı sonucu veriyor
            //String result = Convert.ToString(firstNumber + secondNumber);
            //MessageBox.Show(result);

            resultLabel.Text = (firstNumber + secondNumber).ToString(); // Labeldaki sonuca yazdırmak için yaptık.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String firstNumberText = number1.Text;
            String secondNumberText = number2.Text;
            int firstNumber = Convert.ToInt32(firstNumberText);
            int secondNumber = Convert.ToInt32(secondNumberText);
            resultLabel.Text = (firstNumber - secondNumber).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String firstNumberText = number1.Text;
            String secondNumberText = number2.Text;
            int firstNumber = Convert.ToInt32(firstNumberText);
            int secondNumber = Convert.ToInt32(secondNumberText);
            resultLabel.Text = (firstNumber * secondNumber).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String firstNumberText = number1.Text;
            String secondNumberText = number2.Text;
            int firstNumber = Convert.ToInt32(firstNumberText);
            int secondNumber = Convert.ToInt32(secondNumberText);
            resultLabel.Text = (firstNumber / secondNumber).ToString();
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String firstNumberText = number1.Text;
            String secondNumberText = number2.Text;
            int firstNumber = Convert.ToInt32(firstNumberText);
            int secondNumber = Convert.ToInt32(secondNumberText);

            String operation = operationOption.Text;
            if (operation == "Addition")
            {
                resultLabel.Text = (firstNumber + secondNumber).ToString();
            }
            else if (operation == "Extraction")
            {
                resultLabel.Text = (firstNumber - secondNumber).ToString();
            }
            else if (operation == "Impact")
            {
                resultLabel.Text = (firstNumber * secondNumber).ToString();
            }
            else if (operation == "Division")
            {
                resultLabel.Text = (firstNumber / secondNumber).ToString();
                resultLabel.Text += "\n Remaining=" + (firstNumber % secondNumber).ToString(); // Kalan bulma.
            }
            else
            {
                MessageBox.Show("You Entered an Incorrect Transaction!");
            }
        }
    }
}
