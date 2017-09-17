using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeautomat
{
    public class AddDrinks
    {

        public static void AddCola()
        {
            Drinks.drinklist.Add(new CocaCola(10));
        }

        public static void AddFanta()
        {
            Drinks.drinklist.Add(new Fanta(10));
        }

        public static void AddSprite()
        {
            Drinks.drinklist.Add(new Sprite(10));
        }

        public static void AddJuice()
        {
            Drinks.drinklist.Add(new Juice(15));
        }

        public static void AddWater()
        {
            Drinks.drinklist.Add(new Vatten(5));
        }

        public static void AddCoffe()
        {
            Drinks.drinklist.Add(new Kaffe(8));
        }
    }
}
