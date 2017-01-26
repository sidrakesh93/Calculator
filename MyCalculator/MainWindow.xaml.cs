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
        private int result = 0;
       // private int op = int.MinValue;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            resultTextBox.Text += b.Content;
        }

        private void opperation_button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            resultTextBox.Text = resultTextBox.Text + b.Content;

            
        }

        private void equal_button_Click(object sender, RoutedEventArgs e)
        {
            // todo :
            // 1) switch for the operation controlls
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
