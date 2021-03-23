using FlowerNook.Models.Generated;

namespace FlowerNook.Core.Contexts
{
	public interface IPageContext<out T> : ISiteContext where T : class, IPage
	{
		T Page { get; }
	}
}
