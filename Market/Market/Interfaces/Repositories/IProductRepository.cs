using Market.Interfaces.Common;
using Market.Models;

namespace Market.Interfaces.Repositories
{
    public interface IProductRepository
        : ICreateable<Product>, IReadable<Product>, IUpdateable<Product>, IDeleteable<Product>
    {

    }
}
