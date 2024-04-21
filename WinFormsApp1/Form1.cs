using System;
using System.Numerics;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        bool val = true, convVal = false;
        double in1, in2;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void two_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "";
                val = false;
            }
            Screen.Text += "2";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "";
                val = false;
                convVal = false;
            }
            Screen.Text += "1";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "";
                val = false;
                convVal = false;

            }
            Screen.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "";
                val = false;
                convVal = false;

            }
            Screen.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "";
                val = false;
                convVal = false;

            }
            Screen.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "";
                val = false;
                convVal = false;

            }
            Screen.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "";
                val = false;
                convVal = false;

            }
            Screen.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "";
                val = false;
                convVal = false;

            }
            Screen.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "";
                val = false;
                convVal = false;

            }
            Screen.Text += "9";
        }

        private void add_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            op = '+';
            val = true;

        }

        private void equal_Click(object sender, EventArgs e)
        {
            in2 = Double.Parse(Screen.Text);
            switch (op)
            {
                case '+':
                    Screen.Text = (in1 + in2).ToString("G10");
                    break;
                case 'x':
                    Screen.Text = (in1 * in2).ToString("G10");
                    break;
                case '/':
                    Screen.Text = (in1 / in2).ToString("G10");
                    break;
                case '-':
                    Screen.Text = (in1 - in2).ToString("G10");
                    break;
                case '^':
                    Screen.Text = Math.Pow(in1, in2).ToString("G10");
                    break;
                case '%':
                    Screen.Text = (in1% in2).ToString("G10");
                    break;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            op = 'x';
            val = true;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            op = '/';
            val = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            op = '-';
            val = true;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "";
                val = false;
            }
            Screen.Text += "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (val)
            {
                Screen.Text = "0";
                val = false;
            }
            Screen.Text += ".";
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (Screen.Text != "" && Screen.Text != "0")
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1);
        }

        private void sin_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            Screen.Text = Math.Sin(in1).ToString("G10");
        }

        private void cos_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            Screen.Text = Math.Cos(in1).ToString("G10");
        }

        private void hexa_Click(object sender, EventArgs e)
        {
            if (!convVal)
            {

                in1 = Double.Parse(Screen.Text);
                int temp = (int)in1;
                Screen.Text = temp.ToString("X");
            }
            val = true;
            convVal = true;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            in1 = in2 = 0;
            val = true;
            op = '\0';
            Screen.Text = "0";
        }

        private void binary_Click(object sender, EventArgs e)
        {
            if (!convVal)
            {
                in1 = Double.Parse(Screen.Text);
                int temp = (int)in1;
                Screen.Text = Convert.ToString(temp, 2);
            }
            val = false;

            convVal = true;
        }

        private void octal_Click(object sender, EventArgs e)
        {
            if (!convVal)
            {

                in1 = Double.Parse(Screen.Text);
                int temp = (int)in1;
                Screen.Text = Convert.ToString(temp, 8);
            }
            convVal = true;
            val = false;

        }

        private void log_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            Screen.Text = Math.Log(in1).ToString("G10");
        }

        private void square_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            op = '^';
            val = true;
        }

        private void root_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            BigInteger temp = (BigInteger)in1;
            if (temp == 0 || temp == 1)
                temp = 1;

            for (BigInteger i = temp - 1; i >= 2; --i)
                temp *= i;

            Screen.Text = temp.ToString("G10");
        }

        private void tan_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            Screen.Text = Math.Tan(in1).ToString("G10");
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            Screen.Text = Math.Sinh(in1).ToString("G10");
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            Screen.Text = Math.Cosh(in1).ToString("G10");
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            Screen.Text = Math.Tanh(in1).ToString("G10");
        }

        private void Mod_Click(object sender, EventArgs e)
        {
            in1 = Double.Parse(Screen.Text);
            op = '%';
            val = true;
        }
    }
}
