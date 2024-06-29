using Azure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CoSmellRefine.Models.Domain;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using CoSmellRefine.Utility;

namespace CoSmellRefine.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CodeSmell> CodeSmells { get; set; }
        public DbSet<CodeSmellCategory> CodeSmellCategories { get; set; }
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

        public DbSet<ModuleCompletion> ModuleCompletion { get; set; }

        public DbSet<QuizResults> QuizResults { get; set; }

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


            builder.Entity<Module>()
                .HasOne(m => m.CodeSmellCategory)
                .WithMany(csc => csc.Modules) // Assuming CodeSmellCategory has a collection of Modules
                .HasForeignKey(m => m.CodeSmellCategoryId)
                .OnDelete(DeleteBehavior.Restrict); // or .NoAction()

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



            //Seed Developer

            var developerId = "680a7849-11d6-44d1-8ec5-fdac6ca72260";
            var developer = new IdentityUser
            {
                UserName = "developer@cosmellrefine.com",
                Email = "developer@cosmellrefine.com",
                NormalizedEmail = "developer@cosmellrefine.com".ToUpper(),
                NormalizedUserName = "developer@cosmellrefine.com".ToUpper(),
                Id = developerId
            };

            developer.PasswordHash = new PasswordHasher<IdentityUser>()
                .HashPassword(developer, "developer@123");

            builder.Entity<IdentityUser>().HasData(developer);


            // Add role to Developer
            var developerRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = developerRoleId,
                    UserId = developerId
                }
            };

            builder.Entity<IdentityUserRole<string>>().HasData(developerRoles);



            // Seeding CodeSmellCategory
            var bloaterCategoryId = Guid.NewGuid();
            var ooAbusersCategoryId = Guid.NewGuid();
            var changePreventersCategoryId = Guid.NewGuid();
            var dispensablesCategoryId = Guid.NewGuid();
            var couplersCategoryId = Guid.NewGuid();

            builder.Entity<CodeSmellCategory>().HasData(
                new CodeSmellCategory { Id = bloaterCategoryId, Name = "Bloaters", Description = "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", ImageUrl= "https://finance-blog-post.s3.amazonaws.com/bloaters.png" },
                new CodeSmellCategory { Id = ooAbusersCategoryId, Name = "Object Orientation Abusers", Description = "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", ImageUrl= "https://finance-blog-post.s3.amazonaws.com/object_orientation_abusers.png" },
                new CodeSmellCategory { Id = changePreventersCategoryId, Name = "Change Preventers", Description = "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", ImageUrl= "https://finance-blog-post.s3.amazonaws.com/change_preventers.png" },
                new CodeSmellCategory { Id = dispensablesCategoryId, Name = "Dispensables", Description = "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", ImageUrl= "https://finance-blog-post.s3.amazonaws.com/dispensables.png" },
                new CodeSmellCategory { Id = couplersCategoryId, Name = "Couplers", Description = "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", ImageUrl= "https://finance-blog-post.s3.amazonaws.com/couplers.png" }
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


            //seed refactoringtechniques table

            // Seed RefactoringTechnique table
            builder.Entity<RefactoringTechnique>().HasData(
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Move Method", Description = "Move a method to another class if it clearly belongs there." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Extract Method", Description = "Extract part of a method into a separate method and move it to the appropriate class." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Encapsulate Field", Description = "Hide public fields from direct access by using getters and setters." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Introduce Assertion", Description = "Use assertions to make rules about a necessary state explicit in the code." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Extract Class", Description = "Move methods and data into a new class to isolate changes to specific parts of the system." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Replace Type Code with Subclass", Description = "Replace type code with subclassing or state/strategy patterns." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Replace Conditional with Polymorphism", Description = "Use polymorphism to replace the switch statement." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Introduce Null Object", Description = "Use the Null Object pattern to handle default or missing cases in a switch statement." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Move Field", Description = "Move parts of one class to the class where they are used, but only if the first class truly doesn't need them." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Collapse Hierarchy", Description = "Merge a subclass into its parent class to simplify the hierarchy." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Inline Class", Description = "Merge the components of a near-useless class into another class and remove the empty class." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Remove Parameter", Description = "Simplify methods by removing unneeded parameters." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Form Template Method", Description = "Use the Template Method pattern if the same code is found in two subclasses at the same level but isn't completely identical." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Substitute Algorithm", Description = "Choose the best algorithm and replace others with it if two methods do the same thing but use different algorithms." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Consolidate Conditional Expression", Description = "Merge multiple conditional expressions performing the same code into a single condition and extract the common code into a new method." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Consolidate Duplicate Conditional Fragments", Description = "Move common code outside of the conditional expression if it is performed in all branches." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Hide Delegate", Description = "Simplify client code by hiding the message chain, providing a single method that handles the entire chain." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Change Bidirectional Association to Unidirectional", Description = "Reduce dependency by changing mutually interdependent classes to unidirectional relationships." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Replace Delegation with Inheritance", Description = "Use inheritance to formalize the relationship if the intimacy is between a subclass and its superclass." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Introduce Foreign Method", Description = "Add methods externally to a library class to provide the needed functionality without modifying the original class." },
                new RefactoringTechnique { Id = Guid.NewGuid(), Name = "Introduce Local Extension", Description = "Create a local extension of the library class to extend and modify it to meet your needs while keeping the original library intact." }
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

            // Seed Questions
            var question1 = new Question
            {
                Id = Guid.NewGuid(),
                UserId = developer.Id,
                Title = "Question 1",
                Body = "Body of question 1",
                PostedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                Status = QuestionStatus.Closed,
                Type = QuestionType.CodeSmellIdentification,
                CodeSnippet = "CodeSnippet1",
                IsDeleted = false,  
            };

            var question2 = new Question
            {
                Id = Guid.NewGuid(),
                UserId = developer.Id,
                Title = "Question 2",
                Body = "Body of question 2",
                PostedDate = DateTime.UtcNow.AddDays(-1),
                ModifiedDate = DateTime.UtcNow,
                Status = QuestionStatus.Open,
                Type = QuestionType.RefactoringTechniqueIdentification,
                CodeSnippet = "CodeSnippet2",
                IsDeleted = false,
            };

            builder.Entity<Question>().HasData(question1, question2);

            // Seed QuestionResponses
            var response1 = new QuestionResponse
            {
                Id = Guid.NewGuid(),
                UserId = developer.Id,
                QuestionId = question1.Id,
                Body = "Response to question 1",
                CodeSnippet = "Console.WriteLine(\"Hello World\");",
                PostedDate = DateTime.UtcNow,
                IsDeleted = false,
            };

            var response2 = new QuestionResponse
            {
                Id = Guid.NewGuid(),
                UserId = developer.Id,
                QuestionId = question2.Id,
                Body = "Another response to question 1",
                CodeSnippet = "Console.WriteLine(\"Hello World\");",
                PostedDate = DateTime.UtcNow.AddMinutes(-30),
                IsDeleted = false,
            };

            builder.Entity<QuestionResponse>().HasData(response1, response2);




            //seed the vote table

            builder.Entity<Vote>().HasData(
           new Vote
           {
               Id = Guid.NewGuid(),
               UserId = developer.Id,
               ResponseId = response1.Id,
               VoteDate = DateTime.UtcNow,
               IsUpvote = true
           },
           new Vote
           {
               Id = Guid.NewGuid(),
               UserId = developer.Id,
               ResponseId = response1.Id,
               VoteDate = DateTime.UtcNow,
               IsUpvote = false
           },
           new Vote
           {
               Id = Guid.NewGuid(),
               UserId = developer.Id,
               ResponseId = response2.Id,
               VoteDate = DateTime.UtcNow,
               IsUpvote = true
           }
       );


            //seed the report issue table
            // Seed ReportIssues
            var report1 = new ReportIssue
            {
                Id = Guid.NewGuid(),
                UserId = developer.Id,
                DiscussionItemId = question1.Id,
                DiscussionType = DiscussionType.Question,
                Reason = "Inappropriate content",
                ReportDate = DateTime.UtcNow,
                Status = ReportIssueStatus.InReview,
                StatusReason = "None"
            };

            var report2 = new ReportIssue
            {
                Id = Guid.NewGuid(),
                UserId = developer.Id,
                DiscussionItemId = question2.Id,
                DiscussionType = DiscussionType.Response,
                Reason = "Spam",
                ReportDate = DateTime.UtcNow.AddHours(-2),
                Status = ReportIssueStatus.NoActionNeeded,
                StatusReason = "The content is appropriate",
            };

            var report3 = new ReportIssue
            {
                Id = Guid.NewGuid(),
                UserId = developer.Id,
                DiscussionItemId = question2.Id,
                DiscussionType = DiscussionType.Question,
                Reason = "Duplicate content",
                ReportDate = DateTime.UtcNow.AddHours(-1),
                Status = ReportIssueStatus.WarnedUser,
                StatusReason = "User comment is inappropriate",
            };
            builder.Entity<ReportIssue>().HasData(report1, report2, report3);

        }
    }
}
