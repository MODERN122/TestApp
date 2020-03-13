using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
    /// Логика взаимодействия для CashSessionsWindow.xaml
    /// </summary>
    public partial class CashSessionsWindow : Window, IDisposable
    {
        private List<CashSession> _sessionList = new List<CashSession>();

        public CashSessionsWindow()
        {
            InitializeComponent();
            CashSessionGrid.ItemsSource = _sessionList;
        }
        private void CashSessionClick(object sender, MouseButtonEventArgs e)
        {
            if (CashSessionGrid.SelectedIndex==-1)
                return;
            var ordersWindow = new OrderListWindow((CashSessionGrid.SelectedItem as CashSession).id);
            ordersWindow.Show();

        }

        public string GetStringDate(DateTime date) => date.Year + "-" +
                                                      (date.Month > 9
                                                          ? date.Month.ToString()
                                                          : (date.Month.ToString("00"))) + "-" +
                                                      (date.Day > 9
                                                          ? date.Day.ToString()
                                                          : (date.Day.ToString("00")));
        
        private void DateTimeChanged(object sender, SelectionChangedEventArgs e)
        {
            CashSessionGrid.ItemsSource = Json.GetObject<List<CashSession>>(
                "http://185.220.32.104:8080/test-sales/api/departments/rst/cashsessions/"
                + GetStringDate(DatePicker.DisplayDate));
        }
        
        public void Dispose()
        {
            this.Close();
        }

    }
}
