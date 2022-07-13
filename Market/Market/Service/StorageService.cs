using Market.Interfaces.Repositories;
using Market.Interfaces.Services;
using Market.Repositories;
using Market.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service
{
    public class StorageService : IStorageService
    {
        IProductRepository productRepository;
        IStorageRepository storageRepository;
        public StorageService()
        {
            productRepository = new ProductRepository();
            storageRepository = new StorageRepository();
        }

        public async Task<IList<StorageViewModel>> FindByProductIdAsync(int productId)
        {
            IList<StorageViewModel> resultList = new List<StorageViewModel>();

            var storages = await storageRepository.FindByProductId(productId);
            foreach (var storage in storages)
            {
                StorageViewModel storageViewModel = new StorageViewModel();
                storageViewModel.Id = storage.Id;
                storageViewModel.ProductName = (await productRepository.GetAsync(storage.ProductId)).Name;
                storageViewModel.BuyPrice = storage.BuyPrice;
                storageViewModel.Count = storage.Count;
                resultList.Add(storageViewModel);
            }

            return resultList;
        }

        public async Task<IList<StorageViewModel>> GetAllAsync()
        {
            IList<StorageViewModel> resultList = new List<StorageViewModel>();

            var storages = await storageRepository.GetAllAsync();
            foreach (var storage in storages)
            {
                StorageViewModel storageViewModel = new StorageViewModel();
                storageViewModel.Id = storage.Id;
                storageViewModel.ProductName = (await productRepository.GetAsync(storage.ProductId)).Name;
                storageViewModel.BuyPrice = storage.BuyPrice;
                storageViewModel.Count = storage.Count;
                resultList.Add(storageViewModel);
            }

            return resultList;
        }

        public Task<StorageViewModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
