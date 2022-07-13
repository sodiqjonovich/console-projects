using Market.Interfaces.Common;
using Market.Models;

namespace Market.Interfaces.Repositories
{
    public interface ISellerRepository :
        ICreateable<Seller>, IReadable<Seller>, IUpdateable<Seller>, IDeleteable<Seller>
    {
    }
}
