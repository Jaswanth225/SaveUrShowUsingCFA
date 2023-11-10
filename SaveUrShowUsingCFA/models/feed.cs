using System.ComponentModel.DataAnnotations;

namespace SaveUrShowUsingCFA.models
{
    public class feed
    {
        [Key]
        public int feedId { get; set; }
        public string username { get; set; }

        public string Text { get; set; }
        [Required]


        public int Rating { get; set; }
    }
}
