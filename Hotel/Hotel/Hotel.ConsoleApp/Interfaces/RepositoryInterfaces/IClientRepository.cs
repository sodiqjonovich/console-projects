using Hotel.ConsoleApp.Interfaces.Common;
using Hotel.ConsoleApp.Models;

namespace Hotel.ConsoleApp.Interfaces.RepositoryInterfaces
{
    public interface IClientRepository :
        ICreateable<Client>, IReadable<Client>, IUpdateable<Client>, IDeleteable<Client>
    {

    }
}
