using System;
using System.Windows.Forms;

namespace BetterCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool OperationSelected = false;
        private double _leftOperand = 0;
        private double _rightOperand = 0;
        private string _operation = "";
        private double _result = 0;
        private string _valueText = "";
        private string _stringRightOperand = "";

        private void numericButton_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)(sender);
            if ((resultTextBox.Text == "0" ) && numericButton.Text != ",")
            {
                resultTextBox.Text = "";
                _stringRightOperand = "";
            }
            if (numericButton.Text == ",")
            {
                if (!resultTextBox.Text.Contains(",") && IsValidLength(resultTextBox.Text))
                {
                    resultTextBox.Text += numericButton.Text;
                }
            }
            else
            {
                if (IsValidLength(resultTextBox.Text + numericButton.Text))
                {
                    if (OperationSelected)
                    {
                        _stringRightOperand += numericButton.Text;
                    }
                    resultTextBox.Text += numericButton.Text;
                }
            }
        }
        
        bool IsValidLength(string text)
        {
            return text.Length <= 15;
        }


        private void inverseButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Convert.ToString(-1 * Convert.ToDouble(resultTextBox.Text));
        }
        
        private void clearTextBox_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
        }
        private void clearAllDataButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
            resultLabel.Text = "";
            _result = 0;
            _rightOperand = 0;
            _leftOperand = 0;
            OperationSelected = false;
        }

        private void removeSingleDigit_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Length > 0)
            {
                resultTextBox.Text = resultTextBox.Text.Remove(resultTextBox.Text.Length - 1, 1);
            }

            if (resultTextBox.Text == "")
            {
                resultTextBox.Text = "0";
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {  
            switch (_operation)
            {
                case "+":
                    resultTextBox.Text = (_result + Double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "-":
                    resultTextBox.Text = (_result - Double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "x":
                    if (_result == 0 && resultTextBox.Text == "0")
                    {
                        _result = 1;
                    }
                    resultTextBox.Text = (_result * Double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "/":
                    double divider = Double.Parse(resultTextBox.Text);
                    if (divider != 0)
                    {
                        resultTextBox.Text = (_result / divider).ToString();
                    }
                    else
                    {
                        resultTextBox.Text = "Nie dziel przez 0";
                        // blockButtons();
                    }
                          
                    break;
                default:
                    resultLabel.Text += $"{resultTextBox}=";
                    break;
            }

        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            if (OperationSelected)
            {
                equalsButon.PerformClick();
            }
           
            Button operationButton = (Button)sender;
            _operation = operationButton.Text;
            resultLabel.Text = resultTextBox.Text + _operation;
            _result = Convert.ToDouble(resultTextBox.Text);
            OperationSelected = true;

        }

       
    }
}
