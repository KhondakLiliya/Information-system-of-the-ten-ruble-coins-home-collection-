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
        const string FileName = "CoinsList.txt";
        List<Coins> _coins = new List<Coins>();
        
        public MainWindow()
        {
            InitializeComponent();
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBoxCoin.ItemsSource = null;
            listBoxCoin.ItemsSource = _coins;
        }
       

        private void NewCoin_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddCoin();
            if(window.ShowDialog().Value)
            {
                _coins.Add(window.NewCoins);
                SaveData();
                RefreshListBox();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxCoin.SelectedIndex != -1)
            {
                _coins.RemoveAt(listBoxCoin.SelectedIndex);
                SaveData();
                RefreshListBox();
            }
        }

        private void listBoxCoin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DeleteCoin.IsEnabled = listBoxCoin.SelectedIndex != -1;
        }

        private void SaveData()
        {
            using (var str = new StreamWriter(FileName))
            {
                foreach (var coin in _coins)
                {
                    str.WriteLine($"{coin.Mint}-{coin.Description}-{coin.Year}");
                }
            }
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = Search.Text;
            if (text == "")
            {
                listBoxCoin.ItemsSource = _coins;
            }

            else
            {
                listBoxCoin.ItemsSource = SearchCoins(text);
            }
        }

        public List<Coins> SearchCoins (string input)
        {
            List<Coins> abc = new List<Coins>();
            foreach (var item in _coins)
            {
                if (input == item.InfMint || input == item.InfDescription || input == item.InfYear)
                {
                    abc.Add(item);
                }
            }
            return abc;
        }
    }
}
