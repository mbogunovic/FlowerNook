using FlowerNook.Models.DocumentTypes.NestedContent;
using FlowerNook.Models.Extensions;
using System.Collections.Generic;
using Umbraco.ModelsBuilder;

namespace FlowerNook.Models.Generated
{
	public partial class Error404 : IPage
	{
		///<summary>
		/// Widgets: Widgets allowed on page.
		///</summary>
		[ImplementPropertyType("widgets")]
		public IEnumerable<INestedContent> Widgets => this.GetNestedContentPropertyValue<INestedContent>();
	}
}
