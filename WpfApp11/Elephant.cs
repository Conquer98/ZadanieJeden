using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp11
{
    class Elephant
    {
        public string name;
        public int earSize;

        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy mają " + earSize + " centymetrów szerokości.", name + " powiedziała...");

        }
    }
}
