using BenchmarkDotNet.Running;
using TestesBenchmark.Tests;

namespace TestesBenchmark
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<NewtonsoftVsSystemTextJson>();
        }
    }
}
