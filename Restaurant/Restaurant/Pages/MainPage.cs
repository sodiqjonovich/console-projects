using System;
using System.Threading.Tasks;

namespace Restaurant.Pages
{
    public class MainPage
    {
        public static async Task RunAsync()
        {
            Console.Clear();
            Console.WriteLine("1. Foydalanuvchilar");
            Console.WriteLine("2. Maxsulotlar");
            Console.WriteLine("3. Xodimlar");
            Console.WriteLine("4. Buyurtmalar");
            Console.WriteLine("5. Buyurtmalar tartiblari");

            var selected = Console.ReadLine();

            if (selected == "1") await ClientsPage.RunAsync();
        }
    }
}
