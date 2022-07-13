using System.Threading.Tasks;

namespace Market.Interfaces.Common
{
    public interface ICreateable<T>
    {
        Task<bool> CreateAsync(T obj);
    }
}
