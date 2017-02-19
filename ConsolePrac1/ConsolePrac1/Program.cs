using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrac1
{
    class Program
    {
        static void Main(string[] args)
        {



            //Console.WriteLine("Do you like meat or chicken");
            //string foodAns = Console.ReadLine().ToLower();

            //switch (foodAns)
            //{
            //    case "meat":
            //        Console.WriteLine("hey I like meat too");
            //        break;

            //    case "chicken":
            //        Console.WriteLine("U R What you eat!!!");
            //        break;

            //    default:
            //        Console.WriteLine("That answer does not compute!!");
            //        break;



            //}

            //Console.ReadKey();

            Work formula = new Work();

            Console.WriteLine("Do you like meat or chicken");
            string factAns = Console.ReadLine().ToUpper();

            formula.GetValue(factAns);

            Console.ReadKey();


            Console.WriteLine("Do you like the Xbox or PS4 better");
            string gameAns = Console.ReadLine().ToUpper();

            formula.GetGame(gameAns);

            Console.ReadKey();

            Console.WriteLine("Do COD, HALO or GOW");
            string gameChoice = Console.ReadLine().ToUpper();

            formula.GetFPS(gameChoice);

            Console.ReadKey();

        }
    }
}
