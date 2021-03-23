using System.Web.Mvc;
using FlowerNook.Core.ViewModels.Partials.Layout;

namespace FlowerNook.Core.Controllers.Surface.Partials
{
	public class LayoutController : BaseSurfaceController
	{
		[ChildActionOnly]
		public ActionResult MetaTags(MetaTagsViewModel viewModel) 
			=> PartialView(viewModel);

		[ChildActionOnly]
		public ActionResult OpenGraph(OpenGraphViewModel viewModel)
			=> PartialView(viewModel);

		[ChildActionOnly]
		public ActionResult Header(HeaderViewModel viewModel)
			=> PartialView(viewModel);

		[ChildActionOnly]
		public ActionResult Footer(FooterViewModel viewModel)
			=> PartialView(viewModel);
	}
}
