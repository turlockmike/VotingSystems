using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystems.Models
{
    class VoterPool
    {
        public const int PREFERENCE_RANGE = 100;
        public List<Voter> voters;

        //Creates a new pool of voters. The size and strategic being from 0 - 1 on the % of strategic
        public VoterPool(ISample sample, int size, double strategic)
        {
            voters = new List<Voter>();
            for(int i = 0; i < size; i++)
            {
                int preference = (int)Math.Round((sample.Generate()) * PREFERENCE_RANGE);
                bool isStrategic = (double)(i + 1) / size <= strategic;
                var voter = new Voter(preference , isStrategic);
                voters.Add(voter);
            }
        }
    }
}
