using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNet.Models
{
    public class Edge
    {
        public int From { get; }
        public int To { get; }

        public Edge(int from, int to)
        {
            if (from == to)
                throw new ArgumentException("Self-loop yasak.");

            From = from;
            To = to;
        }
        //debuglar için toString override edildi 
        public override string ToString() => $"{From} -- {To}";
    }
}
