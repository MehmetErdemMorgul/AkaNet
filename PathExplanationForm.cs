using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AkaNet.Models;

namespace AkaNet
{
    public partial class PathExplanationForm : Form
    {
        public PathExplanationForm()
        {
            InitializeComponent();
        }

        // Form1'den direk text basmak istersen
        public void SetText(string text)
        {
            txtExplain.Text = text;
        }

        // Form1'den Graph + path göndererek otomatik açıklama üretmek istersen
        public PathExplanationForm(Graph g, List<int> path) : this()
        {
            txtExplain.Text = BuildExplanation(g, path);
        }

        private string BuildExplanation(Graph g, List<int> path)
        {
            if (g == null) return "Graph null.";
            if (path == null || path.Count < 2) return "Path boş.";

            var sb = new StringBuilder();
            sb.AppendLine("Seçilen yolun sebebi (edge bazlı):");
            sb.AppendLine("----------------------------------");

            for (int i = 0; i < path.Count - 1; i++)
            {
                int u = path[i];
                int v = path[i + 1];

                var a = g.GetNode(u);
                var b = g.GetNode(v);
                if (a == null || b == null) continue;

                double dAct = Math.Abs(a.Activity - b.Activity);
                double dInt = Math.Abs(a.Interaction - b.Interaction);
                double dConn = Math.Abs(a.ConnectionCount - b.ConnectionCount);
                double w = g.GetWeight(u, v);

                sb.AppendLine($"{u} → {v} seçildi çünkü:");
                sb.AppendLine($"  ΔActivity = {dAct:0.###}, ΔInteraction = {dInt:0.###}, ΔConn = {dConn:0.###}");
                sb.AppendLine($"  Weight = {w:0.####}");
                sb.AppendLine();
            }

            sb.AppendLine("Not: Dijkstra/A* toplam maliyeti minimize edecek şekilde seçim yapar.");
            return sb.ToString();
        }
    }
}
