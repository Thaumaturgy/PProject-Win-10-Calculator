using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectureReview
{
    public partial class Form1 : Form
    {
        bool operandIn = false;
        double ans = 0;
        string mainText = "";
        string operand;
        public Form1()
        {
            InitializeComponent();
            this.labelmain.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void displayNum(int n)
        {
                mainText = mainText + n;
            //edits mainText first so changes to labelmain won't be obvious
                labelmain.Text = mainText;
        }

        private void operation(string s)
        {
            if (mainText == "")//time for a number!
                return;
            if (!operandIn)
            {
                labelsub.Text = mainText + " " + s + " ";
                operandIn = true;
                ans = double.Parse(mainText);
                
            }
            else
            {
                labelsub.Text = labelsub.Text + mainText + " " + s + " ";
                answer(operand, double.Parse(mainText));
                labelmain.Text = "" + ans;
            }
            operand = s;
            mainText = "";
        }

        private void answer(string s, double n)
        {
            if (s == "+")
                ans = ans + n;
            else if (s == "-")
                ans = ans - n;
            else if (s == "*")
                ans = ans * n;
            else if (s == "/") {
                if(n != 0)
                    ans = ans / n;
            }
                
        }

        //1
        private void button13_Click(object sender, EventArgs e)
        {
            displayNum(1);
        }

        //2
        private void button14_Click(object sender, EventArgs e)
        {
            displayNum(2);
        }
        //3
        private void button15_Click(object sender, EventArgs e)
        {
            displayNum(3);
        }
        //4
        private void button9_Click(object sender, EventArgs e)
        {
            displayNum(4);
        }
        //5
        private void button10_Click(object sender, EventArgs e)
        {
            displayNum(5);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            displayNum(6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayNum(7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayNum(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayNum(9);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            displayNum(0);
        }
        //=
        private void button20_Click(object sender, EventArgs e)
        {
            if (mainText == "") return;
            answer(operand, double.Parse(mainText));
            operandIn = false;
            labelsub.Text = "";
            labelmain.Text = "" + ans;
            mainText = "";
        }

        //+
        private void button16_Click(object sender, EventArgs e)
        {
            operation("+");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation("-");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operation("*");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation("/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelmain.Text = "0";
            mainText = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelmain.Text = "0";
            labelsub.Text = "";
            mainText = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //.
        private void button19_Click(object sender, EventArgs e)
        {
            mainText = mainText + '.';
            labelmain.Text = mainText;
        }
    }
}
