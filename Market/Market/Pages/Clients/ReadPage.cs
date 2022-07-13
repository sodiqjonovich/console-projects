using ConsoleTables;
using Market.Interfaces.Repositories;
using Market.Repositories;
using System;
using System.Threading.Tasks;

namespace Market.Pages.Clients
{
    public class ReadPage
    {
        public static async Task RunAsync()
        {
            Console.Write("Foydalanuvchi Id sini kiriting : ");
            int id = int.Parse(Console.ReadLine());

            ConsoleTable consoleTable = new ConsoleTable("Id", "Ism Familiyasi", "Telefon raqami", "Jinsi", "Manzili");
            IClientRepository clientRepository = new ClientRepository();
            var client = await clientRepository.GetAsync(id);
            if (client is not null)
            {
                string gender;
                if (client.Gender == Enums.Gender.Male) gender = "Erkak";
                else gender = "Ayol";
                consoleTable.AddRow(client.Id, client.Name, client.PhoneNumber, gender, client.Address);
                consoleTable.Write();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Xato Id kiritildi");
                Console.ForegroundColor = ConsoleColor.White;
                await RunAsync();
            }
        }
    }
}
