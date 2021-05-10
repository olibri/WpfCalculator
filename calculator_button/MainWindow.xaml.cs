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

namespace calculator_button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
 

        public MainWindow()
        {
            InitializeComponent();
            //a = Bue.Width;
            //b = Bue.Height;
          
        }



   

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            wrap.Background = RedButton.Background;
        }

        private void DorgeBlue_Click(object sender, RoutedEventArgs e)
        {
            wrap.Background = DorgeBlue.Background;

        }

        private void GreenYellow_Click(object sender, RoutedEventArgs e)
        {
            wrap.Background = GreenYellow.Background;

        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            wrap.Background = Green.Background;

        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            wrap.Background = Red.Background;

        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            wrap.Background = Blue.Background;
        }

        private void Navy_Click(object sender, RoutedEventArgs e)
        {
            wrap.Background = Navy.Background;

        }

        private void Gradient_Click(object sender, RoutedEventArgs e)
        {
            wrap.Background = Gradient.Background;

        }

        private void Gradient2_Click(object sender, RoutedEventArgs e)
        {
            wrap.Background = Gradient2.Background;

        }
    }
}
