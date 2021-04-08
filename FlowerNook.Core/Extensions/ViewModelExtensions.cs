using Umbraco.Core.Models.PublishedContent;
using FlowerNook.Core.ViewModels.Pages;
using FlowerNook.Core.ViewModels.Shared;
using FlowerNook.Models.DocumentTypes;
using FlowerNook.Models.Generated;
using FlowerNook.Models.DocumentTypes.NestedContent;
using FlowerNook.Core.Contexts;
using System;
using System.Reflection;
using System.Collections.Generic;
using Umbraco.Core;
using Umbraco.Web.Models;
using System.Linq;
using FlowerNook.Core.ViewModels.Partials.NestedContent;

namespace FlowerNook.Core.Extensions
{
	public static class ViewModelExtensions
	{
		public static ImageViewModel ToViewModel(this Image image)
			=> image != null ? new ImageViewModel(image) : default(ImageViewModel);

		public static ImageViewModel TryCreateImageViewModel(this IPublishedContent content)
		{
			return (content as Image)?.ToViewModel();
		}

		#region [Links]

		public static LinkViewModel AsLinkViewModel(this string text) => !text.IsNullOrWhiteSpace() ? new LinkViewModel("", text) : null;
		public static LinkViewModel AsViewModel(this Link link) => link != null ? new LinkViewModel(link) : null;
		public static IEnumerable<LinkViewModel> AsEnumerableOfLinksViewModel(this IEnumerable<Link> links) => links?
			.Select(l => l.AsViewModel());

		#endregion

		public static XMLSitemapItemViewModel ToViewModel(this ISeo page)
			=> page != null ? new XMLSitemapItemViewModel(page) : default(XMLSitemapItemViewModel);

		#region [Models]

		public static TBaseViewModel AsViewModelWithNestedContentContext<TBaseViewModel>(this INestedContent nestedContent, IPageContext<IPage> context, string classSuffix = "ViewModel") where TBaseViewModel : INestedContentViewModel
			=> nestedContent.CreateNestedContentContext(context).AsViewModel<TBaseViewModel>();

		private static TBaseViewModel AsViewModel<TBaseViewModel>(this INestedContentContext<INestedContent> nestedContentContext, string classSuffix = "ViewModel") where TBaseViewModel : INestedContentViewModel
		{
			if (nestedContentContext == null) return default(TBaseViewModel);

			Type baseType = typeof(TBaseViewModel);
			string modelTypeName = $"{baseType.Namespace}.{nestedContentContext.NestedContent.GetType().Name}{classSuffix}";

			return (TBaseViewModel)Activator.CreateInstance(Assembly.GetAssembly(baseType).GetType(modelTypeName), nestedContentContext);
		}

		#endregion

	}
}
