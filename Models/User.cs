using System.ComponentModel.DataAnnotations;

namespace Class4_Journals.Models
{
    public class User
    {
        [Key]
        public ICollection<Journal> Journals { get; set; }
    }
}
