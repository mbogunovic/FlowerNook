using System;
using FlowerNook.Core.Models;

namespace FlowerNook.Core.ViewModels.Partials.Listing
{
	public class PaginationViewModel
	{
		public PaginationViewModel(IPagination pagination)
		{
			Pagination = pagination ?? throw new ArgumentNullException(nameof(pagination));
		}

		public IPagination Pagination { get; }
	}
}
