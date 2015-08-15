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
        private int op = int.MinValue;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void num_button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            curr_box.Text += b.Content;
        }

        private void op_button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            if (op != int.MinValue)
            {
                if (curr_box.Text != "")
                {
                    if (op == 1)
                    {
                        result += Int32.Parse(curr_box.Text);
                    }
                    else if (op == 2)
                    {
                        result -= Int32.Parse(curr_box.Text);
                    } 
                } 
            }
            else
            {
                result = Int32.Parse(curr_box.Text);
            }

            result_box.Text = "" + result;
            curr_box.Text = "";

            string button_type = b.Content.ToString();

            if (button_type == "+")
            {
                op = 1;
            }
            else if (button_type == "-")
            {
                op = 2;
            }
        }
    }
}
