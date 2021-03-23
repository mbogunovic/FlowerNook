using System.Web.Mvc;
using Umbraco.Web.Mvc;
using FlowerNook.Core.ViewModels.Pages;
using FlowerNook.Models.DocumentTypes;

namespace FlowerNook.Core.Controllers.RenderMvc
{
	public class XMLSitemapController : RenderMvcController
	{
		public ActionResult XMLSitemap(IDomainRoot model)
			=> CurrentTemplate(new XMLSitemapViewModel(model));
	}
}
