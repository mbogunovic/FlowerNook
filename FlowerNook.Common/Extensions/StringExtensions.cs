using Newtonsoft.Json;
using System;

namespace FlowerNook.Common.Extensions
{
	public static class StringExtensions
	{
		/// <summary>
		/// Removes (at most one instance of) the <paramref name="removeString"/> string from the end of the <paramref name="source"/> string.
		/// </summary>
		/// <param name="source">The source string.</param>
		/// <param name="removeString">String to remove from the <paramref name="source"/>.</param>
		/// <param name="comparisonType">Determines how <paramref name="source"/> and <paramref name="removeString"/> strings are compared to each other.</param>
		/// <returns><paramref name="source"/> string without <paramref name="removeString"/> at the end.</returns>
		public static string RemoveSuffix(this string source, string removeString, StringComparison comparisonType = StringComparison.CurrentCulture)
		{
			if (string.IsNullOrWhiteSpace(removeString)) return source;

			if (source.EndsWith(removeString, comparisonType))
			{
				source = source.Remove(source.Length - removeString.Length);
			}

			return source;
		}

		public static T TryToDeserializeJson<T>(this string json)
		{
			try
			{
				return JsonConvert.DeserializeObject<T>(json);
			}
			catch (Exception)
			{
				//ignore
			}

			return default(T);
		}

		/// <summary>
		/// Returns empty string if <paramref name="source"/> string is null.
		/// </summary>
		/// <param name="source">The source string.</param>
		/// <returns>Empty string if <paramref name="source"/> is null, otherwise <paramref name="source"/> string.</returns>
		public static string EmptyIfNull(this string source)
			=> source ?? string.Empty;

		/// <summary>
		/// Checks if <paramref name="source"/> string is equal to specified integer value.
		/// </summary>
		/// <param name="source">The source string.</param>
		/// <param name="i">The integer value.</param>
		/// <returns><c>true</c> if <paramref name="source"/> string is equal to specified integer value, otherwise <c>false</c>.</returns>
		public static bool EqualsInt(this string source, int i) // Can't simply be named Equals as extension resolution mechanism will always prefer string.Equals(obj) overload
			=> string.Equals(source, i.ToString());

		/// <summary>
		/// Checks if <paramref name="path"/> string contains given <paramref name="value"/>.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="value">The integer value.</param>
		/// <returns><c>true</c> if <paramref name="path"/> string contains given <paramref name="value"/>, otherwise <c>false</c>.</returns>
		public static bool ContainsValue(this string path, int value, char separator = ',')
			=> Array.Exists(path.SplitWithNullCheck(separator), segment => segment.Trim().EqualsInt(value));

		/// <summary>
		/// Splits <paramref name="source"/> string on specified <paramref name="separators"/>, with null check.
		/// </summary>
		/// <param name="source">The source string.</param>
		/// <param name="separators">The separator(s).</param>
		/// <returns>Array of <paramref name="source"/> segments delimited by specified <paramref name="separators"/>.</returns>
		public static string[] SplitWithNullCheck(this string source, params char[] separators)
			=> source.EmptyIfNull().Split(separators);
	}
}
