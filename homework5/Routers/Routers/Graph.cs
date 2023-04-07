namespace Routers;

public class Graph
{
    public List<Vertex> Vertices { get; }

    public Graph()
    {
        Vertices = new();
    }

    public Graph(List<Vertex> vertices)
    {
        Vertices = vertices;
    }

    public void AddVertex(Vertex vertex)
    {
        Vertices.Add(vertex);
    }

    public Vertex? GetNodeByNumber(int number)
    {
        foreach (var vertex in Vertices)
        {
            if (vertex.Number == number)
            {
                return vertex;
            }
        }

        return null;
    }

    private void DFS(Vertex startVertex, List<Vertex> visitedVertices)
    {
        visitedVertices.Add(startVertex);
        foreach (var adjacentVertex in startVertex.AdjacentVertices.Keys)
        {
            if (!visitedVertices.Contains(adjacentVertex))
            {
                DFS(adjacentVertex, visitedVertices);
            }
        }
    }

    private bool IsGraphConnected()
    {
        var visitedVertices = new List<Vertex>();
        DFS(Vertices[0], visitedVertices);
        return Vertices.Count == visitedVertices.Count;
    }

    public Graph? BuildMaxSpanningTree()
    {
        if (!IsGraphConnected())
        {
            return null;
        }

        var MST = new Graph(); // Maximum Spanning Tree
        MST.AddVertex(new Vertex(Vertices[0].Number));
        var graphVerticesAddedToMST = new List<Vertex>();
        graphVerticesAddedToMST.Add(Vertices[0]);
        
        while (MST.Vertices.Count != Vertices.Count)
        {
            var maxEdgeLength = 0;
            Vertex vertexToAdd = null!;
            Vertex ancestorOfVertexToAdd = null!;
            foreach (var vertex in graphVerticesAddedToMST)
            {
                foreach (var adjacentVertex in vertex.AdjacentVertices)
                {
                    if (!graphVerticesAddedToMST.Contains(adjacentVertex.Key) &&
                        adjacentVertex.Value >= maxEdgeLength)
                    {
                        maxEdgeLength = adjacentVertex.Value;
                        vertexToAdd = adjacentVertex.Key;
                        ancestorOfVertexToAdd = vertex;
                    }
                }
            }

            var vertexToAddWithoutEdges = new Vertex(vertexToAdd.Number);
            var ancestorOfVertexToAddInMST = MST.GetNodeByNumber(ancestorOfVertexToAdd.Number);
            graphVerticesAddedToMST.Add(vertexToAdd);
            MST.AddVertex(vertexToAddWithoutEdges);
            ancestorOfVertexToAddInMST!.AddAdjacentVertex(vertexToAddWithoutEdges, maxEdgeLength);
        }

        return MST;
    }
}