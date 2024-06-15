using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedQuestionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Questions");

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
        }
    }
}
