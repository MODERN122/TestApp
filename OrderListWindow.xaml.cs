using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Логика взаимодействия для OrderListWindow.xaml
    /// </summary>
    public partial class OrderListWindow : Window, IDisposable
    {
        private List<OrderHeader> _orderHeaderList = new List<OrderHeader>();

        public OrderListWindow()
        {
            _orderHeaderList = Json.GetObject<List<OrderHeader>>("orders_header.json");
            InitializeComponent();
            OrderListGrid.ItemsSource = _orderHeaderList;
        }

        public OrderListWindow(string id)
        {
            string url = "http://185.220.32.104:8080/test-sales/api/cashsessions/" +
                         id + "/orders/header";
            _orderHeaderList = Json.GetObject<List<OrderHeader>>(url);
            InitializeComponent();
            OrderListGrid.ItemsSource = _orderHeaderList.OrderBy(x=>x.number);
        }
        public void Dispose()
        {
            this.Close();
        }

        private void OrderClick(object sender, MouseButtonEventArgs e)
        {
            if (OrderListGrid.SelectedIndex == -1)
                return;
            var ordersWindow = new OrderWindow((OrderListGrid.SelectedItem as OrderHeader).id);
            ordersWindow.Show();
        }
    }
}
