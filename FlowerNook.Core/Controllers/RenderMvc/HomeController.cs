using System.Web.Mvc;
using FlowerNook.Core.ViewModels.Pages;
using FlowerNook.Models.Generated;

namespace FlowerNook.Core.Controllers.RenderMvc
{
	public class HomeController : BasePageController<Home>
	{
		public ActionResult Index(Home model) 
			=> CurrentTemplate(new HomeViewModel(CreatePageContext(model)));
	}
}
