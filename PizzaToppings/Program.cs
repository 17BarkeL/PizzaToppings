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

            WriteLineColour("CYAAAAN", ConsoleColor.Cyan);

            string pizzaToppingInput = Question("What pizza topping do you want? ").ToUpper();

            if (nonVegetarianPizzaToppings.Contains(pizzaToppingInput))
            {
                Console.WriteLine("Not Vegetarian Topping");
            }

            else
            {
                Console.WriteLine("Vegetarian Topping");
            }

            string favouriteMusic = Question("What is you're favourite music genre").ToUpper();

            switch (favouriteMusic)
            {
                case "JAZZ":
                    Console.WriteLine("You like jazzzzzz");
                    break;

                case "ROCK":
                case "K-POP":
                    Console.WriteLine("That's trash");
                    break;

                default:
                    Console.Write("Eh? What's that?");
                    break;
            }

            #region switch...
            /*switch (pizzaToppingInput)
            {
                case "PEPPERONI":
                case "HAM":
                    Console.WriteLine("Not Vegetarian");
                    break;

                case "SWEETCORN":
                case "MUSHROOM":
                    Console.WriteLine("Vegetarian");
                    break;

                default:
                    Console.WriteLine("Don't know?");
                    break;
            }*/
            #endregion

            Console.ReadLine();

        }

        /// <summary>
        /// Ask a question
        /// </summary>
        /// <param name="question">Question to ask</param>
        /// <returns>The answer to the question</returns>
        static string Question(string question) // Ask a question
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        /// <summary>
        /// Write a line to the console in the specified colour
        /// </summary>
        /// <param name="message">The message to write</param>
        /// <param name="colour">The colour to write in</param>
        static void WriteLineColour(string message, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
