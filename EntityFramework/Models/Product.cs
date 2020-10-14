using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;



namespace EntityFramework.Models
{
    public class Product
    {
        public int Id { get; set; } //Each property works as a collumn in the database 

        [Required] //Adds the constraints to the properties below 
        public string Name { get; set; }

        [Column (TypeName = "decimal(18, 2)")]

        public decimal Price { get; set; }
    }
}
