using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace FlowerNook.Core.Extensions
{
	public static class IPublishedContentExtensions
	{
		/// <summary>
		/// Returns children of the <paramref name="source"/>, of the given type <see cref="{T}"/>, that satisfy provided <paramref name="predicate"/>.
		/// </summary>
		/// <typeparam name="T">Type of the children to return.</typeparam>
		/// <param name="source">The source.</param>
		/// <param name="predicate">The predicate that child has to satisfy.</param>
		/// <returns>Children of given type <see cref="{T}"/>, that satisfy provided <paramref name="predicate"/>.</returns>
		public static IEnumerable<T> Children<T>(this IPublishedContent source, Func<T, bool> predicate) where T : class, IPublishedContent
			=> source?.Children<T>().Where(c => predicate(c)) ?? Enumerable.Empty<T>();
	}
}
