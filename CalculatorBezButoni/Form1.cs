namespace CalculatorBezButoni
{
    public partial class Form1 : Form
    {
        char action = '+';
        double num1 = 0;
        double num2 = 0;
        public Form1()
        {
            InitializeComponent();
            rbPlus.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            action = '*';
            Execute();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(textBox1.Text, out result))
            {
                num1 = result;
            }
            else if (textBox1.Text.IsWhiteSpace())
            {
                num1 = 0; 
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("Enter a number please.");
            }
            Execute();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(textBox2.Text, out result))
            {
                num2 = result;
                if (num2 == 0 && action == '/')
                {
                    MessageBox.Show("We can't divide by zero,Sorry.");
                    textBox2.Text = "1";
                    num2 = 1;
                }
            }
            else if (textBox2.Text.IsWhiteSpace())
            {
                num2 = 1;
            }
            else
            {
                textBox2.Clear();
                MessageBox.Show("Enter a number please.");
            }
            Execute();
        }
        private void Execute()
        {
            textBox3.ReadOnly = false;
            switch (action)
            {
                case '+':
                    textBox3.Text = (num1 + num2).ToString("f2");
                    break;
                case '-':
                    textBox3.Text = (num1 - num2).ToString("f2");
                    break;
                case '*':
                    textBox3.Text = (num1 * num2).ToString("f2");
                    break;
                case '/':
                    textBox3.Text = (num1 / num2).ToString("f2");
                    break;
                case '^':
                    textBox3.Text = (Math.Pow(num1,num2)).ToString("f2");
                    break;
            }
            textBox3.ReadOnly = true;
        }
        private void rbPlus_CheckedChanged(object sender, EventArgs e)
        {
            action = '+';
            Execute();
        }

        private void rbMinus_CheckedChanged(object sender, EventArgs e)
        {
            action = '-';
            Execute();
        }

        private void rbDiv_CheckedChanged(object sender, EventArgs e)
        {
            action = '/';
            if (num2 == 0)
            {
                MessageBox.Show("We can't divide by zero,Sorry.");
                textBox2.Text = "1";
                num2 = 1;
            }
            Execute();
        }

        private void rbPower_CheckedChanged(object sender, EventArgs e)
        {
            action = '^';
            Execute();
        }
    }
}
