using System;

namespace Market.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public string ProductName { get; set; }

        public string SellerName { get; set; }

        public int ProductCount { get; set; }

        public double TotalSum { get; set; }

        public DateTime Date { get; set; }
    }
}
