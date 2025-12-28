using System;
using System.Collections.Generic;
using AkaNet.Models;
using AkaNet.Algorithms;


namespace AkaNet.Algorithms
{
    public class AStarResult
    {
        public bool Found { get; set; }
        public List<int> Path { get; set; } = new List<int>();
        public double TotalCost { get; set; }
        public int VisitedCount { get; set; }
    }

    public class AStarAlgorithm
    {
        public AStarResult Run(Graph graph, int start, int target)
        {
            var result = new AStarResult();

            var openSet = new SimplePriorityQueue<int>();

            var cameFrom = new Dictionary<int, int>();
            var gScore = new Dictionary<int, double>();

            foreach (var node in graph.Nodes)
                gScore[node.Id] = double.PositiveInfinity;

            gScore[start] = 0.0;

            // f(n) = g(n) + h(n)
            double startPriority = graph.Heuristic(start, target);
            openSet.Enqueue(start, startPriority);


            var visited = new HashSet<int>();

            while (openSet.Count > 0)
            {
                int current = openSet.Dequeue();

                if (visited.Contains(current))
                    continue;

                visited.Add(current);

                if (current == target)
                {
                    result.Found = true;
                    result.TotalCost = gScore[target];
                    result.Path = ReconstructPath(cameFrom, start, target);
                    result.VisitedCount = visited.Count;
                    return result;
                }

                foreach (var neighbor in graph.NeighborsOf(current))
                {
                    double tentativeG =
                        gScore[current] + graph.GetWeight(current, neighbor);

                    if (tentativeG < gScore[neighbor])
                    {
                        cameFrom[neighbor] = current;
                        gScore[neighbor] = tentativeG;

                        double fScore =
                            tentativeG + graph.Heuristic(neighbor, target);

                        openSet.Enqueue(neighbor, fScore);
                    }
                }
            }

            result.Found = false;
            result.VisitedCount = visited.Count;
            return result;
        }

        private List<int> ReconstructPath(
            Dictionary<int, int> cameFrom,
            int start,
            int target)
        {
            var path = new List<int>();
            int current = target;

            while (current != start)
            {
                path.Add(current);
                current = cameFrom[current];
            }

            path.Add(start);
            path.Reverse();
            return path;
        }
    }
}
