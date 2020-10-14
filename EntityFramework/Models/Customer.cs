using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFramework.Models
{
    public class Customer
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        public ICollection<Order> Orders { get; set; } //Works as 'one to many' relationship to another table: Orders




    }
}
