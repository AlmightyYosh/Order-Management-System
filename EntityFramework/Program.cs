using EntityFramework.Data;
using EntityFramework.Models;
using System;
using System.Linq;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            //This using property makes sure the ContosoPetsContext is desposed of properly when im using it.
            using ContosoPetsContext context = new ContosoPetsContext();


            /****************************************************************************************************
            //ADDS DATA 
       
            //Creates the squeaky bone object.
            Product squeakyBone = new Product()
            {
                Name = "Squeaky Dog Bone",
                Price = 7.99M
            };
            
            //adds object to the table.
            context.Products.Add(squeakyBone);

            

            Product tennisBall = new Product()
            {
                Name = "Tenis Ball 3-Pack",
                Price = 9.99M
            };

            //Note added directly to the Context as entity knows where to add it.
            context.Add(tennisBall);

            //Saves the products to the table on run time.
            context.SaveChanges();
            */
            


            /****************************************************************************************************
            //UPDATES DATABASE

            var squeakyBone = context.Products
                                .Where(p => p.Name == "Squaky Dog Bone")
                                .FirstOrDefault();

            if (squeakyBone is Product)
            {
                squeakyBone.Price = 7.99m;
                squeakyBone.Name = "Squeaky Dog Bone";
            }
            context.SaveChanges();


            //Deletes from DATABASE

            var squeakyBone = context.Products
                                .Where(p => p.Name == "Squeaky Dog Bone")
                                .FirstOrDefault();

            if (squeakyBone is Product)
            {
                context.Remove(squeakyBone);
            }
            context.SaveChanges();
            */


            /****************************************************************************************************/
            //READS FROM DATABASE


            /*Fulid Api Syntax
            var products = context.Products
                .Where(p => p.Price >= 5.00m)
                .OrderBy(p => p.Name);
            */

            var products = from product
                           in context.Products
                           where product.Price > 5.00m
                           orderby product.Name
                           select product;


            foreach (Product p in products)
            {
                Console.WriteLine($"Id:   {p.Id}");
                Console.WriteLine($"Name:   {p.Name}");
                Console.WriteLine($"Price:   {p.Price}");
                Console.WriteLine(new string('-', 20));
            }

            /****************************************************************************************************/


        }

    }
}
