namespace Trie;

/// <summary>
/// Trie data structure.
/// </summary>
public class Trie
{
    private readonly TrieNode root = new();
    
    private class TrieNode
    {
        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            IsTerminal = false;
        }

        public Dictionary<char, TrieNode> Children { get; }
        public bool IsTerminal { get; set; }
        public int HowManyWordsWithThisPrefix { get; set; }
    }

    /// <summary>
    /// Gets the size (word count) of the trie.
    /// </summary>
    public int Size 
        => root.HowManyWordsWithThisPrefix;

    /// <summary>
    /// Adds word to the trie.
    /// </summary>
    /// <param name="word">string to add.</param>
    /// <returns>true if word hasn't been previously consisted in the trie, else false.</returns>
    public bool Add(string word)
    {
        if (Contains(word)) 
            return false;

        var current = root;
        current.HowManyWordsWithThisPrefix++;
        foreach (var symbol in word)
        {
            if (!current.Children.ContainsKey(symbol)) 
                current.Children.Add(symbol, new TrieNode());

            current = current.Children[symbol];
            current.HowManyWordsWithThisPrefix++;
        }

        return current.IsTerminal = true;
    }

    /// <summary>
    /// Checks the existence of a string in the trie.
    /// </summary>
    /// <param name="word">string to check.</param>
    /// <returns>true if string is in the trie, else false.</returns>
    public bool Contains(string word)
    {
        var current = root;
        foreach (var symbol in word)
        {
            if (!current.Children.TryGetValue(symbol, out var nextNode)) 
                return false;

            current = nextNode;
        }

        return current.IsTerminal;
    }

    /// <summary>
    /// Removes string from the trie.
    /// </summary>
    /// <param name="word">string to remove</param>
    /// <returns>true if element has been contained in the trie, else false.</returns>
    public bool Remove(string word)
    {
        if (!Contains(word)) 
            return false;
        RecursiveRemove(root, word, 0);
        return true;
    }

    private bool RecursiveRemove(TrieNode current, string word, int index)
    {
        current.HowManyWordsWithThisPrefix--;
        if (index == word.Length)
        {
            if (!current.IsTerminal)
                return false;

            current.IsTerminal = false;
            return current.Children.Count == 0; 
        }

        var nextNode = current.Children[word[index]];

        var shouldDeleteCurrentNode = 
            RecursiveRemove(nextNode, word, index + 1) && !current.IsTerminal;
        
        if (shouldDeleteCurrentNode)
        {
            current.Children.Remove(word[index]);
            return current.Children.Count == 0;
        }
        
        return false;
    }

    /// <summary>
    /// Counts the number of trie elements that start with a given prefix.
    /// </summary>
    /// <param name="prefix">prefix string to check.</param>
    /// <returns>number of trie elements that start with a given prefix.</returns>
    public int HowManyStartsWithPrefix(string prefix)
    {
        var current = root;
        foreach (char symbol in prefix)
        {
            if (!current.Children.TryGetValue(symbol, out var nextNode)) 
                return 0;

            current = nextNode;
        }

        return current.HowManyWordsWithThisPrefix;
    }
}