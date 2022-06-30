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
    /// Interaction logic for Vehicles.xaml
    /// </summary>
    public partial class Vehicles : Window
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            // object of vehicle class
            Vehicle v = new Vehicle();

            // text from textboxes stored in respective variables
            Vehicle.make = tbMake.Text;
            Vehicle.model = tbModel.Text;
            Vehicle.purchasePrice = Convert.ToDouble(tbPP.Text);
            Vehicle.totalDeposit = Convert.ToDouble(tbDeposit.Text);
            Vehicle.interestRateTemp = Convert.ToDouble(tbInterestRate.Text);
            Vehicle.estInsurancePrem = Convert.ToDouble(tbInsurance.Text);

            // method call from vehicle class
            v.input();

            MessageBox.Show("Please wait..." + "\nCalculating...", "Loading");
            Thread.Sleep(2000);

            MessageBox.Show("The monthly repayment amount for the " + Vehicle.make + " " + Vehicle.model + " will be: R" + Math.Round(Vehicle.monthlyCarRepayment)); // concatonation of user input make, model and calculated monthly repayment 
        }

        private void savingsBtn_Click(object sender, RoutedEventArgs e)
        {
            // object of saving class
            Savings s = new Savings();
            MessageBox.Show("Now loading...", "Loading");
            this.Close();
            s.Show();
        }
    }
}
