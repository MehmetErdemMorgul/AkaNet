using System;
using System.Collections.Generic;
using AkaNet.Models;

namespace AkaNet.Models
{
    public class Graph
    {
        private Dictionary<int, Node> nodes = new Dictionary<int, Node>();
        private Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();

        // 🔹 DIJKSTRA bunu istiyor
        public IEnumerable<Node> Nodes => nodes.Values;

        public void AddNode(Node node)
        {
            if (!nodes.ContainsKey(node.Id))
            {
                nodes[node.Id] = node;
                adj[node.Id] = new List<int>();
            }
        }

        public void AddEdge(int from, int to)
        {
            if (!adj[from].Contains(to))
                adj[from].Add(to);
            if (!adj[to].Contains(from))
                adj[to].Add(from);
        }

        public bool HasEdge(int from, int to)
        {
            return adj.ContainsKey(from) && adj[from].Contains(to);
        }

        public IEnumerable<int> NeighborsOf(int id)
        {
            return adj[id];
        }

        public Node GetNode(int id)
        {
            return nodes[id];
        }

        // 🔥 RAPORDAKİ FORMÜL BURADA
        public double GetWeight(int fromId, int toId)
        {
            var a = nodes[fromId];
            var b = nodes[toId];

            double diff =
                Math.Pow(a.Activity - b.Activity, 2) +
                Math.Pow(a.Interaction - b.Interaction, 2) +
                Math.Pow(a.ConnectionCount - b.ConnectionCount, 2);

            return 1.0 / (1.0 + diff);
        }
    }
}

