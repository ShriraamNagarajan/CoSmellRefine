using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoSmellRefine.Models.ViewModels
{
    public class ModeratorDiscussionViewModel
    {
        public Guid Id { get; set; }
        public IdentityUser User { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public int NumOfResponses { get; set; }
        public DateTime PostedDate { get; set; }
    }
}
