﻿using Hotel.ConsoleApp.Constants;
using Hotel.ConsoleApp.Interfaces.RepositoryInterfaces;
using Hotel.ConsoleApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.ConsoleApp.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private const string _dbPath = DbConstants.ORDER_DB_PATH;

        public async Task CreateAsync(Order obj)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var orderList = JsonConvert.DeserializeObject<List<Order>>(json);

            if (orderList == null) orderList = new List<Order>();
            orderList.Add(obj);

            var newjson = JsonConvert.SerializeObject(orderList);

            await File.WriteAllTextAsync(_dbPath, newjson);
        }

        public async Task DeleteAsync(int id)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var orderList = JsonConvert.DeserializeObject<List<Order>>(json);

            var deletedIndex = orderList.TakeWhile(x => x.Id != id).Count();

            orderList.RemoveAt(deletedIndex);

            var newjson = JsonConvert.SerializeObject(orderList);

            await File.WriteAllTextAsync(_dbPath, newjson);
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var orderList = JsonConvert.DeserializeObject<List<Order>>(json);

            return orderList;
        }

        public async Task<Order> GetAsync(int Id)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var orderList = JsonConvert.DeserializeObject<List<Order>>(json);

            return orderList.FirstOrDefault(x => x.Id == Id);
        }

        public async Task UpdateAsync(int id, Order obj)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var orderList = JsonConvert.DeserializeObject<List<Order>>(json);

            var updatedIndex = orderList.TakeWhile(x => x.Id != id).Count();

            orderList[updatedIndex] = obj;

            var newjson = JsonConvert.SerializeObject(orderList);

            await File.WriteAllTextAsync(_dbPath, newjson);
        }
    }
}
