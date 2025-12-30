using System;
using System.Collections.Generic;
using System.Linq;
using AkaNet.Models;

namespace AkaNet.Models
{
    public class Graph
    {
        private Dictionary<int, Node> nodes = new Dictionary<int, Node>();
        private Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();

        private Dictionary<(int, int), double> edgeWeights
           = new Dictionary<(int, int), double>();


        // Dijkstra bunu istiyor
        public IEnumerable<Node> Nodes => nodes.Values;

        public IEnumerable<Node> GetNodes()
        {
            return nodes.Values;
        }

        public void AddNode(Node node)
        {
            if (node == null) return;

            if (!nodes.ContainsKey(node.Id))
                nodes[node.Id] = node;

            // ✅ kritik: adjacency her zaman açılsın
            if (!adj.ContainsKey(node.Id))
                adj[node.Id] = new List<int>();
        }

        public void AddEdge(int from, int to, double weight = 1.0)
        {
            EnsureAdj(from);
            EnsureAdj(to);

            if (!adj[from].Contains(to))
                adj[from].Add(to);
            if (!adj[to].Contains(from))
                adj[to].Add(from);

            edgeWeights[(from, to)] = weight;
            edgeWeights[(to, from)] = weight;
        }



        public double GetEdgeWeight(int from, int to)
        {
            if (edgeWeights.TryGetValue((from, to), out var w))
                return w;
            return 1.0;
        }

        public void SetEdgeWeight(int from, int to, double w)
        {
            edgeWeights[(from, to)] = w;
            edgeWeights[(to, from)] = w;
        }


        public bool HasEdge(int from, int to)
        {
            return adj.ContainsKey(from) && adj[from].Contains(to);
        }

        public IEnumerable<int> NeighborsOf(int id)
        {
            // ✅ yoksa boş döndür
            return adj.TryGetValue(id, out var list) ? list : Enumerable.Empty<int>();
        }

        public IEnumerable<int> GetNeighbors(int id)
        {
            return NeighborsOf(id);
        }

        public Node GetNode(int id)
        {
            // ✅ yoksa null döndür (Form1 tarafında null kontrolü yap)
            return nodes.TryGetValue(id, out var n) ? n : null;
        }

        // ✅ Silme için gerekli
        public bool RemoveNode(int id)
        {
            if (!nodes.ContainsKey(id)) return false;

            // bağlı kenarları temizle
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

        // RAPORDAKİ FORMÜL BURADA
        public double GetWeight(int fromId, int toId)
        {
            // güvenli: node yoksa büyük maliyet gibi davran
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
    }
}
