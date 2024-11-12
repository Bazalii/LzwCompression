using System.IO.Compression;
using System.Text;

namespace LzwCompression.Compressors;

public class GzipCompressor : ICompressor
{
    public byte[] Compress(string input)
    {
        var bytes = Encoding.UTF8.GetBytes(input);
        using var result = new MemoryStream();
        var lengthBytes = BitConverter.GetBytes(input.Length);
        result.Write(lengthBytes, 0, 4);

        using (var gZipStream = new GZipStream(result, CompressionMode.Compress))
        {
            gZipStream.Write(bytes, 0, input.Length);
            gZipStream.Flush();
        }

        return result.ToArray();
    }

    public override string ToString() => "GzipCompressor";
}