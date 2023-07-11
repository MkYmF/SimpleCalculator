using System.Windows.Forms.VisualStyles;

namespace CalculatorUpdated
{
    public partial class Form1 : Form
    {

        double displayValue, currentValue;
        char operatorSign;

        public Form1()
        {
            InitializeComponent();
            Text = "Simple Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        //Dot, Number Buttons
        public void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        public void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        public void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        public void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        public void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        public void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        public void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        public void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        public void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }
        public void dotButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                dotButton.IsAccessible = false;
            }
            else
            {
                textBox1.Text += ".";
                dotButton.IsAccessible = true;
            }
        }

        //Clear, M+, M- Buttons
        public void clearButton_Click(object sender, EventArgs e)
        {
            currentValue = 0;
            displayValue = 0;
            textBox1.Text = "0";
        }

        public void memoryPlusButton_Click(object sender, EventArgs e)
        {
            double memoryPlus;
            displayValue = double.Parse(textBox1.Text);
            memoryPlus = displayValue + displayValue - currentValue;
            textBox1.Text = memoryPlus.ToString();
        }

        public void memoryMinusButton_Click(object sender, EventArgs e)
        {
            double memoryMinus;
            displayValue = double.Parse(textBox1.Text);
            memoryMinus = displayValue - currentValue;
            textBox1.Text = memoryMinus.ToString();
        }

        //Equal, Operators Button
        public void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text += "";
                }
                else
                {
                    //get the value of textbox1 and save it for use later
                    currentValue = double.Parse(textBox1.Text);


                    string.Format("{0}", currentValue);

                    //set "" or null or 0 so we can use the textbox again with other value
                    textBox1.Text = "";

                    //set the operator sign to use later on...
                    operatorSign = '/';
                }
            }
            catch (Exception Exception)
            {
                textBox1.Text = "";
                throw;
            }
        }

        public void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text += "";
                }
                else
                {
                    //get the value of textbox1 and save it for use later
                    currentValue = double.Parse(textBox1.Text);


                    string.Format("{0}", currentValue);

                    //set "" or null or 0 so we can use the textbox again with other value
                    textBox1.Text = "";

                    //set the operator sign to use later on...
                    operatorSign = '*';
                }
            }
            catch (Exception Exception)
            {
                textBox1.Text = "";
                throw;
            }
        }

        public void minusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text += "-";
                }
                else
                {
                    //get the value of textbox1 and save it for use later
                    currentValue = double.Parse(textBox1.Text);


                    string.Format("- {0}", currentValue);

                    //set "" or null or 0 so we can use the textbox again with other value
                    textBox1.Text = "";

                    //set the operator sign to use later on...
                    operatorSign = '-';
                }
            }
            catch (Exception Exception)
            {
                textBox1.Text = "";
                throw;
            }
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text += "";
                }
                else
                {
                    //get the value of textbox1 and save it for use later
                    currentValue = double.Parse(textBox1.Text);


                    string.Format("+ {0}", currentValue);

                    //set "" or null or 0 so we can use the textbox again with other value
                    textBox1.Text = "";

                    //set the operator sign to use later on...
                    operatorSign = '+';
                }
            }
            catch (Exception Exception)
            {
                textBox1.Text = "";
                throw;
            }
        }
        public void equalButton_Click(object sender, EventArgs e)
        {
            switch (operatorSign)
            {
                case '+':
                    displayValue = double.Parse(textBox1.Text) + currentValue;
                    textBox1.Text = displayValue.ToString();
                    break;

                case '-':
                    displayValue = currentValue - double.Parse(textBox1.Text);
                    textBox1.Text = displayValue.ToString();
                    break;

                case '*':
                    displayValue = double.Parse(textBox1.Text) * currentValue;
                    textBox1.Text = displayValue.ToString();
                    break;

                case '/':
                    displayValue = double.Parse(textBox1.Text) / currentValue;
                    textBox1.Text = displayValue.ToString();
                    break;

                default:
                    if (textBox1.Text == null) {
                        textBox1.Text = "0";
                        currentValue = 0;
                        displayValue = double.Parse(textBox1.Text) + currentValue;
                        textBox1.Text = displayValue.ToString();
                    }
                    break;
            }
        }
    }
}