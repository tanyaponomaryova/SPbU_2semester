namespace ConsoleApp1
{
    internal class Program
    {
        public class Trie
        {
            private class TrieNode
            {
                public Dictionary<char, TrieNode> Children { get; }
                public bool IsTerminal { get; set; }

                public TrieNode()
                {
                    Children = new Dictionary<char, TrieNode>();
                    IsTerminal = false;
                }
            }

            private TrieNode root;

            public int Size { get; private set; }
            
            public Trie()
            {
                root = new TrieNode();
            }

            public void Add(string word)
            {
                TrieNode current = root;
                foreach (char symbol in word) // символ конца строки не учитывает
                {
                    if (!current.Children.ContainsKey(symbol)) // если такого символа нет
                    {
                        current.Children.Add(symbol, new TrieNode()); // то создаем "ветку" с этим символом
                        Size++;
                    }

                    current = current.Children[symbol]; // для обращания к элементам словаря в скобках указывают ключ
                }

                current.IsTerminal = true;
            }

            public bool Contains(string word)
            {
                TrieNode current = root;
                foreach (char symbol in word)
                {
                    if (!current.Children.TryGetValue(symbol, out TrieNode nextNode))
                    {
                        return false;
                    }

                    current = nextNode;
                }

                return current.IsTerminal;
            }
            
            public bool Remove(string word)
            {
                bool isRemoved = false;
                RecursiveRemove(root, word, 0, isRemoved);
                return isRemoved;
            }

            private bool RecursiveRemove(TrieNode current, string word, int index, bool isRemoved) // возвращает нужно ли удалить текущий узел
            {
                if (index == word.Length)
                {
                    if (!current.IsTerminal) // искомое слово есть как префикс какого-то другого слова
                    {
                        return false;
                    }

                    current.IsTerminal = false;
                    isRemoved = true;
                    return current.Children.Count == 0; // если есть дети - узлы выше не удаляем, иначе если нет детей (лист) узлы выше можно спокойно удалять
                }
                
                if (!current.Children.TryGetValue(word[index], out TrieNode nextNode)) // нет окончания слова
                {
                    return false;
                }

                bool shouldDeleteCurrentNode = RecursiveRemove(nextNode, word, index + 1, isRemoved) && !current.IsTerminal;  // лист удаляем, иначе оставляем
                if (shouldDeleteCurrentNode)
                {
                    current.Children.Remove(word[index]);
                    Size--;
                    return current.Children.Count == 0;
                }

                return false;
            }

            public int HowManyStartsWithPrefix(string prefix)
            {
                TrieNode current = root;
                for (int i = 0; i < prefix.Length; i++)
                {
                    if (!current.Children.TryGetValue(prefix[i], out TrieNode nextNode))
                    {
                        return 0;
                    }

                    current = nextNode;
                }

                return HowManyLeaves(current);
            }
            
            private int HowManyLeaves(TrieNode current)
            {
                int result = 0;

                if (current.IsTerminal)
                {
                    result++;
                }

                foreach (var child in current.Children)
                {
                    result += HowManyLeaves(child.Value);
                }

                return result;
            }
        }

        static void PrintMessage()
        {
            Console.WriteLine("Enter: " +
                              "\n0 - to exit," +
                              "\n1 - to add string, " +
                              "\n2 - to remove entered string, " +
                              "\n3 - to check if trie contains entered string, " +
                              "\n4 - to find out how many strings start with entered prefix, " +
                              "\n5 - to find out the size of the trie, " +
                              "\n6 - to print commands.");
        }
        
        public static void Main()
        {
            Console.WriteLine("This program implements the trie data structure!");
            PrintMessage();
            Trie trie = new Trie();
            while (true)
            {
                bool isCorrectInput = int.TryParse(Console.ReadLine(), out int input);
                if (isCorrectInput && input >= 0 && input <= 6)
                {
                    switch (input)
                    {
                        case 0:
                            return;
                        case 1:
                            Console.WriteLine("Enter string: ");
                            string str = Console.ReadLine();
                            trie.Add(str);
                            Console.WriteLine($"String {str} was added.");
                            break;
                        case 2:
                            Console.WriteLine("Enter string: ");
                            str = Console.ReadLine();
                            bool isRemoved = trie.Remove(str);
                            if (isRemoved)
                            {
                                Console.WriteLine($"String {str} is removed.");
                            }
                            else
                            {
                                Console.WriteLine($"String {str} is not in the trie.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter string: ");
                            str = Console.ReadLine();
                            bool contains = trie.Contains(str);
                            if (contains)
                            {
                                Console.WriteLine($"String {str} is in the trie.");
                            }
                            else
                            {
                                Console.WriteLine($"String {str} is not in the trie.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter prefix: ");
                            str = Console.ReadLine();
                            Console.WriteLine($"{trie.HowManyStartsWithPrefix(str)} words start with prefix {str}.");
                            break;
                        case 5:
                            Console.WriteLine($"Trie size equals {trie.Size}.");
                            break;
                        case 6:
                            PrintMessage();
                            break;
                    }

                    Console.WriteLine("Enter next command: ");
                }
                else
                {
                    Console.WriteLine("Incorrect input! Try again: ");
                }
            }
        }
    }
}