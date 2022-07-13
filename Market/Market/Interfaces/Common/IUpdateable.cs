using System.Threading.Tasks;

namespace Market.Interfaces.Common
{
    public interface IUpdateable<T>
    {
        Task<bool> UpdateAsync(int id, T obj);
    }
}
