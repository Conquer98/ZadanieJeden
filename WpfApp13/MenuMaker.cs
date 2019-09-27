using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Pieczoną wołowiną", "Kurczakiem", "Indykiem", "Smażoną wieprzowiną" };
        string[] Condiments = { "musztarda", "majonez", "keczup", "sos czosnkowy", "sos arabski" };
        string[] Breads = { "Chleb ryżowy", "Chleb biały", "Chleb wieloziarnisty", "Chleb zbożowy", "Bułka" };


        public string GetMenuItem()
        {
            string randomMeats = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];

            return randomBreads + " z " + randomMeats + " i do tego " + randomCondiments;
        }
    }
}
