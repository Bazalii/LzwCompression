namespace LzwCompression.Decompressors;

public interface IDecompressor
{
    string Decompress(byte[] input);
}