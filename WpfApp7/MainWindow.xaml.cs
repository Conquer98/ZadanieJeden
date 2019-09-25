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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Guy Joe;
        Guy Bob;
        int bank = 100;

        public MainWindow()
        {
            InitializeComponent();

            Bob = new Guy() { Cash = 50, Name = "Bob" };
            Joe = new Guy() { Cash = 100, Name = "Joe" };

            UpdateForm();
        }

        public void UpdateForm()
        {
            textBox.Text = Joe.Name + " ma " + Joe.Cash + " zł.";
            textBox1.Text = Bob.Name + " ma " + Bob.Cash + " zł.";
            textBox2.Text = "Bank ma " + bank + " zł.";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (bank >= 10)
            {
                bank -= Joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy.");
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            bank += Bob.GiveCash(5);
            UpdateForm();
        }

        private void JoeGiveBob_Click(object sender, RoutedEventArgs e)
        {
            Bob.ReceiveCash(Joe.GiveCash(10));
            UpdateForm();
        }


        private void BobGiveJoe_Click(object sender, RoutedEventArgs e)
        {
            Joe.ReceiveCash(Bob.GiveCash(5));
            UpdateForm();
        }
    }
}
           
