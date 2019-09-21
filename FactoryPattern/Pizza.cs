using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public Pizza()
        {
        }

        public void Prepare()
        {
            Console.WriteLine("1" + PizzaName + "재료준비시작...");
            Console.WriteLine("2" + dough + "...");
            Console.WriteLine("3" + sauce + "...");
            Console.WriteLine("4" + cheese + "...");
            foreach (string topp in toppings)
            {
                Console.WriteLine(topp + "...");
            }
        }

        public void bake()
        {
            Console.WriteLine("5" + "피자 굽기....");
        }

        public void cut()
        {
            Console.WriteLine("6" + "피자 자르기....");
        }

        public void box()
        {
            Console.WriteLine("7" + "피자 포장....");
        }

        protected string PizzaName { get; set; }
        protected string dough;
        protected string sauce;
        protected string cheese;
        protected List<string> toppings = new List<string>();
    }
}
