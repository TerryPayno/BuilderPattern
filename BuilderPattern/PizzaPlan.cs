using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    interface PizzaPlan
    {
        void setPizzaBase(string Dough);
        void setPizzaThickness(string Thickness);
        void setPizzaTopping(string Topping);
        void setPizzaSize(int Size);
    }
}
