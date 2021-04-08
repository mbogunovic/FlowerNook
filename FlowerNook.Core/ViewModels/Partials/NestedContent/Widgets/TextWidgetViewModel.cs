using FlowerNook.Core.Contexts;
using FlowerNook.Core.Extensions;
using FlowerNook.Core.ViewModels.Shared;
using FlowerNook.Models.Generated;
using System.Web;

namespace FlowerNook.Core.ViewModels.Partials.NestedContent.Widgets
{
	public class TextWidgetViewModel : IWidgetViewModel
	{
		public TextWidgetViewModel(INestedContentContext<TextWidget> context)
		{
			Text = context.NestedContent.Text;
			DelimiterImage = context.NestedContent.DelimiterImage.ToViewModel();
		}

		public IHtmlString Text { get; }
		public ImageViewModel DelimiterImage { get; }
	}
}
