using ConsoleTables;
using Market.Interfaces.Services;
using Market.Service;
using System.Threading.Tasks;

namespace Market.Pages.Storages
{
    public class ReadAllPage
    {
        public static async Task RunAsync()
        {
            ConsoleTable consoleTable = new ConsoleTable("Id", "Maxsulot nomi", "Maxsulot sotib olingan narxi", "Maxsulot soni");
            
            IStorageService storageService = new StorageService();
            var storageViewModels = await storageService.GetAllAsync();
            foreach (var storageViewModel in storageViewModels)
            {
                consoleTable.AddRow(storageViewModel.Id, storageViewModel.ProductName, storageViewModel.BuyPrice, storageViewModel.Count);
            }
            consoleTable.Write();
        }


    }
}
