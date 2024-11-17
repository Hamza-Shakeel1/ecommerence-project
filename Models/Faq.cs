using System.ComponentModel.DataAnnotations;

namespace ecom.Models
{
    public class Faq
    {
        [Key]
        public int Faq_Id { get; set; }
        public string Faq_Question { get; set; }
        public string faq_Answer { get; set; }
    }
}
