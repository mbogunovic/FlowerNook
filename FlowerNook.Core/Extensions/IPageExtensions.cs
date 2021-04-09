using FlowerNook.Common;
using FlowerNook.Common.Extensions;
using FlowerNook.Models.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web;
using Umbraco.Web.Composing;

namespace FlowerNook.Core.Extensions
{
	public static class IPageExtensions
	{
		/// <summary>
		/// Returns navigation items for the provided <paramref name="node"/>.
		/// </summary>
		/// <typeparam name="T">Type of the navigation items to return.</typeparam>
		/// <param name="node">The navigation node.</param>
		/// <returns>Navigation items for the provided <paramref name="node"/>.</returns>
		public static IEnumerable<T> GetNavigationItems<T>(this IPage node) where T : class, IPage
			=> node.Children<T>(c => !c.UmbracoNaviHide);

		/// <summary>
		/// Returns navigation items for the provided <paramref name="node"/> depending on specified max level of navigation items.
		/// </summary>
		/// <typeparam name="T">Type of the navigation items to return.</typeparam>
		/// <param name="node">The navigation node.</param>
		/// <param name="maxLevel">The max level of navigation items.</param>
		/// <returns>Navigation items if <paramref name="node"/> level is less than specified max level, otherwise empty sequence.</returns>
		public static IEnumerable<T> GetNavigationItems<T>(this IPage node, int maxLevel) where T : class, IPage
			=> (node?.Level ?? int.MaxValue) < maxLevel ? node.GetNavigationItems<T>() : Enumerable.Empty<T>();

		/// <summary>
		/// Returns primary navigation items from the provided node.
		/// </summary>
		/// <typeparam name="T">Type of the navigation items to return.</typeparam>
		/// <param name="node">The node.</param>
		/// <returns>Primary navigation items.</returns>
		public static IEnumerable<T> GetPrimaryNavigationItems<T>(this IPage node) where T : class, IPage
			=> (node?.Level ?? int.MaxValue) < (AppSettings.PrimaryNavigationDepthLevel) ? node.GetNavigationItems<T>() : Enumerable.Empty<T>();

		/// <summary>
		/// Checks if provided <paramref name="node"/> is active for navigation purposes.
		/// </summary>
		/// <param name="node">The navigation node.</param>
		/// <returns><c>true</c> if <paramref name="node"/> is considered as active, otherwise <c>false</c>.</returns>
		public static bool IsActive(this IPage node)
			=> Current.UmbracoContext?.PublishedRequest?.PublishedContent?.Path.ContainsValue(node.Id) ?? false;
	}
}
