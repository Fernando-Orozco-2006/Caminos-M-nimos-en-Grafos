using System;
using System.Collections.Generic;
class Graph
{
    private int[,] adjacencyMatrix;
    private int vertices;
    public Graph(int vertices)
    {
        this.vertices = vertices;
        adjacencyMatrix = new int[vertices, vertices];
        for (int i = 0; i < vertices; i++)
        {
            for (int j = 0; j < vertices; j++)
            {
                adjacencyMatrix[i, j] = (i == j) ? 0 : int.MaxValue;
            }
        }
    }
    public void AddEdge(int from, int to, int weight)
    {
        adjacencyMatrix[from, to] = weight;
    }
    public void PrintMatrix()
    {
        for (int i = 0; i < vertices; i++)
        {
            for (int j = 0; j < vertices; j++)
            {
                if (adjacencyMatrix[i, j] == int.MaxValue)
                    Console.Write("INF ");
                else
                    Console.Write(adjacencyMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public void FloydWarshall()
    {
        int[,] dist = (int[,])adjacencyMatrix.Clone();
        for (int k = 0; k < vertices; k++)
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (dist[i, k] != int.MaxValue && dist[k, j] != int.MaxValue)
                    {
                        dist[i, j] = Math.Min(dist[i, j], dist[i, k] + dist[k, j]);
                    }
                }
            }
        }
        adjacencyMatrix = dist;
        Console.WriteLine("Matriz de distancias más cortas (Floyd-Warshall):");
        PrintMatrix();
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Favor de ingresar el número de nodos: ");
        int nodes = int.Parse(Console.ReadLine());
        Graph graph = new Graph(nodes);
        Console.Write("Favor de ingresar el de aristas: ");
        int edges = int.Parse(Console.ReadLine());
        for (int i = 0; i < edges; i++)
        {
            Console.Write("Favor de ingresar el origen, destino y peso: ");
            string[] input = Console.ReadLine().Split();
            if (input.Length < 3)
            {
                Console.WriteLine("Entrada inválida. Debe ingresar tres valores: origen, destino y peso.");
                i--;
                continue;
            }
            if (!int.TryParse(input[0], out int from) || !int.TryParse(input[1], out int to) || !int.TryParse(input[2], out int weight))
            {
                Console.WriteLine("Entrada inválida. Asegúrese de ingresar números enteros.");
                i--;
                continue;
            }
            graph.AddEdge(from, to, weight);
        }
        Console.WriteLine("Matriz de adyacencia:");
        graph.PrintMatrix();
        Console.WriteLine("Ejecutando Floyd-Warshall...");
        graph.FloydWarshall();
    }
}

