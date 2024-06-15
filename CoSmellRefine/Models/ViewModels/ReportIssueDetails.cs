using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoSmellRefine.Models.ViewModels
{
    public class ReportIssueDetails
    {
        public Guid Id { get; set; }
        public Guid DiscussionItemId { get; set; }

        public IdentityUser User { get; set; }

        public string Reason { get; set; }

        public DateTime ReportDate { get; set; }
        public string Status { get; set; }

        public string StatusReason { get; set; }

        public string DiscussionType { get; set; }
    }
}
