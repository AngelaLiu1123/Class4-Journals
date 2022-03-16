using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Class4_Journals.Models
{
    public class Journal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JournalNumber { get; set; }

        [StringLength(500, MinimumLength = 3, ErrorMessage = "The length of Name should be more than 3 and less then 500 characters.")]
        public string JournalCotent { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }

        public int? OwningUserNumber { get; set; }
        public int? EditingUserNumber { get; set; }

        public User? OwningUser { get; set; }
        public User? EditingUser { get; set; }

        [ForeignKey("JournalNumber")]
        public ICollection<Comment> Comments { get; set; }
    }
}
