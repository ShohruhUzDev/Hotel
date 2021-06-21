using System.Collections.Generic;

namespace Hotel_interfeys.Models
{
    public class Room
    {
        public int Id { get; set; }
        public  int  Nomer { get; set; }
        public bool Busy { get; set; } = false;
        public uint Cost { get; set; }
        public List<Client> Clients  { get; set; }

    }
}
