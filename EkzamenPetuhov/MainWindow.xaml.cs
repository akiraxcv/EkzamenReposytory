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

namespace EkzamenPetuhov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Hleb.Items.Add("Белый");
            Hleb.Items.Add("Серый");
            Hleb.Items.Add("Злаковый");
        }

        private void Raschet_Click(object sender, RoutedEventArgs e)
        {
            
            Order order = new Order();
            int price = Convert.ToInt32(PriceKilo.Text);
            int ves = Convert.ToInt32(Ves.Text);
            Bread bread = new Bread();
            bread.CenaHleba = price;
            bread.VesHelba = ves;

            int itogcena = bread.PriceForKilo(ves, price);

            string name = Hleb.SelectedItem.ToString();

            OrderTextbox.Text += order.AddToOrder(name, ves, itogcena);
        }

        private void Hleb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Hleb.SelectedIndex == 0)
            {
                int priceforkilo = 130;
                PriceKilo.Text = Convert.ToString(priceforkilo);
            }
            else if (Hleb.SelectedIndex == 1)
            {
                int priceforkilo = 110;
                PriceKilo.Text = Convert.ToString(priceforkilo);
            }
            else if (Hleb.SelectedIndex == 2)
            {
                int priceforkilo = 160;
                PriceKilo.Text = Convert.ToString(priceforkilo);
            }
        }

        private void go_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
