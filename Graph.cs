using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Graph
    {
        private int V; // Number of vertices
        private List<int>[] adjacencyList; // Adjacency list to represent the graph

        public Graph(int v)
        {
            V = v;
            adjacencyList = new List<int>[v];
            for (int i = 0; i < v; ++i)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adjacencyList[v].Add(w);
            adjacencyList[w].Add(v);
        }

        public void DisplayGraph()
        {
            for (int i = 0; i < V; ++i)
            {
                Console.Write("Vertex " + i + ": ");
                foreach (var node in adjacencyList[i])
                {
                    Console.Write(node + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
