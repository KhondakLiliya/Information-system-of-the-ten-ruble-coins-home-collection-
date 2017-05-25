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
using System.Windows.Shapes;

namespace KDZ10Rub
{
    /// <summary>
    /// Логика взаимодействия для AddCoin.xaml
    /// </summary>
    public partial class AddCoin : Window
    {
        public AddCoin()
        {
            InitializeComponent();
        }
    
        public Coins NewCoins
        {
            get { Coins _newCoins = null; return _newCoins; }

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int year;


            if (string.IsNullOrWhiteSpace(Mint1.Text))
            {
                MessageBox.Show("Укажите монетный двор");
                Mint1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Description1.Text))
            {
                MessageBox.Show("Укажите особенность");
                Description1.Focus();
                return;
            }
            
            if (!int.TryParse(Year1.Text, out year) || year < 0 || year == 0)
            {
                MessageBox.Show("Укажите год чеканки");
                Year1.Focus();
                return;
            }

            var _newCoins = new Coins(Mint1.Text, Description1.Text, year);
            DialogResult = true;
        }
    }
}
