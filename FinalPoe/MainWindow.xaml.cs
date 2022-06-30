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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalPoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

   
        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            // income class call 
            Income i = new Income();
            MessageBox.Show("Now loading...", "Loading");
            this.Close();
            i.Show();
        }

        private void ListViewItem_Selected3(object sender, RoutedEventArgs e)
        {
            // exit
            MessageBox.Show("Thank you for using the budgeting app!");
            this.Close();
        }
    }
}
