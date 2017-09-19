using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeautomat
{
    public class Drinkvendor
    {
        public static List<Drinks> drinklist = new List<Drinks>();

        public void AddCoke()
        {
            drinklist.Add(new Drinks(10, "Coca Cola", DrinkType.Coke));
        }

        public void AddFanta()
        {
            drinklist.Add(new Drinks(10, "Fanta", DrinkType.Fanta));
        }

        public void AddSprite()
        {
            drinklist.Add(new Drinks(10, "Sprite", DrinkType.Sprite));
        }

        public void AddKaffe()
        {
            drinklist.Add(new Drinks(8, "Kaffe", DrinkType.Kaffe));
        }

        public void AddVatten()
        {
            drinklist.Add(new Drinks(5, "Vatten", DrinkType.Vatten));
        }

        public void AddJuice()
        {
            drinklist.Add(new Drinks(15, "Juice", DrinkType.Juice));
        }
    }
}
