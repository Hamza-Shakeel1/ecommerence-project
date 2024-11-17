using System.ComponentModel.DataAnnotations;

namespace ecom.Models
{
    public class Admin
    {
        [Key]
        public int admin_Id { get; set; }

        public string admin_Name { get; set; }
        public string admin_Email { get; set; }
        public string admin_Password { get; set; }
        public string admin_Image { get; set; }

    }
}
