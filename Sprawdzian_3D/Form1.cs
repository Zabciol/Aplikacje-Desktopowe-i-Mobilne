using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprawdzian_3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            double a, b, c;
            bool isRight = false;

            tryParse(out a, out b, out c, ref isRight);

            if (isRight)
            {
                getResults(a, b, c);
            }
            else
                error();

        }

        private void tryParse(out double a, out double b, out double c ,ref bool isRight)
        {
            a = 1;
            b = 1;
            c = 1;
            if (
            double.TryParse(textBoxDataA.Text, out a) &&
            double.TryParse(textBoxDataB.Text, out b) &&
            double.TryParse(textBoxDataC.Text, out c) )
            {
                isRight = true;
            }
        }

        private void getResults(double a, double b, double c)
        {
            double delta = getDelta(a, b, c);
            if (delta >= 0)
            {
                double deltaPierwiastek = Math.Sqrt(delta);
                double x1 = getX1(deltaPierwiastek, a, b, c);
                double x2 = getX2(deltaPierwiastek, a, b, c);
                labelResults.Text = "x1 = " + x1 + ", x2 = " + x2;
            }
            else
            {
                error();
            }
        }

        private double getDelta(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            return delta;
        }

        private double getX1(double deltaPierwiastek, double a, double b, double c)
        { 
            double x1 = (-b - deltaPierwiastek) / (2 * a);
            return x1;
        }

        private double getX2(double deltaPierwiastek, double a, double b, double c)
        {
            double x2 = (-b + deltaPierwiastek) / (2 * a);
            return x2;
        }

        private void error()
        {
            labelResults.Text = "Wprowadź poprawne dane";
        }    
    }
}
