﻿using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Running;
using System;

namespace Haken.PerformanceTuningDotnetCoreDemos.CodingAndAlgorithms
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//BenchmarkRunner.Run<StringConcatenationBenchmarks>();
			BenchmarkRunner.Run<SearchInCollectionBenchmarks>();
		}
	}
}
