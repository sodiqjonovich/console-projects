using Hotel.ConsoleApp.Interfaces.RepositoryInterfaces;
using Hotel.ConsoleApp.Interfaces.ServiceInterfaces;
using Hotel.ConsoleApp.Models;
using Hotel.ConsoleApp.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;
        public ClientService()
        {
            clientRepository = new ClientRepository();
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
            => await clientRepository.GetAllAsync();


    }
}
