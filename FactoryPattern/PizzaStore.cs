using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        public Pizza Order(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
