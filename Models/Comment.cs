using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Class4_Journals.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommentNumber { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "The length of Name should be more than 3 and less then 100 characters.")]
        public string Content { get; set; }

        //public int CommentedJournalNumber { get; set; }

        //public Journal Journal { get; set; }

        //public int CommentedUserNumber { get; set; }

        //public User User { get; set; }
    }
}
