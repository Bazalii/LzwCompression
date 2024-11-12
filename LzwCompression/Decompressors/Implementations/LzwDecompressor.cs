using System.Text;

namespace LzwCompression.Decompressors;

public class LzwDecompressor : IDecompressor
{
    public string Decompress(byte[] input)
    {
        var dictionary = new Dictionary<short, string>();
        for (short i = 0; i < 256; i++)
        {
            dictionary.Add(i, ((char)i).ToString());
        }

        var index = 0;
        var compressed = GetCompressedValues(input);
        var w = dictionary[compressed[index]];

        index++;
        var decompressed = new StringBuilder(w);

        for (; index < compressed.Length; index++)
        {
            var k = compressed[index];
            var entry = dictionary.TryGetValue(k, out var value)
                ? value
                : w + w[0];

            decompressed.Append(entry);

            dictionary.Add((short)dictionary.Count, w + entry[0]);

            w = entry;
        }

        return decompressed.ToString();
    }

    private short[] GetCompressedValues(byte[] compressed)
    {
        var result = new short[compressed.Length / 2];
        var resultIndex = 0;

        for (var i = 0; i < compressed.Length; i += 2)
        {
            var currentValue = BitConverter.ToInt16(compressed.AsSpan()[i..(i + 2)]);
            result[resultIndex++] = currentValue;
        }

        return result;
    }

    public override string ToString() => "LzwDecompressor";
}