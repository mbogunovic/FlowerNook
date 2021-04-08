using FlowerNook.Core.Extensions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace FlowerNook.Web.Extensions
{
	/// <summary>
	/// <see cref="HtmlHelper"/> extension methods.
	/// </summary>
	public static class HtmlHelperExtensions
	{
		#region [Render Partial]
		public static void RenderPartial<TViewModel>(this HtmlHelper html, TViewModel model, string partialViewName = null)
		{
			string partialName = !string.IsNullOrWhiteSpace(partialViewName)
				? partialViewName
				: (model?.GetType() ?? typeof(TViewModel)).Name.RemoveViewModelSuffix();

			html.RenderPartial(partialName,
							model,
							new ViewDataDictionary(html.ViewData) { Model = model }); // ViewDataDictionary parameter is necessary to allow passing null for model value.
		}

		public static MvcHtmlString Partial<TViewModel>(this HtmlHelper html, TViewModel model, string partialViewName = null) where TViewModel : class
			=> html.Partial(!string.IsNullOrWhiteSpace(partialViewName) ? partialViewName : (model?.GetType() ?? typeof(TViewModel)).Name.RemoveViewModelSuffix(),
							model,
							new ViewDataDictionary(html.ViewData) { Model = model });   // ViewDataDictionary parameter is necessary to allow passing null for model value.
		#endregion
	}
}