using System;
using Umbraco.Web;
using FlowerNook.Core.Extensions;
using FlowerNook.Core.ViewModels.Shared;
using FlowerNook.Models.Generated;

namespace FlowerNook.Core.ViewModels.Partials.Layout
{
	public class HeaderViewModel
	{
		public HeaderViewModel(IHeader header)
		{
			if (header == null) throw new ArgumentNullException(nameof(header));

			Logo = header.Logo.ToViewModel();
			LogoUrl = header.AncestorOrSelf<Home>().Url;
		}

		public ImageViewModel Logo { get; }
		public string LogoUrl { get; }
	}
}
