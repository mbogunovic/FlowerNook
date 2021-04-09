using FlowerNook.Core.Extensions;
using FlowerNook.Core.ViewModels.Shared;
using FlowerNook.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace FlowerNook.Core.ViewModels.Navigation
{
	public class PrimaryNavigationNodeViewModel
	{
		public PrimaryNavigationNodeViewModel(IPage node)
		{
			IsActive = node.IsActive();
			Link = node.AsLinkViewModel();
			SubNavigation = node.GetNavigationItems<IPage>().Select(x => x.AsNavigationViewModel());
		}

		public bool IsActive { get; }
		public LinkViewModel Link { get; }
		public IEnumerable<PrimaryNavigationNodeViewModel> SubNavigation { get; }
	}
}
