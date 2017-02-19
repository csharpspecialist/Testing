using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Scoffolding.Models
{
    [MetadataType(typeof(Product.Metadata))]
    public partial class Product
    {
        //sealed means that this class can't be inherited from
        sealed class Metadata
        {
            [Key]
            public System.Guid ProductId { get; set; }

            [Required]  //makes the disp name a required field!!!
            [Display(Name = "Product Name:")]
            [StringLength(10)]
            public string Name { get; set; }
            [Required]  //makes the prod price a required field!!!
            [Display(Name = "Product Price:")]
            public Nullable<decimal> Price { get; set; }
        }



    }
}