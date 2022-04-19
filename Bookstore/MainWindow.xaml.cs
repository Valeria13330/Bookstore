using Bookstore.Class;
using Bookstore.Pages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bookstore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static class Perexod
        {
            public static Frame frm;
        }
        public MainWindow()
        {
            InitializeComponent();
            BaseConnect.baseConnect = new Entities3();
            Perexod.frm = frm;
            frm.Navigate(new Main());
        }

        private void buttonBascet_Click(object sender, RoutedEventArgs e)
        {
            Perexod.frm.Navigate(new Bascket());
        }
    }
}
