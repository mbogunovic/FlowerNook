using System.Web.Routing;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using FlowerNook.Core.Extensions;

namespace FlowerNook.Core.Handlers
{
	/// <summary>
	/// Provides root node for the current request
	/// </summary>
	public class DomainRootRouteHandler : UmbracoVirtualNodeRouteHandler
	{
		public DomainRootRouteHandler()
		{ }

		protected override IPublishedContent FindContent(RequestContext requestContext, UmbracoContext umbracoContext) 
			=> umbracoContext.TypedContentAtDomainRoot(requestContext.HttpContext.Request.Url.AbsolutePath);
	}
}
