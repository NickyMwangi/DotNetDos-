``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1848/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11800H 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.304
  [Host]     : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2


```
|  Method | Size |     Mean |   Error |  StdDev |
|-------- |----- |---------:|--------:|--------:|
|     Min | 1000 | 108.5 ns | 2.12 ns | 2.18 ns |
|     Max | 1000 | 102.9 ns | 2.05 ns | 2.52 ns |
| Average | 1000 | 121.9 ns | 2.45 ns | 2.62 ns |
|     Sum | 1000 | 365.0 ns | 4.24 ns | 3.54 ns |
