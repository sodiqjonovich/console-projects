using Hotel.ConsoleApp.Pages.Clients;
using Sharprompt;
using System;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Pages
{
    public class ClientsPage
    {
        public static async Task RunAsync()
        {
            Console.Clear();

            var city = Prompt.Select("Xizmat turini tanlang ",
                new[] {
                    "1. Mijozlar ro'yxati",
                    "2. Mijoz ma'lumotlari",
                    "3. Mijoz ma'lumotlarini yangilash",
                    "4. Mijoz qo'shish",
                    "5. Mijozni o'chirish"});

            var selectedItem = city[0];

            if (selectedItem == '1') await ReadAllPage.RunAsync();
            else if (selectedItem == '2') await ReadPage.RunAsync();
            else if (selectedItem == '3') await UpdatePage.RunAsync();
            else if (selectedItem == '4') await CreatePage.RunAsync();
            else if (selectedItem == '5') await DeletePage.RunAsync();
        }
    }
}
