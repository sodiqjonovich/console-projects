using Sharprompt;
using System;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Pages
{
    public class MainMenuPage
    {
        public static async Task RunAsync()
        {
            Console.Clear();
            var pointer = Prompt.Select("Assalomu alaykum dasturimizga xush kelibsiz!",
                new[] {
                    "1. Xonalar ro'yxati",
                    "2. Mijozlar ro'yxati",
                    "3. Buyurtmalar ro'yxati" });

            var selectedItem = pointer[0];

            if (selectedItem == '1') await RoomsPage.RunAsync();
            else if (selectedItem == '2') await ClientsPage.RunAsync();
            else if (selectedItem == '3') await OrdersPage.RunAsync();
        }
    }
}
