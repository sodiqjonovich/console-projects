using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Interfaces.Common
{
    public interface IUpdateable<T>
    {
        public Task UpdateAsync(int id, T obj);
    }
}
