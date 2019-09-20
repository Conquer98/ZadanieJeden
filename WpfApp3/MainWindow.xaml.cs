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

namespace WpfApp3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //comment
            String name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "Nazwa to " + name
                + "\nx jest równe: " + x
                + "\nd jest równe: " + d;

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Karol";
            if ((someValue == 3) && (name.Equals("Kornel")))
            {
                myLabel.Text = "someValue jest równe 3, a imię to Kornel";
            }
            myLabel.Text = "Wiersz ten jest wykonywany bez wzgledu na warunki";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                myLabel.Text = " x równa się 10";
            }
            else
            {
                myLabel.Text = " x nie równa się 10";
            }

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                count--;
            }
            myLabel.Text = "Odpowiedz brzmi: " + count;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            int p = 2;
            for (int q=2; q<32; q=q*2)
            {
                while (p<q)
                {
                    p = p * 2;
                
                }
                q = p - q;
            }
        }
    }
}
