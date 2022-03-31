using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="Display Order")]
        [Range(1,100,ErrorMessage ="Value must be between 1 and 100 ")]
        public string DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

    }
}
