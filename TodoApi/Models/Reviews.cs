using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
     [Table("Reviews")]
     public class Reviews
     {
          [Key]
          public int Review_Id { get; set; }
          [ForeignKey("P_Id")]
          public int P_Id { get; set; }
          [ForeignKey("User_Id")]
          public int UserId { get; set; }
     }
}
