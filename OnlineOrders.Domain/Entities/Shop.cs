using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrders.Domain.Entities
{
    public class Shop
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public bool OnlieTransmition { get; set; }

        public string? ContactEmail { get; set; }

        public string? ContactPhone { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }

        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
