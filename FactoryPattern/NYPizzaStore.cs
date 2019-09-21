using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "Cheese")
                pizza = new NYStyleCheesePizza();
            else if (type == "Veggie")
                pizza = new NYStyleVeggiePizza();

            return pizza;
        }
    }
}
