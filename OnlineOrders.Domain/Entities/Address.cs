using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace OnlineOrders.Domain.Entities

{
    public class Address
    {
        public int Id { get; set; }
        public string? NameCity { get; set; }

        public string? Street { get; set; }
        public string? PostalCode { get; set; }

        public Shop Shop { get; set; }
        public int ShopId { get; set; }

    }
}
