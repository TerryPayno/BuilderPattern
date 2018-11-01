using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class PizzaDirector
    {
        private PizzaBuilder pizzaBuilder;

        public PizzaDirector(PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }

        public Pizza getPizza()
        {
            return this.pizzaBuilder.getPizza();
        }
        public void makePizza()
        {
            this.pizzaBuilder.buildPizzaBase();
            this.pizzaBuilder.buildPizzaThickness();
            this.pizzaBuilder.buildPizzaTopping();
            this.pizzaBuilder.buildPizzaSize();
        }
    }


}
