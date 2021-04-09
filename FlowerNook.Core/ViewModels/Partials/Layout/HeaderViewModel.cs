using System;
using Umbraco.Web;
using FlowerNook.Core.Extensions;
using FlowerNook.Core.ViewModels.Shared;
using FlowerNook.Models.Generated;
using FlowerNook.Core.ViewModels.Navigation;
using FlowerNook.Core.Contexts;

namespace FlowerNook.Core.ViewModels.Partials.Layout
{
	public class HeaderViewModel
	{
		public HeaderViewModel(IPageContext<IPage> context)
		{
			if (context == null) throw new ArgumentNullException(nameof(context));

			Logo = context.Home.Logo.ToViewModel();
			LogoUrl = context.Home.AncestorOrSelf<Home>().Url;
			Navigation = new PrimaryNavigationViewModel(context);
		}

		public ImageViewModel Logo { get; }
		public string LogoUrl { get; }
		public PrimaryNavigationViewModel Navigation { get; }
	}
}
