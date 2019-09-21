using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ChicagoStyleCheesePizza : CheesePizza
    {
        public ChicagoStyleCheesePizza()
        {
            PizzaName = "시카고스타일치즈피자";
            dough = "아주 두꺼운 도우";
            sauce = "짠 소스";
            cheese = "레지아노 치즈";
            toppings.Add("야채");
            toppings.Add("새우");
        }
    }
}
