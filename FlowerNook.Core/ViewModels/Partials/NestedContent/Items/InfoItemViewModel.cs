using FlowerNook.Core.Contexts;
using FlowerNook.Core.Extensions;
using FlowerNook.Core.ViewModels.Shared;
using FlowerNook.Models.Generated;

namespace FlowerNook.Core.ViewModels.Partials.NestedContent.Items
{
	public class InfoItemViewModel : INestedContentViewModel
	{
		public InfoItemViewModel(INestedContentContext<InfoItem> context)
		{
			Image = context.NestedContent.Image.ToViewModel();
			Title = context.NestedContent.Title;
			Description = context.NestedContent.Description;
			Link = context.NestedContent.Link.AsViewModel();
		}

		public ImageViewModel Image { get; }
		public string Title { get; }
		public string Description { get; }
		public LinkViewModel Link { get; }
	}
}
