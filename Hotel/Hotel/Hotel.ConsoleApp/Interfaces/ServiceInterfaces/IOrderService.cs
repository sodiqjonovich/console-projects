using Hotel.ConsoleApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Interfaces.ServiceInterfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderViewModel>> GetAsync();
    }
}
