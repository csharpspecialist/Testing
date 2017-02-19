using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrac1
{
    class Work
    {

        public void GetValue(string factAns)
        {
            Console.WriteLine($"You know that {factAns} needs to be cooked properly.");
        }


        public void GetGame(string gameAns)
        {
            Console.WriteLine($"You know that {gameAns} rots your brains!!!.");
        }

        public void GetFPS(string gameChoice)
        {
            switch (gameChoice)
            {
                case "COD":
                    Console.WriteLine("One of the greatest FPS games out there");
                    break;

                case "GOW":
                    Console.WriteLine("What r u smokin'!!!");
                    break;


                case "HALO":
                    Console.WriteLine("A real Mans Game!!!");
                    break;

                default:
                    Console.WriteLine("Pick a game that we actually like");
                    break;

            }
        }


    }
}
