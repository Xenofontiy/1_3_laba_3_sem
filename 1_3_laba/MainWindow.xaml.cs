using _1_3_laba.Class_interface;
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
using System.Collections;
using System.IO;
using System.Windows.Shapes;

namespace _1_3_laba
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Number, all_price;
        public MainWindow()
        {
            InitializeComponent();
            menu My_Menu = new menu();

            this.DataContext = My_Menu;
            List_menu.ItemsSource= My_Menu.list_of_order;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Number = Convert.ToInt32(Number_TextBox.Text);
            all_price += Convert.ToInt32(Price_TextBox.Text) * Number;
            All_price_TexBox.Text = Convert.ToString(all_price);
        }

    }
}
