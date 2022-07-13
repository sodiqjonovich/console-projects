using ConsoleTables;
using Market.Interfaces.Services;
using Market.Service;
using System.Threading.Tasks;

namespace Market.Pages.Orders
{
    public class ReadAllPage
    {
        public static async Task RunAsync()
        {
            ConsoleTable consoleTable = new ConsoleTable("Id", "Mijoz", "Maxsulot", "Sotuvchi", "Soni", "Narxi", "Sanasi");

            IOrderService orderService = new OrderService();
            var orderViewModels = await orderService.GetAllAsync();
            foreach (var orderViewModel in orderViewModels)
            {
                consoleTable.AddRow(orderViewModel.Id,
                    orderViewModel.ClientName, orderViewModel.ProductName, orderViewModel.SellerName,
                    orderViewModel.ProductCount, orderViewModel.TotalSum, orderViewModel.Date);
            }
            consoleTable.Write();
        }
    }
}
