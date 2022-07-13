using System;

namespace Hotel.ConsoleApp.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int RoomId { get; set; }

        public double Money { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int OrderDays { get; set; }
    }
}
