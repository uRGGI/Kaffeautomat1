using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeautomat
{
    public class Payment
    {
        
        private Drinkvendor drinkvendor = new Drinkvendor();

        public decimal Sum
        {
            get
            {
                return SumOfDrinks();
                
            }
        }
        public decimal Change { get; set; }
        public decimal AmountPaid { get; set; }

        public decimal SumOfDrinks()
        {
            decimal sum = 0;
            foreach (var drink in Drinkvendor.drinklist)
            {
                sum += drink.Price;
            }
            
            return sum;
        }

        public decimal CalcChange()
        {
            Change = AmountPaid - Sum;
            if (Change < 0)
            {
                Change = 0;
            }

            return Change;
        }

        public decimal AmountToPay()
        {
            if (Sum - AmountPaid < 0)
            {
                return 0;
            }
            return Sum - AmountPaid;
            
        }
    }
}
