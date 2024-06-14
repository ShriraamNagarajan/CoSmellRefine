using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class AddedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Choices",
                table: "Quiz",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8483294-34a3-44e7-aea6-80b861978659", "AQAAAAIAAYagAAAAEEDbv6F0yfrdEhxIr9GVTkwgY9jGJbToGJ7O1y+gjXslDJKAIk9qHxwZHD4Kux02fA==", "8912aaca-5e3d-4097-a733-1f1897a67fa9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0e4055-3bba-4fef-ba7a-e14ec000de39", "AQAAAAIAAYagAAAAEM4fPkUR7CK47Tv4UwczsUu59xXEP2+Q8xOT63oiJ8+KU+vOUObNtJHDyDQC4EeY6A==", "c24bc1f0-b8ae-4f73-a8cf-645f09332bd1" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2cfba27c-a44e-40df-8ab5-5421d8ecb0df"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "Bloaters" },
                    { new Guid("5300881b-ff6c-4364-a53c-d5bfe8bdb02f"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "Object Orientation Abusers" },
                    { new Guid("5d0ed1ef-aa0e-434a-9136-991d7c557d5c"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "Couplers" },
                    { new Guid("649d79a9-82c0-47be-aff5-ca9e45186a65"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "Dispensables" },
                    { new Guid("f72db8d8-1bb5-41b8-be05-8df190f0bc59"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "Change Preventers" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("138af249-fa5c-4d46-899e-faed5d308c9e"), new Guid("5300881b-ff6c-4364-a53c-d5bfe8bdb02f"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("29728e00-470b-4d48-bc2b-beda4beec9c7"), new Guid("649d79a9-82c0-47be-aff5-ca9e45186a65"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("2e367e79-3617-4378-95be-06922e17ea7c"), new Guid("2cfba27c-a44e-40df-8ab5-5421d8ecb0df"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("352cbdea-49b7-4248-b9dd-3e56d293f304"), new Guid("5d0ed1ef-aa0e-434a-9136-991d7c557d5c"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("40d0feaa-1396-4c8d-875d-efff515c42cb"), new Guid("5300881b-ff6c-4364-a53c-d5bfe8bdb02f"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("537cb4e9-60bf-443e-a267-f0b470a38bab"), new Guid("f72db8d8-1bb5-41b8-be05-8df190f0bc59"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("56dbd8b4-e1d9-4739-bdcc-b2a55c3b2da4"), new Guid("649d79a9-82c0-47be-aff5-ca9e45186a65"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("66baa4d6-92c7-4a99-a96f-1cb25b9bdc3d"), new Guid("5d0ed1ef-aa0e-434a-9136-991d7c557d5c"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("6cc18cc8-29f9-485d-a8d3-9ca3d168b33e"), new Guid("2cfba27c-a44e-40df-8ab5-5421d8ecb0df"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" },
                    { new Guid("73f9dcad-252e-458f-b24b-6b4f4dec52d0"), new Guid("649d79a9-82c0-47be-aff5-ca9e45186a65"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("75bb3ce5-dcee-4162-a3a9-f63516fadfaf"), new Guid("649d79a9-82c0-47be-aff5-ca9e45186a65"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("7c8ea8a2-9958-4853-948c-016c19935b44"), new Guid("5300881b-ff6c-4364-a53c-d5bfe8bdb02f"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" },
                    { new Guid("7d6d5c81-be1c-49c9-94c5-f0c314801eee"), new Guid("2cfba27c-a44e-40df-8ab5-5421d8ecb0df"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" },
                    { new Guid("97a90f42-3796-4813-80d5-d1fcb2c448dd"), new Guid("5300881b-ff6c-4364-a53c-d5bfe8bdb02f"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("9efb5462-83dd-43e7-935f-88d4e24347dc"), new Guid("f72db8d8-1bb5-41b8-be05-8df190f0bc59"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("a8e23935-ca0a-4598-8763-aa752f1e2abe"), new Guid("649d79a9-82c0-47be-aff5-ca9e45186a65"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("aab3cbc9-ad5c-4a94-93a7-3a5b53553e36"), new Guid("2cfba27c-a44e-40df-8ab5-5421d8ecb0df"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("b190266a-498e-4144-b71e-b1fd419fafcb"), new Guid("5d0ed1ef-aa0e-434a-9136-991d7c557d5c"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("b43725ff-04cb-491d-849d-43c34f6fcc2a"), new Guid("2cfba27c-a44e-40df-8ab5-5421d8ecb0df"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("d2dc16d3-f841-48d9-b9b3-a01b7d33eeb2"), new Guid("5d0ed1ef-aa0e-434a-9136-991d7c557d5c"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("ea2fef33-7df9-4845-ac66-50ece2cc2369"), new Guid("f72db8d8-1bb5-41b8-be05-8df190f0bc59"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("f24acd86-d5a3-4a18-84f1-02030fdd980a"), new Guid("649d79a9-82c0-47be-aff5-ca9e45186a65"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("138af249-fa5c-4d46-899e-faed5d308c9e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("29728e00-470b-4d48-bc2b-beda4beec9c7"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("2e367e79-3617-4378-95be-06922e17ea7c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("352cbdea-49b7-4248-b9dd-3e56d293f304"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("40d0feaa-1396-4c8d-875d-efff515c42cb"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("537cb4e9-60bf-443e-a267-f0b470a38bab"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("56dbd8b4-e1d9-4739-bdcc-b2a55c3b2da4"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("66baa4d6-92c7-4a99-a96f-1cb25b9bdc3d"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("6cc18cc8-29f9-485d-a8d3-9ca3d168b33e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("73f9dcad-252e-458f-b24b-6b4f4dec52d0"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("75bb3ce5-dcee-4162-a3a9-f63516fadfaf"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7c8ea8a2-9958-4853-948c-016c19935b44"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7d6d5c81-be1c-49c9-94c5-f0c314801eee"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("97a90f42-3796-4813-80d5-d1fcb2c448dd"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("9efb5462-83dd-43e7-935f-88d4e24347dc"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("a8e23935-ca0a-4598-8763-aa752f1e2abe"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("aab3cbc9-ad5c-4a94-93a7-3a5b53553e36"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("b190266a-498e-4144-b71e-b1fd419fafcb"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("b43725ff-04cb-491d-849d-43c34f6fcc2a"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("d2dc16d3-f841-48d9-b9b3-a01b7d33eeb2"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ea2fef33-7df9-4845-ac66-50ece2cc2369"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("f24acd86-d5a3-4a18-84f1-02030fdd980a"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("2cfba27c-a44e-40df-8ab5-5421d8ecb0df"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("5300881b-ff6c-4364-a53c-d5bfe8bdb02f"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d0ed1ef-aa0e-434a-9136-991d7c557d5c"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("649d79a9-82c0-47be-aff5-ca9e45186a65"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("f72db8d8-1bb5-41b8-be05-8df190f0bc59"));

            migrationBuilder.DropColumn(
                name: "Choices",
                table: "Quiz");

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
    }
}
