using AkaNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkaNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var g = new Graph();

            g.AddNode(new Node(1, "A", 0.8, 12, 3));
            g.AddNode(new Node(2, "B", 0.4, 5, 2));
            g.AddNode(new Node(3, "C", 0.9, 20, 4));

            g.AddEdge(1, 2);
            g.AddEdge(2, 3);

            MessageBox.Show(
                "Neighbors of 2: " + string.Join(",", g.NeighborsOf(2))
            );

        }
    }
}
