using AuctionMetalWebApplication.Models;
using System;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace WpfAuctionApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private CreateAuctionWindow createAuctionWindow;
        private AuctionContext auctionContext = new AuctionContext();

        public MainWindow()
        {
            InitializeComponent();
            createAuctionWindow = new CreateAuctionWindow(this);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateContent();
            new Thread(DispatcherTimer_Tick).Start();
        }

        private void DispatcherTimer_Tick()
        {
            while (true)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    UpdateContent();
                }), DispatcherPriority.ApplicationIdle);
                Thread.Sleep(1000);
            }
        }

        private void UpdateContent()
        {
            auctionContext = new AuctionContext();
            var list = auctionContext.Sellers.ToList();
            SellerDataGrid.ItemsSource = list;

        }

        private void CreateAuctionWindow_Click(object sender, RoutedEventArgs e)
        {
            createAuctionWindow.Show();

        }

        public void CreateAuction(Seller seller)
        {
            auctionContext.Sellers.Add(seller);
            auctionContext.SaveChanges();
        }

      
    }
}
