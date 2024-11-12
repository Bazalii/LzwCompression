namespace LzwCompression.Benchmarks;

public static class Randomizer
{
    private static readonly Random Random = new();
    private const string Chars = "abcdefghijklmnopqrstuvABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static string CreateRandomString(int length) =>
        new(Enumerable
            .Repeat(Chars, length)
            .Select(s => s[Random.Next(s.Length)])
            .ToArray());
}