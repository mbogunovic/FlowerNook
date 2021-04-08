using System.Collections.Generic;
using System.Linq;

namespace FlowerNook.Common.Extensions
{
	/// <summary>
	/// Extensions that can be used globaly on object type
	/// </summary>
	public static class GlobalExtensions
	{
		/// <summary>
		/// Checks if object isn't null and does it have some value (elements if IEnumerable)
		/// </summary>
		/// <param name="source">The source (object).</param>
		/// <returns>boolean true/false</returns>
		public static bool HasValue(this object obj)
		{
			return (obj as IEnumerable<object>)?.Any() ?? obj != null && !string.IsNullOrWhiteSpace(obj.ToString());
		}
	}
}
