using System.ComponentModel.DataAnnotations;
namespace Abby.Models
{
    public class Category
    {
        [Key]        //Explicitly defining a primary key
        public int Id { get; set; }
        [Required]      //It is a required property
        public string Name { get; set; }
        [Display(Name = "Display Order")]                                          //Server side validations validations
        [Range(1, 100, ErrorMessage = "Display order must be in range of 1-100!!!")]    //Server side validations
        public int DisplayOrder { get; set; }
    }
}
