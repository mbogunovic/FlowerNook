using FlowerNook.Core.Contexts;
using FlowerNook.Models.Generated;

namespace FlowerNook.Core.ViewModels.Pages
{
	public class HomeViewModel : PageViewModel
	{
		public HomeViewModel(IPageContext<Home> context) : base(context)
		{
		}
	}
}
