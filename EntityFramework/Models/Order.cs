using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFramework.Models
{
    public class Order
    {
        public DateTime OrderFulfiled { get; set; }

        [Required]
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set;  }


    }
}
