using System.Collections.Generic;
using System.Linq;
using AkaNet.Models;

namespace AkaNet.Algorithms
{
    public class ConnectedComponentsAlgorithm
    {
        public List<List<int>> FindComponents(Graph g)
        {
            var visited = new HashSet<int>();
            var comps = new List<List<int>>();

            var allIds = g.Nodes.Select(n => n.Id);

            foreach (var start in allIds)
            {
                if (visited.Contains(start)) continue;

                var comp = new List<int>();
                var stack = new Stack<int>();
                stack.Push(start);
                visited.Add(start);

                while (stack.Count > 0)
                {
                    int u = stack.Pop();
                    comp.Add(u);

                    foreach (var v in g.NeighborsOf(u))
                    {
                        if (visited.Contains(v)) continue;
                        visited.Add(v);
                        stack.Push(v);
                    }
                }

                comp.Sort();
                comps.Add(comp);
            }

            return comps;
        }
    }
}
