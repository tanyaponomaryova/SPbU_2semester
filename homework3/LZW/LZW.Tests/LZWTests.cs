namespace LZW.Tests;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void CompressAndDecompressTextFile()
    {
        var nameOfFileToCompress = @"..\..\..\TestTextFile.txt";
        var nameOfFileToCompareWith = @"..\..\..\TestTextFileToCompareWith.txt";
        LZW.CompressFile(nameOfFileToCompress);
        bool isDecompressionCorrect = LZW.DecompressFile(nameOfFileToCompress + ".zipped");
        byte[] initialFileBytes = File.ReadAllBytes(nameOfFileToCompareWith);
        byte[] decompressedFileBytes = File.ReadAllBytes(nameOfFileToCompress);
        
        Assert.IsTrue(isDecompressionCorrect);
        Assert.AreEqual(initialFileBytes.Length, decompressedFileBytes.Length);
        
        for (int i = 0; i < initialFileBytes.Length; i++)
        {
            Assert.AreEqual(initialFileBytes[i], decompressedFileBytes[i]);
        }
    }
}