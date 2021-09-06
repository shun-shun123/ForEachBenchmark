using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;

namespace ForEach
{
    public class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig()
        {
            AddExporter(MarkdownExporter.GitHub);
            AddDiagnoser(MemoryDiagnoser.Default);

            AddJob(Job.Default);
        }
    }


    [Config(typeof(BenchmarkConfig))]
    public class ForEachBenchmark
    {
        private const int DATA_SIZE = 100_000;

        private const int TRY_COUNT = 100;

        private int[] _sampleArray;

        private IEnumerable<int> _sampleEnumerable;

        [GlobalSetup]
        public void Setup()
        {
            var rand = new Random();
            _sampleArray = Enumerable.Range(0, DATA_SIZE).ToArray();
            _sampleEnumerable = Enumerable.Range(0, DATA_SIZE).ToArray();
        }

        [Benchmark]
        public void ArrayForEach()
        {
            foreach (var i in _sampleArray)
            {
                
            }
        }

        [Benchmark]
        public void IEnumerableForEach()
        {
            foreach (var i in _sampleEnumerable)
            {
            }
        }
    }
}