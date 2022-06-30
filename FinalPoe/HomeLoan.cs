using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalPoe
{
    internal class HomeLoan : Expenses
    {
        // variables are set as public in order for other classes to access them
        public static double monthlyRepayment;
        public static double rentalFee;
        // set to public in order for other classes to access them
        public static double purchasePrice;
        public static double deposit;
        public static double interestRate;
        public static int repaymentTime;
        public static double grossIncomeTemp = grossIncome;


        public override void input()
        {

        }

        public void repayment(double purchasePriceTemp, double totDepositTemp, double interestRateTemp, int monthsTemp)// arguments will take their values from the main class 
        {

            double principalAmount = purchasePriceTemp - totDepositTemp;
            int years = monthsTemp / 12;
            double interest = interestRateTemp * 0.01;

            double totalRepayment = (principalAmount * (1 + interest * years)); // calculating total repayment 

            monthlyRepayment = totalRepayment / monthsTemp;
        }
    }
}
