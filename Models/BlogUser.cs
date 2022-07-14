using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBlogProject.Models
{
    public class BlogUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters.", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters.", MinimumLength = 2)]
        public string LastName { get; set; }

        [Display(Name = "User Image")]
        public byte[] ImageData { get; set; }

        [Display(Name = "User Image File Type")]
        public string ImageContentType { get; set; }

        // used to transfer information
        [NotMapped]
        public IFormFile Image { get; set; }

        [Display(Name = "Your Facebook")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters.", MinimumLength = 2)]
        public string FacebookUrl { get; set; }

        [Display(Name = "Your Twitter")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters.", MinimumLength = 2)]
        public string TwitterUrl { get; set; }

        [NotMapped]
        public string FullName
        {
            get { 
                return $"{FirstName} {LastName}"; 
            }
        }

        public virtual ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();


    }
}
