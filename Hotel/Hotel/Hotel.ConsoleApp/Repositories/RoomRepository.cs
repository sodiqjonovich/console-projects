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
    public class RoomRepository : IRoomRepository
    {
        public async Task CreateAsync(Room obj)
        {
            var json = await File.ReadAllTextAsync(DbConstants.ROOM_DB_PATH);

            var roomlist = JsonConvert.DeserializeObject<List<Room>>(json);

            if (roomlist == null) roomlist = new List<Room>();
            roomlist.Add(obj);

            var newjson = JsonConvert.SerializeObject(roomlist);

            await File.WriteAllTextAsync(DbConstants.ROOM_DB_PATH, newjson);
        }

        public async Task DeleteAsync(int id)
        {
            var json = await File.ReadAllTextAsync(DbConstants.ROOM_DB_PATH);

            var roomlist = JsonConvert.DeserializeObject<List<Room>>(json);

            var deletedIndex = roomlist.TakeWhile(x => x.Id != id).Count();

            roomlist.RemoveAt(deletedIndex);

            var newjson = JsonConvert.SerializeObject(roomlist);

            await File.WriteAllTextAsync(DbConstants.ROOM_DB_PATH, newjson);
        }

        public async Task<IEnumerable<Room>> GetAllAsync()
        {
            var json = await File.ReadAllTextAsync(DbConstants.ROOM_DB_PATH);

            var roomlist = JsonConvert.DeserializeObject<List<Room>>(json);

            return roomlist;
        }

        public async Task<Room> GetAsync(int Id)
        {
            var json = await File.ReadAllTextAsync(DbConstants.ROOM_DB_PATH);

            var roomlist = JsonConvert.DeserializeObject<List<Room>>(json);

            return roomlist.Where(x => x.Id == Id).FirstOrDefault();
        }

        public async Task UpdateAsync(int id, Room obj)
        {
            var json = await File.ReadAllTextAsync(DbConstants.ROOM_DB_PATH);

            var roomlist = JsonConvert.DeserializeObject<List<Room>>(json);

            var updatedIndex = roomlist.TakeWhile(x => x.Id != id).Count();

            roomlist[updatedIndex] = obj;

            var newjson = JsonConvert.SerializeObject(roomlist);

            await File.WriteAllTextAsync(DbConstants.ROOM_DB_PATH, newjson);
        }
    }
}
