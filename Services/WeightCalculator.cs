using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkaNet.Models;

namespace AkaNet.Services
{
    public class WeightCalculator
    {
        public double Calculate(Node a, Node b)
        {
            double dActivity = a.Activity - b.Activity;
            double dInteraction = a.Interaction - b.Interaction;
            double dConnection = a.ConnectionCount - b.ConnectionCount;

            double sum =
                (dActivity * dActivity) +
                (dInteraction * dInteraction) +
                (dConnection * dConnection);

            return 1.0 / (1.0 + sum);
        }
    }
}