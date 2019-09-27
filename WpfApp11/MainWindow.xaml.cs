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

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Elephant lucinda;
        Elephant lloyd;

        public MainWindow()
        {
            InitializeComponent();
            lucinda = new Elephant() { name = "Lucinda", earSize = 33 };
            lloyd = new Elephant() { name = "Lloyd", earSize = 40 };
        }

        private void Lloydbutton_Click(object sender, RoutedEventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void Lucindabutton_Click(object sender, RoutedEventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void Zamienbutton_Click(object sender, RoutedEventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd.TellMe("Cześć", lucinda);
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Obiekty zamienione!");
        }

        private void Klik_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
