using Bookstore.Class;
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
using static Bookstore.MainWindow;

namespace Bookstore.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    /// 
    public partial class Main : Page
    {
        List<Boockstore> boockstores = BaseConnect.baseConnect.Boockstore.ToList();
        List<Add> add = BaseConnect.baseConnect.Add.ToList();
        public Main()
        {
            InitializeComponent();
            listbox1.ItemsSource = boockstores;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            //BaseConnect.baseConnect.SaveChanges(); //Синхронизировать с сервером
            ////создаем запись в таблице Users, соответствующую данной                 
            //Add a1 = new Add();
            
            //BaseConnect.baseConnect.Boockstore.Add(a1);
            //BaseConnect.baseConnect.SaveChanges();
            //MessageBox.Show("Данные записаны успешно");
        }
        private void buttonBascet_Click(object sender, RoutedEventArgs e)
        {
            Perexod.frm.Navigate(new Bascket());

        }
    }
}
