using Hotel.ConsoleApp.Pages;
using Sharprompt;
using System;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Common
{
    public class SubFooter
    {
        public static async Task MakeFooterAsync()
        {
            var pointer = Prompt.Select("-->",
                new[] {
                    "1. Menu",
                    "2. Exit"});

            var selectedItem = pointer[0];

            if (selectedItem == '1') await MainMenuPage.RunAsync();
            else if (selectedItem == '2')
            {
                Environment.Exit(0);
            }
        }
    }
}
