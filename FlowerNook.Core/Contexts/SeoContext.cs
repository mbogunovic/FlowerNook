using System;
using FlowerNook.Models.DocumentTypes;

namespace FlowerNook.Core.Contexts
{
	public class SeoContext<T> : SiteContext, ISeoContext<T> where T : class, ISeo
	{
		public SeoContext(T seo, ISiteContext siteContext) : base(siteContext.UmbracoHelper)
		{
			Seo = seo ?? throw new ArgumentNullException(nameof(seo));
		}

		public T Seo { get; }
	}
}
