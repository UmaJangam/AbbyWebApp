
using System.ComponentModel.DataAnnotations;
namespace AbbyWeb.Model
{
    public class Category
    {
        [Key]        //Explicitly defining a primary key
        public int Id { get; set; }
        [Required]      //It is a required property
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
