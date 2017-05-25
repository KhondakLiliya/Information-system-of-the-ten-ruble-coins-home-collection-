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
using System.IO;

namespace KDZ10Rub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Username1.Text == "Liliya" && Password1.Text == "lil1898")
            {
                HaveCoins coin = new HaveCoins();
                coin.Show();
                this.Close();
            }
        }
    }
}
