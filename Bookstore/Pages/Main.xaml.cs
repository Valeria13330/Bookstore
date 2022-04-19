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

namespace Bookstore.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    /// 
    public static class Perexod
    {
        public static Frame frm;
    }
    public partial class Main : Page
    {
        List<Boockstore> boockstores = BaseConnect.baseConnect.Boockstore.ToList();
        List<Add> productsType = BaseConnect.baseConnect.Add.ToList();
        public Main()
        {
            InitializeComponent();
            listbox1.ItemsSource = boockstores;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            BaseConnect.baseConnect.SaveChanges(); //Синхронизировать с сервером
            //создаем запись в таблице Users, соответствующую данной                 
            Boockstore data = new Boockstore();
            data.Title = Title.Text;

            BaseConnect.baseConnect.Boockstore.Add(data);
            BaseConnect.baseConnect.SaveChanges();
            MessageBox.Show("Данные записаны успешно");/
        }
    }
}
