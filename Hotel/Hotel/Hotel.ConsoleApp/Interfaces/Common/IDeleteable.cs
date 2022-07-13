using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Interfaces.Common
{
    public interface IDeleteable<T>
    {
        public Task DeleteAsync(int id);
    }
}
