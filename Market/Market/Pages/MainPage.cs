using System;
using System.Threading.Tasks;

namespace Market.Pages
{
    public class MainPage
    {
        public static async Task RunAsync()
        {
            Console.Clear();
            Console.WriteLine("1. Foydalanuvchilar");
            Console.WriteLine("2. Sotuvchilar");
            Console.WriteLine("3. Maxsulotlar");
            Console.WriteLine("4. Omborxona");
            Console.WriteLine("5. Buyurtmalar");

            string str = Console.ReadLine();
            if (str == "1") await ClientsPage.RunAsync();
            else if (str == "2") await SellersPage.RunAsync();
            else if (str == "3") await ProductsPage.RunAsync();
            else if (str == "4") await StoragesPage.RunAsync();
            else if (str == "5") await OrdersPage.RunAsync();
            else
            {
                Console.WriteLine("Xato kiritildi!");
                await RunAsync();
            }
        }
    }
}
