using AkaNet.Models;
using AkaNet.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNet.Algorithms
{
    public class BfsAlgorithm
    {
        public TraversalResult Run(Graph graph, int startNodeId)
        {
            var result = new TraversalResult();

            var q = new Queue<int>();
            q.Enqueue(startNodeId);
            result.Visited.Add(startNodeId);

            while (q.Count > 0)
            {
                int current = q.Dequeue();
                result.VisitOrder.Add(current);

                foreach (var nb in graph.NeighborsOf(current))
                {
                    if (!result.Visited.Contains(nb))
                    {
                        result.Visited.Add(nb);
                        q.Enqueue(nb);
                    }
                }
            }

            return result;
        }
    }
}
