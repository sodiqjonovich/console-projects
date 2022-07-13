using ConsoleTables;
using Hotel.ConsoleApp.Common;
using Hotel.ConsoleApp.Interfaces.ServiceInterfaces;
using Hotel.ConsoleApp.Services;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Pages.Clients
{
    public sealed class ReadAllPage
    {
        public static async Task RunAsync()
        {
            IClientService clientService = new ClientService();

            var clients = await clientService.GetAllAsync();

            ConsoleTable table = new ConsoleTable("Id", "Familiya Ismi", "Passport Seria Raqami");

            foreach (var client in clients)
            {
                table.AddRow(client.Id, client.LastName + " " + client.FirstName, client.PassportSeriaNumber);
            }
            table.Write();

            await SubFooter.MakeFooterAsync();
        }
    }
}
