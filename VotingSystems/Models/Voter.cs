using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystems.Models
{
    class Voter
    {

        //This represents the voters preference on an issue
        public int preference;

        //This represents if the voter is strategic
        public bool strategic;

        public Voter(int preference, bool strategic)
        {
            this.preference = preference;
            this.strategic = strategic;
        }

        public Candidate Choose(Candidate[] candidates)
        {
            Candidate current = candidates[0];

            for (int i = 1; i < candidates.Length; i++)
            {
                if (Math.Abs(preference - candidates[i].policy) < Math.Abs(preference - current.policy))
                {
                    current = candidates[i];
                }
            }

            return current;
        }
    }
}
