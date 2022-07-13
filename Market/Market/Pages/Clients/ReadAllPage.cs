using ConsoleTables;
using Market.Interfaces.Repositories;
using Market.Repositories;
using System;
using System.Threading.Tasks;

namespace Market.Pages.Clients
{
    public class ReadAllPage
    {
        public static async Task RunAsync()
        {
            ConsoleTable consoleTable = new ConsoleTable("Id", "Ism Familiyasi", "Telefon raqami", "Jinsi", "Manzili");

            IClientRepository clientRepository = new ClientRepository();
            var clients = await clientRepository.GetAllAsync();
            foreach (var client in clients)
            {
                string gender;
                if (client.Gender == Enums.Gender.Male) gender = "Erkak";
                else gender = "Ayol";
                consoleTable.AddRow(client.Id, client.Name, client.PhoneNumber, gender, client.Address);
            }
            consoleTable.Write();

            System.Console.WriteLine("1.Main menu      2.Exit");
            var str = Console.ReadLine();
            if(str == "1") await MainPage.RunAsync();
        }
    }
}
