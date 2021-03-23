using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using FlowerNook.Core.ViewModels.Pages;
using FlowerNook.Core.ViewModels.Partials.Listing;
using FlowerNook.Core.ViewModels.Shared;
using FlowerNook.Models.DocumentTypes;
using FlowerNook.Models.Generated;

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

		public static XMLSitemapItemViewModel ToViewModel(this ISeo page)
			=> page != null ? new XMLSitemapItemViewModel(page) : default(XMLSitemapItemViewModel);

	}
}
