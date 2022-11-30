using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class MainForm : Form
    {
        bool buttonAddIfClick;
        bool buttonMinusIfClick;
        bool buttonMultiplicationIfClick;
        bool buttonDivisionIfClick;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Click()
        {
            int firstNumber;
            int.TryParse(textBoxMain.Text, out firstNumber);

            textBoxMain.Text = "";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            button_Click();
            
        }





        //private void buttonAdd_Click(object sender, EventArgs e)
        //{
        //    int firstNumber;
        //    int secondNumber;
        //    if (int.TryParse(textBoxFirsNumber.Text, out firstNumber)
        //        && int.TryParse(textBoxMain.Text, out secondNumber))
        //    {
        //        int result = firstNumber + secondNumber;
        //        labelResult.Text = "" + result;
        //    }
        //    else
        //    {
        //        labelResult.Text = "Podano nieprawidłowe dane"
        //    }
        //}
    }
}
