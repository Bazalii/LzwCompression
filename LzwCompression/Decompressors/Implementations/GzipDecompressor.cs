using System.IO.Compression;
using System.Text;

namespace LzwCompression.Decompressors;

public class GzipDecompressor : IDecompressor
{
    public string Decompress(byte[] input)
    {
        using var source = new MemoryStream(input);
        var lengthBytes = new byte[4];
        source.Read(lengthBytes, 0, 4);

        var length = BitConverter.ToInt32(lengthBytes, 0);
        using var decompressionStream = new GZipStream(source, CompressionMode.Decompress);
        var result = new byte[length];
        decompressionStream.Read(result, 0, length);

        return Encoding.UTF8.GetString(result);
    }

    public override string ToString() => "GzipDecompressor";
}