using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBlogProject.Models
{
    public class Blog
    {
        // Blog is a parent of Post
        // primary key
        public int Id { get; set; }
        // foreign key
        public string AuthorId { get; set; }
        // blog post

        [Required]  // {0} = name, {1} = 100, {2} = 2
        [StringLength(100, ErrorMessage = "Blog {0} at least {2} characters and no more than {1} charactres.", MinimumLength = 2)]
        public string BlogName { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "Blog {0} at least {2} characters and no more than {1} charactres.", MinimumLength = 2)]
        public string Description { get; set; }

        // blog creationand update stamp
        [DataType(DataType.Date)]  // will only be date but not data-time
        [Display(Name = "Created Date")]  // visual on frontend
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime? UpdatedDate { get; set; }  // nullable

        // blog images - ImageData and ImageContentType get hteir properties from IFormFile Image
        [Display(Name = "Blog Image")]
        public byte[] ImageData { get; set; }
        [Display(Name = "Image File Type")]
        public string ImageContentType { get; set; }
        // used to transfer information
        [NotMapped]
        public IFormFile Image { get; set; }


        // navigation property
        public virtual IdentityUser Author { get; set; }  //child class of parent IdentityUser - allows navigation from a blog to its author
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>(); // zero to many Posts - blog is a parent to Posts


    }
}
