using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrac3
{
    class Program
    {
        static void Main(string[] args)
        {
            Work people = new Work();


            Console.WriteLine("What's Your favorite color??");

            string color = Console.ReadLine().ToLower();

            if(color == "red")
            {
                Console.WriteLine("Good Choice");
            }
            else if (color == "blue")
            {
                Console.WriteLine("better choice");
            }
            else
            {
                Console.WriteLine("Whatever!!!!");
            }
            Console.ReadKey();
            Sprite();
            people.Dude();
            Console.ReadKey();
        }

        public static void Sprite()
        {
            Console.WriteLine("u r not nicety!!!");
            Console.ReadKey();
        }

    }
}
