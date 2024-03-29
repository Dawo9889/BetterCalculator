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
        private string _operation = "";
        private string _stringRightOperand = "";
        private double _rightOperand = 0;

        private void numericButton_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)(sender);
            if ((resultTextBox.Text == "0" || OperationSelected) && numericButton.Text != ",")
            {
                resultTextBox.Text = "";
                _stringRightOperand = "";
            }
            if (numericButton.Text == ",")
            {
                if (!resultTextBox.Text.Contains(",") && IsValidLength(resultTextBox.Text))
                {
                    resultTextBox.Text += numericButton.Text;
                    _stringRightOperand += numericButton.Text;
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
            OperationSelected = false;
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
            _rightOperand = Convert.ToDouble(resultTextBox.Text);
            switch (_operation)
            {
                case "+":
                    resultTextBox.Text = (_leftOperand + _rightOperand).ToString();
                    break;
                case "-":
                    resultTextBox.Text = (_leftOperand - _rightOperand).ToString();
                    break;
                case "*":

                    resultTextBox.Text = (_leftOperand * _rightOperand).ToString();
                    break;
                case "/":
                    if (_rightOperand != 0)
                    {
                        resultTextBox.Text = (_leftOperand / _rightOperand).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Nie dziel przez 0");
                        clearAllDataButton.PerformClick();
                    }
                    break;
               
            }
            
            resultLabel.Text = $"{_leftOperand}{_operation}{_rightOperand}=";
        }

        

        private void operationButton_Click(object sender, EventArgs e)
        {
            if (_stringRightOperand != "")
            {
                equalsButon.PerformClick();
            }
            
            Button operationButton = (Button)sender;
            _operation = operationButton.Text;
            resultLabel.Text = resultTextBox.Text + _operation;
            _leftOperand = Convert.ToDouble(resultTextBox.Text);
            OperationSelected = true;
            _stringRightOperand = "";
        }

       
    }
}
