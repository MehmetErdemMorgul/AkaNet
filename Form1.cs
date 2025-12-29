using AkaNet.Algorithms;
using AkaNet.Data;
using AkaNet.Models;
using System;
using System.Linq;
using System.Windows.Forms;

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

            foreach (var node in g.Nodes)
            {
                cmbStart.Items.Add(node.Id);
                cmbTarget.Items.Add(node.Id);
            }

            // Varsayılan seçim
            cmbStart.SelectedIndex = 0;
            cmbTarget.SelectedIndex = 0;
        }

        

        private void btnBfs_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var bfs = new BfsAlgorithm();
            int startId = (int)cmbStart.SelectedItem;
            var res = bfs.Run(g, startId);

            foreach (var id in res.VisitOrder)
                listBox1.Items.Add(id);
        }

        private void btnDfs_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var dfs = new DfsAlgorithm();
            int startId = (int)cmbStart.SelectedItem;
            var res = dfs.Run(g, startId);

            foreach (var id in res.VisitOrder)
                listBox1.Items.Add(id);
        }
        private void btnComponents_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            var alg = new ConnectedComponentsAlgorithm();
            var comps = alg.FindComponents(g);

            listBox1.Items.Add($"Component count: {comps.Count}");
            for (int i = 0; i < comps.Count; i++)
                listBox1.Items.Add($"C{i + 1}: " + string.Join(", ", comps[i]));
        }

        private void btnCentrality_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            var alg = new DegreeCentralityAlgorithm();
            var top5 = alg.TopK(g, 5);

            listBox1.Items.Add("Top 5 Degree Centrality (NodeId | Degree)");
            foreach (var row in top5)
                listBox1.Items.Add($"{row.NodeId} | {row.Degree}");
        }

        private void btnColoring_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();

            var cc = new ConnectedComponentsAlgorithm();
            var comps = cc.FindComponents(g);

            var wp = new WelshPowellColoring();

            for (int i = 0; i < comps.Count; i++)
            {
                var colorMap = wp.Color(g, comps[i]);

                listBox1.Items.Add($"Component C{i + 1} coloring (NodeId -> Color):");
                foreach (var kv in colorMap.OrderBy(x => x.Key))
                    listBox1.Items.Add($"{kv.Key} -> {kv.Value}");
                listBox1.Items.Add("-----");
            }
        }


        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int startId = (int)cmbStart.SelectedItem;
            int targetId = (int)cmbTarget.SelectedItem;

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
            listBox1.Items.Add($"Visited nodes: {res.VisitedCount}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAStar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int start = (int)cmbStart.SelectedItem;
            int target = (int)cmbTarget.SelectedItem;

            var astar = new AStarAlgorithm();
            var res = astar.Run(g, start, target);

            if (!res.Found)
            {
                listBox1.Items.Add("Path not found");
                return;
            }

            listBox1.Items.Add("A* Path: " + string.Join(" -> ", res.Path));
            listBox1.Items.Add("Total cost: " + res.TotalCost.ToString("0.0000"));
            listBox1.Items.Add("Visited nodes: " + res.VisitedCount);
        }

        
    }
}
