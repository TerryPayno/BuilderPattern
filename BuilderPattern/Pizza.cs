using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Pizza : PizzaPlan
    {
        private string pizzaDough;
        private int pizzaSize;
        private string pizzaThickness;
        private string pizzaTopping;

        public void setPizzaBase(string Dough)
        {
            pizzaDough = Dough;
        }

        public string getPizzaBase() { return pizzaDough; }

        public void setPizzaSize(int Size)
        {
            pizzaSize = Size;
        }

        public int getPizzaSize() { return pizzaSize; }

        public void setPizzaThickness(string Thickness)
        {
            pizzaThickness = Thickness;
        }

        public string getPizzaThickness() { return pizzaThickness; }

        public void setPizzaTopping(string Topping)
        {
            pizzaTopping = Topping;
        }

        public string getPizzaTopping() { return pizzaTopping; }
    }
}
