using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Class4_Journals.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserNumber { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "The length of Name should be more than 3 and less then 100 characters.")]
        public string Name { get; set; }

        [ForeignKey("UserNumber")]
        public ICollection<Journal> Journals { get; set; }
    }
}
