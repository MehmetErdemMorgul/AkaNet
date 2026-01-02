using System.Collections.Generic;
using System.Linq;
using AkaNet.Models;

namespace AkaNet.Algorithms
{
    public class DegreeCentralityAlgorithm
    {
        public Dictionary<int, int> ComputeDegrees(Graph g)
        {
            return g.Nodes.ToDictionary(n => n.Id, n => g.NeighborsOf(n.Id).Count());
        }

        public List<(int NodeId, int Degree)> TopK(Graph g, int k)
        {
            var deg = ComputeDegrees(g);
            return deg.OrderByDescending(x => x.Value)
                      .ThenBy(x => x.Key)
                      .Take(k)
                      .Select(x => (x.Key, x.Value))
                      .ToList();
        }
    }
}
