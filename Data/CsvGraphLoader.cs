using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using AkaNet.Models;

namespace AkaNet.Data
{
    public static class CsvGraphLoader
    {
        public static Graph Load(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException($"CSV not found: {fileName}");

            var graph = new Graph();
            var lines = File.ReadAllLines(fileName);

            // Node'ları tutmak için
            var nodes = new Dictionary<int, Node>();

            // 🔹 1) NODE OKUMA (header atlanır)
            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                // 🔥 CSV satırı , ile ayrılıyor
                var parts = lines[i].Split(',');

                int id = int.Parse(parts[0].Trim());
                double activity = double.Parse(parts[1].Trim(), CultureInfo.InvariantCulture);
                double interaction = double.Parse(parts[2].Trim(), CultureInfo.InvariantCulture);
                int connectionCount = int.Parse(parts[3].Trim());

                var node = new Node(id, $"N{id}", activity, interaction, connectionCount);
                nodes[id] = node;
                graph.AddNode(node);
            }

            // 🔹 2) EDGE OKUMA (Neighbors)
            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                var parts = lines[i].Split(',');

                int fromId = int.Parse(parts[0].Trim());

                if (parts.Length < 5 || string.IsNullOrWhiteSpace(parts[4]))
                    continue;

                // 🔥 Komşular ; ile ayrılıyor
                var neighbors = parts[4].Split(';');

                foreach (var n in neighbors)
                {
                    int toId = int.Parse(n.Trim());

                    // Çift kenarı engelle
                    if (!graph.HasEdge(fromId, toId))
                        graph.AddEdge(fromId, toId);
                }
            }

            return graph;
        }
    }
}
