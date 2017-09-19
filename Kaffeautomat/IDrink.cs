using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeautomat
{
    public interface IDrink
    {
        decimal Price { get; set; }
        string Name { get; set; }
    }
}
