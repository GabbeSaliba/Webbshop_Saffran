using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
     [Table("Pictures")]
     public class Pictures
     {
          [Key]
          public int PictureId { get; set; }
          public int ImgAddress { get; set; }
          [ForeignKey("P_Id")]
          public int ProductId { get; set; }
     }
}
