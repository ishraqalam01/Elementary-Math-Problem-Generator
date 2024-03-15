//Name: Ishraq Alam
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator_IshraqAlam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            string strUser; //Yogurt container that allows user to enter inputs
            double dblPaymentAmount; //A = Payment amount per period
            double dblPrincipalAmount; //P = Initial Principal (loan amount)
            double dblInterestRate; //r = Interest rate per period
            int intAmortizationPeriod; //The amortization period (total time in years to pay back a mortgage) used to find the total number of payments
            double dblPaymentPeriods; //n = Total Number of payments or Periods

            //Input
            Console.WriteLine("Please enter the amount of money you borrowed ($): "); //prompts the user to enter the principal amount of money, the amount of money they were loaned
            strUser = Console.ReadLine();
            dblPrincipalAmount = double.Parse(strUser); //Converts string to double

            Console.WriteLine("Please enter the interest rate of your mortgage (%): "); //asks the user to enter the interest rate for their mortgage. It remains the same since it is fixed.
            strUser = Console.ReadLine();
            dblInterestRate = double.Parse(strUser); //Converts string to double

            Console.WriteLine("Please enter the amortization period in years (total time to pay off mortgage): "); //asks the user to enter the amortization period
            strUser = Console.ReadLine();
            intAmortizationPeriod = Int32.Parse(strUser); //Converts string to int

            //Process
            dblPaymentPeriods = 12 * intAmortizationPeriod; //calculates the payment period in months by multiplying the amortization in years by 12
            dblInterestRate = dblInterestRate / 100; //converts the fixed total interest rate in percent to a decimal
            dblInterestRate = dblInterestRate / 12; //finds the interest rate per month by dividing the total rate by 12
            dblPaymentAmount = dblPrincipalAmount * (((dblInterestRate * Math.Pow((1 + dblInterestRate), dblPaymentPeriods))) / ((Math.Pow((1 + dblInterestRate), dblPaymentPeriods)) - 1)); //Calculates the total payment amount per month using the formula A = (P*r (1+r)^n) / ((1+r)^n - 1). Utilizes Math.Pow for doing calculations to the power n.
            dblPaymentAmount = Math.Round(dblPaymentAmount, 2); //Rounds the monthly payment amount to 2 decimal places

            //Output
            Console.WriteLine("Your monthly fixed amount to be paid is: $" + dblPaymentAmount); //Displays the monthly payment amount to the user

            Console.ReadKey(); //Ends the program
        }
    }
}
