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
    /// Interaction logic for Renting.xaml
    /// </summary>
    public partial class Renting : Window
    {
        public delegate void msgDel();
        public static double tempExpenses;

        public Renting()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            // enter button

            // saves textbox text into variable
            HomeLoan.rentalFee = Convert.ToDouble(tbRent.Text);

            MessageBox.Show("Data saved!");
        }

   
        private void vehicleBtn_Click(object sender, RoutedEventArgs e)
        {
            // vehicle class object
            Vehicles v = new Vehicles();
            MessageBox.Show("Now loading...", "Loading");
            this.Close();
            v.Show();
        }

        private void savingsBtn_Click(object sender, RoutedEventArgs e)
        {
            // savings class object
            Savings s = new Savings();
            MessageBox.Show("Now loading...", "Loading");
            this.Close();
            s.Show();
        }
    }
}
