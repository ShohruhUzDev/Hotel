using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_interfeys.Models
{
    public  class Client
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string  FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Phone { get; set; }
        public int? RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime DateOfArrival { get; set; }
        public DateTime DateOfDepartur { get; set; }

    }
}
