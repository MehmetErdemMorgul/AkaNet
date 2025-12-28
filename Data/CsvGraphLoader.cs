using System;
using System.Globalization;
using System.IO;
using System.Linq;
using AkaNet.Models;

namespace AkaNet.Data
{
    public static class CsvGraphLoader
    {
        public static Graph Load(string fileName)
        {
            var graph = new Graph();

            if (!File.Exists(fileName))
                throw new FileNotFoundException($"CSV not found: {fileName}");

            var lines = File.ReadAllLines(fileName)
                            .Where(l => !string.IsNullOrWhiteSpace(l))
                            .ToArray();

            if (lines.Length < 2) return graph; // header var ama veri yok

            // 1) Node'ları oku (önce node'lar)
            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length < 5) continue;

                int id = int.Parse(parts[0].Trim());
                double activity = double.Parse(parts[1].Trim(), CultureInfo.InvariantCulture);
                double interaction = double.Parse(parts[2].Trim(), CultureInfo.InvariantCulture);
                int connectionCount = int.Parse(parts[3].Trim());

                // Name CSV'de yoksa id'den üretelim
                var node = new Node(id, $"Node {id}", activity, interaction, connectionCount);
                graph.AddNode(node);
            }

            // 2) Edge'leri oku (Neighbors'tan)
            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length < 5) continue;

                int fromId = int.Parse(parts[0].Trim());

                var neighborsRaw = parts[4].Trim();
                if (string.IsNullOrWhiteSpace(neighborsRaw)) continue;

                // ; veya , ile ayrılmış komşu listesini destekle
                var neighbors = neighborsRaw
                    .Split(new[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim());

                foreach (var nbStr in neighbors)
                {
                    if (!int.TryParse(nbStr, out int toId)) continue;
                    if (fromId == toId) continue; // self-loop engelle

                    graph.AddEdge(fromId, toId);
                }
            }

            return graph;
        }
    }
}
