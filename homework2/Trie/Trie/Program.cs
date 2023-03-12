namespace Trie;

internal class Program
{
    private static void PrintMessage()
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

    private static void Main()
    {
        Console.WriteLine("This program implements the trie data structure!");
        PrintMessage();
        var trie = new Trie();
        while (true)
        {
            var isCorrectInput = int.TryParse(Console.ReadLine(), out var input) && input >= 0 && input <= 6;
            if (isCorrectInput)
            {
                switch (input)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Enter string to add: ");
                        var str = Console.ReadLine();
                        if (str == null)
                        {
                            Console.WriteLine("Input error.");
                            return;
                        }

                        var isAdded = trie.Add(str);
                        Console.WriteLine(isAdded
                            ? $"String \"{str}\" was added."
                            : $"String \"{str}\" is already in the trie.");
                        break;
                    case 2:
                        Console.WriteLine("Enter string to remove: ");
                        str = Console.ReadLine();
                        if (str == null)
                        {
                            Console.WriteLine("Input error.");
                            return;
                        }

                        var isRemoved = trie.Remove(str);
                        Console.WriteLine(isRemoved
                            ? $"String \"{str}\" is removed."
                            : $"String \"{str}\" is not in the trie.");
                        break;
                    case 3:
                        Console.WriteLine("Enter string to check if it is in the trie: ");
                        str = Console.ReadLine();
                        if (str == null)
                        {
                            Console.WriteLine("Input error.");
                            return;
                        }

                        var isContained = trie.Contains(str);
                        Console.WriteLine(isContained
                            ? $"String \"{str}\" is in the trie."
                            : $"String \"{str}\" is not in the trie.");
                        break;
                    case 4:
                        Console.WriteLine("Enter prefix: ");
                        str = Console.ReadLine();
                        if (str == null)
                        {
                            Console.WriteLine("Input error.");
                            return;
                        }

                        Console.WriteLine($"{trie.HowManyStartsWithPrefix(str)} words start with prefix \"{str}\".");
                        break;
                    case 5:
                        Console.WriteLine($"Trie size equals {trie.Size}.");
                        break;
                    case 6:
                        PrintMessage();
                        break;
                }

                Console.WriteLine("\nEnter next command: ");
            }
            else
            {
                Console.WriteLine("Incorrect input! Try again: ");
            }
        }
    }
}