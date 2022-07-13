using Hotel.ConsoleApp.Pages;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await MainMenuPage.RunAsync();
        }
    }
}
