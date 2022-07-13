using ConsoleTables;
using Market.Interfaces.Repositories;
using Market.Repositories;
using System.Threading.Tasks;

namespace Market.Pages.Products
{
    public class ReadAllPage
    {
        public static async Task RunAsync()
        {
            ConsoleTable consoleTable = new ConsoleTable("Id", "Nomi", "Narxi");

            IProductRepository productRepository = new ProductRepository();
            var products = await productRepository.GetAllAsync();

            foreach (var product in products)
            {
                consoleTable.AddRow(product.Id, product.Name, product.Price);
            }
            consoleTable.Write();
        }
    }
}
