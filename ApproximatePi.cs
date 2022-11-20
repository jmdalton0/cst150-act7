using System;
using System.Windows.Forms;

namespace Act7
{
    // form to approximate the value of pi
    public partial class ApproximatePi : Form
    {
        public ApproximatePi()
        {
            InitializeComponent();
        }

        // update the number of terms displayed by the result label
        private void updateResultLabel(int numTerms)
        {
            resultLabel.Text = String.Format("Approximate value of pi after {0} terms:", numTerms);
        }

        // update the result
        private void updateResultValueLabel(double result)
        {
            resultValueLabel.Text = result.ToString();
        }

        // clean input and perform calculation on click
        private void calcButton_Click(object sender, EventArgs e)
        {
            int numTerms = 0;
            // if user input is a positive integer, perform calculation
            if (int.TryParse(numTermsTextBox.Text, out numTerms) && numTerms > -1)
            {
                updateResultLabel(numTerms);

                double result = 4.0;
                // for each term
                for (int i = 1; i < numTerms; i++) // start at 1 to make sure the result is 4 if the user enters 0 or 1
                {
                    // formula for each term
                    double term = 4.0 / ((i * 2) + 1);
                    // add if n is even
                    if (i % 2 == 0)
                    {
                        result += term;
                    }
                    // subtract is n is odd
                    else
                    {
                        result -= term;
                    }
                }

                updateResultValueLabel(result);
            }
            else
            {
                MessageBox.Show("Please enter a positive integer");
            }
        }
    }
}
