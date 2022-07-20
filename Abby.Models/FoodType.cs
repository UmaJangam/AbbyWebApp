using System.ComponentModel.DataAnnotations;

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
