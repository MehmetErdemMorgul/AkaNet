using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNet.Results
{
    public class TraversalResult
    {
        public List<int> VisitOrder { get; } = new List<int>();
        public HashSet<int> Visited { get; } = new HashSet<int>();
    }
}
