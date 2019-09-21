using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore ps = new NYPizzaStore();
            Pizza pz = ps.Order("Cheese");           

            Console.WriteLine("/////////////////////////");

            PizzaStore ps2 = new ChicagoPizzaStore();
            Pizza pz2 = ps2.Order("Cheese");
                        
            while(true)
            {

            }
        }
    }
}
