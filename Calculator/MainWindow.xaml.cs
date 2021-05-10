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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a, b;
        char s;
        bool yes, ChangeZnak_;
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Логіку взяв з калькулятора на формах " +
                "лиш переробив під лейбли замість текстбоксів " +
                "просто по дизайну два лейбла краще виглядають прикупі ніж два текстбокса");
            a = b = 0;
            s = '\0';
            yes = false;
            ChangeZnak_ = false;
            HeadWindow.Content = String.Empty;

            Window2.Content = String.Empty;
        }

        private bool ChekMinus()
        {
            if(HeadWindow.Content == "" && yes== false)
            {
                HeadWindow.Content = '-';
                return false;
            }
            return true;

        }
        private void Check_change_action(char sym)
        {
            if (HeadWindow.Content == "" && yes == false)
            {
                Window2.Content = Window2.Content.ToString().Remove(Window2.Content.ToString().Length-1,1);
                Window2.Content = Window2.Content.ToString() + sym;
            }
        }
        private void Diya(char symbol , string symbol2, object sender, RoutedEventArgs e)
        {
            CheckDot();
            if (yes == true)
            {
                s = symbol;
                a = Convert.ToDouble(Window2.Content);
                Window2.Content += symbol2;
                HeadWindow.Content = String.Empty;
                yes = false;
                return;
            }

            if (Window2.Content != "" && HeadWindow.Content != "")
            {
                Zerult_Click(sender, e);
                s = symbol;
                Window2.Content += symbol2;
                HeadWindow.Content = String.Empty;
                yes = false;
                return;
            }
            if (Window2.Content == "")
            {
                a = Convert.ToDouble(HeadWindow.Content.ToString());
                Window2.Content = HeadWindow.Content;
                HeadWindow.Content = symbol2;
            }
            else if (yes == false)
            {
                Zerult_Click(sender, e);
                Window2.Content = HeadWindow.Content;
            }
            s = symbol;
            Window2.Content += symbol2;
            HeadWindow.Content = String.Empty;
        }
        private void CheckDot()
        {
            foreach (var item in HeadWindow.Content.ToString())
                if (item == '.')
                    HeadWindow.Content = HeadWindow.Content.ToString().Replace(".", ",");//перевірка на крапку. Можна було і без цього обійтись але на всякий випадок нехай буде
        }

        private void CE_Clear_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content = String.Empty;
        }

        private void C_Delete_Click(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            HeadWindow.Content = String.Empty;
            Window2.Content = String.Empty;
            yes = false;
            ChangeZnak_ = false;
        }

        private void Delete_one_symbol_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content = HeadWindow.Content.ToString().Remove(HeadWindow.Content.ToString().Length - 1, 1);
            for (int i = 0; i < HeadWindow.Content.ToString().Length; i++)
            {
                if (HeadWindow.Content.ToString()[i] == ',' && i + 1 != HeadWindow.Content.ToString().Length - 1)
                {
                    HeadWindow.Content = HeadWindow.Content.ToString().Remove(HeadWindow.Content.ToString().Length - 1, 1);
                    return;
                }
            }
        }

      
        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += "7";
        }

        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += "8";

        }

        private void NineBtn_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += "9";

        }
        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += "4";

        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += "5";

        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += "6";

        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += "1";

        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += "2";

        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += "3";

        }



        private void Division_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeZnak_ == true)
            {
                Check_change_action('/');
                ChangeZnak_ = false;
                s = '/';
                return;
            }
            Diya('/', "/", sender, e);
        }
        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeZnak_ == true)
            {
                Check_change_action('*');
                ChangeZnak_ = false;
                s = '*';
                return;
            }
            Diya('*', "*", sender, e);
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeZnak_ == true)
            {
                Check_change_action('+');
                ChangeZnak_ = false;
                s = '+';
                return;
            }
            Diya('+', "+", sender, e);
        }

      

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeZnak_ == true)
            {
                Check_change_action('-');
                s = '-';
                ChangeZnak_ = false;

                return;
            }
            if (!ChekMinus())
                return;
            Diya('-', "-", sender, e);
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += ",";

        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            HeadWindow.Content += "0";

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                OneBtn_Click(sender, e);
            }
            else if (e.Key == Key.Escape)
            {
                C_Delete_Click(sender, e);
            }
            else if (e.Key== Key.D2 || e.Key == Key.NumPad2)
            {
                TwoBtn_Click(sender, e);
            }
            else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                ThreeBtn_Click(sender, e);
            }
            else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                FourBtn_Click(sender, e);
            }
            else if (e.Key == Key.D5 || e.Key== Key.NumPad5)
            {
                FiveBtn_Click(sender, e);
            }
            else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                SixBtn_Click(sender, e);
            }
            else if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                SevenBtn_Click(sender, e);
            }
            else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                EightBtn_Click(sender, e);
            }
            else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                NineBtn_Click(sender, e);
            }
            else if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                Zero_Click(sender, e);
            }
            else if (e.Key == Key.Add)
            {
                Plus_Click(sender, e);
            }
            else if (e.Key == Key.Subtract)
            {
                Minus_Click(sender, e);
            }
            else if (e.Key == Key.Multiply)
            {
                Multiplication_Click(sender, e);
            }
            else if (e.Key == Key.Divide)
            {
                Division_Click(sender, e);
            }
            else if (e.Key == Key.Enter)
            {
                Zerult_Click(sender, e);
            }
            else if (e.Key == Key.Decimal)
            {
                Point_Click(sender, e);
            }
        }

        private void Zerult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                b = Convert.ToDouble(HeadWindow.Content);

                switch (s)
                {
                    case '+':
                        a += b;
                        break;
                    case '-':
                        a -= b;
                        break;
                    case '*':
                        a *= b;
                        break;
                    case '/':
                        a /= b;
                        break;
                    default:
                        break;
                }
                HeadWindow.Content = String.Empty;
                Window2.Content = Convert.ToString(a);
                yes = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Шоб поміняти дію потрібно нажати внизу кнопку і тоді вибрати нову дію"
                    +"\n\nдля відємного числа просто ставите мінус і все дію міняти не  потрібно");
            }
            
        }

        private void Znak_Click(object sender, RoutedEventArgs e)
        {
            ChangeZnak_ = true;
        }
    }
}
