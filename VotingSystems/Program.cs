using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            do
            {
                Console.WriteLine("Ranked Choice Voting Simulation. Please select options");
                ShowMenu();
                int choice = GetInteger(1, 3);
                switch (choice)
                {
                    case 1:
                        SetOptions();
                        break;
                    case 2:
                        RunSimulation();
                        break;
                    case 3:
                        done = true;
                        break;

                }

            } while (!done);
        }

        private static void RunSimulation()
        {

        }

        private static void SetOptions()
        {

        }

        private static void ShowMenu()
        {
            Console.WriteLine("1 Set Options");
            Console.WriteLine("2.Run Simulation");
            Console.WriteLine("3. Exit");
        }

        private static int GetInteger(int min, int max)
        {
            int res = -1;
            bool done = false;
            while (!done)
            {
                Console.Write(": ");
                if (int.TryParse(Console.ReadLine(), out res))
                {
                    done = res >= min && res <= max;
                }
            }
            return res;
        }



    }
}
