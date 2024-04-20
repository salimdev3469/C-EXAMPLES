using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            TasKagitMakas();
            Console.ReadLine();
        }

        private static void TasKagitMakas()
        {
            // Rock breaks scissors
            // Rock breaks scissors
            // Paper covers rock
            // Scissors cut paper

            // The user enters an option as rock/paper/scissors
            // The PC randomly chooses one of them
            // In the end, the scores are kept
            // The user can exit the game with q
            int win = 0;
            int los = 0;
            string kullanici = "";
            do
            {
                Console.WriteLine("ROCK, PAPER, SCISSORS?(r for ROCK,p for PAPER, s for SCISSORS)");
                kullanici = Console.ReadLine();
                string[] secenek = { "r", "p", "s" };
                Random pc = new Random();
                int a = pc.Next(3);//0 1 2
                Console.Write("Computer's choice:" + secenek[a] + "\n");

                if (kullanici == "r" && secenek[a] == "p")
                {
                    los++;
                }
                if (kullanici == "r" && secenek[a] == "s")
                {
                    win++;
                }
                if (kullanici == "s" && secenek[a] == "p")
                {
                    win++;
                }
                if (kullanici == "s" && secenek[a] == "r")
                {
                    los++;
                }
                if (kullanici == "p" && secenek[a] == "r")
                {
                    win++;
                }
                if (kullanici == "p" && secenek[a] == "s")
                {
                    los++;
                }

            } while (kullanici != "q");


            if (win > los)
            {
                Console.WriteLine("USER WIN! Score: " + win);
            }
            else
            {
                Console.WriteLine("Computer win. Score: " + los);
            }
        }
    }
}
