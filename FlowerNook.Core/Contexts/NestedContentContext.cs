using FlowerNook.Models.DocumentTypes.NestedContent;
using FlowerNook.Models.Generated;

namespace FlowerNook.Core.Contexts
{
	public class NestedContentContext<T> : INestedContentContext<T> where T : INestedContent
	{
		public NestedContentContext(T nestedContent, IPageContext<IPage> pageContext)
		{
			NestedContent = nestedContent;
			PageContext = pageContext;
		}

		public T NestedContent { get; }
		public IPageContext<IPage> PageContext { get; }
	}
}
