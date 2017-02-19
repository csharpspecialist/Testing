using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Do you like the Cleveland Browns");
            string thought = Console.ReadLine().ToUpper();


            if (thought == "YES")
            {
                Console.WriteLine("u r a brave person");

            }
            else if (thought == "NO")
            {
                
                Console.WriteLine("Which team do you like then");
                string answer = Console.ReadLine().ToUpper();


                if (answer == "COWBOYS")
                {
                    Console.WriteLine("You are a super chump!!!");
                }
                else if (answer == "RAVENS")
                {
                    Console.WriteLine("U Really Suck");
                }
                else
                    Console.WriteLine("Back to the drawing board!!!");
            }
            else
                Console.WriteLine("U R not a human!!!!");

            Console.ReadLine();

            arnold();


            Console.WriteLine("Case Statement Time*****************************");


            Console.WriteLine("Which sport is your favorite");
            string sport = Console.ReadLine().ToUpper();


            switch (sport)
            {
                case "FOOTBALL":                        
                        Console.WriteLine("Good choice");
                    break;

                case "BASKETBALL": 

                    Console.WriteLine("Basketball is seriously a Mans Game!!!!!");
                    break;
                case "SOCCER":

                    Console.WriteLine("That is a true sport for sissies!!!!");
                    break;

                case "BADMITTEN":
                    Console.WriteLine("U Sir are a Girlie man!!!");
                    break;


                default:
                    Console.WriteLine("Whatever!!!!");
                    break;
            }
            Console.ReadKey();

        } 

        public static void arnold()
        {
            Console.WriteLine("Get to the chopper!!!!");
            Console.ReadLine();
        }
        
    }
}
