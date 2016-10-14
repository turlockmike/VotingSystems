using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystems.Models
{
    //Interface for generating a voter
    //All classes implementing this should return a value bewteen 0 and 1.
    interface ISample
    {
        double Generate();
    }
}
