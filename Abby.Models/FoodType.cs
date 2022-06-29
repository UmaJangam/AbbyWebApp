using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.Models
{
    public class FoodType
    {
        [Key]        //Explicitly defining a primary key
        public int Id { get; set; }
        [Required]      //It is a required property
        public string Name { get; set; }
    }
       
}
