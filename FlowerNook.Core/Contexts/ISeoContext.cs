using FlowerNook.Models.DocumentTypes;

namespace FlowerNook.Core.Contexts
{
	public interface ISeoContext<out T> : ISiteContext where T : class, ISeo
	{
		T Seo { get; }
	}
}
