using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class SeedCodeSmellandCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d79eabc-ed8f-4729-bd16-120507147f1a", "AQAAAAIAAYagAAAAENJcMm0wP0TbRbU1w5xXIZloaa0oEiR8DY4Xs9mtavw5+HgSej3J701hJ668uKGWXQ==", "42f1157b-6433-4e9b-ae8a-dbe7d8ee5915" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d27516e-f46c-4103-9b4b-5439cf96ef00", "AQAAAAIAAYagAAAAEDQmEp+OiGcaMfHeHVZCVdo2Zf/xin+Zuuwo4Sn+KPZYslfmSCBLmIygIxUX/tuDlA==", "54b6b82d-4cae-463e-b276-a81138b7625e" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("283da0f2-2f50-41b5-984d-1be19a089ece"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "Bloaters" },
                    { new Guid("85a9441c-06ef-48b0-b5da-5c9e4ffce67c"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "Dispensables" },
                    { new Guid("8aa35427-b797-4d97-9c68-c7dd7ed6417b"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "Object Orientation Abusers" },
                    { new Guid("9b7b7b0e-6e30-4721-94e8-2c5a4ed748fa"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "Couplers" },
                    { new Guid("f0522d16-9140-4380-83f4-cf02b662e116"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "Change Preventers" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("08c83954-a276-40cd-9913-c11557fa0297"), new Guid("283da0f2-2f50-41b5-984d-1be19a089ece"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("1841fc3a-c860-4dd0-8cf7-e9c742a91511"), new Guid("85a9441c-06ef-48b0-b5da-5c9e4ffce67c"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("28a29476-4d44-4666-9c3b-5e4b1abbcbc3"), new Guid("9b7b7b0e-6e30-4721-94e8-2c5a4ed748fa"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("49bbbf7e-3723-40c2-aef4-c650ffd419f3"), new Guid("85a9441c-06ef-48b0-b5da-5c9e4ffce67c"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("4d4f1e76-b641-48b9-a458-26a2eee9b2bf"), new Guid("85a9441c-06ef-48b0-b5da-5c9e4ffce67c"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("64f5a831-6da4-4930-8410-e084d8bfaf6f"), new Guid("8aa35427-b797-4d97-9c68-c7dd7ed6417b"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" },
                    { new Guid("68acd5a9-7313-42c4-aa4f-b5698cdfc9a4"), new Guid("9b7b7b0e-6e30-4721-94e8-2c5a4ed748fa"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("6b6b10e6-7672-4578-b9fd-1f3262851bd9"), new Guid("283da0f2-2f50-41b5-984d-1be19a089ece"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("7ea36232-79b1-4ef3-bb57-ffa9f023467c"), new Guid("8aa35427-b797-4d97-9c68-c7dd7ed6417b"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("8dcbf3fe-a2ee-47e5-9663-4dac6718d59a"), new Guid("85a9441c-06ef-48b0-b5da-5c9e4ffce67c"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("8e21c744-87ae-4f67-85ae-98699ea58db2"), new Guid("9b7b7b0e-6e30-4721-94e8-2c5a4ed748fa"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("90c375ad-5bc7-4d98-8c25-7995f98b1c07"), new Guid("85a9441c-06ef-48b0-b5da-5c9e4ffce67c"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("bd25bce2-b8ce-4ad0-976c-d8d561ba79a0"), new Guid("f0522d16-9140-4380-83f4-cf02b662e116"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("c72af66f-4e89-40bc-b5d2-365d1961e37e"), new Guid("85a9441c-06ef-48b0-b5da-5c9e4ffce67c"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("cb369f6b-3ac4-4eec-acb3-9fa974e2a752"), new Guid("9b7b7b0e-6e30-4721-94e8-2c5a4ed748fa"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("cc2a05ab-fa62-487f-ba7b-5f98121c24e4"), new Guid("283da0f2-2f50-41b5-984d-1be19a089ece"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("db4491ba-a42e-4aaa-85c0-9d5539ba4cfd"), new Guid("283da0f2-2f50-41b5-984d-1be19a089ece"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" },
                    { new Guid("dc57dc92-406d-4028-aa02-55b264e39ddd"), new Guid("f0522d16-9140-4380-83f4-cf02b662e116"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("dc9e94c8-33f8-43ed-9116-bff76de41172"), new Guid("283da0f2-2f50-41b5-984d-1be19a089ece"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" },
                    { new Guid("edb024fd-c652-494f-b6be-10480581a97a"), new Guid("f0522d16-9140-4380-83f4-cf02b662e116"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("fcc0154d-c389-4425-b884-8f9ed817f492"), new Guid("8aa35427-b797-4d97-9c68-c7dd7ed6417b"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("ff43f907-a6be-4418-8591-a3790c4e078b"), new Guid("8aa35427-b797-4d97-9c68-c7dd7ed6417b"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("08c83954-a276-40cd-9913-c11557fa0297"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("1841fc3a-c860-4dd0-8cf7-e9c742a91511"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("28a29476-4d44-4666-9c3b-5e4b1abbcbc3"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("49bbbf7e-3723-40c2-aef4-c650ffd419f3"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("4d4f1e76-b641-48b9-a458-26a2eee9b2bf"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("64f5a831-6da4-4930-8410-e084d8bfaf6f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("68acd5a9-7313-42c4-aa4f-b5698cdfc9a4"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("6b6b10e6-7672-4578-b9fd-1f3262851bd9"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7ea36232-79b1-4ef3-bb57-ffa9f023467c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("8dcbf3fe-a2ee-47e5-9663-4dac6718d59a"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("8e21c744-87ae-4f67-85ae-98699ea58db2"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("90c375ad-5bc7-4d98-8c25-7995f98b1c07"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("bd25bce2-b8ce-4ad0-976c-d8d561ba79a0"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("c72af66f-4e89-40bc-b5d2-365d1961e37e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("cb369f6b-3ac4-4eec-acb3-9fa974e2a752"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("cc2a05ab-fa62-487f-ba7b-5f98121c24e4"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("db4491ba-a42e-4aaa-85c0-9d5539ba4cfd"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("dc57dc92-406d-4028-aa02-55b264e39ddd"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("dc9e94c8-33f8-43ed-9116-bff76de41172"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("edb024fd-c652-494f-b6be-10480581a97a"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("fcc0154d-c389-4425-b884-8f9ed817f492"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ff43f907-a6be-4418-8591-a3790c4e078b"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("283da0f2-2f50-41b5-984d-1be19a089ece"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("85a9441c-06ef-48b0-b5da-5c9e4ffce67c"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("8aa35427-b797-4d97-9c68-c7dd7ed6417b"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b7b7b0e-6e30-4721-94e8-2c5a4ed748fa"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0522d16-9140-4380-83f4-cf02b662e116"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caf14e55-aea8-46f9-8373-ead925c34cb8", "AQAAAAIAAYagAAAAEAaMvPPNo14+zoedkHltRDPBHdA5ZAiTYpfdaCEZ8Uqxj//orYW7K6dgJf9qq1Siqw==", "0b5147ae-e08b-4e1a-a296-0c3ded8fc42b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64632fb0-c494-4d60-b0b8-660017c1cd1d", "AQAAAAIAAYagAAAAEMaQXejtx7UkaazMaUTwtcW5M2354IC7PDPQDnBJx9gbgoUNrtJMeh4O2LZxHknfTg==", "3df358bf-1ed3-419c-bcb1-81f73baed7a0" });
        }
    }
}
