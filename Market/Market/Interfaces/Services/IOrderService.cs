using Market.Interfaces.Common;
using Market.Models;
using Market.ViewModels;

namespace Market.Interfaces.Services
{
    public interface IOrderService : ICreateable<Order>, IReadable<OrderViewModel>
    {
        //Task<IList<OrderViewModel>> GetAllAsync();
    }
}
