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
        int policy;
        
        public Candidate(int policy)
        {
            this.policy = policy;
        }
    }
}
