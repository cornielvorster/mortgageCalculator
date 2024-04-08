using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mortgageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            redSchedule = new RichTextBox();
            InitializeComponent();
        }

        
        //clearing all fields
      

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MortgagaCalculator calc = new MortgagaCalculator();//creating an instance of Morgage Calculator

            //try catch to catch errors if someone trys to enter a string in any of the int or double inputs
            try
            {
                double loanAmount = Convert.ToDouble(txtAmount.Text);
                double interestRate = Convert.ToDouble(txtInterestRate.Text);
                int loanTerm = (int)sedLoanTerm.Value;

                if (loanAmount <= 0 || loanAmount > 100000000) //ensuring that a user cant chose a loan amount out of the range
                {
                    MessageBox.Show("Loan amount has to be in the range of 1 to 100000000");
                }
                else if (interestRate <= 0 || interestRate > 20)
                {
                    MessageBox.Show("Interest rate has to be in the range of 1 to 20");//ensuring that a user cant chose a interest rate out of the range
                }
                else if (loanTerm <= 0 || loanTerm > 50)//ensuring that a user cant chose a loan term out of the range
                {
                    MessageBox.Show("Loan term must be in the range of 1 to 50 years");
                }
                else
                {
                    //monthly repayment
                    double monthlyRepaymentValue = calc.CalculateMonthlyRepayment(loanAmount, interestRate, loanTerm);
                    txtMonthlyRepayment.Text = $"{monthlyRepaymentValue:F2}";

                    //total interest
                    double totalInterest = calc.CalculateTotalInterestPaid(loanAmount, interestRate, loanTerm);
                    txtTotalInterest.Text = $"{totalInterest:F2}";

                    //totalAmount
                    double totalAmount = calc.CalculateTotalAmountPaid(loanAmount, interestRate, loanTerm);
                    txtTotalAmount.Text = $"{totalAmount:F2}";

                    //amorzation schedule
                    calc.GenerateAmortizationSchedule(loanAmount, interestRate, loanTerm, redSchedule);
                }
            }
            catch (FormatException ex)
            {
                //  Block of code to handle errors
                MessageBox.Show("Please enter valid digits: 1-9 and , are only acceptable ");
            }
        }

        //clearing all fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtInterestRate.Clear();
            sedLoanTerm.ResetText();
            txtMonthlyRepayment.Clear();
            txtTotalInterest.Clear();
            txtInterestRate.Clear();
            txtTotalAmount.Clear();
            redSchedule.Text = "";
        }
    }
}
