namespace Routers;

public class Vertex
{
    public Vertex(int number)
    {
        Number = number;
        AdjacentVertices = new();
    }

    public Vertex(int number, Dictionary<Vertex, int> adjacentVertices)
    {
        Number = number;
        AdjacentVertices = adjacentVertices;
    }
    
    public int Number { get; }
    public Dictionary<Vertex, int> AdjacentVertices { get; }

    public void AddAdjacentVertex(Vertex vertex, int edgeLength)
    {
        AdjacentVertices.Add(vertex, edgeLength);
    }
}