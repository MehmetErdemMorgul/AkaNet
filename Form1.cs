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
            var dij = new DijkstraAlgorithm();
            var res = dij.Run(g, 1, 3);

            if (!res.Found)
            {
                listBox1.Items.Add("Path not found");
                return;
            }

            listBox1.Items.Add("Path: " + string.Join(" -> ", res.Path));
            listBox1.Items.Add("Total cost: " + res.TotalCost.ToString("0.0000"));
        }
    }
}
