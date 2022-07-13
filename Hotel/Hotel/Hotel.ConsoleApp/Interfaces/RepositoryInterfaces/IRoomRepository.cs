using Hotel.ConsoleApp.Interfaces.Common;
using Hotel.ConsoleApp.Models;

namespace Hotel.ConsoleApp.Interfaces.RepositoryInterfaces
{
    public interface IRoomRepository :
        ICreateable<Room>, IReadable<Room>, IUpdateable<Room>, IDeleteable<Room>
    {

    }
}
