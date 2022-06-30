using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoe
{
    internal class Calc : Expenses
    {
        // holds remaining monthly balance after all deductions have been made
        public static double monthlyAmount; 
        public override void input()
        {
            if (HomeLoan.rentalFee > 0) // if rent was > 0 then it was chosen --> so option 1 --> else option 2
            {
                monthlyAmount = (grossIncome - (totalExpenses + HomeLoan.rentalFee + Vehicle.monthlyCarRepayment + estTax + Savings.monthlyReqAmount));
            }
            else
            {
                monthlyAmount = (grossIncome - (totalExpenses + HomeLoan.monthlyRepayment + Vehicle.monthlyCarRepayment + estTax + Savings.monthlyReqAmount)); ;
            }
        }
    }
}
