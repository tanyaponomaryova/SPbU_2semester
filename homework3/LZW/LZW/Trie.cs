namespace LZW;

/// <summary>
/// Trie data structure with possibility of character-by-character addition and a pointer to the current node.
/// </summary>
public class Trie
{
    private class Node
    {
        public Dictionary<char, Node> Children { get; set; }
        
        public int Number { get; }

        public Node(int number)
        {
            Number = number;
            Children = new Dictionary<char, Node>();
        }
    }
    
    private Node root;
    
    private Node currentNodePointer;

    private int numberOfSequences = 0;
    
    /// <summary>
    /// Initializes new instance of Trie class.
    /// </summary>
    public Trie()
    {
        root = new Node(-1);
        currentNodePointer = root;
    }

    /// <summary>
    /// Adds char type element to trie.
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns>true and number of sequence if sequence from current node
    /// and given symbol are already in trie, else false and number of new sequence.</returns>
    public (bool isInTree, int elementNumber) AddSymbolWithPointer(char symbol)
    {
        bool isInTree = true;
        int elementNumber = 0;
        
        if (!currentNodePointer.Children.ContainsKey(symbol))
        {
            currentNodePointer.Children.Add(symbol, new Node(numberOfSequences));
            isInTree = false;
            elementNumber = numberOfSequences;
            currentNodePointer = root;
            numberOfSequences++;
        }
        else
        {
            currentNodePointer = currentNodePointer.Children[symbol];
            elementNumber = currentNodePointer.Number;
        }

        return (isInTree, elementNumber);
    }
}