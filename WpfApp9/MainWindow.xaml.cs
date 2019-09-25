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

namespace WpfApp9
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
            int myInt = 10;
            byte mByte = (byte)myInt;
            double myDouble = (double)mByte;
            //bool myBool = (bool)myDouble;
            string myString = "false";
            //myBool = (bool)myString;
            //myString = (string)myInt;
            myString = myInt.ToString();
            //myBool = (bool)mByte;
            //mByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            //myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            
            MessageBox.Show("myInt wynosi: " + myInt + "\nmByte wynosi: " + mByte 
                + "\nmyDouble wynosi: " +myDouble + "\nmyChar wynosi: " + myChar);


        }
    }
}
