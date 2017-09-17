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

        public static Fanta AddFanta()
        {
            return new Fanta(10);
        }

        public static Sprite AddSprite()
        {
            return new Sprite(10);
        }

        public static Juice AddJuice()
        {
            return new Juice(15);
        }

        public static Vatten AddWater()
        {
            return new Vatten(5);
        }

        public static Kaffe AddCoffe()
        {
            return new Kaffe(8);
        }
    }
}
