using System;
class Graph
{
    private int[,] adjMatrix;
    private int numVertices;

    public Graph(int numVertices)
    {
        this.numVertices = numVertices;
        adjMatrix = new int[numVertices, numVertices];
    }

    public void AddEdge(int i, int j)
    {
        if (i >= 0 && i < numVertices && j > 0 && j < numVertices)
        {
            adjMatrix[i, j] = 1;
            adjMatrix[j, i] = 1;
        }
    }

    public void RemoveEdge(int i, int j)
    {
        if (i >= 0 && i < numVertices && j > 0 && j < numVertices)
        {
            adjMatrix[i, j] = 0;
            adjMatrix[j, i] = 0;
        }
    }

    public void PrintMatrix()
    {
        for (int i = 0; i < numVertices; i++)
        {
            for (int j = 0; j < numVertices; j++)
            {
                Console.Write(adjMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {


        Graph g = new Graph(5);

        g.AddEdge(1, 4);
        
        g.PrintMatrix();
    }
}
