using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class Product
    {
        [Key]
        public int  Product_Id { get; set; }

        public string Product_Name { get; set; }

        public int Product_Price { get; set; }
    }
}
