using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalPoe
{
    /// <summary>
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window
    {
        public static double amountGoal;
        public static double savingTime;
        public static string savingReason;
        public static double interestGiven;
        public static double monthlyReqAmount;
    

    public Savings()
        {
            InitializeComponent();
        }

        private void detailedExpensesBtn_Click(object sender, RoutedEventArgs e)
        {
            // object of detailed expenses class
            DetailedExpensesWPF dtw = new DetailedExpensesWPF();
            MessageBox.Show("Now loading...", "Loading");
            this.Close();
            dtw.Show();
        }

        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            // enter button

            // saves values into respective variables
            amountGoal = Convert.ToDouble(tbSavingAmount.Text);
            savingTime = Convert.ToDouble(tbsavingTime.Text);
            savingReason = tbSavingReason.Text;
            interestGiven = Convert.ToDouble(tbInterestRate.Text);


            // temp variables used for the formula --> entire formula can be found in the user manual
            double interestTemp = interestGiven * 0.01; // multiply by 0.01 to create percentage
            double timeTemp = savingTime / 12; // divide months by 12 to get years

            double P = amountGoal * (interestTemp/12); // calc top half of forumla

            double P2 = Math.Pow((1 + interestTemp/12),(12 * timeTemp)); // calc bottom half of formula

            double P3 = P2 - 1; // calc 2nd part of bottom half

            monthlyReqAmount = P / P3; // divide top half by bottom half to get answer 

            MessageBox.Show("The monthly saved amount required to reach R" + amountGoal + " is: R" + Math.Round(monthlyReqAmount), "Reason for saving: " + savingReason); // message box to display monthly requirement

        }
    }
}
