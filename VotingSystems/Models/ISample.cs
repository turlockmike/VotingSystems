using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystems.Models
{
    //Interface for generating a voter
    //All classes implementing this should return a value bewteen -1 and 1 if possible
    interface ISample
    {
        double Generate();

        IEnumerable<double> Generate(int quantity);
    }
}
