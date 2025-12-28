using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNet.Models
{
    public class Node
    {
        public int Id { get; }
        public string Name { get; set; }
        public double Activity { get; set; }
        public double Interaction { get; set; }
        public int ConnectionCount { get; set; }

        public Node(int id, string name, double activity, double interaction, int connectionCount)
        {
            Id = id;
            Name = name ?? "";
            Activity = activity;
            Interaction = interaction;
            ConnectionCount = connectionCount;
        }
        //debuglar için toString override edildi 
        public override string ToString() => $"{Id} - {Name}";
    }
}
