﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Windforms_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj w pierwszym programie WindForms");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string message = "Witaj " + textBoxName.Text + " w tym pragramie!";

            MessageBox.Show(message);
        }
    }
}

