using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }



        private int testResults()
        {
            int result = 0;

            if (button_pytanie1_odp2.Checked)
            {
                result++;
            }

            if (button_pytanie_2_odp_1.Checked)
            {
                result++;
            }

            if (checkBox_pytanie_3_odp_1.Checked &&
                checkBox_pytanie_3_odp_3.Checked &&
                !checkBox_pytanie_3_odp_2.Checked)
            {
                result++;
            }

            
            if (textBox_pytanie_4.Text.Replace(" ", "").ToUpper() == "DROGAMLECZNA" ||
                textBox_pytanie_4.Text.Replace(" ", "").ToUpper() == "MILKYWAY" )
            {
                result++;
            }


            return result;
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Check_Click(object sender, EventArgs e)
        { 
                button_Check.Text = testResults().ToString() + "/4";
     
        }

    }
}
