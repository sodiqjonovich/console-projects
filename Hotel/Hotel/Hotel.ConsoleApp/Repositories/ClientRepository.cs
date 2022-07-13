using Hotel.ConsoleApp.Constants;
using Hotel.ConsoleApp.Interfaces.RepositoryInterfaces;
using Hotel.ConsoleApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private const string _dbPath = DbConstants.CLIENT_DB_PATH;

        public async Task CreateAsync(Client obj)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var clientList = JsonConvert.DeserializeObject<List<Client>>(json);

            if (clientList == null) clientList = new List<Client>();
            clientList.Add(obj);

            var newjson = JsonConvert.SerializeObject(clientList);

            await File.WriteAllTextAsync(_dbPath, newjson);
        }

        public async Task DeleteAsync(int id)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var clientList = JsonConvert.DeserializeObject<List<Client>>(json);

            var deletedIndex = clientList.TakeWhile(x => x.Id != id).Count();

            clientList.RemoveAt(deletedIndex);

            var newjson = JsonConvert.SerializeObject(clientList);

            await File.WriteAllTextAsync(_dbPath, newjson);
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var clientList = JsonConvert.DeserializeObject<List<Client>>(json);

            return clientList;
        }

        public async Task<Client> GetAsync(int Id)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var clientList = JsonConvert.DeserializeObject<List<Client>>(json);

            return clientList.FirstOrDefault(x => x.Id == Id);
        }

        public async Task UpdateAsync(int id, Client obj)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var clientList = JsonConvert.DeserializeObject<List<Client>>(json);

            var updatedIndex = clientList.TakeWhile(x => x.Id != id).Count();

            clientList[updatedIndex] = obj;

            var newjson = JsonConvert.SerializeObject(clientList);

            await File.WriteAllTextAsync(_dbPath, newjson);
        }
    }
}
