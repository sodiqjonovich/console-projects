using Restaurant.Helpers;
using Restaurant.Pages.Clients;
using System;
using System.Threading.Tasks;

namespace Restaurant.Pages
{
    public class ClientsPage
    {
        public static async Task RunAsync()
        {
            Console.Clear();
            Console.WriteLine("1. Barcha foydalanuvchilar ro'yxati");
            Console.WriteLine("2. Ma'lum foydalanuvchi ro'yxati");
            Console.WriteLine("3. Foydalanuvchi ma'lumotlarini qo'shish");
            Console.WriteLine("4. Foydalanuvchi ma'lumotlarini o'zgartirish");
            Console.WriteLine("5. Foydalanuvchi ma'lumotlarini o'chirish");

        key:
            var selected = Console.ReadLine();
            if (selected == "1") await ReadAllPage.RunAsync();
            else if (selected == "2") await ReadPage.RunAsync();
            else if (selected == "3") await CreatePage.RunAsync();
            else if (selected == "4") await UpdatePage.RunAsync();
            else if (selected == "5") await DeletePage.RunAsync();
            else
            {
                StatusHelper.WrongMessage("Tanlovda xatolik bor! \nIltimos qayta tanlovni bajaring");
                goto key;
            }
        }
    }
}
