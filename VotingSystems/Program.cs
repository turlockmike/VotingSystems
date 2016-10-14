using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystems.Models;

namespace VotingSystems
{
    class Program
    {
        static readonly int[] DEFAULT_CANDIDATES = { 10, -10 };


        static VoterPool pool;
        static ISample sample;
        static Candidate[] candidates;
        static int size = 100;
        static double strategic = 0.0;
        
        static void Main(string[] args)
        {
            SetDefaultOptions();
            bool done = false;
            do
            {
                Console.WriteLine("Voting Simulation. Please select from menu");
                ShowMenu();
                int choice = GetInteger(1, 6);
                switch (choice)
                {
                    case 1:
                        SetOptions();
                        break;
                    case 2:
                        GenerateVoterPool();
                        break;
                    case 3:
                        GenerateCandidates();
                        break;
                    case 4:
                        RunSimulation();
                        break;
                    case 5:
                        SaveResults();
                        break;
                    case 6:
                        done = true;
                        break;
                }

            } while (!done);
        }

        private static void SaveResults()
        {

        }

        private static void GenerateCandidates()
        {

        }

        private static void GenerateDefaultCandidates()
        {
            candidates = new Candidate[DEFAULT_CANDIDATES.Length];
            int i = 0;
            foreach(int policy in DEFAULT_CANDIDATES)
            {
                candidates[i] = new Candidate(DEFAULT_CANDIDATES[i]);
                i++;
            }
        }

        private static void SetDefaultOptions()
        {
            sample = new GuassianSample();
            GenerateDefaultCandidates();
        }

        private static void GenerateVoterPool()
        {
            pool = new VoterPool(sample, size, strategic);
            foreach (var voter in pool.voters)
            {
                Console.WriteLine("Voter: Preference {0} Strategic: {1}", voter.preference, voter.strategic);
            }
        }

        private static void RunSimulation()
        {
            if (sample == null)
            {
                Console.WriteLine("Sample must be generated first");
                return;
            }

            foreach(Candidate c in candidates)
            {
                c.ResetVotes();
            }

            foreach(Voter v in pool.voters)
            {
                Candidate c = v.Choose(candidates);
                c.CastVote();
            }

            Console.WriteLine("Results are in:");
            candidates.OrderBy((c) => { return -c.votes; });
            foreach(var c in candidates)
            {
                Console.WriteLine("Candidate with policy {0} had a total of {1} votes", c.policy, c.votes);
            }
        }

        private static void SetOptions()
        {

        }

        private static void ShowMenu()
        {
            Console.WriteLine("1 Set Options");
            Console.WriteLine("2 Generate Voter Pool");
            Console.WriteLine("3 Generate Candidates");
            Console.WriteLine("4 Run Simulation");
            Console.WriteLine("5 Save Results");
            Console.WriteLine("6 Exit");
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
