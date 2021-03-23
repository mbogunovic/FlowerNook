using Umbraco.Web.Mvc;
using FlowerNook.Core.Contexts;
using FlowerNook.Core.Extensions;
using FlowerNook.Models.Generated;

namespace FlowerNook.Core.Controllers.RenderMvc
{
	public abstract class BasePageController<T> : RenderMvcController where T : class, IPage
	{
		protected IPageContext<T> CreatePageContext(T page) => Umbraco.CreatePageContext(page);
	}
}
