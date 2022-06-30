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
    /// Interaction logic for Income.xaml
    /// </summary>
    public partial class Income : Window
    {
        public Income()
        {
            InitializeComponent();
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            // back btn
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            // enter btn

            //stores the values inputted into the textboxes into the respective variables
            Expenses.grossIncome = Convert.ToDouble(tbGrossIncome.Text);
            Expenses.estTax = Convert.ToDouble(tbTax.Text);

            Expenses.groceries = Convert.ToDouble(tbGroceries.Text);
            Expenses.expensesList.Add(Expenses.groceries);

            Expenses.waterLights = Convert.ToDouble(tbWaterLights.Text);
            Expenses.expensesList.Add(Expenses.waterLights);

            Expenses.travel = Convert.ToDouble(tbTravel.Text);
            Expenses.expensesList.Add(Expenses.travel);

            Expenses.phone = Convert.ToDouble(tbPhone.Text);
            Expenses.expensesList.Add(Expenses.phone);

            Expenses.extras = Convert.ToDouble(tbExtras.Text);
            Expenses.expensesList.Add(Expenses.extras);

            Expenses.totalExpenses = Math.Round(Expenses.expensesList.Sum());


            MessageBox.Show("Your data has been saved!"); // message box displays message
        }

        private void loanBtn_Click(object sender, RoutedEventArgs e)
        {
            // calls loan class 
            Loan l = new Loan();
            MessageBox.Show("Now loading...", "Loading");
            this.Close();
            l.Show();
        }

        private void rentBtn_Click_1(object sender, RoutedEventArgs e)
        {
            // calls renting class
            Renting r = new Renting();
            MessageBox.Show("Now loading...", "Loading");
            this.Close();
            r.Show();
        }
    }
}
