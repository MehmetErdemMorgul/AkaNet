using AkaNet.Algorithms;
using AkaNet.Data;
using AkaNet.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AkaNet
{
    public partial class Form1 : Form
    {
        private Graph g;

        private Dictionary<int, PointF> nodePos = new Dictionary<int, PointF>();

        private List<int> currentPath = new List<int>();
        private HashSet<(int, int)> pathEdges = new HashSet<(int, int)>();

        // ✅ Welsh–Powell renkleri: NodeId -> ColorIndex
        private Dictionary<int, int> nodeColors = new Dictionary<int, int>();

        // ✅ Renk paleti
        private readonly Color[] palette = new Color[]
        {
            Color.DeepSkyBlue, Color.Orange, Color.MediumSeaGreen, Color.MediumPurple,
            Color.Gold, Color.Crimson, Color.Teal, Color.Sienna, Color.OliveDrab,
            Color.CadetBlue, Color.HotPink, Color.SlateBlue
        };

        public Form1()
        {
            InitializeComponent();

            g = new Graph();
            ReloadUIAfterGraphLoad(); // bu zaten comboboxları temizler/doldurur (şu an boş olacak)

            // Boşsa SelectedIndex verme!
            if (cmbStart.Items.Count > 0) cmbStart.SelectedIndex = 0;
            if (cmbTarget.Items.Count > 0) cmbTarget.SelectedIndex = 0;

            BuildLayout();
            pnlCanvas.Invalidate();

            pnlCanvas.Resize += pnlCanvas_Resize;
        }


        private void BuildLayout()
        {
            nodePos.Clear();
            if (g == null) return;

            var nodes = g.Nodes.OrderBy(n => n.Id).ToList();
            int nCount = nodes.Count;
            if (nCount == 0) return;

            float cx = pnlCanvas.ClientSize.Width / 2f;
            float cy = pnlCanvas.ClientSize.Height / 2f;

            // Panel küçükse bile taşmayacak şekilde radius
            float radius = Math.Min(pnlCanvas.ClientSize.Width, pnlCanvas.ClientSize.Height) * 0.35f;
            radius = Math.Max(radius, 120f);

            // Küçük bir rastgele kaydırma (daha doğal dursun)
            var rnd = new Random(123); // sabit seed: her çalıştırmada aynı dağılım

            for (int i = 0; i < nCount; i++)
            {
                double ang = (2.0 * Math.PI * i) / nCount;

                float x = cx + (float)(radius * Math.Cos(ang));
                float y = cy + (float)(radius * Math.Sin(ang));

                // Hafif jitter
                x += rnd.Next(-25, 26);
                y += rnd.Next(-25, 26);

                // Node merkezden çizildiği için sol-üst köşeye kaydır (30x30 node)
                nodePos[nodes[i].Id] = new PointF(x - 15, y - 15);
            }
        }


        private void pnlCanvas_Resize(object sender, EventArgs e)
        {
            if (g == null) return;
            BuildLayout();
            pnlCanvas.Invalidate();
        }

        private void btnBfs_Click(object sender, EventArgs e)
        {
            ClearPath();
            ClearColoring();
            listBox1.Items.Clear();

            var bfs = new BfsAlgorithm();
            int startId = (int)cmbStart.SelectedItem;
            var res = bfs.Run(g, startId);

            foreach (var id in res.VisitOrder)
                listBox1.Items.Add(id);
        }

        private void btnDfs_Click(object sender, EventArgs e)
        {
            ClearPath();
            ClearColoring();
            listBox1.Items.Clear();

            var dfs = new DfsAlgorithm();
            int startId = (int)cmbStart.SelectedItem;
            var res = dfs.Run(g, startId);

            foreach (var id in res.VisitOrder)
                listBox1.Items.Add(id);
        }

        private void btnComponents_Click(object sender, EventArgs e)
        {
            ClearPath();
            ClearColoring();
            listBox1.Items.Clear();

            var alg = new ConnectedComponentsAlgorithm();
            var comps = alg.FindComponents(g);

            listBox1.Items.Add($"Component count: {comps.Count}");
            for (int i = 0; i < comps.Count; i++)
                listBox1.Items.Add($"C{i + 1}: " + string.Join(", ", comps[i]));
        }

        private void btnCentrality_Click(object sender, EventArgs e)
        {
            ClearPath();
            ClearColoring();
            listBox1.Items.Clear();

            var alg = new DegreeCentralityAlgorithm();
            var top5 = alg.TopK(g, 5);

            listBox1.Items.Add("Top 5 Degree Centrality (NodeId | Degree)");
            foreach (var row in top5)
                listBox1.Items.Add($"{row.NodeId} | {row.Degree}");
        }

        private void btnColoring_Click(object sender, EventArgs e)
        {
            ClearPath();
            ClearColoring();
            listBox1.Items.Clear();

            nodeColors.Clear();

            var cc = new ConnectedComponentsAlgorithm();
            var comps = cc.FindComponents(g);
            var wp = new WelshPowellColoring();

            for (int i = 0; i < comps.Count; i++)
            {
                var colorMap = wp.Color(g, comps[i]); // NodeId -> ColorIndex

                // listBox çıktısı (kalsın)
                listBox1.Items.Add($"Component C{i + 1} coloring (NodeId -> Color):");
                foreach (var kv in colorMap.OrderBy(x => x.Key))
                {
                    nodeColors[kv.Key] = kv.Value; // ✅ canvas için kaydet
                    listBox1.Items.Add($"{kv.Key} -> {kv.Value}");
                }
                listBox1.Items.Add("-----");
            }

            pnlCanvas.Invalidate(); // ✅ renklere göre yeniden çiz
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ClearColoring();

            int startId = (int)cmbStart.SelectedItem;
            int targetId = (int)cmbTarget.SelectedItem;

            var dij = new DijkstraAlgorithm();
            var res = dij.Run(g, startId, targetId);

            if (!res.Found || res.Path == null || res.Path.Count == 0)
            {
                listBox1.Items.Add("Path not found");
                currentPath.Clear();
                pathEdges.Clear();
                pnlCanvas.Invalidate();
                return;
            }

            listBox1.Items.Add("Path: " + string.Join(" -> ", res.Path));
            listBox1.Items.Add("Edge costs:");

            double sum = 0.0;
            for (int i = 0; i < res.Path.Count - 1; i++)
            {
                int u = res.Path[i];
                int v = res.Path[i + 1];

                var nu = g.GetNode(u);
                var nv = g.GetNode(v);

                double w = g.GetWeight(u, v);
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

            SetPath(res.Path);
        }

        private void ClearPath()
        {
            currentPath.Clear();
            pathEdges.Clear();
            pnlCanvas.Invalidate();
        }

        private void btnAStar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ClearColoring();

            int start = (int)cmbStart.SelectedItem;
            int target = (int)cmbTarget.SelectedItem;

            var astar = new AStarAlgorithm();
            var res = astar.Run(g, start, target);

            if (!res.Found || res.Path == null || res.Path.Count == 0)
            {
                listBox1.Items.Add("Path not found");
                currentPath.Clear();
                pathEdges.Clear();
                pnlCanvas.Invalidate();
                return;
            }

            listBox1.Items.Add("A* Path: " + string.Join(" -> ", res.Path));
            listBox1.Items.Add("Total cost: " + res.TotalCost.ToString("0.0000"));
            listBox1.Items.Add("Visited nodes: " + res.VisitedCount);

            SetPath(res.Path);
        }

        private void SetPath(List<int> path)
        {
            currentPath = path.ToList();

            pathEdges.Clear();
            for (int i = 0; i + 1 < currentPath.Count; i++)
            {
                int a = currentPath[i];
                int b = currentPath[i + 1];
                pathEdges.Add((a, b));
                pathEdges.Add((b, a)); // yönsüz
            }

            pnlCanvas.Invalidate();
        }
        private void ClearColoring()
        {
            nodeColors.Clear();
            pnlCanvas.Invalidate();
        }
        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (g == null || nodePos.Count == 0) return;

            var gr = e.Graphics;

            // 1) NORMAL EDGE'LERİ ÇİZ (hepsi siyah)
            foreach (var node in g.Nodes)
            {
                int u = node.Id;

                foreach (var v in g.NeighborsOf(u))
                {
                    if (v < u) continue;
                    if (!nodePos.ContainsKey(u) || !nodePos.ContainsKey(v)) continue;

                    PointF pu = nodePos[u];
                    PointF pv = nodePos[v];

                    pu = new PointF(pu.X + 15, pu.Y + 15);
                    pv = new PointF(pv.X + 15, pv.Y + 15);

                    using (var pen = new Pen(Color.Black, 2f))
                    {
                        gr.DrawLine(pen, pu, pv);
                    }

                    // ağırlık yazısı
                    double w = g.GetWeight(u, v);
                    string txt = w.ToString("0.###");

                    float mx = (pu.X + pv.X) / 2f;
                    float my = (pu.Y + pv.Y) / 2f;

                    var size = gr.MeasureString(txt, this.Font);
                    gr.DrawString(txt, this.Font, Brushes.DarkRed,
                        mx - size.Width / 2f,
                        my - size.Height / 2f - 4);
                }
            }

            // 2) PATH'İ EN ÜSTE KIRMIZI/KALIN ÇİZ
            if (currentPath != null && currentPath.Count >= 2)
            {
                using (var penPath = new Pen(Color.Red, 7f))
                {
                    for (int i = 0; i + 1 < currentPath.Count; i++)
                    {
                        int a = currentPath[i];
                        int b = currentPath[i + 1];

                        if (!nodePos.ContainsKey(a) || !nodePos.ContainsKey(b)) continue;

                        PointF pa = nodePos[a];
                        PointF pb = nodePos[b];

                        pa = new PointF(pa.X + 15, pa.Y + 15);
                        pb = new PointF(pb.X + 15, pb.Y + 15);

                        gr.DrawLine(penPath, pa, pb);
                    }
                }
            }

            // 3) NODE'LARI ÇİZ (Welsh–Powell rengine göre)
            foreach (var kv in nodePos)
            {
                int id = kv.Key;
                PointF p = kv.Value;

                int cidx = nodeColors.ContainsKey(id) ? nodeColors[id] : -1;
                Color c = (cidx >= 0) ? palette[cidx % palette.Length] : Color.Blue;

                using (var br = new SolidBrush(c))
                {
                    gr.FillEllipse(br, p.X, p.Y, 30, 30);
                }

                gr.DrawString(id.ToString(), this.Font, Brushes.White, p.X + 8, p.Y + 6);
            }
        }
        private void ReloadUIAfterGraphLoad()
        {
            // seçimleri temizle
            cmbStart.Items.Clear();
            cmbTarget.Items.Clear();

            foreach (var node in g.Nodes.OrderBy(n => n.Id))
            {
                cmbStart.Items.Add(node.Id);
                cmbTarget.Items.Add(node.Id);
            }

            if (cmbStart.Items.Count > 0) cmbStart.SelectedIndex = 0;
            if (cmbTarget.Items.Count > 0) cmbTarget.SelectedIndex = 0;

            cmbEdgeA.Items.Clear();
            cmbEdgeB.Items.Clear();

            foreach (var node in g.Nodes.OrderBy(n => n.Id))
            {
                cmbEdgeA.Items.Add(node.Id);
                cmbEdgeB.Items.Add(node.Id);
            }

            if (cmbEdgeA.Items.Count > 0) cmbEdgeA.SelectedIndex = 0;
            if (cmbEdgeB.Items.Count > 0) cmbEdgeB.SelectedIndex = 0;

            // eski çizimleri temizle
            currentPath.Clear();
            pathEdges.Clear();
            nodeColors.Clear();

            BuildLayout();
            pnlCanvas.Invalidate();
        }
        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                ofd.Title = "Graph CSV seç";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    g = CsvGraphLoader.Load(ofd.FileName);
                    ReloadUIAfterGraphLoad();
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Yüklendi: " + System.IO.Path.GetFileName(ofd.FileName));
                    listBox1.Items.Add("Node sayısı: " + g.Nodes.Count());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("CSV yüklenemedi: " + ex.Message);
                }
            }
        }
        private int FindNodeAt(Point p)
        {
            const int r = 15; // node yarıçap (30x30 çiziyorduk)
            foreach (var kv in nodePos)
            {
                float cx = kv.Value.X + r;
                float cy = kv.Value.Y + r;
                float dx = p.X - cx;
                float dy = p.Y - cy;
                if (dx * dx + dy * dy <= r * r)
                    return kv.Key;
            }
            return -1;
        }
        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            int id = FindNodeAt(e.Location);
            if (id < 0) return;

            FillNodePanel(id);

            var n = g.GetNode(id);
            var neigh = g.NeighborsOf(id).OrderBy(x => x).ToList();

            string msg =
                $"Node {n.Id}\n" +
                $"Act: {n.Activity}  Int: {n.Interaction}\n" +
                $"Conn: {n.ConnectionCount}\n" +
                $"Neigh: {(neigh.Count == 0 ? "-" : string.Join(", ", neigh))}";

            tip.Show(msg, pnlCanvas, e.Location.X + 10, e.Location.Y + 10, 2500);
        }


        private void FillNodePanel(int id)
        {
            var n = g.GetNode(id);
            if (n == null) return;

            selectedNodeId = id;

            txtId.Text = n.Id.ToString();
            txtName.Text = n.Name;
            txtInteraction.Text = n.Interaction.ToString();
            txtActivity.Text = n.Activity.ToString();
             txtConnCount.Text = n.ConnectionCount.ToString();
        }

        private ToolTip tip = new ToolTip();
        private void Form1_Load(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private int selectedNodeId = -1;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClearNode_Click(object sender, EventArgs e)
        {
            selectedNodeId = -1;
            txtId.Clear();
            txtName.Clear();
            txtInteraction.Clear();
            txtActivity.Clear();
            txtConnCount.Clear();
        }
        private void btnAddNode_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text.Trim());

                string name = string.IsNullOrWhiteSpace(txtName.Text)
                    ? $"N{id}"
                    : txtName.Text.Trim();

                double interaction = double.Parse(
                    txtInteraction.Text.Trim().Replace(',', '.'),
                    System.Globalization.CultureInfo.InvariantCulture
                );

                double activity = double.Parse(
                    txtActivity.Text.Trim().Replace(',', '.'),
                    System.Globalization.CultureInfo.InvariantCulture
                );

                // ConnCount bence otomatik olmalı; yeni node için 0 bırakıyoruz
                int cc = 0;

                if (g.GetNode(id) != null)
                {
                    MessageBox.Show("Bu ID zaten var!");
                    return;
                }

                g.AddNode(new Node(id, name, activity, interaction, cc));

                // UI yenile
                ReloadUIAfterGraphLoad();

                MessageBox.Show($"Node eklendi: {id}");

                btnClearNode_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
        }
        private void btnUpdateNode_Click(object sender, EventArgs e)
        {
            try
            {
                int id = selectedNodeId >= 0 ? selectedNodeId : int.Parse(txtId.Text.Trim());

                var n = g.GetNode(id);
                if (n == null)
                {
                    MessageBox.Show("Node bulunamadı.");
                    return;
                }

                // değerleri güncelle
                n.Name = string.IsNullOrWhiteSpace(txtName.Text) ? n.Name : txtName.Text.Trim();

                n.Interaction = double.Parse(txtInteraction.Text.Trim().Replace(',', '.'),
                    System.Globalization.CultureInfo.InvariantCulture);

                n.Activity = double.Parse(txtActivity.Text.Trim().Replace(',', '.'),
                    System.Globalization.CultureInfo.InvariantCulture);

                // ConnCount'u elle alma; otomatik kalsın (istersen açıkça güncelle)
                n.ConnectionCount = g.NeighborsOf(id).Count();

                // weight'ler bu alanlardan beslendiği için çizim + algoritmalar artık güncel
                pnlCanvas.Invalidate();

                MessageBox.Show($"Node güncellendi: {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }
        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            try
            {
                int id = selectedNodeId >= 0 ? selectedNodeId : int.Parse(txtId.Text.Trim());

                bool ok = g.RemoveNode(id);
                if (!ok)
                {
                    MessageBox.Show("Silinecek node bulunamadı.");
                    return;
                }

                // çizimleri temizle
                ClearPath();
                ClearColoring();

                // seçimi temizle
                btnClearNode_Click(null, null);

                // UI + canvas yenile
                ReloadUIAfterGraphLoad();

                MessageBox.Show($"Node silindi: {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            int a = (int)cmbEdgeA.SelectedItem;
            int b = (int)cmbEdgeB.SelectedItem;

            if (a == b)
            {
                MessageBox.Show("Aynı node’a edge eklenmez.");
                return;
            }

            if (!g.HasEdge(a, b))
                g.AddEdge(a, b);

            // ConnCount'ları da güncelle (istersen)
            var na = g.GetNode(a); if (na != null) na.ConnectionCount = g.NeighborsOf(a).Count();
            var nb = g.GetNode(b); if (nb != null) nb.ConnectionCount = g.NeighborsOf(b).Count();

            pnlCanvas.Invalidate();
        }
        private void btnDeleteEdge_Click(object sender, EventArgs e)
        {
            int a = (int)cmbEdgeA.SelectedItem;
            int b = (int)cmbEdgeB.SelectedItem;

            if (a == b)
            {
                MessageBox.Show("Aynı node seçilemez.");
                return;
            }

            bool ok = g.RemoveEdge(a, b);
            if (!ok)
            {
                MessageBox.Show("Bu iki node arasında edge yok.");
                return;
            }

            // ConnCount güncelle
            var na = g.GetNode(a); if (na != null) na.ConnectionCount = g.NeighborsOf(a).Count();
            var nb = g.GetNode(b); if (nb != null) nb.ConnectionCount = g.NeighborsOf(b).Count();

            // Path ve renklendirmeyi temizle
            ClearPath();
            ClearColoring();

            pnlCanvas.Invalidate();
            MessageBox.Show("Edge silindi.");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Tüm graph sıfırlanacak. Emin misiniz?",
                "Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            // 1) Yeni boş graph
            g = new Graph();

            // 2) Çizim ve algoritma durumlarını temizle
            nodePos.Clear();
            currentPath.Clear();
            pathEdges.Clear();
            nodeColors.Clear();

            // 3) ComboBox'ları temizle
            cmbStart.Items.Clear();
            cmbTarget.Items.Clear();
            cmbEdgeA.Items.Clear();
            cmbEdgeB.Items.Clear();

            // 4) Sağ paneli temizle
            btnClearNode_Click(null, null);

            // 5) Canvas yeniden çiz
            BuildLayout();
            pnlCanvas.Invalidate();

            // 6) Bilgi mesajı (opsiyonel ama güzel)
            listBox1.Items.Clear();
            listBox1.Items.Add("Graph resetlendi. Yeni bir graph oluşturabilirsiniz.");
        }



    }
}
