using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NYStyleCheesePizza : CheesePizza
    {
        public NYStyleCheesePizza()
        {
            PizzaName = "뉴욕스타일치즈피자";
            dough = "아주 얇은 도우";
            sauce = "매운 소스";
            cheese = "모짜렐라치즈";
            toppings.Add("고기");
            toppings.Add("햄");
        }
    }
}
