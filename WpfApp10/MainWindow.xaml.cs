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

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int startMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            startMileage = (int)integer1.Value;
            endingMileage = (int)integer2.Value;


            if(startMileage<=endingMileage)
            {
                milesTraveled = endingMileage - startMileage;
                amountOwed = milesTraveled * reimburseRate;
                textBlock3.Text = amountOwed.ToString() + " zł";

            }
            else
            {
                MessageBox.Show("Początkowy stan licznika musi być mniejszy niż końcowy!!!!", "Nie mogę obliczyć odległości");
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Droga, którą przebył nasz pojazd wynosi: " + milesTraveled + " kilometrów.", "Przebyta odległość :");
        }
    }
}
