using FlowerNook.Core.Contexts;
using FlowerNook.Core.Extensions;
using FlowerNook.Core.ViewModels.Partials.NestedContent.Items;
using FlowerNook.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace FlowerNook.Core.ViewModels.Partials.NestedContent.Widgets
{
	public class BannerWidgetViewModel : IWidgetViewModel
	{
		public BannerWidgetViewModel(INestedContentContext<BannerWidget> context)
		{
			Items = context.NestedContent.Items
				.Select(x => x.AsViewModelWithNestedContentContext<BannerItemViewModel>(context.PageContext));
		}

		public IEnumerable<BannerItemViewModel> Items { get; }
	}
}
