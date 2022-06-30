using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoe
{
    internal abstract class Expenses
    {
        // abstract class Expenses to hold variables utilised in derived classes
        public static double grossIncome;
        public static double estTax;
        public static double groceries;
        public static double waterLights;
        public static double travel;
        public static double phone;
        public static double extras;
        public static List<double> expensesList = new List<double>();
        public static double totalExpenses;
        // abstract method
        public abstract void input();
    }
}
