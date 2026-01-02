using System;
using System.Collections.Generic;
using System.Linq;

namespace AkaNet.Models
{
    public class Graph
    {
        private readonly Dictionary<int, Node> nodes = new Dictionary<int, Node>();
        private readonly Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();

       
        public IEnumerable<Node> Nodes => nodes.Values;

        public int NodeCount => nodes.Count;

        public IEnumerable<Node> GetNodes() => nodes.Values;

        public Node GetNode(int id)
        {
            return nodes.TryGetValue(id, out var n) ? n : null;
        }

        public IEnumerable<int> NeighborsOf(int id)
        {
            return adj.TryGetValue(id, out var list) ? list : Enumerable.Empty<int>();
        }

        public IEnumerable<int> GetNeighbors(int id) => NeighborsOf(id);

       
        public void AddNode(Node node)
        {
            if (node == null) return;

            if (!nodes.ContainsKey(node.Id))
                nodes[node.Id] = node;

            if (!adj.ContainsKey(node.Id))
                adj[node.Id] = new List<int>();
        }

        public void AddEdge(int from, int to)
        {
            if (from == to) return;

            EnsureAdj(from);
            EnsureAdj(to);

            if (!adj[from].Contains(to))
                adj[from].Add(to);

            if (!adj[to].Contains(from))
                adj[to].Add(from);
        }

        public bool HasEdge(int from, int to)
        {
            return adj.ContainsKey(from) && adj[from].Contains(to);
        }

        
        public bool RemoveNode(int id)
        {
            if (!nodes.ContainsKey(id)) return false;

            if (adj.TryGetValue(id, out var neigh))
            {
                foreach (var v in neigh.ToList())
                {
                    if (adj.TryGetValue(v, out var listV))
                        listV.Remove(id);
                }
            }

            adj.Remove(id);
            nodes.Remove(id);
            return true;
        }

        public bool RemoveEdge(int from, int to)
        {
            bool removed = false;

            if (adj.TryGetValue(from, out var a))
                removed |= a.Remove(to);

            if (adj.TryGetValue(to, out var b))
                removed |= b.Remove(from);

            return removed;
        }

        private void EnsureAdj(int id)
        {
            if (!adj.ContainsKey(id))
                adj[id] = new List<int>();
        }

        
        public double GetWeight(int fromId, int toId)
        {
            if (!nodes.ContainsKey(fromId) || !nodes.ContainsKey(toId))
                return 0.0;

            var a = nodes[fromId];
            var b = nodes[toId];

            double diff =
                Math.Pow(a.Activity - b.Activity, 2) +
                Math.Pow(a.Interaction - b.Interaction, 2) +
                Math.Pow(a.ConnectionCount - b.ConnectionCount, 2);

            return 1.0 / (1.0 + diff);
        }

        public double Heuristic(int fromId, int targetId)
        {
            if (!nodes.ContainsKey(fromId) || !nodes.ContainsKey(targetId))
                return double.PositiveInfinity;

            var a = nodes[fromId];
            var b = nodes[targetId];

            return
                Math.Abs(a.Activity - b.Activity) +
                Math.Abs(a.Interaction - b.Interaction) +
                Math.Abs(a.ConnectionCount - b.ConnectionCount);
        }

        
        public int EdgeCount
        {
            get
            {
                int count = 0;
                foreach (var kv in adj)
                {
                    int u = kv.Key;
                    foreach (var v in kv.Value)
                    {
                        if (v > u) count++; // 
                    }
                }
                return count;
            }
        }

        public double AverageDegree
        {
            get
            {
                int n = NodeCount;
                if (n == 0) return 0.0;
                return (2.0 * EdgeCount) / n;
            }
        }

        public double AverageWeight
        {
            get
            {
                int e = 0;
                double sum = 0.0;

                foreach (var kv in adj)
                {
                    int u = kv.Key;
                    foreach (var v in kv.Value)
                    {
                        if (v <= u) continue; // unique edge
                        sum += GetWeight(u, v);
                        e++;
                    }
                }

                if (e == 0) return 0.0;
                return sum / e;
            }
        }
    }
}
