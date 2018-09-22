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

namespace CSc_semester_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game_mode game;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            game = new Game_mode();
            game.Show();
            Main_menu.Hide();

        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to quit?","", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Main_menu.Close();
            }
            else if (result == MessageBoxResult.No)
            {
                
            }
        }
    }
}   
