using ConsoleTables;
using Market.Interfaces.Repositories;
using Market.Interfaces.Services;
using Market.Models;
using Market.Repositories;
using Market.Service;
using System;
using System.Threading.Tasks;

namespace Market.Pages.Orders
{
    public class CreatePage
    {
        public static async Task RunAsync()
        {
            Order order = new Order();
            System.Console.Write("Buyurtma Id sini kiriting : ");
            order.Id = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mijozlar ro'yxati");
            Console.ForegroundColor = ConsoleColor.White;

            await Pages.Clients.ReadAllPage.RunAsync();
            Console.Write("Mijoz Id sini kiriting : ");
            order.ClientId = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mahsulotlar ro'yxati");
            Console.ForegroundColor = ConsoleColor.White;

            await Pages.Products.ReadAllPage.RunAsync();
            Console.Write("Maxsulot Id sini kiriting : ");
            order.ProductId = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sotuvchilar ro'yxati");
            Console.ForegroundColor = ConsoleColor.White;

            await Pages.Sellers.ReadAllPage.RunViewAsync();
            Console.Write("Sotuvchi Id sini kiriting : ");
            order.SellerId = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ombordagi ushbu maxsulot ro'yxati");
            Console.ForegroundColor = ConsoleColor.White;

            await Pages.Storages.ReadPage.RunAsync(order.ProductId);
            Console.Write("Mahsulot sonini kiriting : ");
            order.Count = int.Parse(Console.ReadLine());

            order.Date = DateTime.Now;
            IProductRepository productRepository = new ProductRepository();
            order.TotalSum = (await productRepository.GetAsync(order.ProductId)).Price * order.Count;

            IOrderService orderService = new OrderService();
            await orderService.CreateAsync(order);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Buyurtma muvaffaqiyatli qo'shildi");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
