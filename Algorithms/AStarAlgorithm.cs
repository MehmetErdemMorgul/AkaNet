using System;
using System.Collections.Generic;
using AkaNet.Models;

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
        public AStarResult Run(Graph graph, int startId, int targetId)
        {
            var openSet = new HashSet<int>();
            var cameFrom = new Dictionary<int, int>();

            var gScore = new Dictionary<int, double>();
            var fScore = new Dictionary<int, double>();

            foreach (var node in graph.GetNodes())
            {
                gScore[node.Id] = double.PositiveInfinity;
                fScore[node.Id] = double.PositiveInfinity;
            }

            gScore[startId] = 0;
            fScore[startId] = Heuristic(graph, startId, targetId);

            openSet.Add(startId);

            int visited = 0;

            while (openSet.Count > 0)
            {
                int current = GetLowestF(openSet, fScore);
                visited++;

                if (current == targetId)
                {
                    return new AStarResult
                    {
                        Found = true,
                        Path = ReconstructPath(cameFrom, current),
                        TotalCost = gScore[current],
                        VisitedCount = visited
                    };
                }

                openSet.Remove(current);

                foreach (var neighbor in graph.GetNeighbors(current))
                {
                    double tentativeG =
                        gScore[current] + graph.GetWeight(current, neighbor);

                    if (tentativeG < gScore[neighbor])
                    {
                        cameFrom[neighbor] = current;
                        gScore[neighbor] = tentativeG;
                        fScore[neighbor] =
                            tentativeG + Heuristic(graph, neighbor, targetId);

                        openSet.Add(neighbor);
                    }
                }
            }

            return new AStarResult { Found = false };
        }

        private int GetLowestF(HashSet<int> set, Dictionary<int, double> fScore)
        {
            double min = double.PositiveInfinity;
            int best = -1;

            foreach (var id in set)
            {
                if (fScore[id] < min)
                {
                    min = fScore[id];
                    best = id;
                }
            }

            return best;
        }

        private List<int> ReconstructPath(
            Dictionary<int, int> cameFrom, int current)
        {
            var path = new List<int> { current };

            while (cameFrom.ContainsKey(current))
            {
                current = cameFrom[current];
                path.Insert(0, current);
            }

            return path;
        }

        private double Heuristic(Graph graph, int a, int b)
        {
            var na = graph.GetNode(a);
            var nb = graph.GetNode(b);

            double da = na.Activity - nb.Activity;
            double di = na.Interaction - nb.Interaction;
            double dc = na.ConnectionCount - nb.ConnectionCount;

            return Math.Sqrt(da * da + di * di + dc * dc);
        }
    }
}
