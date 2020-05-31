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
using System.Threading;

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Global Variables
        double result = 0;
        string operation = "";
        bool isOperation = false;

        public void MainwWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Actions taken for the numeric button press events
            Button button = (Button)sender;
            if ((resultTextBox.Text == "0") || (isOperation))
            {
                resultTextBox.Clear();
            }

            if (button.Content.ToString() == ".")
            {
                if (!resultTextBox.Text.Contains("."))
                {
                    resultTextBox.Text = resultTextBox.Text + button.Content;
                }
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + button.Content;
            }

            isOperation = false;
            
            

        }

        private void operation_button_Click(object sender, RoutedEventArgs e)
        {
            // Actions taken for the operation button press events
            Button button = (Button)sender;
            operation = (button.Content).ToString();    // easier way to do this??
            result = Double.Parse(resultTextBox.Text);
            sumTextBox.Text = result + " " + operation;
            isOperation = true;
        }

        private void equal_button_Click(object sender, RoutedEventArgs e)
        {
            //Actions taken for the equal button press events

            // Switch statement
            switch(operation)
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
            // Actions taken if the clear button is clicked
            resultTextBox.Clear();
            resultTextBox.Text = "0";
            sumTextBox.Clear();
            sumTextBox.Text = "";
        }

        private void resultTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void sumTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

