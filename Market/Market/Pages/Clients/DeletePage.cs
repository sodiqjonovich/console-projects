using ConsoleTables;
using Market.Interfaces.Repositories;
using Market.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Pages.Clients
{
    public class DeletePage
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

            Console.Write("O'chirilishi kerak bo'lgan Id ni kiriting : ");
            int deletedId = int.Parse(Console.ReadLine());

            bool isCorrect = (clients.FirstOrDefault(x => x.Id == deletedId) != null);

            if (isCorrect)
            {
                await clientRepository.DeleteAsync(deletedId);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Muvaffaqiyatli o'chirildi");
                Console.ForegroundColor = ConsoleColor.White;
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
