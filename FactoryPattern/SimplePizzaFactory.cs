using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "Cheeze")
                pizza = new CheesePizza();
            else if (type == "Veggie")
                pizza = new VeggiePizza();

            return pizza;
        }
    }
}
