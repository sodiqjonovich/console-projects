using Market.Interfaces.Repositories;
using Market.Interfaces.Services;
using Market.Repositories;
using Market.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;
        private readonly ISellerRepository sellerRepository;
        private readonly IClientRepository clientRepository;
        private readonly IStorageRepository storageRepository;

        public OrderService()
        {
            orderRepository = new OrderRepository();
            productRepository = new ProductRepository();
            sellerRepository = new SellerRepository();
            clientRepository = new ClientRepository();
            storageRepository = new StorageRepository();
        }

        public async Task<bool> CreateAsync(Models.Order obj)
        {
            int totalCount = obj.Count;
            var storages = await storageRepository.FindByProductId(obj.ProductId);
            foreach (var storage in storages)
            {
                if (storage.Count < totalCount)
                {
                    totalCount = totalCount - storage.Count;
                    storage.Count = 0;
                }
                else if (storage.Count == totalCount)
                {
                    storage.Count = 0;
                    totalCount = 0;
                }
                else
                {
                    storage.Count = storage.Count - totalCount;
                    totalCount = 0;
                }
                await storageRepository.UpdateAsync(storage.Id, storage);
                if (totalCount == 0) break;
            }
            await orderRepository.CreateAsync(obj);
            return true;
        }

        public async Task<IList<OrderViewModel>> GetAllAsync()
        {
            IList<OrderViewModel> resultList = new List<OrderViewModel>();
            var orders = await orderRepository.GetAllAsync();
            foreach (var order in orders)
            {
                OrderViewModel orderViewModel = new OrderViewModel();
                orderViewModel.Id = order.Id;
                orderViewModel.ClientName = (await clientRepository.GetAsync(order.ClientId)).Name;
                orderViewModel.ProductName = (await productRepository.GetAsync(order.ProductId)).Name;
                orderViewModel.SellerName = (await sellerRepository.GetAsync(order.SellerId)).Name;
                orderViewModel.ProductCount = order.Count;
                orderViewModel.Date = order.Date;
                orderViewModel.TotalSum = order.TotalSum;
                resultList.Add(orderViewModel);
            }
            return resultList;
        }

        public Task<OrderViewModel> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
