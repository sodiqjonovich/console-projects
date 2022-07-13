using Market.Interfaces.Common;
using Market.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.Interfaces.Repositories
{
    public interface IStorageRepository
        : ICreateable<Storage>, IReadable<Storage>, IUpdateable<Storage>, IDeleteable<Storage>
    {
        Task<IList<Storage>> FindByProductId(int productId);
    }
}
