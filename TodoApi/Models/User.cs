using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
     [Table("Users")]
     public class User
     {
          [Key]
          public int User_Id { get; set; }
          public string UserName { get; set; }
          public string Password {get;set;}
          public string Name { get; set; }
          public string Email { get; set; }
          public string Phone { get; set; }
          public string address { get; set; }
          public int zipcode { get; set; }
          public string City { get; set; }
          DateTime RegistrationDate { get; set; }

     }
}
