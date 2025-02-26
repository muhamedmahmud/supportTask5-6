using System;
using System.ComponentModel.DataAnnotations;

namespace session5_6Task.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        public int BlogTypeId { get; set; }
        public virtual BlogType Type { get; set; }

        public int NumOfLikes { get; set; }
        public int NumOfComments { get; set; }
    }

    public class BlogType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}