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

namespace CSc_semester_project
{
    /// <summary>
    /// Interaction logic for Game_mode.xaml
    /// </summary>
    public partial class Game_mode : Window
    {
        Game1 dodge;
        Game2 shoot;
        MainWindow menu;
        public Game_mode()
        {
            InitializeComponent();
        }

        private void Dodge_Click(object sender, RoutedEventArgs e)
        {
            dodge = new Game1();
            dodge.Show();
            GameMode.Hide();
           
        }

        private void Shoot_Click(object sender, RoutedEventArgs e)
        {
            shoot = new Game2();
            shoot.Show();
            GameMode.Hide();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            menu = new MainWindow();
            menu.Show();
            GameMode.Hide();
        }
    }
}
