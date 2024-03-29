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

        private bool _isOperationPerfomed = false;
        private double _leftOperand = 0;
        private double _rightOperand = 0;
        private double _result = 0;
        private string valueText = "";
        private void numericButton_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)(sender);
            if ((resultTextBox.Text == "0" || _isOperationPerfomed) && numericButton.Text != ",")
                resultTextBox.Text = "";

            _isOperationPerfomed = false;

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
            _isOperationPerfomed = false;
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

        private void equalsButon_Click(object sender, EventArgs e)
        {

        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Button operationButton = (Button)sender;
            


        }

       
    }
}
