using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string op = "NULL";
        public double num1,num2,res;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            op = "-";
            num1 = Int32.Parse(textBox1.Text);
            textBox1.Text = " ";
            textBox2.Text = num1.ToString() + Environment.NewLine + "-";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            op = "*";
            num1 = Int32.Parse(textBox1.Text);
            textBox1.Text = " ";
            textBox2.Text = num1.ToString() + Environment.NewLine + "*";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            op = "/";
            num1 = Int32.Parse(textBox1.Text);
            textBox1.Text = " ";
            textBox2.Text = num1.ToString() + Environment.NewLine + "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (op != "NULL")
            {
                if (textBox1.Text != "")
                {
                    num2 = Int32.Parse(textBox1.Text);
                        switch(op)
                        {
                            case "+": res=num1+num2;
                                break;
                            case "-": res = num1 - num2;
                                break;
                            case "*": res = num1 * num2;
                                break;
                            case "/": if (num2 != 0) { res = num1 / num2; }
                                break;
                            case "S": if (num2 != 0) { res = Math.Pow(num1,num2); }
                                break;
                            case "%": if (num2 != 0) { res = Math.IEEERemainder (num1, num2); }
                                break;
                            case "R": if (num2 != 0) { res = Math.Log (num1, num2); }
                                break;
                             
                        }
                        textBox1.Text = res.ToString();
                        textBox2.Text = "";
                }
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            op = "+";
            num1 = Int32.Parse(textBox1.Text);
            textBox1.Text=" ";
            textBox2.Text = num1.ToString() + Environment.NewLine + "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            op = "NULL";
            num1 = 0;
            num2 = 0;
            textBox1.Text = "";
            textBox2.Text = "";
       
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
           }

        private void button18_Click(object sender, EventArgs e)
        {
            op = "S";
            num1 = Int32.Parse(textBox1.Text);
            textBox1.Text = " ";
            textBox2.Text = num1.ToString() + Environment.NewLine + "S";
        
        }

        private void button19_Click(object sender, EventArgs e)
        {
            op = "%";
            num1 = Int32.Parse(textBox1.Text);
            textBox1.Text = " ";
            textBox2.Text = num1.ToString() + Environment.NewLine + "%";
        
        }

        private void button20_Click(object sender, EventArgs e)
        {
            op = "R";
            num1 = Int32.Parse(textBox1.Text);
            textBox1.Text = " ";
            textBox2.Text = num1.ToString() + Environment.NewLine + "R";
        
        }
    }
}
