using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager words = new Manager();

            Console.WriteLine("Do You like Quiche??");
            string blast = Console.ReadLine().ToUpper();

            if(blast == "YES")
            {
                Console.WriteLine("U r an Idiot!!!");
            }
            else if(blast == "NO")
            {
                Console.WriteLine("Correctamundo!!!");
            }
            else
                Console.WriteLine("Whatever!!!!");
            Console.ReadLine();

            Console.WriteLine("What is your name!!!");
            string nameAnswer = Console.ReadLine().ToUpper();

            words.Funny();

           // Program.Whatever();

            Whatever();

            Program.Holdem();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }        

        public static void Whatever()
        {
            Console.WriteLine("Whatever!!!!");
            Console.ReadKey();
        }
        
        static void Holdem() //this is a private method since it's not marked public
        {
            Console.WriteLine("You've got to know when to hold 'em!!!!");
            Console.ReadKey();
        }

    }
    
}
