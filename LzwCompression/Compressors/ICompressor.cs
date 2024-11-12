namespace LzwCompression.Compressors;

public interface ICompressor
{
    byte[] Compress(string input);
}