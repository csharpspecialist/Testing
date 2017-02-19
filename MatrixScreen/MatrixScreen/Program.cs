using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixScreen
{
    class Program
    {
        static void Main(string[] args)
        {

            //setting text color
            Console.ForegroundColor = ConsoleColor.Green;

            //random # generator
            Random rand = new Random();

            //string pattern
            String str = "";

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            for (int i = 0; i < 2000; i++)
            {

                if (i % 2 == 0 )
                {
                    str = "";
                    for (int j = 0; j <79; j++)
                    {
                        int n = rand.Next(5);
                        if(n < 2)
                        {
                            str += n.ToString();
                        }
                        else
                        {
                            str += " ";
                        }
                    }
                }

                //print out the string pattern
                Console.WriteLine(str);

            }
            Console.WriteLine("End of screen....");
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
        
}

