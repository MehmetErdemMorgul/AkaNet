using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AkaNet.Models;

namespace AkaNet
{
    public partial class PathExplanationForm : Form
    {
        // 1️⃣ PARAMETRESİZ constructor (ŞART)
        public PathExplanationForm()
        {
            InitializeComponent();
            rtbExplain.Clear();
        }

        // 2️⃣ DIŞARIDAN TEXT GÖNDERMEK İÇİN
        public PathExplanationForm(string text) : this()
        {
            WriteColoredExplanation(text);
        }

        // 3️⃣ GRAPH + PATH İLE OTOMATİK AÇIKLAMA
        public PathExplanationForm(Graph g, List<int> path) : this()
        {
            string text = BuildExplanation(g, path);
            WriteColoredExplanation(text);
        }

        // --------------------------------------------------

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

                sb.AppendLine($"Adım {i + 1}: {u} → {v}");
                sb.AppendLine($"  ΔActivity = {dAct:0.###}");
                sb.AppendLine($"  ΔInteraction = {dInt:0.###}");
                sb.AppendLine($"  ΔConnection = {dConn:0.###}");
                sb.AppendLine($"  Weight = {w:0.####}");
                sb.AppendLine();
            }
            sb.AppendLine("----------------------------------");
            sb.AppendLine("Algoritma, toplam ağırlığı minimize eden yolu seçmiştir.");
            return sb.ToString();
        }

        // --------------------------------------------------

        private void WriteColoredExplanation(string text)
        {
            rtbExplain.Clear();

            var lines = text.Split(new[] { "\r\n" }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                if (line.StartsWith("Adım"))
                    AppendLine(line, Color.DarkBlue, true);
                else if (line.Contains("Weight"))
                    AppendLine(line, Color.DarkRed, false);
                else if (line.Contains("Δ"))
                    AppendLine(line, Color.DarkGreen, false);
                else if (line.StartsWith("Seçilen yol") || line.StartsWith("Algoritma"))
                    AppendLine(line, Color.Black, true);
                else
                    AppendLine(line, Color.Black, false);
            }
        }

        private void AppendLine(string text, Color color, bool bold)
        {
            rtbExplain.SelectionStart = rtbExplain.TextLength;
            rtbExplain.SelectionColor = color;
            rtbExplain.SelectionFont = new Font(
                rtbExplain.Font,
                bold ? FontStyle.Bold : FontStyle.Regular
            );
            rtbExplain.AppendText(text + Environment.NewLine);
            rtbExplain.SelectionColor = rtbExplain.ForeColor;
        }
    }
}

