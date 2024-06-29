namespace CoSmellRefine.Models.ViewModels
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public bool IsCompleted { get; set; }
    }
}
