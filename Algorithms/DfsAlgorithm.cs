using System.Collections.Generic;
using AkaNet.Models;
using AkaNet.Results;

namespace AkaNet.Algorithms
{
    public class DfsAlgorithm
    {
        public TraversalResult Run(Graph graph, int startNodeId)
        {
            var result = new TraversalResult();
            DFS(graph, startNodeId, result);
            return result;
        }

        private void DFS(Graph graph, int current, TraversalResult result)
        {
            result.Visited.Add(current);
            result.VisitOrder.Add(current);

            foreach (var nb in graph.NeighborsOf(current))
            {
                if (!result.Visited.Contains(nb))
                {
                    DFS(graph, nb, result);
                }
            }
        }
    }
}
