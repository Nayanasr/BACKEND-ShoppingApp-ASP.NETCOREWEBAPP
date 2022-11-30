using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class Cart
    {
        [Key]
        public int Cart_Id { get; set; }
        public string Cart_Name { get; set; }

        [Display(Name ="Product")]
        public virtual int Product_Id { get; set; }

        [ForeignKey("Product_Id")]
        public virtual Product product { get; set; }
    }
}
