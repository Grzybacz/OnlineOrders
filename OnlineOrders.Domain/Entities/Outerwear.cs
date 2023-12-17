using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace OnlineOrders.Domain.Entities
{ 
    public class Outerwear { 

    
        public int Id { get; set; }

        public string? Name { get; set; }

        public int InStock { get; set; }

        public int Ordered { get; set; }

        public Category? Category { get; set; }

        public int CategoryId { get; set; }
    }
}
