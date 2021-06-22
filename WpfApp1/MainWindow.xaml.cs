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

namespace WpfApp1
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

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
        }

        private void myButton_2_Click(object sender, RoutedEventArgs e)
        {
            string[] calculate = TextBox.Text.Split(' ');
            calculate[calculate.Length - 1] = (Convert.ToDouble(calculate[calculate.Length - 1]) * -1).ToString();
            TextBox.Text = "";
            foreach (string str in calculate)
                if (calculate.Length == 1)
                    TextBox.Text += str;
                else
                    TextBox.Text += str + " ";
        }

        private void myButton_3_Click(object sender, RoutedEventArgs e)
        {
            string[] calculate = TextBox.Text.Split(' ');
            calculate[calculate.Length - 1] = (Convert.ToDouble(calculate[calculate.Length - 1]) / 100).ToString();
            TextBox.Text = "";
            foreach (string str in calculate)
                if (calculate.Length == 1)
                    TextBox.Text += str;
                else
                    TextBox.Text += str + " ";
        }

        private void myButton_4_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += " / ";
        }

        private void myButton_5_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += " * ";
        }

        private void myButton_7_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += " - ";
        }

        private void myButton_9_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += " + ";
        }

        private void myButton_15_Click(object sender, RoutedEventArgs e)
        {

                string calc = TextBox.Text;
                string[] calculate = calc.Split(' ');
                double sum = Convert.ToDouble(calculate[0]);
                for (int i = 1; i < calculate.Length;)
                {
                    if (calculate[i] == "+")
                    {
                        sum = sum + Convert.ToDouble(calculate[i + 1]);
                    }
                    if (calculate[i] == "-")
                    {
                        sum = sum - Convert.ToDouble(calculate[i + 1]);
                    }
                    if (calculate[i] == "*")
                    {
                        sum = sum * Convert.ToDouble(calculate[i + 1]);
                    }

                    if (calculate[i] == "/")
                    {
                        sum = sum / Convert.ToDouble(calculate[i + 1]);
                    }
                    if (calculate[i] == "%")
                    {
                        sum = sum / Convert.ToDouble(calculate[i + 1]);
                    }

                    i += 2;
            }
            TextBlk.Text = sum.ToString();
        }

        private void myButton_21_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "3";
        }

        private void myButton_20_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "6";
        }

        private void myButton_19_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "9";
        }

        private void myButton_18_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "8";
        }

        private void myButton_17_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "5";

        }

        private void myButton_16_Click(object sender, RoutedEventArgs e)
        {

        }

        private void myButton_14_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += ",";

            if (TextBox.Text == ",") TextBox.Text = "0,";
        }

        private void myButton_13_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "0";
        }

        private void myButton_12_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "1";
        }

        private void myButton_11_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "4";
        }

        private void myButton_10_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "7";
        }
    }
}
