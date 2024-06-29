using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoSmellRefine.Models.Domain
{
    public class ResponseComment
    {

        [Key]
        public Guid Id { get; set; }
        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [ValidateNever]
        public IdentityUser User { get; set; }

        [Required]
        public Guid ResponseId { get; set; }

        [ForeignKey("ResponseId")]
        [ValidateNever]
        public QuestionResponse Response { get; set; }

        [Required]
        public DateTime CommentDate { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public string Body { get; set; }


    }
}
