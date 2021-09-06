using BenchmarkDotNet.Running;
using ForEach;

namespace ForEachPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new[]
            {
                typeof(ForEachBenchmark)
            });
            switcher.Run(args);
        }
    }
}
