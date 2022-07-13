using Market.Interfaces.Common;
using Market.Models;

namespace Market.Interfaces.Repositories
{
    public interface IOrderRepository :
        ICreateable<Order>, IReadable<Order>, IUpdateable<Order>, IDeleteable<Order>
    {
    }
}
