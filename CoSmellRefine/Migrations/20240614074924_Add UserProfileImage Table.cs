using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class AddUserProfileImageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("06af262a-6fa6-42b3-8f42-3f351b11bccf"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("1ae66fc4-66de-4d52-91c3-db0ceb211530"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("2178fc16-65db-41a0-811e-0e901ce2603c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("24c2d10b-95bd-41a1-8b15-90013c1369d7"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("3ef46211-c501-40e0-a88e-83ac0a3bbf1f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("4bd94478-6944-44af-83df-07ae68a4cc81"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("505d221d-8221-48b6-b23a-e47bc5bf6c5e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("57dd9254-7aa7-4246-ad57-aa1f27c2fc37"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("5cf85d87-14ae-40c5-bd64-39d830fffbe8"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("67806903-9697-404f-af91-9336bee9c365"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("6804131c-bc29-4e6b-9545-1ba3f0c5b470"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("8a03658b-3224-4348-9f9f-b2b52fc082a0"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("8ec27fc9-40ab-4d25-9671-dd7f178fa464"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("94b46499-9750-4420-b74c-168ab7a0556f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("9a3b12fe-a22f-4706-b2d5-bc3c793eb8d6"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("a2e20d67-5023-4923-8545-af002022f451"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("a982298d-fcc9-4199-926c-e56ece119286"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("c5a00ce7-ba83-4329-9f6a-0c0ce2900616"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e1f1cd82-aca5-40a6-9d16-1c69eda8407e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e3559d3a-259c-4314-ba8b-0b25295191d7"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ea3a3224-2d5a-43ff-a2cc-f427f79206ad"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ebcfeee5-2899-410d-96b5-7782561c6213"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("46589a39-8768-442a-9d66-7a47877ea606"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("cf88753d-77f1-43ce-9621-8f15ded4383e"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("e1993765-7a6d-4fc1-993b-8a8c50e9cbaa"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("5213dfc8-7187-40c9-af73-176bc61d35d8"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("80532ed2-4d7e-45c9-983c-622077d66558"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("acdb87ed-74c8-426a-9b83-0e12ab20ce2a"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("c45c392f-44f0-4f92-9bc8-9bbd601a3b34"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1607fd9-0761-4051-88c2-47ca12a2722d"));

            migrationBuilder.CreateTable(
                name: "UserProfileImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfileImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfileImages_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa66c499-5cfb-4063-99f0-08ebc6451ea7", "AQAAAAIAAYagAAAAEPFHRW7mXy4fmzfyK1xVXbhhXnDEac2oyYg+v+jI7xZQevFLBfJ8UUlhgziah5+xDw==", "ebab0bfa-9508-402f-a006-e2d04b816d21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51b872bc-d742-4987-a2b9-b1df74d25ab6", "AQAAAAIAAYagAAAAEEl9sf/JxoRisKFM2uOR7+ONj3rrQ1ygnvV/u6yJweqdwUQgvIXAuxv/cMw7IMb5nA==", "8d1b566d-77f6-43fe-a5b7-4e70803dc076" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("01d42116-b553-462e-b9aa-0b6b7e93208e"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "Change Preventers" },
                    { new Guid("532dbdb3-f639-4468-a1ea-7bdc9b70e324"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "Dispensables" },
                    { new Guid("ac8b0083-cc48-4c42-8a8d-e4d72c57195a"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "Couplers" },
                    { new Guid("b31adc79-2529-46b7-8cd6-f36b570f3eb2"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "Object Orientation Abusers" },
                    { new Guid("d516c542-1618-4037-b944-1adb5bac39b9"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "Bloaters" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsRead", "Message", "SentTime", "UserId" },
                values: new object[,]
                {
                    { new Guid("642f75f6-2ab7-4f2d-95ae-3b9f6aeed600"), true, "This is your second notification", new DateTime(2024, 6, 13, 7, 49, 23, 782, DateTimeKind.Utc).AddTicks(5919), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("a15d0fc8-a99e-48a4-aed6-c12ecd6af2e2"), false, "This is your first notification", new DateTime(2024, 6, 12, 7, 49, 23, 782, DateTimeKind.Utc).AddTicks(5906), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("c2ff895f-aaa3-4de6-a027-80a68fc13f4b"), false, "This is your first notification", new DateTime(2024, 6, 11, 7, 49, 23, 782, DateTimeKind.Utc).AddTicks(5921), "0bb96526-4ffd-4846-8e00-ac29d53671d0" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00d3111b-c5c1-478d-9af1-a64dab038e12"), new Guid("d516c542-1618-4037-b944-1adb5bac39b9"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("025ed894-3517-4750-96a1-62e800810e4c"), new Guid("532dbdb3-f639-4468-a1ea-7bdc9b70e324"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("0c7fe465-bc5a-4648-b7bc-bea4ddff6cc3"), new Guid("01d42116-b553-462e-b9aa-0b6b7e93208e"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("107c8f4b-8710-424d-bc89-66fd3ffe2391"), new Guid("532dbdb3-f639-4468-a1ea-7bdc9b70e324"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("1c8bf61e-66e6-4cd8-8171-562a3fef21eb"), new Guid("d516c542-1618-4037-b944-1adb5bac39b9"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("1e062bea-264d-4d1a-b4e0-50acf07e1871"), new Guid("d516c542-1618-4037-b944-1adb5bac39b9"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("20b59542-2451-49c9-b390-c74ce685d20f"), new Guid("b31adc79-2529-46b7-8cd6-f36b570f3eb2"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("2856117b-e168-43dd-ab76-fb7d79345e85"), new Guid("ac8b0083-cc48-4c42-8a8d-e4d72c57195a"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("2d656e05-e0da-4e64-87d4-83a2c26a519c"), new Guid("532dbdb3-f639-4468-a1ea-7bdc9b70e324"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("4f4dffc8-42fa-490e-b176-74a8c3712ff3"), new Guid("ac8b0083-cc48-4c42-8a8d-e4d72c57195a"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("5ef6b2f0-f9da-48d2-aa71-1fb84c906077"), new Guid("b31adc79-2529-46b7-8cd6-f36b570f3eb2"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("67db1d7d-54aa-4d57-ab2b-73a240f5db8e"), new Guid("b31adc79-2529-46b7-8cd6-f36b570f3eb2"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("7d7311e8-ceb2-4af9-a1ac-5d7d7e3100a3"), new Guid("532dbdb3-f639-4468-a1ea-7bdc9b70e324"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("919bbd42-daec-4caa-9a5e-d5e49525c5b7"), new Guid("ac8b0083-cc48-4c42-8a8d-e4d72c57195a"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("92b3e939-87c3-4612-b811-5672fb00ff23"), new Guid("01d42116-b553-462e-b9aa-0b6b7e93208e"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("96d5e052-d0dc-40f4-ab94-4ce2353f6b66"), new Guid("d516c542-1618-4037-b944-1adb5bac39b9"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" },
                    { new Guid("bed63c07-c721-49da-85c8-c0553b09ae12"), new Guid("d516c542-1618-4037-b944-1adb5bac39b9"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" },
                    { new Guid("ce56377a-e8f2-491c-ac05-25cf221f7a69"), new Guid("01d42116-b553-462e-b9aa-0b6b7e93208e"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("f0b010f8-d557-426e-81bc-45b5b3c7edd8"), new Guid("532dbdb3-f639-4468-a1ea-7bdc9b70e324"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("f193f8e4-0101-4939-876b-623ff35802a7"), new Guid("ac8b0083-cc48-4c42-8a8d-e4d72c57195a"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("f752eaf3-0a56-49a0-8d1b-4da6bf88207b"), new Guid("532dbdb3-f639-4468-a1ea-7bdc9b70e324"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("ffada982-28e2-4f06-873b-438a04436e9c"), new Guid("b31adc79-2529-46b7-8cd6-f36b570f3eb2"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfileImages_UserID",
                table: "UserProfileImages",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfileImages");

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("00d3111b-c5c1-478d-9af1-a64dab038e12"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("025ed894-3517-4750-96a1-62e800810e4c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("0c7fe465-bc5a-4648-b7bc-bea4ddff6cc3"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("107c8f4b-8710-424d-bc89-66fd3ffe2391"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("1c8bf61e-66e6-4cd8-8171-562a3fef21eb"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("1e062bea-264d-4d1a-b4e0-50acf07e1871"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("20b59542-2451-49c9-b390-c74ce685d20f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("2856117b-e168-43dd-ab76-fb7d79345e85"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("2d656e05-e0da-4e64-87d4-83a2c26a519c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("4f4dffc8-42fa-490e-b176-74a8c3712ff3"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("5ef6b2f0-f9da-48d2-aa71-1fb84c906077"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("67db1d7d-54aa-4d57-ab2b-73a240f5db8e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7d7311e8-ceb2-4af9-a1ac-5d7d7e3100a3"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("919bbd42-daec-4caa-9a5e-d5e49525c5b7"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("92b3e939-87c3-4612-b811-5672fb00ff23"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("96d5e052-d0dc-40f4-ab94-4ce2353f6b66"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("bed63c07-c721-49da-85c8-c0553b09ae12"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ce56377a-e8f2-491c-ac05-25cf221f7a69"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("f0b010f8-d557-426e-81bc-45b5b3c7edd8"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("f193f8e4-0101-4939-876b-623ff35802a7"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("f752eaf3-0a56-49a0-8d1b-4da6bf88207b"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ffada982-28e2-4f06-873b-438a04436e9c"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("642f75f6-2ab7-4f2d-95ae-3b9f6aeed600"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("a15d0fc8-a99e-48a4-aed6-c12ecd6af2e2"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("c2ff895f-aaa3-4de6-a027-80a68fc13f4b"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("01d42116-b553-462e-b9aa-0b6b7e93208e"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("532dbdb3-f639-4468-a1ea-7bdc9b70e324"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac8b0083-cc48-4c42-8a8d-e4d72c57195a"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("b31adc79-2529-46b7-8cd6-f36b570f3eb2"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("d516c542-1618-4037-b944-1adb5bac39b9"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9c39420-e605-4e27-ad67-c9305eeeafe7", "AQAAAAIAAYagAAAAELlMm4jIvE2DUfxhS8yiXyduhuEBaT2fb0X4ZTRZuPiF9XxT7/eoa6RbEUupGRlFRw==", "8283158f-15bf-40dd-a5a5-fb5db7f1bdb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6125f0fa-08c1-4ffb-bff6-c7b7f3191f5e", "AQAAAAIAAYagAAAAEG7rUGsTboC7hljKxL9CaRjlJ3xARI//I4qtQnziLs3DTasT0D53I5f7SgtfbVddNQ==", "a5ecc110-8a6f-4edb-9424-5ff9db358cc9" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("5213dfc8-7187-40c9-af73-176bc61d35d8"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "Change Preventers" },
                    { new Guid("80532ed2-4d7e-45c9-983c-622077d66558"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "Object Orientation Abusers" },
                    { new Guid("acdb87ed-74c8-426a-9b83-0e12ab20ce2a"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "Dispensables" },
                    { new Guid("c45c392f-44f0-4f92-9bc8-9bbd601a3b34"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "Couplers" },
                    { new Guid("d1607fd9-0761-4051-88c2-47ca12a2722d"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "Bloaters" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsRead", "Message", "SentTime", "UserId" },
                values: new object[,]
                {
                    { new Guid("46589a39-8768-442a-9d66-7a47877ea606"), false, "This is your first notification", new DateTime(2024, 6, 12, 6, 26, 54, 903, DateTimeKind.Utc).AddTicks(6985), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("cf88753d-77f1-43ce-9621-8f15ded4383e"), true, "This is your second notification", new DateTime(2024, 6, 13, 6, 26, 54, 903, DateTimeKind.Utc).AddTicks(7005), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("e1993765-7a6d-4fc1-993b-8a8c50e9cbaa"), false, "This is your first notification", new DateTime(2024, 6, 11, 6, 26, 54, 903, DateTimeKind.Utc).AddTicks(7008), "0bb96526-4ffd-4846-8e00-ac29d53671d0" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("06af262a-6fa6-42b3-8f42-3f351b11bccf"), new Guid("80532ed2-4d7e-45c9-983c-622077d66558"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("1ae66fc4-66de-4d52-91c3-db0ceb211530"), new Guid("acdb87ed-74c8-426a-9b83-0e12ab20ce2a"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("2178fc16-65db-41a0-811e-0e901ce2603c"), new Guid("5213dfc8-7187-40c9-af73-176bc61d35d8"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("24c2d10b-95bd-41a1-8b15-90013c1369d7"), new Guid("5213dfc8-7187-40c9-af73-176bc61d35d8"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("3ef46211-c501-40e0-a88e-83ac0a3bbf1f"), new Guid("acdb87ed-74c8-426a-9b83-0e12ab20ce2a"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("4bd94478-6944-44af-83df-07ae68a4cc81"), new Guid("d1607fd9-0761-4051-88c2-47ca12a2722d"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("505d221d-8221-48b6-b23a-e47bc5bf6c5e"), new Guid("acdb87ed-74c8-426a-9b83-0e12ab20ce2a"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("57dd9254-7aa7-4246-ad57-aa1f27c2fc37"), new Guid("5213dfc8-7187-40c9-af73-176bc61d35d8"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("5cf85d87-14ae-40c5-bd64-39d830fffbe8"), new Guid("d1607fd9-0761-4051-88c2-47ca12a2722d"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("67806903-9697-404f-af91-9336bee9c365"), new Guid("d1607fd9-0761-4051-88c2-47ca12a2722d"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" },
                    { new Guid("6804131c-bc29-4e6b-9545-1ba3f0c5b470"), new Guid("80532ed2-4d7e-45c9-983c-622077d66558"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("8a03658b-3224-4348-9f9f-b2b52fc082a0"), new Guid("80532ed2-4d7e-45c9-983c-622077d66558"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("8ec27fc9-40ab-4d25-9671-dd7f178fa464"), new Guid("acdb87ed-74c8-426a-9b83-0e12ab20ce2a"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("94b46499-9750-4420-b74c-168ab7a0556f"), new Guid("c45c392f-44f0-4f92-9bc8-9bbd601a3b34"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("9a3b12fe-a22f-4706-b2d5-bc3c793eb8d6"), new Guid("acdb87ed-74c8-426a-9b83-0e12ab20ce2a"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("a2e20d67-5023-4923-8545-af002022f451"), new Guid("80532ed2-4d7e-45c9-983c-622077d66558"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" },
                    { new Guid("a982298d-fcc9-4199-926c-e56ece119286"), new Guid("d1607fd9-0761-4051-88c2-47ca12a2722d"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("c5a00ce7-ba83-4329-9f6a-0c0ce2900616"), new Guid("c45c392f-44f0-4f92-9bc8-9bbd601a3b34"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("e1f1cd82-aca5-40a6-9d16-1c69eda8407e"), new Guid("d1607fd9-0761-4051-88c2-47ca12a2722d"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" },
                    { new Guid("e3559d3a-259c-4314-ba8b-0b25295191d7"), new Guid("c45c392f-44f0-4f92-9bc8-9bbd601a3b34"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("ea3a3224-2d5a-43ff-a2cc-f427f79206ad"), new Guid("acdb87ed-74c8-426a-9b83-0e12ab20ce2a"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("ebcfeee5-2899-410d-96b5-7782561c6213"), new Guid("c45c392f-44f0-4f92-9bc8-9bbd601a3b34"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" }
                });
        }
    }
}
