``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1848/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11800H 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.304
  [Host]   : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2 [AttachedDebugger]
  .NET 6.0 : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2


```
|  Method |      Job |  Runtime | Size |      Mean |    Error |    StdDev | Allocated |
|-------- |--------- |--------- |----- |----------:|---------:|----------:|----------:|
|     Min | .NET 6.0 | .NET 6.0 |  100 | 370.09 ns | 7.103 ns |  9.483 ns |      32 B |
|     Max | .NET 6.0 | .NET 6.0 |  100 | 351.16 ns | 5.413 ns |  5.063 ns |      32 B |
| Average | .NET 6.0 | .NET 6.0 |  100 | 368.19 ns | 4.968 ns |  4.647 ns |      32 B |
|     Sum | .NET 6.0 | .NET 6.0 |  100 | 352.46 ns | 6.961 ns | 10.203 ns |      32 B |
|     Min | .NET 7.0 | .NET 7.0 |  100 |  13.70 ns | 0.259 ns |  0.230 ns |         - |
|     Max | .NET 7.0 | .NET 7.0 |  100 |  11.67 ns | 0.219 ns |  0.215 ns |         - |
| Average | .NET 7.0 | .NET 7.0 |  100 |  15.78 ns | 0.331 ns |  0.442 ns |         - |
|     Sum | .NET 7.0 | .NET 7.0 |  100 |  44.19 ns | 0.236 ns |  0.221 ns |         - |
