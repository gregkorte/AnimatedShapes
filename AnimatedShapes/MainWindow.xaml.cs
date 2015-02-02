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

namespace AnimatedShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FirstMove(object sender, MouseEventArgs e)
        {
            double windowHeight = this.ActualHeight;
            double windowWidth = this.ActualWidth;
            Random random = new Random();
            int xMovement = random.Next(200) - 1;
            int yMovement = random.Next(300) - 1;

            Canvas.SetTop(RectangleOne, xMovement);
            Canvas.SetLeft(RectangleOne, yMovement);

            //RectangleOne.HorizontalAlignment = xMovement;
            //RectangleOne.VerticalAlignment = yMovement;
            RectangleOne.Fill = Brushes.DarkOliveGreen;
        }
    }
}
