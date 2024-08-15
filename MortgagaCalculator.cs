using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mortgageCalculator
{
    internal class MortgagaCalculator
    {
        //method to calculate monthly repayment
        public double CalculateMonthlyRepayment(double loanAmount, double annualInterestRate, int loanTermYears){
            double monthlyInterestRate = annualInterestRate / 12 / 100; // Convert annual interest rate to monthly and percentage to decimal
            int numberOfPayments = loanTermYears * 12; // Convert loan term from years to months
            double monthlyPayment = loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments) / (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);
           
            return monthlyPayment;
        }

        //method to calculate interest paid over the lifetime of the loan
        public double CalculateTotalInterestPaid(double loanAmount, double annualInterestRate, int loanTermYears)
        {
            double monthlyInterestRate = annualInterestRate / 12 / 100; // Convert annual interest rate to monthly and percentage to decimal
            int numberOfPayments = loanTermYears * 12; // Convert loan term from years to months
            double monthlyPayment = loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments) / (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);

            double totalIntrestPaid = (monthlyPayment*numberOfPayments) - loanAmount +1;

            return totalIntrestPaid;
        }

        //method to calculate the total amount paid over the lifetime of the loan
        public double CalculateTotalAmountPaid(double loanAmount, double annualInterestRate, int loanTermYears)
        {
            double monthlyInterestRate = annualInterestRate / 12 / 100; // Convert annual interest rate to monthly and percentage to decimal
            int numberOfPayments = loanTermYears * 12; // Convert loan term from years to months
            double monthlyPayment = loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments) / (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);
            
            double totalAmountPaid = (monthlyPayment * numberOfPayments);

            return totalAmountPaid;

        }
        
        //method to generate the amortization schedule
        public void GenerateAmortizationSchedule(double loanAmount, double annualInterestRate, int loanTermYears, RichTextBox richTextBox)
        {
            StringBuilder schedule = new StringBuilder();
            double monthlyInterestRate = annualInterestRate / 12 / 100; // Convert annual interest rate to monthly and percentage to decimal
            int numberOfPayments = loanTermYears * 12; // Convert loan term from years to months
            double monthlyPayment = loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments) / (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);

            double totalPayment = monthlyPayment * numberOfPayments;
            double remainingBalance = loanAmount;

            //headings for the columns
            schedule.AppendLine($"{"Payment#",-8}{"Principal",-15}{"Interest",-15}{"Total Payment",-20}{"Loan Balance",-15}");
            schedule.AppendLine("---------------------------------------------------------------------------------------------");

            //looping through all payments
            for (int paymentNumber = 1; paymentNumber <= numberOfPayments; paymentNumber++)
            {
                double interestPayment = remainingBalance * monthlyInterestRate;
                double principalPayment = monthlyPayment - interestPayment;

                remainingBalance -= principalPayment;

                totalPayment -= monthlyPayment;

                schedule.AppendLine($"{paymentNumber,-8:F0}{principalPayment,-15:F2}{interestPayment,-15:F2}{monthlyPayment,-20:F2}{totalPayment,-15:F2}");
            }

            richTextBox.Text = schedule.ToString();
        }





    }
}

