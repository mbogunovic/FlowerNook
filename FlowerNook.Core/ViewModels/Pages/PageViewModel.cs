using System;
using System.Collections.Generic;
using System.Linq;
using FlowerNook.Core.Contexts;
using FlowerNook.Core.Extensions;
using FlowerNook.Core.ViewModels.Partials.Layout;
using FlowerNook.Core.ViewModels.Partials.NestedContent.Widgets;
using FlowerNook.Models.Generated;

namespace FlowerNook.Core.ViewModels.Pages
{
	public class PageViewModel
	{
		public PageViewModel(IPageContext<IPage> context)
		{
			if (context == null) throw new ArgumentNullException(nameof(context));

			MetaTagsLazy = new Lazy<MetaTagsViewModel>(() => new MetaTagsViewModel(context.CreateSeoContext(context.Page)));
			WidgetsLazy = new Lazy<IEnumerable<IWidgetViewModel>>(() => context.CurrentPage.Widgets
				.Select(x => x.AsViewModelWithNestedContentContext<IWidgetViewModel>(context)));
			OpenGraphLazy = new Lazy<OpenGraphViewModel>(() => new OpenGraphViewModel(context, context.Page));
			HeaderLazy = new Lazy<HeaderViewModel>(() => new HeaderViewModel(context));
			FooterLazy = new Lazy<FooterViewModel>(() => new FooterViewModel(context.Home));
			CookieScriptLazy = new Lazy<string>(() => context.Home.CookieScript);
			GoogleTagManagerScriptCodeLazy = new Lazy<string>(() => context.Home.GoogleTagManagerScriptCode);
			GoogleTagManagerNonScriptCodeLazy = new Lazy<string>(() => context.Home.GoogleTagManagerNonScriptCode);
			GoogleAnalyticsCodeLazy = new Lazy<string>(() => context.Home.GoogleAnalyticsScriptCode);
		}

		public MetaTagsViewModel MetaTags => MetaTagsLazy.Value;
		public OpenGraphViewModel OpenGraph => OpenGraphLazy.Value;
		public HeaderViewModel Header => HeaderLazy.Value;
		public FooterViewModel Footer => FooterLazy.Value;

		public string CookieScript => CookieScriptLazy.Value;
		public string GoogleTagManagerScriptCode => GoogleTagManagerScriptCodeLazy.Value;
		public string GoogleTagManagerNonScriptCode => GoogleTagManagerNonScriptCodeLazy.Value;
		public string GoogleAnalyticsCode => GoogleAnalyticsCodeLazy.Value;

		private Lazy<MetaTagsViewModel> MetaTagsLazy { get; }
		public Lazy<IEnumerable<IWidgetViewModel>> WidgetsLazy { get; }
		private Lazy<OpenGraphViewModel> OpenGraphLazy { get; }
		private Lazy<HeaderViewModel> HeaderLazy { get; }
		private Lazy<FooterViewModel> FooterLazy { get; }
		
		private Lazy<string> CookieScriptLazy { get; }
		private Lazy<string> GoogleTagManagerScriptCodeLazy { get; }
		private Lazy<string> GoogleTagManagerNonScriptCodeLazy { get; }
		private Lazy<string> GoogleAnalyticsCodeLazy { get; }
	}
}
