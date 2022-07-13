using ConsoleTables;
using Restaurant.Helpers;
using Restaurant.Interfaces.Repositories;
using Restaurant.Repositories;
using System;
using System.Threading.Tasks;

namespace Restaurant.Pages.Clients
{
    public class ReadPage
    {
        public static async Task RunAsync()
        {
            IClientRepository clientRepository = new ClientRepository();
            Console.Write("Foydalanuvchi Id sini kiriting : ");
            int clientId = int.Parse(Console.ReadLine());
            var client = await clientRepository.GetAsync(clientId);

            ConsoleTable consoleTable = new ConsoleTable("Id", "Ismi", "Jinsi", "Telefon nomeri", "Manzili");

            string gender;
            if (client.Gender == Enums.Gender.Male) gender = "Erkak";
            else gender = "Ayol";
            consoleTable.AddRow(client.Id, client.Name, gender, client.PhoneNumber, client.Address);

            consoleTable.Write();

            await RoutingHelper.MakeFooterAsync();
        }
    }
}
