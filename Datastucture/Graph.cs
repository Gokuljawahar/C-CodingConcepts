using System;
using System.Collections.Generic;

public class Graph
{
    Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

    public void AddEdge(int src, int dest)
    {
        if (!adjList.ContainsKey(src))
            adjList[src] = new List<int>();
        if (!adjList.ContainsKey(dest))
            adjList[dest] = new List<int>();

        adjList[src].Add(dest);
        adjList[dest].Add(src);
    }

    public void PrintGraph()
    {
        foreach (var node in adjList)
        {
            Console.Write("Vertex " + node.Key + ":");
            foreach (var edge in node.Value)
            {
                Console.Write(" " + edge);
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph graph = new Graph();
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(2, 5);
        graph.AddEdge(3, 5);
        graph.AddEdge(4, 5);
        graph.AddEdge(4, 6);
        graph.AddEdge(4, 6);
        graph.AddEdge(4, 7);

        graph.PrintGraph();
    }
}
