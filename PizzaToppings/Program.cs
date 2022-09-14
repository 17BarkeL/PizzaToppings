using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaToppings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nonVegetarianPizzaToppings = new List<string> { "CHICKEN", "HAM", "MEAT", "PEPPERONI", "SALAMI" };
            Console.WriteLine("What pizza topping do you want?");
            string pizzaToppingInput = Console.ReadLine().ToUpper();

            if (nonVegetarianPizzaToppings.Contains(pizzaToppingInput))
            {
                Console.WriteLine("Not Vegetarian Topping");
            }

            else
            {
                Console.WriteLine("Vegetarian Topping");
            }

            Console.ReadLine();
        }
    }
}
