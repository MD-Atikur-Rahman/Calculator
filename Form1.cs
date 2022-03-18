namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2= string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "1";
            textBox1.Text += input;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "2";
            textBox1.Text += input;
        }

        private void button_3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "3";
            textBox1.Text += input;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "4";
            textBox1.Text += input;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "5";
            textBox1.Text += input;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "6";
            textBox1.Text += input;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "7";
            textBox1.Text += input;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "8";
            textBox1.Text += input;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "9";
            textBox1.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "0";
            textBox1.Text += input;
        }

        private void buttond_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += ".";
            textBox1.Text += input;
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void buttonp_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonm_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttong_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttondv_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void buttoneq_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            input = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
        }
    }
}