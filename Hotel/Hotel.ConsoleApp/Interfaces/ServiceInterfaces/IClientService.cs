using Hotel.ConsoleApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Interfaces.ServiceInterfaces
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAllAsync();
    }
}
