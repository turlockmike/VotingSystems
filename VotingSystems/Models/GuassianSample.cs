using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystems.Models
{
    class GuassianSample : ISample
    {
        public double Generate()
        {
            var normal = Normal.WithMeanStdDev(0.0, 0.5);
            return normal.Sample();
        }

        public IEnumerable<double> Generate(int quantity)
        {
            var normal = Normal.WithMeanStdDev(0.0, 0.5);
            return normal.Samples();
        }
    }
}
