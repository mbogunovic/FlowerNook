using FlowerNook.Core.Contexts;
using FlowerNook.Core.Extensions;
using FlowerNook.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace FlowerNook.Core.ViewModels.Navigation
{
	public class PrimaryNavigationViewModel
	{
		public PrimaryNavigationViewModel(ISiteContext context)
		{
			NavigationNodes = context.Home
				.GetPrimaryNavigationItems<IPage>()
				.Select(n => n.AsNavigationViewModel())
				.ToList();
		}

		public IEnumerable<PrimaryNavigationNodeViewModel> NavigationNodes { get; }
	}
}
