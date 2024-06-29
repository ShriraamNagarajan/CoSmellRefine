using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoSmellRefine.Models.Domain
{
    public class CodeSmellCategory
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        //Navigation Property
        public ICollection<Module> Modules { get; set; }

    }
}
