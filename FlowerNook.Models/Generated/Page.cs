using FlowerNook.Models.DocumentTypes.NestedContent;
using FlowerNook.Models.Extensions;
using System.Collections.Generic;
using Umbraco.ModelsBuilder;

namespace FlowerNook.Models.Generated
{
	/// <summary>
	/// Page document type model.
	/// </summary>
	/// <seealso cref="IPage"/>
	partial class Page : IPage
	{
		///<summary>
		/// Widgets: Widgets allowed on page.
		///</summary>
		[ImplementPropertyType("widgets")]
		public IEnumerable<INestedContent> Widgets => this.GetNestedContentPropertyValue<INestedContent>();
	}
}
