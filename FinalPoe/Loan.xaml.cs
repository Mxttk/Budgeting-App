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
    /// Interaction logic for Loan.xaml
    /// </summary>
    public partial class Loan : Window
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            // object of homeloan class
            HomeLoan hl = new HomeLoan();

            // saves inputted text into respective variables
            HomeLoan.purchasePrice = Convert.ToDouble(tbPurchasePrice.Text);
            HomeLoan.deposit = Convert.ToDouble(tbDeposit.Text);
            HomeLoan.interestRate = Convert.ToDouble(tbInterestRate.Text);
            HomeLoan.repaymentTime = Convert.ToInt32(tbMonths.Text);

            // variables are passed in as arguments in order for the loan to be calculated
            hl.repayment(HomeLoan.purchasePrice, HomeLoan.deposit, HomeLoan.interestRate, HomeLoan.repaymentTime);


            string msg = "The monthly repayment will be: R";
            msg += Convert.ToString(Math.Round(HomeLoan.monthlyRepayment)); // concatonating the string msg with the monthlyrepayment for the Home loan
            MessageBox.Show(msg, "Monthly repayment");

            MessageBox.Show("Calculating loan approval probability...");
            Thread.Sleep(2000);
            Console.WriteLine();


            if (HomeLoan.monthlyRepayment > (HomeLoan.grossIncomeTemp / 3)) // if greater than 1/3 of gross income --> unlinkely loan approval
            {
                MessageBox.Show("***WARNING***"
                                  + "\n Monthly repayment fee exceeds expected gross income amount"
                                  + "\n Loan approval unlikely","WARNING");
            }
            else
            {
                MessageBox.Show("***SUCCESS***"
                                 + "\n Expected gross income is sufficient"
                                 + "\n Loan approval likely","SUCCESS");
            }


        }

        private void vehicleBtn_Click(object sender, RoutedEventArgs e)
        {
            // object of vehicle class
            Vehicles v = new Vehicles();
            MessageBox.Show("Now loading...", "Loading");
            this.Close();
            v.Show(); // displays vehicle wpf
        }

        private void savingsBtn_Click(object sender, RoutedEventArgs e)
        {
            // object of savings class
            Savings s = new Savings();
            MessageBox.Show("Now loading...", "Loading");
            this.Close();
            s.Show();
        }
    }
}
