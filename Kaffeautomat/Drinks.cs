using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeautomat
{
    public class Drinks : IDrink
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public DrinkType Drinktype { get; set; }

        public Drinks()
        {
            
        }

        public Drinks(int price, string name, DrinkType type)
        {
            this.Price = price;
            this.Name = name;
            this.Drinktype = type;
        }
    }

    /*public class CocaCola : Drinks
    {
        public CocaCola(decimal price, string name)
        {
            Drinktype = DrinkType.Coke;
            this.Name = name;
            this.Price = price;
        }
    }

    public class Fanta : Drinks
    {
        public Fanta(decimal price, string name)
        {
            Drinktype = DrinkType.Fanta;
            this.Name = name;
            this.Price = price;
        }
    }

    public class Sprite : Drinks
    {
        public Sprite(decimal price, string name)
        {
            Drinktype = DrinkType.Sprite;
            this.Name = name;
            this.Price = price;
        }
    }

    public class Kaffe : Drinks
    {
        public Kaffe(decimal price, string name)
        {
            Drinktype = DrinkType.Kaffe;
            this.Name = name;
            this.Price = price;
        }

    }

    public class Vatten : Drinks
    {
        public Vatten(decimal price, string name)
        {
            this.Drinktype = DrinkType.Vatten;
            this.Name = name;
            this.Price = price;
        }
    }

    public class Juice : Drinks
    {
        public Juice(decimal price, string name)
        {
            this.Drinktype = DrinkType.Juice;
            this.Name = name;
            this.Price = price;
        }

    }
    */

    public enum DrinkType
    {
        Coke,
        Fanta,
        Sprite,
        Kaffe,
        Juice,
        Vatten
    }
}
