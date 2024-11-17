using System.ComponentModel.DataAnnotations;

namespace ecom.Models
{
    public class Feeddback
    {
        [Key]
        public int Feedback_Id { get; set; }
        public int User_Name { get; set; }
        public int User_Message { get; set; }
    }
}
