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
    /// Interaction logic for DetailedExpensesWPF.xaml
    /// </summary>
    public partial class DetailedExpensesWPF : Window
    {
        public static double expensesOutput;
        public delegate void msgDel();
        public static double tempExpenses;

        public DetailedExpensesWPF()
        {
            InitializeComponent();
            Calc c = new Calc();


            // display all expenses in tetxblocks
            tbGroceries.Text =("R" + Convert.ToString(HomeLoan.groceries));
            tbWaterLights.Text = ("R" + Convert.ToString(HomeLoan.waterLights));
            tbTravel.Text = ("R" + Convert.ToString(HomeLoan.travel));
            tbPhone.Text = ("R" + Convert.ToString(HomeLoan.phone));
            tbExtras.Text = ("R" + Convert.ToString(HomeLoan.extras));

            // property display
            tbRent.Text = ("R" + Convert.ToString(HomeLoan.rentalFee));
            tbRepayment.Text = ("R" + Convert.ToString(Math.Round(HomeLoan.monthlyRepayment)));

            // vehicle display
            tbVehicle.Text = ("R" + Convert.ToString(Math.Round(Vehicle.monthlyCarRepayment)));

            // savings display
            tbSavings.Text = ("R" + Convert.ToString(Math.Round(Savings.monthlyReqAmount)));

            // extra info display
            tbIncome.Text = ("R" + Convert.ToString(HomeLoan.grossIncome));
            tbTax.Text = ("R" + Convert.ToString(HomeLoan.estTax));


            if (HomeLoan.rentalFee > 0) // used condition to decicide wwhether to add rental fee or home repayment
            {
                expensesOutput = Expenses.totalExpenses + Vehicle.monthlyCarRepayment + HomeLoan.rentalFee + Expenses.estTax + Savings.monthlyReqAmount;
            }
            else
            {
                expensesOutput = Expenses.totalExpenses + Vehicle.monthlyCarRepayment + HomeLoan.monthlyRepayment + Expenses.estTax + Savings.monthlyReqAmount;
            }

            tbTotalExpenses.Text = ("R" + Convert.ToString(Math.Round(expensesOutput)));

            c.input();

            tbTotal.Text = ("R" + Convert.ToString(Math.Round(Calc.monthlyAmount))); // remaining monthly balance displayed


            // delegate that will pop up when total expenses exceed 75% of gross income
            msgDel mg = delegate // anon method using delegates
            {
                if (HomeLoan.rentalFee > 0)
                {
                    tempExpenses = Expenses.totalExpenses + Vehicle.monthlyCarRepayment + HomeLoan.rentalFee + Expenses.estTax + Savings.monthlyReqAmount; // if rent was chosen rent is used in calc

                    if (tempExpenses > (Expenses.grossIncome * 0.75)) // if expenses exceed 75% of gross income --> warning message is issued
                    {
                      MessageBox.Show("******WARNING******" + "\n Total expenses exceed 75% of your income!"
                                          + "\n Saving is recommended","WARNING");
                    }
                }
                else
                {
                    tempExpenses = Expenses.totalExpenses + Vehicle.monthlyCarRepayment + HomeLoan.monthlyRepayment + Expenses.estTax + Savings.monthlyReqAmount; // if purchase property was chosen --> monthly repayment is used in calc

                    if (tempExpenses > (Expenses.grossIncome * 0.75))
                    {
                       MessageBox.Show("******WARNING******" + "\n Total expenses exceed 75% of your income!"
                                          + "\n Saving is recommended","WARNING");
                    }
                }
            };

            // invoking the delegate
            mg.Invoke();



        }

        private void menuBtn_Click(object sender, RoutedEventArgs e)
        {
            // menu button
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
    }
}
