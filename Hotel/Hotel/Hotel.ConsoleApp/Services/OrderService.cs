using Hotel.ConsoleApp.Interfaces.RepositoryInterfaces;
using Hotel.ConsoleApp.Interfaces.ServiceInterfaces;
using Hotel.ConsoleApp.Repositories;
using Hotel.ConsoleApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IClientRepository clientRepository;
        private readonly IRoomRepository roomRepository;
        public OrderService()
        {
            orderRepository = new OrderRepository();
            clientRepository = new ClientRepository();
            roomRepository = new RoomRepository();
        }

        public async Task<IEnumerable<OrderViewModel>> GetAsync()
        {
            var orders = await orderRepository.GetAllAsync();

            List<OrderViewModel> list = new List<OrderViewModel>();

            foreach (var order in orders)
            {
                OrderViewModel orderViewModel = new OrderViewModel();
                orderViewModel.OrderId = order.Id;
                var user = await clientRepository.GetAsync(order.ClientId);
                orderViewModel.ClientFullName = user.Id + ". " + user.FirstName + " " + user.LastName;
                var room = await roomRepository.GetAsync(order.RoomId);
                orderViewModel.RoomName = room.Name;
                orderViewModel.RoomType = room.RoomType.ToString();
                orderViewModel.Money = order.Money;
                orderViewModel.RegistrationDate = order.RegistrationDate;
                orderViewModel.OrderDays = order.OrderDays;

                list.Add(orderViewModel);
            }
            return list;
        }
    }
}
