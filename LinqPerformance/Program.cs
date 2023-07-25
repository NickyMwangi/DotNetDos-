

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using LinqPerformance;

#region BenchMarks Between .Net6 and .Net7

// For IEnumerables, ICollection and IList
BenchmarkRunner.Run<Linqs>();

// For IEnumerable Min, Max, Sum and Average
BenchmarkRunner.Run<BenchMarkDto>();

#endregion
