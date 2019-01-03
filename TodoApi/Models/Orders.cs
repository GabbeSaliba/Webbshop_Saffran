using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
     [Table("Orders")]
     public class Orders
     {
          [Key]
          public int OrderId { get; set; }
          public DateTime Date { get; set; }
          [ForeignKey("User_Id")]
          public int UserID { get; set; }
          public String Status { get; set; }

     }
}
