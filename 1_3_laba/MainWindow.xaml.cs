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
        int all_price, Final_Price, Final_Time;
        menu My_Menu; order My_Order;


        public struct _order
        {
            public string name_Order { get; set; }
            public int price_Order { get; set; }
            public int pries_of_food_Order { get; set; }
            public int number_Order { get; set; }


        }
        public struct order
        {
            public List<_order> Final_Order;

        }

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            My_Menu = new menu();
            List_menu.ItemsSource = My_Menu.list_of_order;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _order _My_Order = new _order();

            _My_Order.name_Order = Name_TextBox.Text;

            _My_Order.number_Order = Convert.ToInt32(Number_TextBox.Text);

            _My_Order.price_Order = Convert.ToInt32(Price_TextBox.Text)* _My_Order.number_Order;

            _My_Order.pries_of_food_Order = Convert.ToInt32(Pries_of_food_TextBox.Text)* _My_Order.number_Order;

            all_price += Convert.ToInt32(Price_TextBox.Text) * _My_Order.number_Order;
            All_price_TexBox.Text = Convert.ToString(all_price);
            if (Final_Time < Convert.ToInt32(Time_TextBox.Text))
                Final_Time = Convert.ToInt32(Time_TextBox.Text);

            My_Order = new order();
            My_Order.Final_Order = new List<_order>();
            My_Order.Final_Order.Add(_My_Order);
            List_Оrder_ListView.Items.Add (My_Order.Final_Order);


        }

    }
}
