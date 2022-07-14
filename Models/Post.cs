using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBlogProject.Models
{
    public class Post
    {
        // primary key
        public int Id { get; set; }
        // foreign key
        public int BlogId { get; set; }
        // foreign key
        public string AuthorId { get; set; }

        [Required]
        [StringLength(75, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters.", MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters.", MinimumLength = 2)]
        public string Abstract { get; set; }

        [Required]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime Updated { get; set; }

        public bool IsReady { get; set; }

        public string Slug { get; set; }  // derived from the title of the post

        [Display(Name = "Blog Image")]
        public byte[] ImageData { get; set; }
        [Display(Name = "Image File Type")]
        public string ImageContentType { get; set; }
        // used to transfer information
        [NotMapped]
        public IFormFile Image { get; set; }


    }
}
