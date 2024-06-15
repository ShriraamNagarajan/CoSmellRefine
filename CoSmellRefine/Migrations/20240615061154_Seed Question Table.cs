using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuestionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("13a065d5-ca26-4d8a-a111-00d5d8a54a66"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("20dfbb9c-44a9-4b0f-ad5c-b63ee265bc40"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("2a5ac66d-7d11-4e88-8efb-ce159bd74f30"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("3419bfc8-fd57-4579-8273-a2725e026b8e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("348c1d7c-1494-4250-a752-212eaef03f88"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("36161d94-8851-4fab-8e6a-2e3e61530bc2"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("39fad3d6-cee6-4bac-8af8-15c8734670dc"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("47ccc613-d146-483c-8e8e-03072ec6e588"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("57186e72-5735-43f1-bc91-17dc5e0f79bf"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("579ba1b7-1b50-4095-b7d5-03670cffe42d"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("5c48b022-bde1-4951-b7cf-cf8b483595a8"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("663e4f72-33da-40cd-b8c8-f0e9bb5122a9"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("687d1817-12b7-4ece-9cc2-03593349e03d"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("68907ad4-e064-4230-8f51-69c40f8bb403"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("6db6eadd-9a43-458d-babc-a0b18e99b66f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("794dcb80-b164-4753-bf12-601d7b65426d"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7bce4eec-ca0b-49b9-a6a5-3406fbd360da"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("98d0960b-8388-4021-9de7-aebb71720883"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ab012817-acf6-421c-bf25-95559212c115"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("bee57ecb-d3da-49b7-b046-d5a6eb998d6c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("cc6bba15-ced7-436c-91a2-a90d35a5c99d"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ecfea6ee-d995-4a57-a0ea-370b1d09f1c5"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("58468023-25de-4f8b-9646-2758fa476783"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("5cfd6987-5b43-4691-963f-502cf98feb47"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("8a88c7b4-62cf-4c60-b7f4-796324d37d76"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("51b3010a-c2c7-496b-963c-e90ec30f3de8"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("6e9f9feb-e0c3-4bef-b62a-714dc010dfe2"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("9744b6e9-40f2-4b3d-90ca-e11f740a7a28"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("c6e22fbc-5507-4e32-90bc-059c10f3297f"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("c7180354-60c6-4661-860d-eb0d23561602"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76de01f1-b52d-4a78-84a7-18d4a68a8151", "AQAAAAIAAYagAAAAELbZ9tvvBP/L1gLzq8SL/trWApAb9ZDCS58fGJriGVFNK8Bh+peshZ1eWlkY+VYFaQ==", "7428b89a-5471-4888-964d-d7a1de877264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03441c82-becd-4eab-9850-cac0e0a4a99f", "AQAAAAIAAYagAAAAEGugJ/12cqe12JcpXSVuPV4E6r/51o4rREP5oZEljmThniuFdSU5dJNknjL+31fe+A==", "33b20dd4-663b-4b12-ab0f-5a9132ed7b34" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "680a7849-11d6-44d1-8ec5-fdac6ca72260", 0, "ac8c426d-8b4e-4a0d-915e-a4fe0241aa47", "developer@cosmellrefine.com", false, false, null, "DEVELOPER@COSMELLREFINE.COM", "DEVELOPER@COSMELLREFINE.COM", "AQAAAAIAAYagAAAAED6cBW7xhFfc9AQn4or3Z7TL5UrHZrNJYjO70Jev49so0qRx9oZIn7C++T4E8o1Oxg==", null, false, "674b238a-3fbd-4ceb-b3e2-c9042b07e0d3", false, "developer@cosmellrefine.com" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("13ccdb71-c1c4-4107-a5a2-6260875d4a58"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "Bloaters" },
                    { new Guid("5fa10a73-2b26-47db-a339-789dd72fe22f"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "Dispensables" },
                    { new Guid("6d6c4c40-7bd3-4c4d-931a-378fd31280b8"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "Change Preventers" },
                    { new Guid("da5a9916-e264-4377-b45f-5243e1b6147e"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "Couplers" },
                    { new Guid("f5e346fa-690b-46fc-895b-7a8a85701b9b"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "Object Orientation Abusers" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsRead", "Message", "SentTime", "UserId" },
                values: new object[,]
                {
                    { new Guid("0424d1cb-72f0-4e33-aa44-56f53320671a"), false, "This is your first notification", new DateTime(2024, 6, 13, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6221), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("045de39d-b04e-423e-b167-9a107aed96bb"), true, "This is your second notification", new DateTime(2024, 6, 14, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6249), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("8ad3e951-71b1-4649-89cb-e1425667a23a"), false, "This is your first notification", new DateTime(2024, 6, 12, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6252), "0bb96526-4ffd-4846-8e00-ac29d53671d0" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "06b0066a-4de5-412e-9d62-0dda4d0cc709", "680a7849-11d6-44d1-8ec5-fdac6ca72260" });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("048a2c59-396f-471a-8eed-83f26367161f"), new Guid("5fa10a73-2b26-47db-a339-789dd72fe22f"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("0531b65f-fe6c-4f52-85d3-e5197eec43de"), new Guid("13ccdb71-c1c4-4107-a5a2-6260875d4a58"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("10e68e96-bca9-45f3-bd0e-f8d539eff9b1"), new Guid("da5a9916-e264-4377-b45f-5243e1b6147e"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("5ad71665-af08-44b4-b829-02dd9009667e"), new Guid("13ccdb71-c1c4-4107-a5a2-6260875d4a58"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" },
                    { new Guid("7664b336-c8ac-46d7-b49c-83657647ede8"), new Guid("f5e346fa-690b-46fc-895b-7a8a85701b9b"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("8515ecc4-5823-43d2-b174-75fd3593fd28"), new Guid("f5e346fa-690b-46fc-895b-7a8a85701b9b"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" },
                    { new Guid("8d872815-9821-4b04-824b-bc69ede2a531"), new Guid("5fa10a73-2b26-47db-a339-789dd72fe22f"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("949ebbfb-c247-4a94-b26c-fe2719348d50"), new Guid("5fa10a73-2b26-47db-a339-789dd72fe22f"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("94ea6baa-b216-4303-8a4c-ab4e55ec9f1c"), new Guid("5fa10a73-2b26-47db-a339-789dd72fe22f"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("98c8f357-437c-4012-8531-29a04119d805"), new Guid("f5e346fa-690b-46fc-895b-7a8a85701b9b"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("b0baf75c-d4df-4f35-befa-10b5fa9ff256"), new Guid("13ccdb71-c1c4-4107-a5a2-6260875d4a58"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("c8f46cb0-0476-4a2c-86a9-689207066f69"), new Guid("da5a9916-e264-4377-b45f-5243e1b6147e"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("cad6c9b4-6d97-4b00-a78f-bb3d56c9eca5"), new Guid("13ccdb71-c1c4-4107-a5a2-6260875d4a58"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("d0f810cc-f994-4973-b4e7-78f13160c86c"), new Guid("6d6c4c40-7bd3-4c4d-931a-378fd31280b8"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("d64ac881-3a9a-4bd4-8901-9a03825aed8f"), new Guid("6d6c4c40-7bd3-4c4d-931a-378fd31280b8"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("de57f463-9c70-468b-a1dd-98c942ada917"), new Guid("6d6c4c40-7bd3-4c4d-931a-378fd31280b8"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("e409baaf-6ee2-419f-848e-956b623a982e"), new Guid("da5a9916-e264-4377-b45f-5243e1b6147e"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("e58b8a02-392a-442e-8a1b-bbf6aa3790ca"), new Guid("5fa10a73-2b26-47db-a339-789dd72fe22f"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("e6c1a617-84c4-436d-9e36-78bedaefc8a0"), new Guid("5fa10a73-2b26-47db-a339-789dd72fe22f"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("e8ef58b4-0596-450a-82ea-db549f64e55a"), new Guid("da5a9916-e264-4377-b45f-5243e1b6147e"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("ed06ab85-8e90-4432-ade0-401296b64974"), new Guid("f5e346fa-690b-46fc-895b-7a8a85701b9b"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("f7516410-ed6e-47c0-85f1-ca70dd2f7bec"), new Guid("13ccdb71-c1c4-4107-a5a2-6260875d4a58"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Body", "CodeSnippet", "ModifiedDate", "PostedDate", "Status", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("55193247-a474-4136-a1d3-e6473ac8630a"), "Body of question 2", "CodeSnippet2", new DateTime(2024, 6, 15, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6292), new DateTime(2024, 6, 14, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6291), "Open", "Question 2", "Refactoring Technique Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("a1b0853a-cd0d-42c6-9f46-c6f2255d1a4b"), "Body of question 1", "CodeSnippet1", new DateTime(2024, 6, 15, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6288), new DateTime(2024, 6, 15, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6287), "Closed", "Question 1", "Code Smell Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Body", "PostedDate", "QuestionId", "QuestionId1", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c57129f-4184-479a-90d1-16f70b61dac4"), "Another response to question 1", new DateTime(2024, 6, 15, 5, 41, 54, 91, DateTimeKind.Utc).AddTicks(6357), new Guid("55193247-a474-4136-a1d3-e6473ac8630a"), null, "Pending", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("7301fb56-eeb9-495e-9934-e6967cb55a68"), "Response to question 1", new DateTime(2024, 6, 15, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6355), new Guid("a1b0853a-cd0d-42c6-9f46-c6f2255d1a4b"), null, "Accepted", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "06b0066a-4de5-412e-9d62-0dda4d0cc709", "680a7849-11d6-44d1-8ec5-fdac6ca72260" });

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("048a2c59-396f-471a-8eed-83f26367161f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("0531b65f-fe6c-4f52-85d3-e5197eec43de"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("10e68e96-bca9-45f3-bd0e-f8d539eff9b1"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("5ad71665-af08-44b4-b829-02dd9009667e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7664b336-c8ac-46d7-b49c-83657647ede8"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("8515ecc4-5823-43d2-b174-75fd3593fd28"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("8d872815-9821-4b04-824b-bc69ede2a531"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("949ebbfb-c247-4a94-b26c-fe2719348d50"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("94ea6baa-b216-4303-8a4c-ab4e55ec9f1c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("98c8f357-437c-4012-8531-29a04119d805"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("b0baf75c-d4df-4f35-befa-10b5fa9ff256"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("c8f46cb0-0476-4a2c-86a9-689207066f69"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("cad6c9b4-6d97-4b00-a78f-bb3d56c9eca5"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("d0f810cc-f994-4973-b4e7-78f13160c86c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("d64ac881-3a9a-4bd4-8901-9a03825aed8f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("de57f463-9c70-468b-a1dd-98c942ada917"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e409baaf-6ee2-419f-848e-956b623a982e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e58b8a02-392a-442e-8a1b-bbf6aa3790ca"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e6c1a617-84c4-436d-9e36-78bedaefc8a0"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e8ef58b4-0596-450a-82ea-db549f64e55a"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ed06ab85-8e90-4432-ade0-401296b64974"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("f7516410-ed6e-47c0-85f1-ca70dd2f7bec"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("0424d1cb-72f0-4e33-aa44-56f53320671a"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("045de39d-b04e-423e-b167-9a107aed96bb"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("8ad3e951-71b1-4649-89cb-e1425667a23a"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("1c57129f-4184-479a-90d1-16f70b61dac4"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("7301fb56-eeb9-495e-9934-e6967cb55a68"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("13ccdb71-c1c4-4107-a5a2-6260875d4a58"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("5fa10a73-2b26-47db-a339-789dd72fe22f"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d6c4c40-7bd3-4c4d-931a-378fd31280b8"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("da5a9916-e264-4377-b45f-5243e1b6147e"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("f5e346fa-690b-46fc-895b-7a8a85701b9b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("55193247-a474-4136-a1d3-e6473ac8630a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a1b0853a-cd0d-42c6-9f46-c6f2255d1a4b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "680a7849-11d6-44d1-8ec5-fdac6ca72260");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a622738-2a5d-4c87-8ad6-9f24ebb0f098", "AQAAAAIAAYagAAAAEESXuWX1yiusB8OBjOGgmmBqcQaTqtPRJrPcx4pBTFfCwdU2wce4jixrtesWC4E10g==", "bb936f4c-eca5-44e2-88d4-3df8fc9a3199" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd981552-0428-4e4d-959d-f3c12bb13416", "AQAAAAIAAYagAAAAEFXwS4ObNi7u37+p81WrVqDy5c1xUD6usPmLnkoYz5W59ZJ8BzjYhAz2vVARXBbwfw==", "2dc520c6-b173-4b8e-9c35-ba154bbd9660" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("51b3010a-c2c7-496b-963c-e90ec30f3de8"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "Change Preventers" },
                    { new Guid("6e9f9feb-e0c3-4bef-b62a-714dc010dfe2"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "Bloaters" },
                    { new Guid("9744b6e9-40f2-4b3d-90ca-e11f740a7a28"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "Couplers" },
                    { new Guid("c6e22fbc-5507-4e32-90bc-059c10f3297f"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "Object Orientation Abusers" },
                    { new Guid("c7180354-60c6-4661-860d-eb0d23561602"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "Dispensables" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsRead", "Message", "SentTime", "UserId" },
                values: new object[,]
                {
                    { new Guid("58468023-25de-4f8b-9646-2758fa476783"), false, "This is your first notification", new DateTime(2024, 6, 12, 1, 0, 44, 533, DateTimeKind.Utc).AddTicks(8960), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("5cfd6987-5b43-4691-963f-502cf98feb47"), true, "This is your second notification", new DateTime(2024, 6, 14, 1, 0, 44, 533, DateTimeKind.Utc).AddTicks(8953), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("8a88c7b4-62cf-4c60-b7f4-796324d37d76"), false, "This is your first notification", new DateTime(2024, 6, 13, 1, 0, 44, 533, DateTimeKind.Utc).AddTicks(8942), "0bb96526-4ffd-4846-8e00-ac29d53671d0" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("13a065d5-ca26-4d8a-a111-00d5d8a54a66"), new Guid("6e9f9feb-e0c3-4bef-b62a-714dc010dfe2"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" },
                    { new Guid("20dfbb9c-44a9-4b0f-ad5c-b63ee265bc40"), new Guid("6e9f9feb-e0c3-4bef-b62a-714dc010dfe2"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("2a5ac66d-7d11-4e88-8efb-ce159bd74f30"), new Guid("c7180354-60c6-4661-860d-eb0d23561602"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("3419bfc8-fd57-4579-8273-a2725e026b8e"), new Guid("6e9f9feb-e0c3-4bef-b62a-714dc010dfe2"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("348c1d7c-1494-4250-a752-212eaef03f88"), new Guid("9744b6e9-40f2-4b3d-90ca-e11f740a7a28"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("36161d94-8851-4fab-8e6a-2e3e61530bc2"), new Guid("c7180354-60c6-4661-860d-eb0d23561602"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("39fad3d6-cee6-4bac-8af8-15c8734670dc"), new Guid("c6e22fbc-5507-4e32-90bc-059c10f3297f"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" },
                    { new Guid("47ccc613-d146-483c-8e8e-03072ec6e588"), new Guid("c7180354-60c6-4661-860d-eb0d23561602"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("57186e72-5735-43f1-bc91-17dc5e0f79bf"), new Guid("9744b6e9-40f2-4b3d-90ca-e11f740a7a28"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("579ba1b7-1b50-4095-b7d5-03670cffe42d"), new Guid("6e9f9feb-e0c3-4bef-b62a-714dc010dfe2"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("5c48b022-bde1-4951-b7cf-cf8b483595a8"), new Guid("c6e22fbc-5507-4e32-90bc-059c10f3297f"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("663e4f72-33da-40cd-b8c8-f0e9bb5122a9"), new Guid("c7180354-60c6-4661-860d-eb0d23561602"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("687d1817-12b7-4ece-9cc2-03593349e03d"), new Guid("9744b6e9-40f2-4b3d-90ca-e11f740a7a28"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("68907ad4-e064-4230-8f51-69c40f8bb403"), new Guid("51b3010a-c2c7-496b-963c-e90ec30f3de8"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("6db6eadd-9a43-458d-babc-a0b18e99b66f"), new Guid("c7180354-60c6-4661-860d-eb0d23561602"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("794dcb80-b164-4753-bf12-601d7b65426d"), new Guid("51b3010a-c2c7-496b-963c-e90ec30f3de8"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("7bce4eec-ca0b-49b9-a6a5-3406fbd360da"), new Guid("6e9f9feb-e0c3-4bef-b62a-714dc010dfe2"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" },
                    { new Guid("98d0960b-8388-4021-9de7-aebb71720883"), new Guid("c6e22fbc-5507-4e32-90bc-059c10f3297f"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("ab012817-acf6-421c-bf25-95559212c115"), new Guid("c6e22fbc-5507-4e32-90bc-059c10f3297f"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("bee57ecb-d3da-49b7-b046-d5a6eb998d6c"), new Guid("c7180354-60c6-4661-860d-eb0d23561602"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("cc6bba15-ced7-436c-91a2-a90d35a5c99d"), new Guid("9744b6e9-40f2-4b3d-90ca-e11f740a7a28"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("ecfea6ee-d995-4a57-a0ea-370b1d09f1c5"), new Guid("51b3010a-c2c7-496b-963c-e90ec30f3de8"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" }
                });
        }
    }
}
