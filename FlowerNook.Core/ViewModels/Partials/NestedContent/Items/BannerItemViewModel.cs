using FlowerNook.Core.Contexts;
using FlowerNook.Core.Extensions;
using FlowerNook.Core.ViewModels.Shared;
using FlowerNook.Models.Generated;

namespace FlowerNook.Core.ViewModels.Partials.NestedContent.Items
{
	public class BannerItemViewModel : INestedContentViewModel
	{
		public BannerItemViewModel(INestedContentContext<BannerItem> context)
		{
			Title = context.NestedContent.Title;
			Link = context.NestedContent.Link.AsViewModel();
			Background = context.NestedContent.Background.ToViewModel();
		}

		public ImageViewModel Background { get; }
		public string Title { get; }
		public LinkViewModel Link { get; }
	}
}
