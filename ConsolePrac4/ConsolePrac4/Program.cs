using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrac4
{
    class Program
    {
        static void Main(string[] args)
        {
            Question nice = new Question();

            Console.WriteLine("whats you fav color");
            string pick = Console.ReadLine().ToUpper();


            switch (pick)
            {
                case "BLUE":
                    Console.WriteLine ($"Your answer was {pick} Good Choice");
                    break;

                case "RED":
                    Console.WriteLine($"Your answer was {pick}... What r u a Ruskie for the Red Army!!!");
                    break;

                case "GREEN":
                    Console.WriteLine($"Your answer was {pick}..Going for the money");
                    break;

                case "ORANGE":
                    Console.WriteLine($"Your answer was {pick}..Orange you glad you played this game!!");
                    break;

                case "YELLOW":
                    nice.Yellow();
                    Console.WriteLine($"Your answer was {pick}...Yellow is only good for sapsuckers and mustard!!! ");
                    break;

                default:
                    Console.WriteLine($"Your answer was {pick}...We don't understand your choice");
                    break;

            }
            Console.ReadLine();
            nice.Why();


            nice.Later();


            int cats = 100;
            int dogs = 2;

            // Create a string with string interpolation syntax.
            string animals = $"cats = {cats} and dogs = {dogs}";
            // Call Console.WriteLine.
            Console.WriteLine(animals);
            Console.ReadKey();

        }
    }
}
