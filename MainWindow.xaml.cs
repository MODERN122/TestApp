using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
using Newtonsoft.Json;

namespace TestApp
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
    }
}
//http://185.220.32.104:8080/test-sales/api/nomenclature
//http://185.220.32.104:8080/test-sales/api/departments/rst/cashsessions/2020-01-02
//http://185.220.32.104:8080/test-sales/api/cashsessions/0240b39b-360f-4166-9e3f-c5e43ea1a493/orders/content
//http://185.220.32.104:8080/test-sales/api/cashsessions/0240b39b-360f-4166-9e3f-c5e43ea1a493/orders/header
//http://185.220.32.104:8080/test-sales/api/orders/f9a3d2ba-f88b-4106-8e9c-f2a646dab6cc
