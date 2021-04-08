using FlowerNook.Core.Contexts;
using FlowerNook.Core.Extensions;
using FlowerNook.Core.ViewModels.Partials.NestedContent.Items;
using FlowerNook.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace FlowerNook.Core.ViewModels.Partials.NestedContent.Widgets
{
	public class InfoWidgetViewModel : IWidgetViewModel
	{
		public InfoWidgetViewModel(INestedContentContext<InfoWidget> context)
		{
			Items = context.NestedContent.Items
				.Select(x => x.AsViewModelWithNestedContentContext<InfoItemViewModel>(context.PageContext));
		}

		public IEnumerable<InfoItemViewModel> Items { get; }
	}
}
