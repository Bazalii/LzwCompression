namespace LzwCompression.Compressors;

public class LzwCompressor : ICompressor
{
    private const int MaxDictionarySize = short.MaxValue;

    public byte[] Compress(string input)
    {
        var dictionary = new Dictionary<string, short>(MaxDictionarySize);
        for (short i = 0; i < 256; i++)
        {
            dictionary.Add(((char)i).ToString(), i);
        }

        var w = string.Empty;
        var compressed = new List<byte>(input.Length * 2);

        foreach (var c in input)
        {
            var wc = w + c;
            if (dictionary.ContainsKey(wc))
            {
                w = wc;
            }
            else
            {
                compressed.AddRange(BitConverter.GetBytes(dictionary[w]));
                
                if (dictionary.Count < MaxDictionarySize)
                {
                    dictionary.Add(wc, (short)dictionary.Count);
                }

                w = c.ToString();
            }
        }
        
        if (string.IsNullOrEmpty(w) is false)
        {
            compressed.AddRange(BitConverter.GetBytes(dictionary[w]));
        }

        return compressed.ToArray();
    }

    public override string ToString() => "LzwCompressor";
}