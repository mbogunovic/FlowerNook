using FlowerNook.Models.DocumentTypes.NestedContent;
using FlowerNook.Models.Generated;

namespace FlowerNook.Core.Contexts
{
	/// <summary>
	/// Nested Content Context containing information about the Nested Content item, page containing it and site information.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface INestedContentContext<out T> where T : INestedContent
	{
		T NestedContent { get; }
		IPageContext<IPage> PageContext { get; }
	}
}
