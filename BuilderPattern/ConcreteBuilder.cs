using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class ConcreteBuilder: PizzaBuilder
    {
        private Pizza pizza;
        
        public ConcreteBuilder()
        {
            this.pizza = new Pizza();
        }

        public void buildPizzaBase()
        {
            pizza.setPizzaBase("Romana");
        }

        public void buildPizzaSize()
        {
            pizza.setPizzaSize(14);
        }

        public void buildPizzaThickness()
        {
            pizza.setPizzaThickness("Thin");
        }

        public void buildPizzaTopping()
        {
            pizza.setPizzaTopping("Cheese");
        }
        public Pizza getPizza()
        {
            return this.pizza;
        }



    }
}
