using System;
using System.Collections.Generic;
using System.Linq;
using AkaNet.Models;
using AkaNet.Results;

namespace AkaNet.Algorithms
{
    public class DijkstraAlgorithm
    {
        public PathResult Run(Graph graph, int startId, int targetId)
        {
            var dist = new Dictionary<int, double>();
            var prev = new Dictionary<int, int?>();

            int visitedCount = 0;

            foreach (var n in graph.Nodes)
            {
                dist[n.Id] = double.PositiveInfinity;
                prev[n.Id] = null;
            }

            dist[startId] = 0;

            var unvisited = new HashSet<int>(graph.Nodes.Select(n => n.Id));

            while (unvisited.Count > 0)
            {
                // unvisited içinden dist'i en küçük olanı seç
                int current = unvisited.OrderBy(id => dist[id]).First();
                visitedCount++;

                if (double.IsPositiveInfinity(dist[current]))
                    break; // erişilemeyen bölge

                if (current == targetId)
                    break;

                unvisited.Remove(current);

                foreach (var nb in graph.NeighborsOf(current))
                {
                    if (!unvisited.Contains(nb)) continue;

                    double w = graph.GetWeight(current, nb); // ✅ weight burada kullanılıyor
                    double alt = dist[current] + w;

                    if (alt < dist[nb])
                    {
                        dist[nb] = alt;
                        prev[nb] = current;
                    }
                }
            }

            // yolu çıkar
            var result = new PathResult();
            if (!dist.ContainsKey(targetId) || double.IsPositiveInfinity(dist[targetId]))
            {
                result.Found = false;
                return result;
            }

            result.Found = true;
            result.TotalCost = dist[targetId];
            result.VisitedCount = visitedCount;

            int? cur = targetId;
            while (cur != null)
            {
                result.Path.Insert(0, cur.Value);
                cur = prev[cur.Value];
            }

            return result;
        }
    }
}
