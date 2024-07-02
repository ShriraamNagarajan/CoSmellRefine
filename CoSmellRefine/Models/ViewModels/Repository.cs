namespace CoSmellRefine.Models.ViewModels
{
    public class Repository
    {
        public string name { get; set; }
        public string full_name { get; set; } // Add this property
        public User owner { get; set; }
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
    }
}
