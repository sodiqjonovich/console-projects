using System;

namespace Hotel.ConsoleApp.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }

        public string ClientFullName { get; set; }

        public string RoomName { get; set; }

        public string RoomType { get; set; }

        public double Money { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int OrderDays { get; set; }
    }
}
