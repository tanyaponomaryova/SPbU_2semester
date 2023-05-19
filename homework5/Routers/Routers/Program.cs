namespace Routers;

internal class Program
{
    static int Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Passed invalid number of arguments.");
            return 0;
        }

        string inputFilePath = args[0];
        string outputFilePath = args[1];

        Graph initialGraph = null!;
        try
        {
            initialGraph = ReadGraphFromFile(inputFilePath);
        }
        catch
        {
            Console.WriteLine("Input file is invalid.");
            return 0;
        }

        var modifiedGraph = initialGraph.BuildMaxSpanningTree();
        if (modifiedGraph == null)
        {
            Console.WriteLine("Graph is not connected.");
            return -1;
        }

        PrintGraphToFile(outputFilePath, modifiedGraph);
        Console.WriteLine("New graph was written in output file.");
        return 0;
    }

    public static Graph ReadGraphFromFile(string filePath)
    {
        using var streamReader = new StreamReader(filePath);
        string? line = streamReader.ReadLine();
        var graph = new Graph();
        while (line != null)
        {
            var splitedLine = line.Split(new char[] { ':', ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var currentVertexNumber = int.Parse(splitedLine[0]);
            var currentVertex = graph.GetNodeByNumber(currentVertexNumber);
            if (currentVertex == null)
            {
                currentVertex = new Vertex(currentVertexNumber);
                graph.AddVertex(currentVertex);
            }

            for (int i = 1; i < splitedLine.Length; i += 2)
            {
                var adjacentVertexNumber = int.Parse(splitedLine[i]);
                var edgeLength = int.Parse(splitedLine[i + 1]);

                var adjacentVertex = graph.GetNodeByNumber(adjacentVertexNumber);
                if (adjacentVertex == null)
                {
                    adjacentVertex = new Vertex(adjacentVertexNumber);
                    graph.AddVertex(adjacentVertex);
                }

                currentVertex.AddAdjacentVertex(adjacentVertex, edgeLength);
                adjacentVertex.AddAdjacentVertex(currentVertex, edgeLength);
            }

            line = streamReader.ReadLine();
        }

        return graph;
    }

    public static void PrintGraphToFile(string filePath, Graph graph)
    {
        using var streamWriter = new StreamWriter(filePath);
        foreach (var vertex in graph.Vertices)
        {
            if (vertex.AdjacentVertices.Count == 0)
            {
                continue;
            }

            streamWriter.Write(vertex.Number.ToString() + ": ");
            var adjacentVerticesCounter = 0;
            foreach (var adjacentVertex in vertex.AdjacentVertices)
            {
                streamWriter.Write(adjacentVertex.Key.Number.ToString() + " (" + adjacentVertex.Value.ToString() + ")");
                adjacentVerticesCounter++;
                if (adjacentVerticesCounter < vertex.AdjacentVertices.Count)
                {
                    streamWriter.Write(", ");
                }
            }

            streamWriter.Write("\n");
        }
    }
}