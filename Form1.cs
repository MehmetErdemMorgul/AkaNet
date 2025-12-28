using System;
using System.Windows.Forms;
using AkaNet.Models;
using AkaNet.Algorithms;

namespace AkaNet
{
    public partial class Form1 : Form
    {
        private Graph g;

        public Form1()
        {
            InitializeComponent();

            g = new Graph();
            g.AddNode(new Node(1, "A", 0.8, 12, 3));
            g.AddNode(new Node(2, "B", 0.4, 5, 2));
            g.AddNode(new Node(3, "C", 0.9, 20, 4));

            g.AddEdge(1, 2);
            g.AddEdge(2, 3);
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

            int startId = 1;
            int targetId = 3;

            var dij = new DijkstraAlgorithm();
            var res = dij.Run(g, startId, targetId);

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
