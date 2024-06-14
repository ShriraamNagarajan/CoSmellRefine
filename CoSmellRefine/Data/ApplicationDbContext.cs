using Azure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CoSmellRefine.Models.Domain;
using System.Reflection.Emit;

namespace CoSmellRefine.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CodeSmell> CodeSmells { get; set; }
        public DbSet<CodeSmellCategory> CodeSmellCategories { get; set; }
        public DbSet<EducationalProgress> EducationalProgress { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleVideo> ModuleVideos { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionImage> QuestionImages { get; set; }
        public DbSet<RefactoringTechnique> RefactoringTechniques { get; set; }
        public DbSet<ReportIssue> ReportIssues { get; set; }
        public DbSet<QuestionResponse> Responses { get; set; }
        public DbSet<ResponseComment> ResponseComments { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Flashcard> Flashcards { get; set; }
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<UserProfileImage> UserProfileImages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<QuestionResponse>()
             .HasOne(qr => qr.User)
             .WithMany()
             .HasForeignKey(qr => qr.UserId)
             .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<QuestionResponse>()
                .HasOne(qr => qr.Question)
                .WithMany()
                .HasForeignKey(qr => qr.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);


            // Seed Roles (User, Admin, Author)

            var adminRoleId = "80abfbab-92b8-454d-b82b-50b4a1568ec2";
            var moderatorRoleId = "5f74cbd8-bd98-46d9-9760-bdad0ec7c033";
            var developerRoleId = "06b0066a-4de5-412e-9d62-0dda4d0cc709";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name= "Admin",
                    NormalizedName = "Admin",
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId
                },
                new IdentityRole
                {
                    Name = "Moderator",
                    NormalizedName = "Moderator",
                    Id = moderatorRoleId,
                    ConcurrencyStamp = moderatorRoleId
                },
                new IdentityRole
                {
                    Name = "Developer",
                    NormalizedName = "Developer",
                    Id = developerRoleId,
                    ConcurrencyStamp = developerRoleId
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);

            // Seed AdminUser
            var adminId = "0bb96526-4ffd-4846-8e00-ac29d53671d0";
            var adminUser = new IdentityUser
            {
                UserName = "admin@cosmellrefine.com",
                Email = "admin@cosmellrefine.com",
                NormalizedEmail = "admin@cosmellrefine.com".ToUpper(),
                NormalizedUserName = "admin@cosmellrefine.com".ToUpper(),
                Id = adminId
            };

            adminUser.PasswordHash = new PasswordHasher<IdentityUser>()
                .HashPassword(adminUser, "admin@123");


            builder.Entity<IdentityUser>().HasData(adminUser);


            // Add admin role to admin
            var adminRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminId
                }
            };

            builder.Entity<IdentityUserRole<string>>().HasData(adminRoles);


            //Seed Moderator

            var moderatorId = "9411a478-8335-4360-9a4c-9640eb2e18cd";
            var moderator = new IdentityUser
            {
                UserName = "moderator@cosmellrefine.com",
                Email = "moderator@cosmellrefine.com",
                NormalizedEmail = "moderator@cosmellrefine.com".ToUpper(),
                NormalizedUserName = "moderator@cosmellrefine.com".ToUpper(),
                Id = moderatorId
            };

            moderator.PasswordHash = new PasswordHasher<IdentityUser>()
                .HashPassword(moderator, "moderator@123");

            builder.Entity<IdentityUser>().HasData(moderator);


            // Add role to Author
            var moderatorRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = moderatorRoleId,
                    UserId = moderatorId
                }
            };

            builder.Entity<IdentityUserRole<string>>().HasData(moderatorRoles);




            // Seeding CodeSmellCategory
            var bloaterCategoryId = Guid.NewGuid();
            var ooAbusersCategoryId = Guid.NewGuid();
            var changePreventersCategoryId = Guid.NewGuid();
            var dispensablesCategoryId = Guid.NewGuid();
            var couplersCategoryId = Guid.NewGuid();

            builder.Entity<CodeSmellCategory>().HasData(
                new CodeSmellCategory { Id = bloaterCategoryId, Name = "Bloaters", Description = "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them." },
                new CodeSmellCategory { Id = ooAbusersCategoryId, Name = "Object Orientation Abusers", Description = "All these code smells result from the incomplete or incorrect application of object-oriented programming principles." },
                new CodeSmellCategory { Id = changePreventersCategoryId, Name = "Change Preventers", Description = "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly." },
                new CodeSmellCategory { Id = dispensablesCategoryId, Name = "Dispensables", Description = "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand." },
                new CodeSmellCategory { Id = couplersCategoryId, Name = "Couplers", Description = "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation." }
            );

            // Seeding CodeSmell
            builder.Entity<CodeSmell>().HasData(
                new CodeSmell { Id = Guid.NewGuid(), Name = "Long Method", Description = "A Long Method is a method that contains too many lines of code.", CodeSmellCategoryId = bloaterCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Large Class", Description = "A Large Class is a class that contains too many fields, methods, or lines of code.", CodeSmellCategoryId = bloaterCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Primitive Obsession", Description = "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", CodeSmellCategoryId = bloaterCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Long Parameter List", Description = "A Long Parameter List occurs when a method has more than three or four parameters.", CodeSmellCategoryId = bloaterCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Data Clumps", Description = "Data Clumps occur when identical groups of variables appear in different parts of the code.", CodeSmellCategoryId = bloaterCategoryId },

                new CodeSmell { Id = Guid.NewGuid(), Name = "Switch Statements", Description = "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", CodeSmellCategoryId = ooAbusersCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Temporary Field", Description = "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", CodeSmellCategoryId = ooAbusersCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Refused Bequest", Description = "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", CodeSmellCategoryId = ooAbusersCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Alternative Classes with Different Interfaces", Description = "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", CodeSmellCategoryId = ooAbusersCategoryId },

                new CodeSmell { Id = Guid.NewGuid(), Name = "Divergent Change", Description = "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", CodeSmellCategoryId = changePreventersCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Shotgun Surgery", Description = "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", CodeSmellCategoryId = changePreventersCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Parallel Inheritance Hierarchies", Description = "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", CodeSmellCategoryId = changePreventersCategoryId },

                new CodeSmell { Id = Guid.NewGuid(), Name = "Comments", Description = "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", CodeSmellCategoryId = dispensablesCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Duplicate Code", Description = "It's when two or more code fragments in your program are nearly or entirely the same.", CodeSmellCategoryId = dispensablesCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Lazy Class", Description = "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", CodeSmellCategoryId = dispensablesCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Data Class", Description = "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", CodeSmellCategoryId = dispensablesCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Dead Code", Description = "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", CodeSmellCategoryId = dispensablesCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Speculative Generality", Description = "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", CodeSmellCategoryId = dispensablesCategoryId },

                new CodeSmell { Id = Guid.NewGuid(), Name = "Feature Envy", Description = "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", CodeSmellCategoryId = couplersCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Inappropriate Intimacy", Description = "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", CodeSmellCategoryId = couplersCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Message Chains", Description = "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", CodeSmellCategoryId = couplersCategoryId },
                new CodeSmell { Id = Guid.NewGuid(), Name = "Middle Man", Description = "It's a class that exists solely to pass messages to another class, without adding any real value itself.", CodeSmellCategoryId = couplersCategoryId }
            );


            //seed notification table
            builder.Entity<Notification>().HasData(
            new Notification
            {
                Id = Guid.NewGuid(),
                UserId = "0bb96526-4ffd-4846-8e00-ac29d53671d0", 
                Message = "This is your first notification",
                SentTime = DateTime.UtcNow.AddDays(-2),
                IsRead = false
            },
            new Notification
            {
                Id = Guid.NewGuid(),
                UserId = "0bb96526-4ffd-4846-8e00-ac29d53671d0", 
                Message = "This is your second notification",
                SentTime = DateTime.UtcNow.AddDays(-1),
                IsRead = true
            },
            new Notification
            {
                Id = Guid.NewGuid(),
                UserId = "0bb96526-4ffd-4846-8e00-ac29d53671d0", 
                Message = "This is your first notification",
                SentTime = DateTime.UtcNow.AddDays(-3),
                IsRead = false
            }
        );

        }
    }
}
