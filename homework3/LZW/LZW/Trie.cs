namespace LZW;
public class Trie
{
    private Node root;

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
    
    private Node currentNode;
    
    private int numberForNewNode;

    public Trie()
    {
        root = new Node(-1);
        currentNode = root;
        numberForNewNode = -1;
    }

    /// <summary>
    /// Adds chat type element to trie.
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns>true and number of sequence if sequence from current node
    /// and given symbol is already in trie, else false and number of new sequence.</returns>
    public (bool isInTree, int elementNumber) AddSymbol(char symbol)
    {
        bool isInTree = true;
        int elementNumber = 0;
        
        if (!currentNode.Children.ContainsKey(symbol))
        {
            numberForNewNode++;
            var newNode = new Node(numberForNewNode);
            currentNode.Children[symbol] = newNode;

            isInTree = false;
            elementNumber = numberForNewNode;

            currentNode = root;
        }
        else
        {
            currentNode = currentNode.Children[symbol];
            elementNumber = currentNode.Number;
        }

        return (isInTree, elementNumber);
    }
}