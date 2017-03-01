using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsolePrac4
{
    class Question
    {
        public void  Red()
        {
            Console.WriteLine("Yo Asss is mine!!!");
            Console.ReadKey();
        }

        public void Yellow()
        {
            Console.WriteLine($"Yellow is for Straight Suckas!!!!!");
            Console.ReadKey();
        }


        public void Later()
        {
            Console.WriteLine("We Are Outta Here!!!!");
            Console.ReadKey();
        }

        public void Why()

        {

            Console.WriteLine("Do you like Football or Basketball");
            string ans = Console.ReadLine().ToUpper();

            if (ans == "FOOTBALL")
            {
                Console.WriteLine("A real Man's Sport!!!");
            }
            else if (ans == "BASKETBALL")
            {
                Console.WriteLine("Basketball is an OK Sport also!!!");
            }
            else
            {
                Console.WriteLine("Whatever!!!");
            }


            Console.WriteLine("Boxing is VERY tough Also!!!!");
            Console.ReadKey();
        }



    }
}
