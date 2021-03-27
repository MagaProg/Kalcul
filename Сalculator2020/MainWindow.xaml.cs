using System;
using System.Collections.Generic;
using System.Data;
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

namespace Сalculator2020
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
        
        private void one_Click(object sender, RoutedEventArgs e)
        {
            string d = "1";


            reshenie.Text += d;
        }

        private void zero_Copy_Click(object sender, RoutedEventArgs e)
        {
            otvet.Content = "";
            reshenie.Text = "";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            string d = "2";


            reshenie.Text += d;

        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
           


            string d = "3";


            reshenie.Text += d;
            
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            string d = "4";


            reshenie.Text += d;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            string d = "5";


            reshenie.Text += d;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            string d = "6";


            reshenie.Text += d;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            string d = "7";


            reshenie.Text += d;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            string d = "8";


            reshenie.Text += d;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            string d = "9";


            reshenie.Text += d;
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            string d = "0";


            reshenie.Text += d;
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {

            string d = "+";


            reshenie.Text += d;

        }

        private void ostatok_Click(object sender, RoutedEventArgs e)
        {
            string d = "%";


            reshenie.Text += d;
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            string d = "-";


            reshenie.Text += d;
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            string d = "*";


            reshenie.Text += d;
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            string d = "/";


            reshenie.Text += d;
        }

        private void Equality_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                      double value = Convert.ToDouble(new DataTable().Compute(reshenie.Text, null));
                      otvet.Content = value;
                oshibka.Content = "";
            }
            catch (System.Data.EvaluateException)
            {
                oshibka.Content = "Веденны некоректные данные!!";
            }
            catch (System.InvalidCastException)
            {
                oshibka.Content = "";
            }
            catch (System.Data.SyntaxErrorException)
            {
                oshibka.Content = "Веденны некоректные данные!!";
            }

        }
    }
}
