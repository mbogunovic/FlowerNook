using System;
using FlowerNook.Models.Generated;

namespace FlowerNook.Core.ViewModels.Partials.Layout
{
	public class FooterViewModel
	{
		public FooterViewModel(IFooter footer)
		{
			if (footer == null) throw new ArgumentNullException(nameof(footer));

			CopyrightText = footer.CopyrightText;
		}

		public string CopyrightText { get; }
	}
}
