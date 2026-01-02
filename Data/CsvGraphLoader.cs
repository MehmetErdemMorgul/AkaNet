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

            if (lines.Length < 2)
                throw new Exception("CSV boş veya sadece header var.");

            // Header’a göre kolon ayıracı seç (',' mi ';' mi?)
            char colSep = DetectColumnSeparator(lines[0]);

            // 1) NODE OKUMA (header atlanır)
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;

                try
                {
                    var parts = SplitCols(line, colSep);

                    if (parts.Length < 4)
                        throw new Exception($"Beklenen en az 4 kolon var (Id,Activity,Interaction,ConnectionCount). Bulunan: {parts.Length}");

                    int id = ParseInt(parts[0]);
                    double activity = ParseDouble(parts[1]);
                    double interaction = ParseDouble(parts[2]);
                    int connectionCount = ParseInt(parts[3]);

                    var node = new Node(id, $"N{id}", activity, interaction, connectionCount);
                    graph.AddNode(node);
                }
                catch (Exception ex)
                {
                    throw new Exception($"CSV NODE parse hatası (satır {i + 1}): '{line}' -> {ex.Message}");
                }
            }

            // 2) EDGE OKUMA (Neighbors)
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;

                try
                {
                    var parts = SplitCols(line, colSep);

                    int fromId = ParseInt(parts[0]);

                    // 5. kolon yoksa komşu yok
                    if (parts.Length < 5 || string.IsNullOrWhiteSpace(parts[4]))
                        continue;

                    var neighbors = SplitNeighbors(parts[4]);

                    foreach (var n in neighbors)
                    {
                        int toId = ParseInt(n);

                        if (toId == fromId) continue; // self-loopu engelleyen kod 

                        if (!graph.HasEdge(fromId, toId))
                            graph.AddEdge(fromId, toId);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"CSV EDGE parse hatası (satır {i + 1}): '{line}' -> {ex.Message}");
                }
            }

            return graph;
        }

        private static char DetectColumnSeparator(string headerLine)
        {
            int comma = headerLine.Split(',').Length;
            int semi = headerLine.Split(';').Length;
            return (semi > comma) ? ';' : ',';
        }

        private static string[] SplitCols(string line, char colSep)
        {
            // split kodu  
            return line.Split(colSep);
        }

        private static string[] SplitNeighbors(string s)
        {
            return s.Split(new[] { ';', '|', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static int ParseInt(string s)
        {
            return int.Parse(s.Trim(), CultureInfo.InvariantCulture);
        }

        private static double ParseDouble(string s)
        {
            s = s.Trim().Replace(',', '.'); // 0,8 -> 0.8
            return double.Parse(s, CultureInfo.InvariantCulture);
        }
    }
}
