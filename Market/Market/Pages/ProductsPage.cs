using Market.Pages.Products;
using System;
using System.Threading.Tasks;

namespace Market.Pages
{
    public class ProductsPage
    {
        public static async Task RunAsync()
        {
            Console.Clear();
            Console.WriteLine("1. Barcha mahsulotlar ro'yxati");
            Console.WriteLine("2. Ma'lum mahsulot ro'yxati");
            Console.WriteLine("3. Mahsulot qo'shish");
            Console.WriteLine("4. Mahsulot ma'lumotlarini yangilash");
            Console.WriteLine("5. Mahsulotni o'chirish");

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
