using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TheBlogProject.Models
{
    public class Comment
    {
        // primary key
        public int Id { get; set; }

        // foreign keys
        public int PostId { get; set; }
        public string AuthorId { get; set; }
        public string ModeratorId { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters.", MinimumLength = 2)]
        [Display(Name = "Comment")]
        public string Body { get; set; }

        [DataType(DataType.Date)]  // will only be date but not data-time
        [Display(Name = "Created Date")]  // visual on frontend
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime? UpdatedDate { get; set; }  // nullable

        public DateTime? Moderated { get; set; }  // nullable
        public DateTime? Deleted { get; set; }  // nullable

        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters.", MinimumLength = 2)]
        [Display(Name = "Moderated Comment")]
        public string ModeratedBody { get; set; }

        // Navigation Properties - Virtual
        public virtual Post Post { get; set; }
        public virtual IdentityUser Author { get; set; }
        public virtual IdentityUser Moderator { get; set; }


    }
}
