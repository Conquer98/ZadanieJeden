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

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };
                     
                textBlock.Text = menu.GetMenuItem();
                textBlock1.Text = menu.GetMenuItem();
                textBlock2.Text = menu.GetMenuItem();
                textBlock3.Text = menu.GetMenuItem();

            MessageBox.Show("Danie numer 1 - " + textBlock.Text + "\nDanie numer 2 - " + textBlock1.Text + "\nDanie numer 3 - " + textBlock2.Text +
                "\nDanie numer 4 - " + textBlock3.Text, "Niechlujny Janek Menu: ");
            
          
        }
    }
}
