using ConsoleTables;
using Hotel.ConsoleApp.Interfaces.RepositoryInterfaces;
using Hotel.ConsoleApp.Repositories;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Pages
{
    public class RoomsPage
    {
        public static async Task RunAsync()
        {
            ConsoleTable roomtable = new ConsoleTable("Id", "Nomi", "Turi", "Eni", "Kengligi");
            IRoomRepository roomRepository = new RoomRepository();
            var rooms = await roomRepository.GetAllAsync();
            foreach (var room in rooms)
            {
                roomtable.AddRow(room.Id, room.Name, room.RoomType, room.Width, room.Height);
            }
            roomtable.Write();
        }
    }
}
