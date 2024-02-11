using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //FIELDS
        double fstNum, secNum;
        string operation;
       
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0")
            {
                TxtDisplay1.Text = "1";
            }
            else
                TxtDisplay1.Text += "1";


            if (TxtDisplay2.Text == "0")
                TxtDisplay2.Text = "1";
            else
                TxtDisplay2.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0")
            {
                TxtDisplay1.Text = "2";
            }
            else
                TxtDisplay1.Text += "2";

            if (TxtDisplay2.Text == "0")
            {
                TxtDisplay2.Text = "2";
            }
            else
                TxtDisplay2.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0")
            {
                TxtDisplay1.Text = "3";
            }
            else
                TxtDisplay1.Text += "3";

            if (TxtDisplay2.Text == "0")
            {
                TxtDisplay2.Text = "3";
            }
            else
                TxtDisplay2.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0")
            {
                TxtDisplay1.Text = "4";
            }
            else
                TxtDisplay1.Text += "4";

            if (TxtDisplay2.Text == "0")
            {
                TxtDisplay2.Text = "4";
            }
            else
                TxtDisplay2.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0")
            {
                TxtDisplay1.Text = "5";
            }
            else
                TxtDisplay1.Text += "5";

            if (TxtDisplay2.Text == "0")
            {
                TxtDisplay2.Text = "5";
            }
            else
                TxtDisplay2.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0")
            {
                TxtDisplay1.Text = "6";
            }
            else
                TxtDisplay1.Text += "6";

            if (TxtDisplay2.Text == "0")
            {
                TxtDisplay2.Text = "6";
            }
            else
                TxtDisplay2.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0")
            {
                TxtDisplay1.Text = "7";
            }
            else
                TxtDisplay1.Text += "7";

            if (TxtDisplay2.Text == "0")
            {
                TxtDisplay2.Text = "7";
            }
            else
                TxtDisplay2.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0")
            {
                TxtDisplay1.Text = "8";
            }
            else
                TxtDisplay1.Text += "8";

            if (TxtDisplay2.Text == "0")
            {
                TxtDisplay2.Text = "8";
            }
            else
                TxtDisplay2.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0")
            {
                TxtDisplay1.Text = "9";
            }
            else
                TxtDisplay1.Text += "9";


            if (TxtDisplay2.Text == "0")
            {
                TxtDisplay2.Text = "9";
            }
            else
                TxtDisplay2.Text += "9";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            fstNum = Double.Parse(TxtDisplay1.Text);
            operation = "+";
            TxtDisplay1.Text = "";
            TxtDisplay2.Text += "+";
        }

        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            fstNum = Double.Parse(TxtDisplay1.Text);
            operation = "-";
            TxtDisplay1.Text = "";
            TxtDisplay2.Text += "-";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            fstNum = Double.Parse(TxtDisplay1.Text);
            operation = "*";
            TxtDisplay1.Text = "";
            TxtDisplay2.Text += "*";
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            fstNum = Double.Parse(TxtDisplay1.Text);
            operation = "/";
            TxtDisplay1.Text = "";
            TxtDisplay2.Text += "/";
        }

        private void BtnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(TxtDisplay1.Text);
            TxtDisplay1.Text = Convert.ToString(-1 * q);
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "";
            TxtDisplay2.Text = "";
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "";
            TxtDisplay2.Text = "";

            string f, s;
            f = Convert.ToString(fstNum);
            s = Convert.ToString(secNum);
            f = "";
            s = "";
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if(TxtDisplay1.Text == "")
            {
                TxtDisplay1.Text = "0";
            }
            if(TxtDisplay1.Text.Length > 1)
            {
                TxtDisplay1.Text = TxtDisplay1.Text.Remove(TxtDisplay1.Text.Length - 1, 1);
            }
            else
            {
                TxtDisplay1.Text = "0";
            }



            if (TxtDisplay2.Text == "")
            {
                TxtDisplay2.Text = "0";
            }
            if (TxtDisplay2.Text.Length > 1)
            {
                TxtDisplay2.Text = TxtDisplay2.Text.Remove(TxtDisplay2.Text.Length - 1, 1);
            }
            else
            {
                TxtDisplay2.Text = "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            secNum = Double.Parse(TxtDisplay1.Text);

            switch(operation)
            {
                case "+":
                    TxtDisplay1.Text = (fstNum + secNum).ToString();
                    break;
                case "-":
                    TxtDisplay1.Text = (fstNum - secNum).ToString();
                    break;
                case "*":
                    TxtDisplay1.Text = (fstNum * secNum).ToString();
                    break;
                case "/":
                    TxtDisplay1.Text = (fstNum / secNum).ToString();
                    break;
                default:
                    break;

            }
        }

        private void BtnDesimal_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text += ",";
            TxtDisplay2.Text += ",";
        }

        private void TxtDisplay2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
