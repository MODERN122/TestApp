﻿using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using Newtonsoft.Json;

namespace TestApp
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window,IDisposable
    {
        private Order _order = new Order();
        public DataGrid datagrid;

        public OrderWindow()
        {
            _order = Json.GetObject<Order>("order.json");
            InitializeComponent();
            this.DataContext = this;
            OrderGrid.ItemsSource = _order.orderItemsList;
        }

        public OrderWindow(string id)
        {
            string url = "http://185.220.32.104:8080/test-sales/api/orders/" + id;
            _order = Json.GetObject<Order>(url);
            InitializeComponent();
            this.DataContext = this;
            OrderGrid.ItemsSource = _order.orderItemsList;
            datagrid = OrderGrid;
        }

        private async void SaveJsonFile(object sender, RoutedEventArgs e)
        {
            FileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.Filter = "Json Files|*.json";
            dialog.ShowDialog();
            
            if(dialog.FileName=="")
                return;
            using (FileStream file = File.Create(dialog.FileName))
            {
                var jsonString = JsonConvert.SerializeObject(_order);
                var jsonFile = Encoding.UTF8.GetBytes(jsonString);
                await file.WriteAsync(jsonFile);
            }
            
        }
        public void Dispose()
        {
            this.Close();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if(OrderGrid.SelectedIndex==-1)
                return;
            _order.orderItemsList.Remove(OrderGrid.SelectedItem as Orderitemslist);
            datagrid.ItemsSource=null;
            datagrid.ItemsSource = _order.orderItemsList;
        }
    }
}
