using FlowerNook.Core.Contexts;
using FlowerNook.Models.DocumentTypes.NestedContent;
using FlowerNook.Models.Generated;
using System;

namespace FlowerNook.Core.Extensions
{
	/// <summary>
	/// INestedContent extension methods.
	/// </summary>
	public static class INestedContentExtensions
	{
		/// <summary>
		/// INestedContent extension method for creating context.
		/// </summary>
		public static INestedContentContext<T> CreateNestedContentContext<T>(this T nestedContent, IPageContext<IPage> pageContext) where T : INestedContent
		{
			if (nestedContent == null) return default;

			return (INestedContentContext<T>)Activator.CreateInstance(typeof(NestedContentContext<>).MakeGenericType(nestedContent.GetType()), nestedContent, pageContext);
		}
	}
}
