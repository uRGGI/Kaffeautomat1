using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeautomat
{
    public static class Payment
    {
        

        public static double Sum
        {
            get
            {
                return SumOfDrinks();
                
            }
        }
        public static double Change { get; set; }
        public static double AmountPaid { get; set; }

        public static double SumOfDrinks()
        {
            double sum = 0;
            foreach (var drink in Drinks.drinklist)
            {
                sum += drink.Price;
            }
            
            return sum;
        }

        public static double CalcChange()
        {
            Change = AmountPaid - Sum;
            if (Change < 0)
            {
                Change = 0;
            }

            return Change;
        }

        public static double AmountToPay()
        {
            if (Sum - AmountPaid < 0)
            {
                return 0;
            }
            return Sum - AmountPaid;
            
            
        }
    }
}
