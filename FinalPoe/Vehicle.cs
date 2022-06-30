using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalPoe
{
    internal class Vehicle : Expenses
    {
        // variable that will store the monthly repayment
        public static double monthlyCarRepayment;

        public static string  make;
        public static string model;
        public static double purchasePrice;
        public static double totalDeposit;
        public static double interestRateTemp;
        public static double estInsurancePrem;


        public override void input()
        {
                double principalAmount = purchasePrice - totalDeposit;
                double interestRate = interestRateTemp * 0.01; // * by 0.01 so that calc is able to use percentage correctly

                double totalRepayment = principalAmount * (1 + (interestRate * 5));

                monthlyCarRepayment = (totalRepayment / 60) + estInsurancePrem; 
        }
    }
}
