using FlowerNook.Models.Generated;

namespace FlowerNook.Models.Extensions
{
	public static class PageExtensions
	{
		public static string PageTitle(this IPage page)
		{
			return page.GetPropertyWithDefaultValue(page.Name);
		}

		public static bool IsHome(this IPage page)
		{
			return page.ContentType.Alias == Home.ModelTypeAlias;
		}
	}
}
