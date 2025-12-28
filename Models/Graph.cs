using System;
using System.Collections.Generic;
using System.Linq;
using AkaNet.Services;

namespace AkaNet.Models
{
    public class Graph
    {
        // Basit ve okunur olsun diye List tuttuk
        private readonly List<Node> _nodes = new List<Node>();
        private readonly List<Edge> _edges = new List<Edge>();

        // Algoritmalar için hızlı komşu bulma (cache). Graph kalabalık durmasın diye private.
        private Dictionary<int, HashSet<int>> _neighborsCache = null;

        public IReadOnlyList<Node> Nodes => _nodes;
        public IReadOnlyList<Edge> Edges => _edges;

        // ---------- NODE ----------
        public void AddNode(Node node)
        {
            if (node == null) throw new ArgumentNullException(nameof(node));

            // aynı Id ile node eklenmesin
            if (_nodes.Any(n => n.Id == node.Id))
                throw new InvalidOperationException("Duplicate node (aynı Id).");

            _nodes.Add(node);
            _neighborsCache = null; // komşuluk cache bozuldu
        }

        private readonly WeightCalculator _weightCalculator = new WeightCalculator();

        public double GetWeight(int fromId, int toId)
        {
            var from = _nodes.FirstOrDefault(n => n.Id == fromId);
            var to = _nodes.FirstOrDefault(n => n.Id == toId);

            if (from == null || to == null)
                throw new System.ArgumentException("Node bulunamadı.");

            return _weightCalculator.Calculate(from, to);
        }


        public Node GetNode(int id)
        {
            var n = _nodes.FirstOrDefault(x => x.Id == id);
            if (n == null) throw new KeyNotFoundException("Node bulunamadı: " + id);
            return n;
        }

        public bool HasNode(int id) => _nodes.Any(n => n.Id == id);

        public bool HasEdge(int from, int to)
        {
            return Edges.Any(e =>
                (e.From == from && e.To == to) ||
                (e.From == to && e.To == from));
        }

        // ---------- EDGE ----------
        public void AddEdge(int from, int to)
        {
            // Edge constructor self-loop kontrolünü zaten yapıyor
            if (!HasNode(from) || !HasNode(to))
                throw new InvalidOperationException("Edge eklemek için iki node da önce eklenmeli.");

            // yönsüz duplicate kontrolü
            bool exists = _edges.Any(e =>
                (e.From == from && e.To == to) ||
                (e.From == to && e.To == from));

            if (exists)
                throw new InvalidOperationException("Duplicate edge.");

            _edges.Add(new Edge(from, to));
            _neighborsCache = null; // cache bozuldu
        }

        public void RemoveEdge(int from, int to)
        {
            int idx = _edges.FindIndex(e =>
                (e.From == from && e.To == to) ||
                (e.From == to && e.To == from));

            if (idx < 0) return;

            _edges.RemoveAt(idx);
            _neighborsCache = null;
        }

        // ---------- NEIGHBORS (BFS/DFS/Dijkstra için) ----------
        public IReadOnlyCollection<int> NeighborsOf(int id)
        {
            var map = GetOrBuildNeighbors();
            if (!map.ContainsKey(id))
                throw new KeyNotFoundException("Node bulunamadı: " + id);

            return map[id].ToList().AsReadOnly();
        }

        private Dictionary<int, HashSet<int>> GetOrBuildNeighbors()
        {
            if (_neighborsCache != null) return _neighborsCache;

            var map = new Dictionary<int, HashSet<int>>();
            foreach (var n in _nodes)
                map[n.Id] = new HashSet<int>();

            foreach (var e in _edges)
            {
                map[e.From].Add(e.To);
                map[e.To].Add(e.From);
            }

            _neighborsCache = map;
            return _neighborsCache;
        }
    }
}
