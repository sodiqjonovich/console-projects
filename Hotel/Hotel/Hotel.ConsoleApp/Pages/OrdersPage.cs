using ConsoleTables;
using Hotel.ConsoleApp.Interfaces.ServiceInterfaces;
using Hotel.ConsoleApp.Services;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Pages
{
    public class OrdersPage
    {
        public static async Task RunAsync()
        {
            IOrderService orderService = new OrderService();
            var orderViewModels = await orderService.GetAsync();
            ConsoleTable consoleTable =
                new ConsoleTable("OrderId", "Foydalanuvchi", "Xona nomi", "Xona turi", "Narxi", "Registratsiya sanasi", "Muddati");

            foreach (var order in orderViewModels)
            {
                consoleTable.AddRow(order.OrderId, order.ClientFullName, order.RoomName, order.RoomType, order.Money + " so'm", order.RegistrationDate, order.OrderDays + " kun");
            }

            consoleTable.Write();
        }
    }
}
