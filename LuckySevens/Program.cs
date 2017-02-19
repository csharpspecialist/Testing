using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@" 

         _.-'~~~~~~`-._
        /      ||      \
       /       ||       \
      |        ||        |
      | _______||_______ |
      |/ ----- \/ ----- \|
     /  (     )  (     )  \
    / \  ----- () -----  / \
   /   \      /||\      /   \
  /     \    /||||\    /     \
 /       \  /||||||\  /       \
/_        \o========o/        _\
  `--...__|`-._  _.-'|__...--'
          |    `'    |

");


            string[] famous = { "Carl", "Jamie", "Karla", "Ren", "Stimpy", "Jeremy" ,"Jamie", "Brian", "Marshall", "Jamie"};

            int paparazi = 0;

            for (int i = 0; i < famous.Length; i++)
            {
                if (famous[i] == "Jamie")
                {
                    paparazi++;
                }
            }

            Console.WriteLine($"the name Jamie came up {paparazi} times");
            Console.ReadLine();

            Console.WriteLine("  Welcome to the Lucky Sevens Game");
            int totalSevens = 0;

            Random rand = new Random();
            int dice1;
            int dice2;

            for (int i = 1; i < 100; i++)
            {
                dice1 = rand.Next(1, 7);
                dice2 = rand.Next(1, 7);

                if (dice1 + dice2 == 7)
                { 

                Console.WriteLine("You rolled a 7..Lucky dog");
                totalSevens++;
                }
            }

            Console.WriteLine($"You rolled a 7 {totalSevens} times.. out of a total of 100 rolls..Lucky dog");





            Console.ReadLine();

        }
    }
}
