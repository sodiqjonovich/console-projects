using Market.Interfaces.Repositories;
using Market.Models;
using Market.Repositories;
using System;
using System.Threading.Tasks;

namespace Market.Pages.Clients
{
    public class CreatePage
    {
        public static async Task RunAsync()
        {
            Client client = new Client();
            Console.Clear();
            Console.WriteLine("------- Foydalanuvchi qo'shish ------");
            Console.Write("Foydalanuvchi Id : ");
            client.Id = int.Parse(Console.ReadLine());
            Console.Write("Foydalanuvchi ismi : ");
            client.Name = Console.ReadLine();
            Console.Write("Telefon raqami : ");
            client.PhoneNumber = Console.ReadLine();
            Console.WriteLine("1. Erkak     2. Ayol");
            if (int.Parse(Console.ReadLine()) - 1 == 0) client.Gender = Enums.Gender.Male;
            else client.Gender = Enums.Gender.Female;
            Console.Write("Manzili : ");
            client.Address = Console.ReadLine();

            IClientRepository clientRepository = new ClientRepository();
            await clientRepository.CreateAsync(client);

            Console.WriteLine("Muvaffaqiyatli qo'shildi");
        }
    }
}
