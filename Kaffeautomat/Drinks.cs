using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeautomat
{
    public class Drinks : IDrink
    {
        public static List<IDrink> drinklist = new List<IDrink>();

        public double Price { get; set; }

        public Drinks()
        {

        }

        public Drinks(int price)
        {
            this.Price = price;
        }
    }

    public class CocaCola : Drinks
    {
        public CocaCola(double price)
        {
            this.Price = price;
        }
    }

    public class Fanta : Drinks
    {
        public Fanta(double price)
        {
            this.Price = price;
        }
    }

    public class Sprite : Drinks
    {
        public Sprite(double price)
        {
            this.Price = price;
        }
    }

    public class Kaffe : Drinks
    {
        public Kaffe(double price)
        {
            this.Price = price;
        }

    }

    public class Vatten : Drinks
    {
        public Vatten(double price)
        {
            this.Price = price;
        }
    }

    public class Juice : Drinks
    {
        public Juice(double price)
        {
            this.Price = price;
        }

    }
}
