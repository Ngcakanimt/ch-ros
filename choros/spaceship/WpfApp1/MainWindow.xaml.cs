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
using System.Windows.Threading;
using ThinkLib;
using System.Drawing;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        // private BitmapImage[] imageForShip;

        Turtle ship, obstacle, obstacle1, obstacle2, obstacle3, obstacle4;
        DispatcherTimer theTimer;
        public void SetApperance(ImageSource spaceimg, int hotspotX, int hotspotY)
        //changing the turtle's appearance to the ship
        {
            ImageSource imgSrc = new BitmapImage(new Uri("C:\\Users\\USER\\Desktop\\CSc 102\\choros\\spaceship\\WpfApp1\\spaceship.png"));
           // ship.SetAppearance(imgSrc, 60, 90);
          //  ship.Stamp(imgSrc.)
        }

        public MainWindow()
        {
            InitializeComponent();
            ship = new Turtle(playground);
            ship.BrushDown = false;

            obstacle = new Turtle(playground, 400, 200);
            obstacle.BodyBrush = Brushes.DarkRed;

            obstacle1 = new Turtle(playground, 300, 200);
            obstacle1.BodyBrush = Brushes.Cyan;

            obstacle3 = new Turtle(playground, 200, 200);
            obstacle3.BodyBrush = Brushes.DodgerBlue;

            obstacle4 = new Turtle(playground, 600, 200);
            obstacle4.BodyBrush = Brushes.LightCoral;

            obstacle2 = new Turtle(playground, 400, 200);
            obstacle2.BodyBrush = Brushes.LightYellow;

            //string thisProject = "pack://application:,/";
            //imageForShip = new BitmapImage[]{
            //  new BitmapImage(new Uri(thisProject + "spaceship"))};
            theTimer = new DispatcherTimer();
            theTimer.Interval = TimeSpan.FromMilliseconds(10);
            theTimer.IsEnabled = true;
            theTimer.Tick += dispatcherTimer_tick;

        } //constructing the ship and it's movements


       /* public void setApperance(ImageSource spaceimg, double hotspotX, double hotspotY)
        //changing the turtle's appearance to the ship
        {
            ImageSource imgSrc = new BitmapImage(new Uri("C:\\Users\\USER\\Desktop\\CSc 102\\choros\\spaceship\\WpfApp1\\spaceship.png"));
            ship.SetAppearance(imgSrc, 60, 90);
        } */
        private void dispatcherTimer_tick(object sender, EventArgs e)
        {
            

            updateTurtle();
        }
        private void updateTurtle()
        {
            
            ship.Forward(1);

        }
        private void shipPos(Point currentPosition)
        {
            Ellipse shipP = new Ellipse();
            Canvas.SetTop(shipP, currentPosition.Y);
            Canvas.SetLeft(shipP, currentPosition.X);

         
        }
        private void obstaclePos(Point currentPosition)
        {
            //obstacle.Position = Random.
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Escape:
                    this.Close();
                    break;
                case Key.Up:
                    ship.Left(100);
                    break;
                case Key.Down:
                    ship.Right(100);
                    break;
                //case Key.Up:
                    
                    
            }
        }
        private void updateView()
        {
           
        }
            

    }
}
