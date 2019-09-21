using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "Cheese")
                pizza = new ChicagoStyleCheesePizza();
            else if (type == "Veggie")
                pizza = new ChicagoStyleVeggiePizza();

            return pizza;
        }
    }
}
