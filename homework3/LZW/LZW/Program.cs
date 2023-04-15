using System.Collections;
using System.Drawing;

namespace LZW;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nIncorrect input! Arguments must be file path and key -c or -u to compress and decompress file respectively.\n");
            Console.ResetColor();
            return;
        }

        if (!File.Exists(args[0]))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nFile path is invalid.\n");
            Console.ResetColor();
            return;
        }

        if (string.Equals(args[1], "-c"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            LZW.CompressFile(args[0]);
            Console.WriteLine($"\nCompressed file {args[0]}.zipped was created.");
            FileInfo notCompressedFile = new FileInfo(args[0]);
            FileInfo compressedFile = new FileInfo(args[0] + ".zipped");
            Console.WriteLine($"\nCompression coefficient (size of initial file / size of compressed file): {(float)notCompressedFile.Length / (float)compressedFile.Length}.\n");
        }
        else if (string.Equals(args[1], "-u"))
        {
            if (!args[0].EndsWith(".zipped"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nFile for decompression is invalid. File must be called \"*.zipped\".\n");
                Console.ResetColor();
                return;
            }
            bool isCompressionCorrect = LZW.DecompressFile(args[0]);
            if (isCompressionCorrect)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nDecompressed file {args[0].Remove(args[0].Length - 7)} was created.\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Decompression failed :(\n");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nKey must be -c or -u to compress and decompress file respectively.\n");
        }
        
        Console.ResetColor();
    }
}

