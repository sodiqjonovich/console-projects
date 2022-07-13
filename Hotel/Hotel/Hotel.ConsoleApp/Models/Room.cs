using Hotel.ConsoleApp.Enums;

namespace Hotel.ConsoleApp.Models
{
    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public RoomType RoomType { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }
    }
}
