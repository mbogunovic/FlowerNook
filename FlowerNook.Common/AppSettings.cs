using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace FlowerNook.Common
{
	/// <summary>
	/// Enables access to application settings, stored in App.config or Web.config 'appSettings' section.
	/// </summary>
	public static class AppSettings
	{
		public static bool DisableHttpCompression => Get(defaultValue: false);
		public static string XMLSitemapRouteUrl => Get(defaultValue: "xmlsitemap");
		public static string RobotsTxtSource => Get(defaultValue: "File"); // allowed values Cms, File

		// Navigation
		public static int PrimaryNavigationDepthLevel => Get(1);

		/// <summary>
		/// Retrieves configuration value associated with given <paramref name="key"/>.
		/// </summary>
		/// <typeparam name="T">Configuration value type.</typeparam>
		/// <param name="key">Configuration key.</param>
		/// <returns>Configuration value associated with given <paramref name="key"/>.</returns>
		public static T Get<T>([CallerMemberName] string key = null)
		{
			string setting = ConfigurationManager.AppSettings[key];
			if (string.IsNullOrWhiteSpace(setting))
			{
				throw new ConfigurationErrorsException($"Key '{key}' not found in the configuration file!");
			}

			return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(setting);
		}

		/// <summary>
		/// Retrieves configuration value associated with given <paramref name="key"/>.
		/// If value for given <paramref name="key"/> is not found, <paramref name="defaultValue"/> is returned.
		/// </summary>
		/// <typeparam name="T">Configuration value type.</typeparam>
		/// <param name="key">Configuration key.</param>
		/// <param name="defaultValue">Default value.</param>
		/// <returns>Configuration value associated with given <paramref name="key"/>, or <paramref name="defaultValue"/> if given <paramref name="key"/> is not found.</returns>
		public static T Get<T>(T defaultValue, [CallerMemberName] string key = null)
		{
			string setting = ConfigurationManager.AppSettings[key];
			if (string.IsNullOrWhiteSpace(setting))
			{
				return defaultValue;
			}

			return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(setting);
		}
	}
}
