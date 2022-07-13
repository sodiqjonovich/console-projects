using Market.Pages.Storages;
using System;
using System.Threading.Tasks;

namespace Market.Pages
{
    public class StoragesPage
    {
        public static async Task RunAsync()
        {
            Console.Clear();
            Console.WriteLine("1. Barcha omborlar ro'yxati");
            Console.WriteLine("2. Ma'lum ombor ro'yxati");
            Console.WriteLine("3. Ombor qo'shish");
            Console.WriteLine("4. Ombor ma'lumotlarini yangilash");
            Console.WriteLine("5. Omborni o'chirish");

            string str = Console.ReadLine();

            if (str == "1") await ReadAllPage.RunAsync();
            else if (str == "2") await ReadPage.RunAsync();
            else if (str == "3") await CreatePage.RunAsync();
            else if (str == "4") await UpdatePage.RunAsync();
            else if (str == "5") await DeletePage.RunAsync();
            else
            {
                Console.WriteLine("Xato kiritildi!");
                await RunAsync();
            }
        }
    }
}
