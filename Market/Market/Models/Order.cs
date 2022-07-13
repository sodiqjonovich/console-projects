using System;

namespace Market.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int ProductId { get; set; }

        public int SellerId { get; set; }

        public int Count { get; set; }

        public DateTime Date { get; set; }

        public double TotalSum { get; set; }
    }
}
