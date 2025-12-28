using System;
using System.Windows.Forms;
using AkaNet.Models;
using AkaNet.Algorithms;
using AkaNet.Data;

namespace AkaNet
{
    public partial class Form1 : Form
    {
        private Graph g;

        public Form1()
        {
            InitializeComponent();

            string path = "nodes.csv"; // bin/Debug içine koyduysan yeterli
            g = CsvGraphLoader.Load(path);
        }

        private void btnBfs_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var bfs = new BfsAlgorithm();
            var res = bfs.Run(g, 1);

            foreach (var id in res.VisitOrder)
                listBox1.Items.Add(id);
        }

        private void btnDfs_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var dfs = new DfsAlgorithm();
            var res = dfs.Run(g, 1);

            foreach (var id in res.VisitOrder)
                listBox1.Items.Add(id);
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int startId = 1;   // sizde sabitse böyle kalsın (sonra ComboBox yaparız)
            int targetId = 3;

            var dij = new DijkstraAlgorithm();
            var res = dij.Run(g, startId, targetId);

            if (!res.Found || res.Path == null || res.Path.Count == 0)
            {
                listBox1.Items.Add("Path not found");
                return;
            }

            // 1) Path yaz
            listBox1.Items.Add("Path: " + string.Join(" -> ", res.Path));
            listBox1.Items.Add("Edge costs:");

            // 2) Path üzerindeki her kenarın weight’ini yaz
            double sum = 0.0;
            for (int i = 0; i < res.Path.Count - 1; i++)
            {
                int u = res.Path[i];
                int v = res.Path[i + 1];
                var nu = g.GetNode(u);
                var nv = g.GetNode(v);


                double w = g.GetWeight(u, v);   // Graph içindeki dinamik formül
                sum += w;

                listBox1.Items.Add($"{u} -> {v} : {w:0.0000}");

                listBox1.Items.Add(
                  $"{u} -> {v} : w={w:0.0000} | " +
                  $"A({nu.Activity},{nu.Interaction},{nu.ConnectionCount}) - " +
                  $"B({nv.Activity},{nv.Interaction},{nv.ConnectionCount})"
                );
            }

            listBox1.Items.Add($"Total (sum of edges): {sum:0.0000}");
            listBox1.Items.Add($"Total (algorithm): {res.TotalCost:0.0000}");
        }

    }
}
