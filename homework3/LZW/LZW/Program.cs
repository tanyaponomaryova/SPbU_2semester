using System.Collections;

namespace LZW;

class Program
{
    static void Main(string[] args)
    {
        /*for (int k = 0; k < 50000; k++)
        {
            Random random = new Random();
            int size = random.Next(10, 200);
            var stringToCompress = new char[size];
            for (int i = 0; i < size; i++)
            {
                stringToCompress[i] = (char)random.Next(33, 100);
            }
            for (int j = 0; j < stringToCompress.Length; j++)
            {
                Console.Write(stringToCompress[j]);
            }

            Console.WriteLine();
            
            var resultOfCompression = MyLZW.CompressWithList(stringToCompress);
            (bool isCorrect, var resultOfDecompression) = MyLZW.Decompress(resultOfCompression);

            for (int i = 0; i < stringToCompress.Length; i++)
            {
                if (stringToCompress[i] != resultOfDecompression[i] || stringToCompress.Length != resultOfDecompression.Length || isCorrect == false)
                {
                    Console.WriteLine("WARNING!!!! input string");
                    return;
                }
            }
        }
        var myString = "ABCD";
        var stringToCompress = myString.ToCharArray();
        var resultOfCompression = MyLZW.CompressWithList(stringToCompress);
        (bool isCorrect, var resultOfDecompression) = MyLZW.Decompress(resultOfCompression);*/
        if (args.Length != 2)
        {
            Console.WriteLine("Incorrect input!");
            return;
        }

        if (string.Equals(args[1], "-c"))
        {
            LZW.CompressFile(args[0]);
            Console.WriteLine("Compressed file was created.");
            
            FileInfo notCompressedFile = new FileInfo(args[0]);
            FileInfo compressedFile = new FileInfo(args[0] + ".zipped");
            Console.WriteLine($"Compression coefficient: {notCompressedFile.Length / compressedFile.Length}");
        }
        else if (string.Equals(args[1], "-u"))
        {
            bool isCompressionCorrect = LZW.DecompressFile(args[0]);
            Console.WriteLine(isCompressionCorrect ? "Decompressed file was created." : "Decompression failed :(");
        }
    }
}

