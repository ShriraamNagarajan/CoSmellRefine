using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoSmellRefine.Models.Domain
{
    public class ReportIssue
    {

        [Key]
        public Guid Id { get; set; }

        [Required]  
        public Guid DiscussionItemId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [ValidateNever]
        public IdentityUser User { get; set; }

        [Required]
        public string Reason { get; set; }

        [Required]  
        public DateTime ReportDate { get; set; }

        [Required]  
        public string Status { get; set; }


    }
}
