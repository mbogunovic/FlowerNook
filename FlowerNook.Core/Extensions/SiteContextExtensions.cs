using System;
using FlowerNook.Core.Contexts;
using FlowerNook.Models.DocumentTypes;

namespace FlowerNook.Core.Extensions
{
	public static class SiteContextExtensions
	{
		public static ISeoContext<T> CreateSeoContext<T>(this ISiteContext context, T seo) where T : class, ISeo
		{
			if (seo == null) return default(ISeoContext<T>);

			return (ISeoContext<T>) Activator.CreateInstance(typeof(SeoContext<>).MakeGenericType(seo.GetType()), seo, context);
		}
	}
}
