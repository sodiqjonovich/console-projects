using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Interfaces.Common
{
    public interface ICreateable<T>
    {
        public Task CreateAsync(T obj);
    }
}
