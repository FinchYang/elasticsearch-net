﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Domain;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Cat.CatSegments
{
	public class CatSegmentsUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls()
		{
			await GET("/_cat/segments")
					.Fluent(c => c.CatSegments())
					.Request(c => c.CatSegments(new CatSegmentsRequest()))
					.FluentAsync(c => c.CatSegmentsAsync())
					.RequestAsync(c => c.CatSegmentsAsync(new CatSegmentsRequest()))
				;

			await GET("/_cat/segments/project")
				.Fluent(c => c.CatSegments(r => r.Index<Project>()))
				.Request(c => c.CatSegments(new CatSegmentsRequest(Nest.Indices.Index<Project>())))
				.FluentAsync(c => c.CatSegmentsAsync(r => r.Index<Project>()))
				.RequestAsync(c => c.CatSegmentsAsync(new CatSegmentsRequest(Nest.Indices.Index<Project>())));
		}
	}
}
