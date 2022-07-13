using ConsoleTables;
using Market.Interfaces.Repositories;
using Market.Repositories;
using System.Threading.Tasks;

namespace Market.Pages.Sellers
{
    public class ReadAllPage
    {
        public static async Task RunAsync()
        {
            ConsoleTable consoleTable = new ConsoleTable("Id", "Ism Familiyasi", "Yoshi", "Telefon raqami", "Oyligi", "Jinsi", "Manzili");

            ISellerRepository sellerRepository = new SellerRepository();
            var sellers = await sellerRepository.GetAllAsync();
            foreach (var seller in sellers)
            {
                string gender;
                if (seller.Gender == Enums.Gender.Male) gender = "Erkak";
                else gender = "Ayol";
                consoleTable.AddRow(seller.Id, seller.Name, seller.Age, seller.PhoneNumber, seller.Salary, gender, seller.Address);
            }
            consoleTable.Write();
        }
        public static async Task RunViewAsync()
        {
            ConsoleTable consoleTable = new ConsoleTable("Id", "Ism Familiyasi", "Yoshi", "Telefon raqami", "Jinsi");

            ISellerRepository sellerRepository = new SellerRepository();
            var sellers = await sellerRepository.GetAllAsync();
            foreach (var seller in sellers)
            {
                string gender;
                if (seller.Gender == Enums.Gender.Male) gender = "Erkak";
                else gender = "Ayol";
                consoleTable.AddRow(seller.Id, seller.Name, seller.Age, seller.PhoneNumber, gender);
            }
            consoleTable.Write();
        }
    }
}
