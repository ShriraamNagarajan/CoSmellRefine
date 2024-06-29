using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedModuleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("00d8c1e7-cce7-4690-8c96-4a6051c9ce71"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("275fea78-2c91-4c25-a5f7-9ed038660ff7"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("29b1e6bf-dd7b-4177-80b0-fe6b0966f232"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("414774eb-8236-49ba-bf30-e6f7a0b89edb"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("42dd99d5-9a0e-4dee-999b-e70bbcc15b0a"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("4a4ab2d1-09f4-4388-8754-6ee627ce1b5e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("511c614f-3cad-4c4c-872d-9b44d4ee4384"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("56dd4b0f-2f61-415c-815b-d5a4b232bb4d"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("60731cec-9492-404f-8ecd-64b0a555ae65"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("618947af-ce54-4d66-8c15-3c67fa63d3ef"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("62b91c50-aa6c-497e-87ec-bf6efa7bbc19"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("63f82595-340c-41f7-a804-a11e3a60bf6e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("68ce32ae-88f2-41d2-827d-bb1e1f912aee"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("750da832-b5ce-41a6-b1a9-d88e5e5b214b"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("8302ce0b-3327-49fb-b503-59b27fd21b79"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("85de4761-3f3e-42b5-a012-25fd6e553745"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("8b1ceccc-fe12-4e3a-a145-986b29d951cc"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("9052108c-0571-4956-8943-195b4633d2b3"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("97dfd496-b438-44af-9515-c4679cfd72a2"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ce602344-eafd-4dd1-b52e-878b7eefbce8"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e0dcf502-9b15-4a76-8d4f-d53a7d7125d3"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("eeb3097c-1fe9-4e17-8d7b-4438787b2f2d"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("55b68b3a-c98e-4814-9c32-48b2dfa37b5d"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("7fe86c8b-f2fb-414c-a09a-86912886aa2b"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("f001d9b6-8293-4a63-bc32-ed8c8dc94e0d"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("136e97b3-6d1e-4dc5-9b2c-916a2a448e14"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("169cc71d-297d-412d-97eb-6ddd844a90d1"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("2abeb85f-5c5e-4dc3-bb05-359da6cfeae8"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("2d92ebe4-8259-40c0-a8ed-cc3922b361bb"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("3088ddf2-48f7-4411-bcb3-0e64372d67bf"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("53b3e61e-08ff-409c-9805-9fe86ef306a1"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("64d6b2c3-4a0c-4ffd-b87f-58a461c97606"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("66de5e0c-91be-4983-ae3c-628e62378fc7"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("67f191cb-a7a5-40c2-b269-6848eb22e434"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("6a3fbf51-16c0-4ad0-87e8-c339312da0a3"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("7218f03e-b0fd-459a-8258-39f82c5d9d7d"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("7daedb76-a49c-4792-a02c-bcbd0594afd2"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("8191f1cc-d01f-470c-8c46-d1d6303f1d07"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("a6a54b81-199e-450e-a430-7d1447c574aa"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("ba15f373-31a3-480e-91ee-ac5c7974a94c"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("ca862571-a0a3-4be3-9010-f372743635f2"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("e2ec1973-c21a-4020-bf43-7f33de5cda52"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("e34fc05e-69ef-4ed1-864b-fe3120484216"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("ee12a9e5-3b2d-49e1-87b2-c1fada2831e0"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("f4cd659b-1842-4adf-a9b6-daf27fbf4672"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("f7a7e663-3c24-48ba-bb11-c865397f46a9"));

            migrationBuilder.DeleteData(
                table: "ReportIssues",
                keyColumn: "Id",
                keyValue: new Guid("4c740216-4b6e-46bf-8ab3-756125a114f4"));

            migrationBuilder.DeleteData(
                table: "ReportIssues",
                keyColumn: "Id",
                keyValue: new Guid("755c67e9-0b7f-48d7-b164-75c75ae93922"));

            migrationBuilder.DeleteData(
                table: "ReportIssues",
                keyColumn: "Id",
                keyValue: new Guid("81faa546-4e4c-453d-a614-5a149cce6dc1"));

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: new Guid("049818f4-fcaf-400f-a42f-a2db9a3718ed"));

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: new Guid("0d5a3705-3b07-4887-b5f0-45292d95c66b"));

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: new Guid("4cf08bbd-141e-49c5-97cf-eb357f1e536a"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("24426aca-b747-4915-a561-2e05090c6d6e"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("91a8b163-a434-41d5-83be-08121482b66e"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("08e92f41-113c-40b5-9e9f-bca311e29431"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("9f79c66d-54b5-496c-9b58-15dc8e8528f6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0a38e6b2-8103-4703-9653-b3e4a7e9cd9f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("61c606af-95a6-4afa-9f4e-a202d0a64a72"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Modules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb93f9c3-2e48-4002-9fac-fa17ce3faf2e", "AQAAAAIAAYagAAAAEKSC6pxpSOEvwCNK2b5FIqBAMtdS2Hv3UuU6o30qlUlQL33kC5jGukVciIT0FqXFRw==", "c72bfacd-257e-46b9-81a9-1a6ba21bd347" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "680a7849-11d6-44d1-8ec5-fdac6ca72260",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1add123-1903-47d3-ae78-cdd44bb95804", "AQAAAAIAAYagAAAAEOOdTu67GIJMOw8RnGGixpn6xOva4jY/0BB/qcXl/20hIY2KDbM3GnYXDoXpJ7VUYg==", "a616aab5-5700-428c-b9f5-58d6f9ac160e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3b294e4-b8af-4cd0-bb85-44ecd6612db6", "AQAAAAIAAYagAAAAEAxXWhiFWBUkkJtLMeVI9YaZo7TDuxLrFXQgGinpcq5vP//6z4eYsxodjH+viJEmJA==", "10b2a9b2-ad92-4ec1-8a9c-392c0190aec7" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("29f27e4a-26fd-423f-a8f3-69b3d14d14d2"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "https://finance-blog-post.s3.amazonaws.com/object_orientation_abusers.png", "Object Orientation Abusers" },
                    { new Guid("34618ef1-6f93-4f84-9959-99f341207f3c"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "https://finance-blog-post.s3.amazonaws.com/change_preventers.png", "Change Preventers" },
                    { new Guid("4c54f675-91a7-4057-9fc6-b8ff2d5d5326"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "https://finance-blog-post.s3.amazonaws.com/couplers.png", "Couplers" },
                    { new Guid("5e604a4d-0fe5-407e-9d20-7ebcaf7f72a1"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "https://finance-blog-post.s3.amazonaws.com/bloaters.png", "Bloaters" },
                    { new Guid("a2b122e6-95b5-4876-b958-982cf065c586"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "https://finance-blog-post.s3.amazonaws.com/dispensables.png", "Dispensables" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsRead", "Message", "SentTime", "UserId" },
                values: new object[,]
                {
                    { new Guid("5d767b86-8dfc-47a2-9c23-25f1b3f0eb4a"), false, "This is your first notification", new DateTime(2024, 6, 26, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7446), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("6856e873-dc4b-4503-9bcc-7064926cceed"), true, "This is your second notification", new DateTime(2024, 6, 27, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7456), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("d29fc1fe-d852-4d7e-81d5-caebdc551297"), false, "This is your first notification", new DateTime(2024, 6, 25, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7459), "0bb96526-4ffd-4846-8e00-ac29d53671d0" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Body", "CodeSnippet", "IsDeleted", "ModifiedDate", "PostedDate", "Status", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("bbe011e4-2c28-4a96-9943-e44bf15dc181"), "Body of question 1", "CodeSnippet1", false, new DateTime(2024, 6, 28, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7484), new DateTime(2024, 6, 28, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7483), "Closed", "Question 1", "Code Smell Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("d611c77c-d12d-4f03-a2d3-bf6301a833ce"), "Body of question 2", "CodeSnippet2", false, new DateTime(2024, 6, 28, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7490), new DateTime(2024, 6, 27, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7490), "Open", "Question 2", "Refactoring Technique Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "RefactoringTechniques",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("057a96a8-d93a-4245-a0e1-af8cc1af18e6"), "Choose the best algorithm and replace others with it if two methods do the same thing but use different algorithms.", "Substitute Algorithm" },
                    { new Guid("14566781-7093-4259-901d-39bed97f0ffd"), "Simplify client code by hiding the message chain, providing a single method that handles the entire chain.", "Hide Delegate" },
                    { new Guid("23494f01-2aea-460a-a50a-97ed606124cc"), "Use the Template Method pattern if the same code is found in two subclasses at the same level but isn't completely identical.", "Form Template Method" },
                    { new Guid("241faf55-f802-4f3d-bae0-7d59acbcfc3a"), "Replace type code with subclassing or state/strategy patterns.", "Replace Type Code with Subclass" },
                    { new Guid("4d589fdc-0e18-4d09-b682-923f350d913a"), "Move methods and data into a new class to isolate changes to specific parts of the system.", "Extract Class" },
                    { new Guid("4e72fcc1-f18c-4432-b0dc-7a935d93e9af"), "Simplify methods by removing unneeded parameters.", "Remove Parameter" },
                    { new Guid("5a3c19b4-0354-4990-8419-93a9789d2c1c"), "Hide public fields from direct access by using getters and setters.", "Encapsulate Field" },
                    { new Guid("66b68563-bcb0-452e-b7d1-1239a167dc66"), "Move common code outside of the conditional expression if it is performed in all branches.", "Consolidate Duplicate Conditional Fragments" },
                    { new Guid("77532039-c92a-44c9-99b8-65a5146e1d28"), "Use the Null Object pattern to handle default or missing cases in a switch statement.", "Introduce Null Object" },
                    { new Guid("8a31f414-dc46-4465-8392-bbc7c1677171"), "Use polymorphism to replace the switch statement.", "Replace Conditional with Polymorphism" },
                    { new Guid("a5cf3c83-8d1a-42bd-8183-f0181c6da65e"), "Use inheritance to formalize the relationship if the intimacy is between a subclass and its superclass.", "Replace Delegation with Inheritance" },
                    { new Guid("af71e55d-9d07-4f53-af1b-ed9b042bd620"), "Merge the components of a near-useless class into another class and remove the empty class.", "Inline Class" },
                    { new Guid("b5218c85-2fac-4641-bb11-b69ed7050066"), "Use assertions to make rules about a necessary state explicit in the code.", "Introduce Assertion" },
                    { new Guid("b60928bf-64ad-4824-a33e-9196db9c0da2"), "Extract part of a method into a separate method and move it to the appropriate class.", "Extract Method" },
                    { new Guid("c14e70cd-a1fc-48ff-8396-f785401f5aaa"), "Move a method to another class if it clearly belongs there.", "Move Method" },
                    { new Guid("c252c47a-2b20-4f89-9da9-376cb42e00d4"), "Merge a subclass into its parent class to simplify the hierarchy.", "Collapse Hierarchy" },
                    { new Guid("e098d5de-a734-4f60-96ea-bc857073b447"), "Create a local extension of the library class to extend and modify it to meet your needs while keeping the original library intact.", "Introduce Local Extension" },
                    { new Guid("e4c3c6c2-a0b1-43b9-88cb-f6fc1cb6f830"), "Reduce dependency by changing mutually interdependent classes to unidirectional relationships.", "Change Bidirectional Association to Unidirectional" },
                    { new Guid("e5f14401-b3c0-41a5-83a2-aca1da8d90a5"), "Merge multiple conditional expressions performing the same code into a single condition and extract the common code into a new method.", "Consolidate Conditional Expression" },
                    { new Guid("f7b43b02-e92c-4a2e-99d4-d3e97830dc3a"), "Move parts of one class to the class where they are used, but only if the first class truly doesn't need them.", "Move Field" },
                    { new Guid("fcb646aa-08b9-45a1-9ef2-c85ce3814e0a"), "Add methods externally to a library class to provide the needed functionality without modifying the original class.", "Introduce Foreign Method" }
                });

            migrationBuilder.InsertData(
                table: "ReportIssues",
                columns: new[] { "Id", "DiscussionItemId", "DiscussionType", "Reason", "ReportDate", "Status", "StatusReason", "UserId" },
                values: new object[,]
                {
                    { new Guid("16cf1537-a2ea-47d4-bc10-221785de2b7b"), new Guid("bbe011e4-2c28-4a96-9943-e44bf15dc181"), "Question", "Inappropriate content", new DateTime(2024, 6, 28, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7692), "In Review", "None", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("f31dac25-6b83-45bc-97cb-ee0e4dabc125"), new Guid("d611c77c-d12d-4f03-a2d3-bf6301a833ce"), "Question", "Duplicate content", new DateTime(2024, 6, 28, 8, 40, 51, 30, DateTimeKind.Utc).AddTicks(7700), "Warned User", "User comment is inappropriate", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("f3b8ebd8-6645-4c0c-aec4-0df12a1273d5"), new Guid("d611c77c-d12d-4f03-a2d3-bf6301a833ce"), "Response", "Spam", new DateTime(2024, 6, 28, 7, 40, 51, 30, DateTimeKind.Utc).AddTicks(7696), "No Action Needed", "The content is appropriate", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2a60268b-692b-4964-96a0-d4f1045f5370"), new Guid("a2b122e6-95b5-4876-b958-982cf065c586"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("2aa28253-fa7f-4111-b910-7483fd582300"), new Guid("a2b122e6-95b5-4876-b958-982cf065c586"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("38aa7822-8ed0-4309-8608-4567bd75692c"), new Guid("5e604a4d-0fe5-407e-9d20-7ebcaf7f72a1"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("3cdff99a-7385-4ab3-84d6-11c2000d30ef"), new Guid("4c54f675-91a7-4057-9fc6-b8ff2d5d5326"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("4c446165-4fde-473c-b118-18a290030b0e"), new Guid("34618ef1-6f93-4f84-9959-99f341207f3c"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("58a91a2d-8928-4039-8303-ac5fd5ba1b0f"), new Guid("a2b122e6-95b5-4876-b958-982cf065c586"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("61f1a799-1acd-46c4-8e95-a3b0efa07f9e"), new Guid("29f27e4a-26fd-423f-a8f3-69b3d14d14d2"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" },
                    { new Guid("654d4f72-5509-4daf-b9b2-a1dc42242fea"), new Guid("29f27e4a-26fd-423f-a8f3-69b3d14d14d2"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("73461dee-eab0-4d48-ac71-351a18a4bd75"), new Guid("34618ef1-6f93-4f84-9959-99f341207f3c"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("74de66e1-96f2-46b8-9464-a404925f6c61"), new Guid("5e604a4d-0fe5-407e-9d20-7ebcaf7f72a1"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("76300348-775a-4c22-ba00-ab3d330a2854"), new Guid("4c54f675-91a7-4057-9fc6-b8ff2d5d5326"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("79dd83c3-155a-4272-a362-044d345a29c0"), new Guid("5e604a4d-0fe5-407e-9d20-7ebcaf7f72a1"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("a0b1d79f-2d60-470e-98c0-d1f561bae59c"), new Guid("a2b122e6-95b5-4876-b958-982cf065c586"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("a2f0fc27-c429-43e3-9502-1ec5922f6c77"), new Guid("29f27e4a-26fd-423f-a8f3-69b3d14d14d2"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("a42ccade-71f6-4b11-9be7-c613a30a12b5"), new Guid("34618ef1-6f93-4f84-9959-99f341207f3c"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("ac53afe5-22b7-4ab2-a85a-fdf1b8848bba"), new Guid("4c54f675-91a7-4057-9fc6-b8ff2d5d5326"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("b2ce7772-adce-4e86-aaf5-35782b89db14"), new Guid("a2b122e6-95b5-4876-b958-982cf065c586"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("c62e90cc-3666-486e-a93e-4cafbe6035d8"), new Guid("4c54f675-91a7-4057-9fc6-b8ff2d5d5326"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("c6e6c383-2845-4959-a6e7-1ff513d1839e"), new Guid("5e604a4d-0fe5-407e-9d20-7ebcaf7f72a1"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" },
                    { new Guid("d7c82c8e-68e0-4fb3-ac27-128be413319f"), new Guid("29f27e4a-26fd-423f-a8f3-69b3d14d14d2"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("e74745e2-775e-4c23-ac1a-3e2ad421794d"), new Guid("5e604a4d-0fe5-407e-9d20-7ebcaf7f72a1"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" },
                    { new Guid("ebd13c41-1f3f-4bdc-aeaf-ee5dce5ed50b"), new Guid("a2b122e6-95b5-4876-b958-982cf065c586"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Body", "CodeSnippet", "IsDeleted", "PostedDate", "QuestionId", "QuestionId1", "UserId" },
                values: new object[,]
                {
                    { new Guid("2400ce12-6cbc-47d4-a022-3b6448dd7691"), "Another response to question 1", "Console.WriteLine(\"Hello World\");", false, new DateTime(2024, 6, 28, 9, 10, 51, 30, DateTimeKind.Utc).AddTicks(7539), new Guid("d611c77c-d12d-4f03-a2d3-bf6301a833ce"), null, "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("3924ce98-3d5d-4e07-aed0-86aba3c5eda8"), "Response to question 1", "Console.WriteLine(\"Hello World\");", false, new DateTime(2024, 6, 28, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7535), new Guid("bbe011e4-2c28-4a96-9943-e44bf15dc181"), null, "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "Id", "IsUpvote", "ResponseId", "UserId", "VoteDate" },
                values: new object[,]
                {
                    { new Guid("52b70545-2337-4630-8d8f-9d44602926d2"), true, new Guid("2400ce12-6cbc-47d4-a022-3b6448dd7691"), "680a7849-11d6-44d1-8ec5-fdac6ca72260", new DateTime(2024, 6, 28, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7677) },
                    { new Guid("7b9179cc-a062-4a38-bff0-c9dffe46783f"), false, new Guid("3924ce98-3d5d-4e07-aed0-86aba3c5eda8"), "680a7849-11d6-44d1-8ec5-fdac6ca72260", new DateTime(2024, 6, 28, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7666) },
                    { new Guid("a48be175-51af-44d2-87c2-b56ab18af0b7"), true, new Guid("3924ce98-3d5d-4e07-aed0-86aba3c5eda8"), "680a7849-11d6-44d1-8ec5-fdac6ca72260", new DateTime(2024, 6, 28, 9, 40, 51, 30, DateTimeKind.Utc).AddTicks(7621) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("2a60268b-692b-4964-96a0-d4f1045f5370"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("2aa28253-fa7f-4111-b910-7483fd582300"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("38aa7822-8ed0-4309-8608-4567bd75692c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("3cdff99a-7385-4ab3-84d6-11c2000d30ef"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("4c446165-4fde-473c-b118-18a290030b0e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("58a91a2d-8928-4039-8303-ac5fd5ba1b0f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("61f1a799-1acd-46c4-8e95-a3b0efa07f9e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("654d4f72-5509-4daf-b9b2-a1dc42242fea"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("73461dee-eab0-4d48-ac71-351a18a4bd75"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("74de66e1-96f2-46b8-9464-a404925f6c61"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("76300348-775a-4c22-ba00-ab3d330a2854"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("79dd83c3-155a-4272-a362-044d345a29c0"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("a0b1d79f-2d60-470e-98c0-d1f561bae59c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("a2f0fc27-c429-43e3-9502-1ec5922f6c77"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("a42ccade-71f6-4b11-9be7-c613a30a12b5"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ac53afe5-22b7-4ab2-a85a-fdf1b8848bba"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("b2ce7772-adce-4e86-aaf5-35782b89db14"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("c62e90cc-3666-486e-a93e-4cafbe6035d8"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("c6e6c383-2845-4959-a6e7-1ff513d1839e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("d7c82c8e-68e0-4fb3-ac27-128be413319f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e74745e2-775e-4c23-ac1a-3e2ad421794d"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ebd13c41-1f3f-4bdc-aeaf-ee5dce5ed50b"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("5d767b86-8dfc-47a2-9c23-25f1b3f0eb4a"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("6856e873-dc4b-4503-9bcc-7064926cceed"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("d29fc1fe-d852-4d7e-81d5-caebdc551297"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("057a96a8-d93a-4245-a0e1-af8cc1af18e6"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("14566781-7093-4259-901d-39bed97f0ffd"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("23494f01-2aea-460a-a50a-97ed606124cc"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("241faf55-f802-4f3d-bae0-7d59acbcfc3a"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("4d589fdc-0e18-4d09-b682-923f350d913a"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("4e72fcc1-f18c-4432-b0dc-7a935d93e9af"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("5a3c19b4-0354-4990-8419-93a9789d2c1c"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("66b68563-bcb0-452e-b7d1-1239a167dc66"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("77532039-c92a-44c9-99b8-65a5146e1d28"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("8a31f414-dc46-4465-8392-bbc7c1677171"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("a5cf3c83-8d1a-42bd-8183-f0181c6da65e"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("af71e55d-9d07-4f53-af1b-ed9b042bd620"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("b5218c85-2fac-4641-bb11-b69ed7050066"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("b60928bf-64ad-4824-a33e-9196db9c0da2"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("c14e70cd-a1fc-48ff-8396-f785401f5aaa"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("c252c47a-2b20-4f89-9da9-376cb42e00d4"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("e098d5de-a734-4f60-96ea-bc857073b447"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("e4c3c6c2-a0b1-43b9-88cb-f6fc1cb6f830"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("e5f14401-b3c0-41a5-83a2-aca1da8d90a5"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("f7b43b02-e92c-4a2e-99d4-d3e97830dc3a"));

            migrationBuilder.DeleteData(
                table: "RefactoringTechniques",
                keyColumn: "Id",
                keyValue: new Guid("fcb646aa-08b9-45a1-9ef2-c85ce3814e0a"));

            migrationBuilder.DeleteData(
                table: "ReportIssues",
                keyColumn: "Id",
                keyValue: new Guid("16cf1537-a2ea-47d4-bc10-221785de2b7b"));

            migrationBuilder.DeleteData(
                table: "ReportIssues",
                keyColumn: "Id",
                keyValue: new Guid("f31dac25-6b83-45bc-97cb-ee0e4dabc125"));

            migrationBuilder.DeleteData(
                table: "ReportIssues",
                keyColumn: "Id",
                keyValue: new Guid("f3b8ebd8-6645-4c0c-aec4-0df12a1273d5"));

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: new Guid("52b70545-2337-4630-8d8f-9d44602926d2"));

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: new Guid("7b9179cc-a062-4a38-bff0-c9dffe46783f"));

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: new Guid("a48be175-51af-44d2-87c2-b56ab18af0b7"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("29f27e4a-26fd-423f-a8f3-69b3d14d14d2"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("34618ef1-6f93-4f84-9959-99f341207f3c"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c54f675-91a7-4057-9fc6-b8ff2d5d5326"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e604a4d-0fe5-407e-9d20-7ebcaf7f72a1"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2b122e6-95b5-4876-b958-982cf065c586"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("2400ce12-6cbc-47d4-a022-3b6448dd7691"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("3924ce98-3d5d-4e07-aed0-86aba3c5eda8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bbe011e4-2c28-4a96-9943-e44bf15dc181"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d611c77c-d12d-4f03-a2d3-bf6301a833ce"));

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Modules");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8a0137c-1329-4b1d-b3e5-7f8cd013f51c", "AQAAAAIAAYagAAAAECKDynbvEM6JUN1wEiYI7maXgLiX+LcoLn7sP9uT/2tiVC6UJscEiJ/k57Mb4vltMQ==", "dbc5dd6f-78eb-4dd0-9571-7065344e674b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "680a7849-11d6-44d1-8ec5-fdac6ca72260",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "912b22b9-9e81-4451-9ac0-95982ec43906", "AQAAAAIAAYagAAAAEGV9dmMnJjGAVbClsm+TaeqpDqgoR7zFY53Jny531OtUif/HNwKFEhO75RagX2caWg==", "2cc18f23-90fe-44e2-9bf2-13094ca882ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26b07bd3-789b-4e69-a787-0b2a02c81693", "AQAAAAIAAYagAAAAEFtFYAL+BXQ1BEuxjaFT8AtQ5CV2ahfZ4fjDIncY9fIUQpC+9477eFKV92osXjUtaQ==", "fea9f2e9-b8e4-4a32-b9ad-36162d8150b7" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("24426aca-b747-4915-a561-2e05090c6d6e"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "https://finance-blog-post.s3.amazonaws.com/object_orientation_abusers.png", "Object Orientation Abusers" },
                    { new Guid("91a8b163-a434-41d5-83be-08121482b66e"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "https://finance-blog-post.s3.amazonaws.com/change_preventers.png", "Change Preventers" },
                    { new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "https://finance-blog-post.s3.amazonaws.com/bloaters.png", "Bloaters" },
                    { new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "https://finance-blog-post.s3.amazonaws.com/couplers.png", "Couplers" },
                    { new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "https://finance-blog-post.s3.amazonaws.com/dispensables.png", "Dispensables" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsRead", "Message", "SentTime", "UserId" },
                values: new object[,]
                {
                    { new Guid("55b68b3a-c98e-4814-9c32-48b2dfa37b5d"), true, "This is your second notification", new DateTime(2024, 6, 27, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(514), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("7fe86c8b-f2fb-414c-a09a-86912886aa2b"), false, "This is your first notification", new DateTime(2024, 6, 25, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(516), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("f001d9b6-8293-4a63-bc32-ed8c8dc94e0d"), false, "This is your first notification", new DateTime(2024, 6, 26, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(502), "0bb96526-4ffd-4846-8e00-ac29d53671d0" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Body", "CodeSnippet", "IsDeleted", "ModifiedDate", "PostedDate", "Status", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a38e6b2-8103-4703-9653-b3e4a7e9cd9f"), "Body of question 2", "CodeSnippet2", false, new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(539), new DateTime(2024, 6, 27, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(539), "Open", "Question 2", "Refactoring Technique Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("61c606af-95a6-4afa-9f4e-a202d0a64a72"), "Body of question 1", "CodeSnippet1", false, new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(534), new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(533), "Closed", "Question 1", "Code Smell Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "RefactoringTechniques",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("136e97b3-6d1e-4dc5-9b2c-916a2a448e14"), "Use inheritance to formalize the relationship if the intimacy is between a subclass and its superclass.", "Replace Delegation with Inheritance" },
                    { new Guid("169cc71d-297d-412d-97eb-6ddd844a90d1"), "Use polymorphism to replace the switch statement.", "Replace Conditional with Polymorphism" },
                    { new Guid("2abeb85f-5c5e-4dc3-bb05-359da6cfeae8"), "Hide public fields from direct access by using getters and setters.", "Encapsulate Field" },
                    { new Guid("2d92ebe4-8259-40c0-a8ed-cc3922b361bb"), "Create a local extension of the library class to extend and modify it to meet your needs while keeping the original library intact.", "Introduce Local Extension" },
                    { new Guid("3088ddf2-48f7-4411-bcb3-0e64372d67bf"), "Choose the best algorithm and replace others with it if two methods do the same thing but use different algorithms.", "Substitute Algorithm" },
                    { new Guid("53b3e61e-08ff-409c-9805-9fe86ef306a1"), "Use assertions to make rules about a necessary state explicit in the code.", "Introduce Assertion" },
                    { new Guid("64d6b2c3-4a0c-4ffd-b87f-58a461c97606"), "Move methods and data into a new class to isolate changes to specific parts of the system.", "Extract Class" },
                    { new Guid("66de5e0c-91be-4983-ae3c-628e62378fc7"), "Move parts of one class to the class where they are used, but only if the first class truly doesn't need them.", "Move Field" },
                    { new Guid("67f191cb-a7a5-40c2-b269-6848eb22e434"), "Add methods externally to a library class to provide the needed functionality without modifying the original class.", "Introduce Foreign Method" },
                    { new Guid("6a3fbf51-16c0-4ad0-87e8-c339312da0a3"), "Simplify methods by removing unneeded parameters.", "Remove Parameter" },
                    { new Guid("7218f03e-b0fd-459a-8258-39f82c5d9d7d"), "Replace type code with subclassing or state/strategy patterns.", "Replace Type Code with Subclass" },
                    { new Guid("7daedb76-a49c-4792-a02c-bcbd0594afd2"), "Extract part of a method into a separate method and move it to the appropriate class.", "Extract Method" },
                    { new Guid("8191f1cc-d01f-470c-8c46-d1d6303f1d07"), "Reduce dependency by changing mutually interdependent classes to unidirectional relationships.", "Change Bidirectional Association to Unidirectional" },
                    { new Guid("a6a54b81-199e-450e-a430-7d1447c574aa"), "Merge multiple conditional expressions performing the same code into a single condition and extract the common code into a new method.", "Consolidate Conditional Expression" },
                    { new Guid("ba15f373-31a3-480e-91ee-ac5c7974a94c"), "Move common code outside of the conditional expression if it is performed in all branches.", "Consolidate Duplicate Conditional Fragments" },
                    { new Guid("ca862571-a0a3-4be3-9010-f372743635f2"), "Use the Template Method pattern if the same code is found in two subclasses at the same level but isn't completely identical.", "Form Template Method" },
                    { new Guid("e2ec1973-c21a-4020-bf43-7f33de5cda52"), "Merge a subclass into its parent class to simplify the hierarchy.", "Collapse Hierarchy" },
                    { new Guid("e34fc05e-69ef-4ed1-864b-fe3120484216"), "Move a method to another class if it clearly belongs there.", "Move Method" },
                    { new Guid("ee12a9e5-3b2d-49e1-87b2-c1fada2831e0"), "Simplify client code by hiding the message chain, providing a single method that handles the entire chain.", "Hide Delegate" },
                    { new Guid("f4cd659b-1842-4adf-a9b6-daf27fbf4672"), "Merge the components of a near-useless class into another class and remove the empty class.", "Inline Class" },
                    { new Guid("f7a7e663-3c24-48ba-bb11-c865397f46a9"), "Use the Null Object pattern to handle default or missing cases in a switch statement.", "Introduce Null Object" }
                });

            migrationBuilder.InsertData(
                table: "ReportIssues",
                columns: new[] { "Id", "DiscussionItemId", "DiscussionType", "Reason", "ReportDate", "Status", "StatusReason", "UserId" },
                values: new object[,]
                {
                    { new Guid("4c740216-4b6e-46bf-8ab3-756125a114f4"), new Guid("0a38e6b2-8103-4703-9653-b3e4a7e9cd9f"), "Response", "Spam", new DateTime(2024, 6, 28, 5, 15, 32, 972, DateTimeKind.Utc).AddTicks(763), "No Action Needed", "The content is appropriate", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("755c67e9-0b7f-48d7-b164-75c75ae93922"), new Guid("61c606af-95a6-4afa-9f4e-a202d0a64a72"), "Question", "Inappropriate content", new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(761), "In Review", "None", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("81faa546-4e4c-453d-a614-5a149cce6dc1"), new Guid("0a38e6b2-8103-4703-9653-b3e4a7e9cd9f"), "Question", "Duplicate content", new DateTime(2024, 6, 28, 6, 15, 32, 972, DateTimeKind.Utc).AddTicks(766), "Warned User", "User comment is inappropriate", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00d8c1e7-cce7-4690-8c96-4a6051c9ce71"), new Guid("24426aca-b747-4915-a561-2e05090c6d6e"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" },
                    { new Guid("275fea78-2c91-4c25-a5f7-9ed038660ff7"), new Guid("91a8b163-a434-41d5-83be-08121482b66e"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("29b1e6bf-dd7b-4177-80b0-fe6b0966f232"), new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" },
                    { new Guid("414774eb-8236-49ba-bf30-e6f7a0b89edb"), new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("42dd99d5-9a0e-4dee-999b-e70bbcc15b0a"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("4a4ab2d1-09f4-4388-8754-6ee627ce1b5e"), new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("511c614f-3cad-4c4c-872d-9b44d4ee4384"), new Guid("24426aca-b747-4915-a561-2e05090c6d6e"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("56dd4b0f-2f61-415c-815b-d5a4b232bb4d"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("60731cec-9492-404f-8ecd-64b0a555ae65"), new Guid("24426aca-b747-4915-a561-2e05090c6d6e"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("618947af-ce54-4d66-8c15-3c67fa63d3ef"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("62b91c50-aa6c-497e-87ec-bf6efa7bbc19"), new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("63f82595-340c-41f7-a804-a11e3a60bf6e"), new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("68ce32ae-88f2-41d2-827d-bb1e1f912aee"), new Guid("91a8b163-a434-41d5-83be-08121482b66e"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("750da832-b5ce-41a6-b1a9-d88e5e5b214b"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("8302ce0b-3327-49fb-b503-59b27fd21b79"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("85de4761-3f3e-42b5-a012-25fd6e553745"), new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("8b1ceccc-fe12-4e3a-a145-986b29d951cc"), new Guid("91a8b163-a434-41d5-83be-08121482b66e"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("9052108c-0571-4956-8943-195b4633d2b3"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("97dfd496-b438-44af-9515-c4679cfd72a2"), new Guid("24426aca-b747-4915-a561-2e05090c6d6e"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("ce602344-eafd-4dd1-b52e-878b7eefbce8"), new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("e0dcf502-9b15-4a76-8d4f-d53a7d7125d3"), new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("eeb3097c-1fe9-4e17-8d7b-4438787b2f2d"), new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Body", "CodeSnippet", "IsDeleted", "PostedDate", "QuestionId", "QuestionId1", "UserId" },
                values: new object[,]
                {
                    { new Guid("08e92f41-113c-40b5-9e9f-bca311e29431"), "Response to question 1", "Console.WriteLine(\"Hello World\");", false, new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(581), new Guid("61c606af-95a6-4afa-9f4e-a202d0a64a72"), null, "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("9f79c66d-54b5-496c-9b58-15dc8e8528f6"), "Another response to question 1", "Console.WriteLine(\"Hello World\");", false, new DateTime(2024, 6, 28, 6, 45, 32, 972, DateTimeKind.Utc).AddTicks(587), new Guid("0a38e6b2-8103-4703-9653-b3e4a7e9cd9f"), null, "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "Id", "IsUpvote", "ResponseId", "UserId", "VoteDate" },
                values: new object[,]
                {
                    { new Guid("049818f4-fcaf-400f-a42f-a2db9a3718ed"), false, new Guid("08e92f41-113c-40b5-9e9f-bca311e29431"), "680a7849-11d6-44d1-8ec5-fdac6ca72260", new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(738) },
                    { new Guid("0d5a3705-3b07-4887-b5f0-45292d95c66b"), true, new Guid("9f79c66d-54b5-496c-9b58-15dc8e8528f6"), "680a7849-11d6-44d1-8ec5-fdac6ca72260", new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(740) },
                    { new Guid("4cf08bbd-141e-49c5-97cf-eb357f1e536a"), true, new Guid("08e92f41-113c-40b5-9e9f-bca311e29431"), "680a7849-11d6-44d1-8ec5-fdac6ca72260", new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(736) }
                });
        }
    }
}
