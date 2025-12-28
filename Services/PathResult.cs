using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AkaNet.Results
{
    public class PathResult
    {
        public List<int> Path { get; } = new List<int>();
        public double TotalCost { get; set; }
        public bool Found { get; set; }
    }
}
