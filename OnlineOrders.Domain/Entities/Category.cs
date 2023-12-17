using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrders.Domain.Entities

{
    public class Category
    {

        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public Shop Shop { get; set; }

        public int ShopId { get; set; }

        public List<Outerwear> Outerwears { get; set; } = new List<Outerwear>();
    }
}
