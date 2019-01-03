using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
     [Table("Products")]
     public class Product
     {
          [Key]
          public int P_id { get; set; }
          public string P_Name { get; set; }
          public string Description { get; set; }
          public int Price { get; set; }
          public string NutritionFacts { get; set; }
          public Boolean InStock { get; set; }
          [ForeignKey("CategoryId")]
          public int ProductCategory { get; set; }

          public ICollection<Pictures> Pictures { get; set; }
          public ICollection<Reviews> Reviews { get; set; }

     }
}
