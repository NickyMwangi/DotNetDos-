``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1848/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11800H 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.304
  [Host]   : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2 [AttachedDebugger]
  .NET 6.0 : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2


```
|    Method |      Job |  Runtime |     Mean |    Error |   StdDev | Allocated |
|---------- |--------- |--------- |---------:|---------:|---------:|----------:|
| LogIEnume | .NET 6.0 | .NET 6.0 | 972.7 μs | 18.56 μs | 21.37 μs |     649 B |
| LogIEnume | .NET 7.0 | .NET 7.0 | 963.0 μs | 18.08 μs | 16.91 μs |     648 B |
