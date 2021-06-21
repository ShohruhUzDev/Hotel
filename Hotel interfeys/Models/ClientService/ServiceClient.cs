using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_interfeys.Models.ClientService
{
    class ServiceClient
    {
        public HotelContext _hotelContext;
        public ServiceClient(HotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }

        //public Client GetClient(int? id)

        //{
        //    var client = _hotelContext.Clients.FirstOrDefault(i => i.Id == id);
        //    if (client != null)
        //    {
        //        return client;
        //    }
           
        //}
    }
}
