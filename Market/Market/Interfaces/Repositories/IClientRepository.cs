using Market.Interfaces.Common;
using Market.Models;

namespace Market.Interfaces.Repositories
{
    public interface IClientRepository :
        ICreateable<Client>, IReadable<Client>, IUpdateable<Client>, IDeleteable<Client>
    {

    }
}
