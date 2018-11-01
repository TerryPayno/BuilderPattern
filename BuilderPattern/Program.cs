using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder PizzBlueprint = new ConcreteBuilder();

            PizzaDirector pizzaDirector = new PizzaDirector(PizzBlueprint);

            pizzaDirector.makePizza();
            Pizza firstPizza = pizzaDirector.getPizza();
            Console.WriteLine(firstPizza.getPizzaBase());
            Console.WriteLine(firstPizza.getPizzaTopping());
            Console.WriteLine(firstPizza.getPizzaThickness());
            Console.WriteLine(firstPizza.getPizzaSize());
            Console.ReadLine();
        }
    }
}
