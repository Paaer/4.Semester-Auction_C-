using AuctionMetalWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAuctionApp
{
    /// <summary>
    /// Interaction logic for CreateAuctionWindow.xaml
    /// </summary>
    public partial class CreateAuctionWindow : Window
    {
        MainWindow mainWindow;
        public CreateAuctionWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

           private void ButtonCreateAuction_Click(object sender, RoutedEventArgs e)
        {
            if (!TimeLimitDatepicker.SelectedDate.HasValue || amountTxtBox.Text.Equals(""))
            {

                MessageBox.Show("Fill in all fields");

            }
           else
            {
                DateTime datePicker = (DateTime)TimeLimitDatepicker.SelectedDate;
                Seller seller = new Seller { Amount = Int32.Parse(amountTxtBox.Text), MetalType = TypeComboBox.SelectedValue.ToString(), TimeLimit = datePicker };
                mainWindow.CreateAuction(seller);
                Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
