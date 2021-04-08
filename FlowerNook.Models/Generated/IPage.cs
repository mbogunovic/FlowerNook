using FlowerNook.Models.DocumentTypes;
using FlowerNook.Models.DocumentTypes.NestedContent;
using System.Collections.Generic;

namespace FlowerNook.Models.Generated
{
	public partial interface IPage : ISeo
	{
		IEnumerable<INestedContent> Widgets { get; }
	}
}
