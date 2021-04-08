using FlowerNook.Models.Generated;
using Umbraco.Web;

namespace FlowerNook.Core.Contexts
{
	/// <summary>
	/// Site context containing information about the site.
	/// </summary>
	public interface ISiteContext
	{
		IPage CurrentPage { get; }
		Home Home { get; }
		UmbracoHelper UmbracoHelper { get; }
		string GetDictionaryValue(string key);
		ISiteSettings SiteSettings { get; }
	}
}
