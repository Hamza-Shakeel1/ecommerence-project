using System.ComponentModel.DataAnnotations;

namespace ecom.Models
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Price { get; set; }

        public string Product_Description { get; set; }
        public string Product_Image { get; set; }
        public int Cart_Id { get; set; }
    }
}
