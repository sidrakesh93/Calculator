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

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double result = 0;
        string opperation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            resultTextBox.Text += button.Content;
        }

        private void opperation_button_Click(object sender, RoutedEventArgs e)
        {
            // code functionality here
            Button button = (Button)sender;
            opperation = button.Content.ToString(); //maybe a more efficient way to do this?
            result = Double.Parse(resultTextBox.Text);
            sumTextBox.Text = result + " " + opperation;
            
        }

        private void equal_button_Click(object sender, RoutedEventArgs e)
        {
            
            switch (opperation)
            {
                case "+":
                    resultTextBox.Text = (result + Double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "-":
                    resultTextBox.Text = (result - Double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "x":
                    resultTextBox.Text = (result * Double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "/":
                    resultTextBox.Text = (result / Double.Parse(resultTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            

        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            resultTextBox.Text = "0";
            sumTextBox.Clear();
            sumTextBox.Text = " ";
        }
    }
}
