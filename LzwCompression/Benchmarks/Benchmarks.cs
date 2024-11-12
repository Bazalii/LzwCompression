using BenchmarkDotNet.Attributes;
using LzwCompression.Compressors;
using LzwCompression.Decompressors;

namespace LzwCompression.Benchmarks;

[HtmlExporter]
public class Benchmarks
{
    private static readonly LzwCompressor LzwCompressor = new();
    private static readonly LzwDecompressor LzwDecompressor = new();
    private static readonly GzipCompressor GzipCompressor = new();
    private static readonly GzipDecompressor GzipDecompressor = new();

    private static readonly string RandomString1 = Randomizer.CreateRandomString(100);
    private static readonly string RandomString2 = Randomizer.CreateRandomString(10_000);
    private static readonly string RandomString3 = Randomizer.CreateRandomString(1_000_000);

    public static object[][] CompressionPairs => new object[][]
    {
        [LzwCompressor, BenchmarkConstants.LongString1],
        [GzipCompressor, BenchmarkConstants.LongString1],
        [LzwCompressor, BenchmarkConstants.LongString2],
        [GzipCompressor, BenchmarkConstants.LongString2],
    };

    public static object[][] CompressionAndDecompressionArgs => new object[][]
    {
        [LzwCompressor, LzwDecompressor, BenchmarkConstants.ShortString1],
        [GzipCompressor, GzipDecompressor, BenchmarkConstants.ShortString1],
        [LzwCompressor, LzwDecompressor, BenchmarkConstants.LongString1],
        [GzipCompressor, GzipDecompressor, BenchmarkConstants.LongString1],
        [LzwCompressor, LzwDecompressor, BenchmarkConstants.LongString2],
        [GzipCompressor, GzipDecompressor, BenchmarkConstants.LongString2],
        [LzwCompressor, LzwDecompressor, RandomString1],
        [GzipCompressor, GzipDecompressor, RandomString1],
        [LzwCompressor, LzwDecompressor, RandomString2],
        [GzipCompressor, GzipDecompressor, RandomString2],
    };

    [Benchmark]
    [ArgumentsSource(nameof(CompressionPairs))]
    public byte[] Compression(
        ICompressor compressor,
        string input)
    {
        return compressor.Compress(input);
    }

    [Benchmark]
    [ArgumentsSource(nameof(CompressionAndDecompressionArgs))]
    public string CompressionAndDecompression(
        ICompressor compressor,
        IDecompressor decompressor,
        string input)
    {
        var compressionResult = compressor.Compress(input);

        return decompressor.Decompress(compressionResult);
    }

    public static void RunCorrectnessBenchmarks()
    {
        // Проверяем корректность работы Lzw сжатия
        RunCorrectnessBenchmark(LzwCompressor, LzwDecompressor, BenchmarkConstants.Text2);
        
        // Проверяем корректность работы Gzip сжатия
        RunCorrectnessBenchmark(GzipCompressor, GzipDecompressor, BenchmarkConstants.Text2);
    }

    private static void RunCorrectnessBenchmark(
        ICompressor compressor,
        IDecompressor decompressor,
        string input)
    {
        var compressedBytes = compressor.Compress(input);
        var decompressedString = decompressor.Decompress(compressedBytes);

        var algorithmCheck = decompressedString == input;
        Console.WriteLine($"{compressor} сжатие работает: {algorithmCheck}");
    }

    public static void RunLengthBenchmarks()
    {
        // Тестируем хорошую для Lzw строку
        RunLengthBenchmark(BenchmarkConstants.LongString1);
        
        // Тестируем рандомную строку
        RunLengthBenchmark(RandomString1);
        
        // Тестируем рандомную строку
        RunLengthBenchmark(RandomString2);
        
        // Тестируем рандомную строку
        RunLengthBenchmark(RandomString3);
        
        // Тестируем хороший для LZW текст
        RunLengthBenchmark(BenchmarkConstants.Text1);
    }

    private static void RunLengthBenchmark(string input)
    {
        Console.WriteLine($"Длина исходной строки: {input.Length}");

        var compressedLzwBytes = LzwCompressor.Compress(input);
        Console.WriteLine($"Длина закодированной строки Lzw: {compressedLzwBytes.Length}");

        var compressedGzipBytes = GzipCompressor.Compress(input);
        Console.WriteLine($"Длина закодированной строки Gzip: {compressedGzipBytes.Length}");
    }
}