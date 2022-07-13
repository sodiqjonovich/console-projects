using Market.Interfaces.Common;
using Market.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.Interfaces.Services
{
    public interface IStorageService : IReadable<StorageViewModel>
    {
        public Task<IList<StorageViewModel>> FindByProductIdAsync(int productId);
    }
}
