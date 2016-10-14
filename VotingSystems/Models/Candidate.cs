using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystems.Models
{
    class Candidate
    {
        //This represents the candidates position on an issue.
        public int policy;
        public int votes;
        
        public Candidate(int policy)
        {
            this.policy = policy;
            votes = 0;
        }

        public void CastVote()
        {
            votes++;
        }

        public void ResetVotes()
        {
            votes = 0;
        }
    }
}
