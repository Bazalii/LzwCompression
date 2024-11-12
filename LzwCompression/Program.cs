using BenchmarkDotNet.Running;
using LzwCompression.Benchmarks;

Benchmarks.RunCorrectnessBenchmarks();
Benchmarks.RunLengthBenchmarks();
BenchmarkRunner.Run<Benchmarks>();