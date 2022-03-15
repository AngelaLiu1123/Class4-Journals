using System.ComponentModel.DataAnnotations;

namespace Class4_Journals.Models
{
    public class Comment
    {
        [Key]
        public int CommentNumber { get; set; }

        public string Content { get; set; }
    }
}
