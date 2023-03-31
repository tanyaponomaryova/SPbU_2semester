using System.Collections;

namespace LZW;

public static class LZW
{
    /// <summary>
    /// Compresses the file.
    /// </summary>
    /// <param name="path">path to the file you want to compress.</param>
    public static void CompressFile(string path)
    {
        var nameOfCompressedFile = path + ".zipped";
        using FileStream compressedFile = File.Create(nameOfCompressedFile);
        
        byte[] byteArray = File.ReadAllBytes(path);
        int byteArrayIndex = 0;
        
        Trie trie = new Trie();
        for (int i = 0; i < 256; i++)
        {
            trie.AddSymbol((char)i); 
        }
        
        var buffer = new List<bool>();
        int currentBitSequenceLength = 8;

        while (byteArrayIndex < byteArray.Length)
        {
            bool isInTrie = true;
            int currentSequenceNumber = -1;
            int previousSequenceNumber = -1;
            while (isInTrie && byteArrayIndex < byteArray.Length)
            {
                previousSequenceNumber = currentSequenceNumber;
                (isInTrie, currentSequenceNumber) = trie.AddSymbol((char)byteArray[byteArrayIndex]);
                byteArrayIndex++;
            }

            if (isInTrie && byteArrayIndex == byteArray.Length)
            {
                previousSequenceNumber = currentSequenceNumber;
            }
            else
            {
                byteArrayIndex -= 1;
            }

            int digitsCount = 0;
            while (previousSequenceNumber > 0)
            {
                buffer.Add(previousSequenceNumber % 2 == 1);
                previousSequenceNumber /= 2;
                digitsCount++;
            }

            for (int i = 0; i < currentBitSequenceLength - digitsCount; i++)
            {
                buffer.Add(false);
            }

            if (byteArrayIndex == byteArray.Length)
            {
                while (buffer.Count % 8 != 0)
                {
                    buffer.Add(false);
                }
            }

            while (buffer.Count >= 8)
            {
                byte newByte = 0;
                int multiplier = 1;
                for (int i = 0; i < 8; i++)
                {
                    newByte += (byte)(buffer[i] ? multiplier : 0);
                    multiplier *= 2;
                }
            
                buffer.RemoveRange(0, 8);
                compressedFile.WriteByte(newByte);
            }

            if (currentSequenceNumber == (int)Math.Pow(2, currentBitSequenceLength))
            {
                currentBitSequenceLength++;
            }
        }
    }
    
    /// <summary>
    /// Decompresses the file.
    /// </summary>
    /// <param name="path">name of the file you want to decompress.</param>
    /// <returns>true if compression was correct, else false.</returns>
    public static bool DecompressFile(string path)
    {
        byte[] bytesArray = File.ReadAllBytes(path);
        var bitsArray = new BitArray(bytesArray);
        var bitsArrayIndex = 0;
        
        var nameOfDecompressedFile = path.Remove(path.Length - 7);
        using FileStream decompressedFile = File.Create(nameOfDecompressedFile);
        
        var dictionary = new Dictionary<int, string>();
        for (int i = 0; i < 256; i++)
        {
            dictionary.Add(i, char.ToString((char)i));
        }
        
        var currentBitSequenceLength = 8;
        string? previousSequence = null;
        
        while (bitsArrayIndex < bitsArray.Length)
        {
            int multiplier = 1;
            int codeNumber = 0;
            for (int i = 0; i < currentBitSequenceLength; i++)
            {
                if (bitsArrayIndex >= bitsArray.Length)
                {
                    return codeNumber == 0;
                }
                
                codeNumber += (bitsArray[bitsArrayIndex] ? 1 : 0) * multiplier;
                multiplier *= 2;
                bitsArrayIndex++;
            }
            
            var sequenceFromDictionary = dictionary.ContainsKey(codeNumber) ? 
                dictionary[codeNumber] : previousSequence + previousSequence![0];
            
            foreach (var symbol in sequenceFromDictionary)
            {
                decompressedFile.WriteByte((byte)symbol);
            }
            
            if (previousSequence != null)
            {
                dictionary.Add(dictionary.Count, previousSequence + sequenceFromDictionary[0]);
            }
            
            if (dictionary.Count == (int)Math.Pow(2, currentBitSequenceLength))
            {
                currentBitSequenceLength++;
            }
            
            previousSequence = sequenceFromDictionary;
        }

        return true;
    }
}