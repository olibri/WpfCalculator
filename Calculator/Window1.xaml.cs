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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
   
    enum Vimir
    {
         metr, santimer, mile, milimetr, duym
    }
    enum Vimir2
    {
         metr, santimer, mile, milimetr, duym
    }

    public partial class Window1 : Window
    {
        
        bool a,StartProgram;
        double number;
        Vimir vimir;
        Vimir2 vimir2;
        public Window1()
        {
            InitializeComponent();
            a = false;
            number = 0;
            vimir = Vimir.metr;
            vimir = Vimir.metr;
            vimir2 = Vimir2.metr;

            Firstconvert.Content = "0";
            TwoConvert.Content = "0";
            StartProgram = true;
          
        }

        private void Kilometr(object sender, RoutedEventArgs e)
        {
           

        }
        private void HelperConvert(double a1, double a2, double a3, double a4, double a5)
        {
            switch (vimir2)
            {
                case Vimir2.metr:
                    number *= a1;//1;
                    TwoConvert.Content = number.ToString();
                    break;
                case Vimir2.santimer:
                    number *= a2;//100;
                    TwoConvert.Content = number.ToString();
                    break;
                case Vimir2.mile:
                    number *= a3;//0.000621;
                    TwoConvert.Content = number.ToString();
                    break;
                case Vimir2.milimetr:
                    number *= a4;//1000;
                    TwoConvert.Content = number.ToString();
                    break;
                case Vimir2.duym:
                    number *= a5;//39.37;
                    TwoConvert.Content = number.ToString();
                    break;
                default:
                    break;
            }
        }
        private void ConvertHead()
        {
            switch (vimir)
            {
                case Vimir.metr:
                    HelperConvert(1, 100, 0.000621, 1000, 39.37);
                    break;
                case Vimir.santimer:
                    HelperConvert(0.01, 1, 0.000006, 10, 0.393701);
                    break;
                case Vimir.mile:
                    HelperConvert(1609.344, 160934.4, 1, 1609344, 63360);
                    break;
                case Vimir.milimetr:
                    HelperConvert(0.001, 0.1, 0.000000621371192, 1, 0.03937);
                    break;
                case Vimir.duym:
                    HelperConvert(0.0254, 2.54,  0.000016, 25.4, 1);
                    break;
                default:
                    break;
            }
            TwoConvert.Content = number.ToString();

        }

        private void Metr(object sender, RoutedEventArgs e)
        {
            vimir = Vimir.metr;
            HeadMenu.Header = "Metr";
        }

        private void Santimetr(object sender, RoutedEventArgs e)
        {
            vimir = Vimir.santimer;
            HeadMenu.Header = "Santimetr";

        }

        private void Mile(object sender, RoutedEventArgs e)
        {
            vimir = Vimir.mile;
            HeadMenu.Header = "Mile";

        }

        private void milimetr(object sender, RoutedEventArgs e)
        {
            vimir = Vimir.milimetr;
            HeadMenu.Header = "Milimetr";

        }

        private void duym(object sender, RoutedEventArgs e)
        {
            vimir = Vimir.duym;
            HeadMenu.Header = "duym";
        }

        private void Kilometr1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Metr1(object sender, RoutedEventArgs e)
        {
            HeadMenu2.Header = "Metr";
            vimir2 = Vimir2.metr;
        }

        private void Santimetr1(object sender, RoutedEventArgs e)
        {
            HeadMenu2.Header = "Santimetr";
            vimir2 = Vimir2.santimer;

        }

        private void Mile1(object sender, RoutedEventArgs e)
        {
            HeadMenu2.Header = "Mile";
            vimir2 = Vimir2.mile;

        }

        private void milimetr1(object sender, RoutedEventArgs e)
        {
            HeadMenu2.Header = "Milimetr";
            vimir2 = Vimir2.milimetr;

        }

        private void Dyum1(object sender, RoutedEventArgs e)
        {
            HeadMenu2.Header = "duym";
            vimir2 = Vimir2.duym;

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //    mainWindow.Show();
        //}

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            a = true;
            if (StartProgram==true)
            {
                Firstconvert.Content = String.Empty;
                TwoConvert.Content = String.Empty;
                StartProgram = false;
            }
            if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                Firstconvert.Content += "1";
                number = Convert.ToDouble(Firstconvert.Content.ToString());
                TwoConvert.Content = number.ToString();
            }
            else if (e.Key == Key.Escape)
            {
                Firstconvert.Content = String.Empty;
                number = 0;
                TwoConvert.Content = String.Empty;

            }
            else if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                Firstconvert.Content += "2";
                number = Convert.ToDouble(Firstconvert.Content.ToString());

            }
            else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                Firstconvert.Content += "3";
                number = Convert.ToDouble(Firstconvert.Content.ToString());


            }
            else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                Firstconvert.Content += "4";
                number = Convert.ToDouble(Firstconvert.Content.ToString());


            }
            else if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                Firstconvert.Content += "5";
                number = Convert.ToDouble(Firstconvert.Content.ToString());


            }
            else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                Firstconvert.Content += "6";
                number = Convert.ToDouble(Firstconvert.Content.ToString());


            }
            else if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                Firstconvert.Content += "7";
                number = Convert.ToDouble(Firstconvert.Content.ToString());


            }
            else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                Firstconvert.Content += "8";
                number = Convert.ToDouble(Firstconvert.Content.ToString());

            }
            else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                Firstconvert.Content += "9";
                number = Convert.ToDouble(Firstconvert.Content.ToString());

            }
            else if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                Firstconvert.Content += "0";
                number = Convert.ToDouble(Firstconvert.Content.ToString());
            }

            else if (e.Key == Key.Decimal)
            {
                Firstconvert.Content += ",";
            }
            ConvertHead();
        }
    }

}
