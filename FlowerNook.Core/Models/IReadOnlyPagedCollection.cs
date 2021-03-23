using System.Collections.Generic;

namespace FlowerNook.Core.Models
{
	public interface IReadOnlyPagedCollection<out T>
	{
		IReadOnlyList<T> Items { get; }
		IPagination Pagination { get; }
	}
}
