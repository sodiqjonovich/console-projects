using Hotel.ConsoleApp.Interfaces.Common;
using Hotel.ConsoleApp.Models;

namespace Hotel.ConsoleApp.Interfaces.RepositoryInterfaces
{
    public interface IOrderRepository
        : ICreateable<Order>, IReadable<Order>, IUpdateable<Order>, IDeleteable<Order>
    {
    }
}
