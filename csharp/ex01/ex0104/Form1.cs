using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ex0104
{
    public partial class Form1 : Form
    {
        private int number1;
        public int Number1
        {
            get
            {
                if (isNumberic(this.textBox1.Text))
                {
                    number1 = Int32.Parse(textBox1.Text);
                }
                return number1;
            }
            set
            {
                value = number1;
            }
        }

        private int number2;
        public int Number2
        {
            get
            {
                if (isNumberic(this.textBox2.Text))
                {
                    number2 = Int32.Parse(textBox2.Text);
                }
                return number2;
            }
            set
            {
                value = number1;
            }
        }

        private string result;
        public String Result
        {
            get
            {
                if (this.Number2 == 0)
                {
                    this.textBox3.Text = "0不能为除数";
                }
                return result;
            }
            set
            {
                value = result;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            this.textBox1.Text = "0";
            this.textBox2.Text = "0";
            this.textBox3.Text = "";
        }

        private void Print()
        {
            this.Number1 = Int32.Parse(this.textBox1.Text);
            this.Number2 = Int32.Parse(this.textBox2.Text);
            this.Result = this.textBox3.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label5.Text = "+";
            result = (number1 + number2).ToString();

            Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label5.Text = "-";
            result = (number1 - number2).ToString();

            Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label5.Text = "x";
            result = (number1 * number2).ToString();

            Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label5.Text = "/";
            if (number2 == 0) return;

            result = (number1 / number2).ToString();

            Print();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Init();
        }

        public static bool isNumberic(string input)
        {
            var pattern = "/^(0|[1-9][0-9]*|-[1-9][0-9]*)$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isNumberic(this.textBox1.Text))
            {
                number1 = Int32.Parse(textBox1.Text);
                return;
            }
            this.textBox3.Text = "Number1 不合法。";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (isNumberic(this.textBox2.Text))
            {
                number2 = Int32.Parse(textBox2.Text);
                return;
            }
            this.textBox3.Text = "Number2 不合法。";
        }
    }
}
