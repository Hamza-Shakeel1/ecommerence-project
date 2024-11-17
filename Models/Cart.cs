using System.ComponentModel.DataAnnotations;

namespace ecom.Models
{
    public class Cart
    {
        [Key]
        public int Cart_Id { get; set; }
        public int Prod_Id { get; set; }
        public int Cust_Id { get; set; }
        public int Product_Quantity { get; set; }
        public int Cart_Status { get; set; }
    }
}
