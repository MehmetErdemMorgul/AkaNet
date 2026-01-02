using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkaNet.Visuals
{
    public class Coloring
    {
        private readonly Control canvas; 
        private readonly Dictionary<int, Rectangle> nodeRects;

        public Coloring(Control canvas, Dictionary<int, Rectangle> nodeRects)
        {
            this.canvas = canvas;
            this.nodeRects = nodeRects;
        }

        public async Task AnimatePathAsync(List<int> path)
        {
            if (path == null || path.Count == 0) return;

            foreach (var nodeId in path)
            {
                HighlightNode(nodeId, Color.OrangeRed);
                await Task.Delay(400); // animasyon hızı
            }
        }

        private void HighlightNode(int nodeId, Color color)
        {
            if (!nodeRects.ContainsKey(nodeId)) return;

            using (Graphics g = canvas.CreateGraphics())
            using (Brush b = new SolidBrush(color))
            {
                g.FillEllipse(b, nodeRects[nodeId]);
            }
        }
    }
}
