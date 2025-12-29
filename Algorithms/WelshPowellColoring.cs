using System.Collections.Generic;
using System.Linq;
using AkaNet.Models;

namespace AkaNet.Algorithms
{
    public class WelshPowellColoring
    {
        // Her node -> renk indexi (0,1,2...)
        public Dictionary<int, int> Color(Graph g, IEnumerable<int> componentNodeIds)
        {
            var nodes = componentNodeIds
                .OrderByDescending(id => g.NeighborsOf(id).Count()) // dereceye göre azalan
                .ThenBy(id => id)
                .ToList();

            var colorOf = new Dictionary<int, int>();
            int color = 0;

            foreach (var v in nodes)
            {
                if (colorOf.ContainsKey(v)) continue;

                colorOf[v] = color;

                // Aynı renge boyanabilecekleri dolaş
                foreach (var u in nodes)
                {
                    if (colorOf.ContainsKey(u)) continue;

                    bool adjacentToSameColor = colorOf
                        .Where(p => p.Value == color)
                        .Select(p => p.Key)
                        .Any(colored => g.NeighborsOf(u).Contains(colored));

                    if (!adjacentToSameColor)
                        colorOf[u] = color;
                }

                color++;
            }

            return colorOf;
        }
    }
}
