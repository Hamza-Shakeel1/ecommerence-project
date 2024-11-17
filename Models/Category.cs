using System.ComponentModel.DataAnnotations;

namespace ecom.Models
{
    public class Category
    {
        [Key]
        public int category_Id { get; set; }
        public string Category_Name { get; set; }
    }
}
