﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElasticSearch.Client.Domain
{
	public class AnalyzeParams
	{
		public string Index { get; set; }
		public string Field { get; set; }
		public string Analyzer { get; set; }
	}
	public class AnalyzeParams<T> where T : class
	{
		public string Index { get; set; }
		public string Field { get; set; }
		public string Analyzer { get; set; }
	}
}
