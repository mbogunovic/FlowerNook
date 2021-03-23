using FlowerNook.Models.Generated;

namespace FlowerNook.Core.Contexts
{
	public interface ISiteContext
	{
		IPage CurrentPage { get; }
		Home Home { get; }
		ISiteSettings SiteSettings { get; }
	}
}
