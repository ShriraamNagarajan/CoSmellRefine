using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedModelClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a36f550-09d0-42fa-b1cb-ead546dec946", "AQAAAAIAAYagAAAAEO0Y3LKSukIF+m0Kj+TXVqtYScUPbRsa2uGkPxNrg3tp95nQrFzxpKHqO/onXSOGqw==", "5f8631ac-b0ba-4922-b6d4-2fc16ab49e6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a79d2950-66e4-4135-8f5a-f923f2690b98", "AQAAAAIAAYagAAAAEJaG/XZRs4EW/sf5ti7CN6vaDkChx+0q6H0M6Bzd7eQ3yTgg1DyzmPTos5JdTIWJJA==", "eb2d5496-4ed4-468a-8d00-54ce48d9d9c2" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("8cf62615-22d8-4735-aa97-8cb7451a87b5"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "Object Orientation Abusers" },
                    { new Guid("925125b2-fa97-4e51-99b8-8e243d2bc4dc"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "Couplers" },
                    { new Guid("c0762d36-592c-41e1-a438-d6a636615712"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "Dispensables" },
                    { new Guid("d61fe411-2e22-4702-8db6-d1e4887fde89"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "Bloaters" },
                    { new Guid("f93405a9-0d50-4b5b-b639-fa2226b52af5"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "Change Preventers" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00c07437-c848-47fd-9ff3-540b72d0b4f4"), new Guid("d61fe411-2e22-4702-8db6-d1e4887fde89"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("1a8439f6-5fec-4cca-ab9b-650a8053fc93"), new Guid("c0762d36-592c-41e1-a438-d6a636615712"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("2fb5b82d-ff43-4fd5-9eab-6429e733e6a8"), new Guid("925125b2-fa97-4e51-99b8-8e243d2bc4dc"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("3db1101e-cb95-4f6b-bff0-628c360ee6d3"), new Guid("c0762d36-592c-41e1-a438-d6a636615712"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("3e8a613b-ef63-4845-9083-e0e6929d3a4b"), new Guid("925125b2-fa97-4e51-99b8-8e243d2bc4dc"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("431bb696-158b-4754-a3d9-fe3e512076a6"), new Guid("f93405a9-0d50-4b5b-b639-fa2226b52af5"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("46bb040a-03bd-4d55-8f13-28fb713e9a25"), new Guid("c0762d36-592c-41e1-a438-d6a636615712"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("4a445298-1d50-4914-94ad-a00702a138b9"), new Guid("f93405a9-0d50-4b5b-b639-fa2226b52af5"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("503a794b-30dc-476d-9345-f5cc0ea0d8fe"), new Guid("8cf62615-22d8-4735-aa97-8cb7451a87b5"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" },
                    { new Guid("7bc7f0ff-8a14-4426-b9b6-ca1c3c5f8517"), new Guid("d61fe411-2e22-4702-8db6-d1e4887fde89"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" },
                    { new Guid("7e0702a4-2ec6-43fc-b778-99cfbb59654b"), new Guid("c0762d36-592c-41e1-a438-d6a636615712"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("90fd7268-598c-4591-afb1-4f3f70e4f6e0"), new Guid("c0762d36-592c-41e1-a438-d6a636615712"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("9517ad63-d1e1-4eed-a774-713f734aee3b"), new Guid("8cf62615-22d8-4735-aa97-8cb7451a87b5"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("b4b5648e-a120-424c-9de0-7d5ef064d15e"), new Guid("8cf62615-22d8-4735-aa97-8cb7451a87b5"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("b766430b-90ae-43d9-bed1-0a813fe14a82"), new Guid("c0762d36-592c-41e1-a438-d6a636615712"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("dfb833d3-2109-438e-8c77-0006d2d91381"), new Guid("8cf62615-22d8-4735-aa97-8cb7451a87b5"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("e642fa09-a2b4-4ea9-98f7-88e69649f330"), new Guid("925125b2-fa97-4e51-99b8-8e243d2bc4dc"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("e793dc15-c6c6-4523-96f7-6ec7c648f34f"), new Guid("d61fe411-2e22-4702-8db6-d1e4887fde89"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("e7e455f0-1990-4014-8e01-28a8fee50dfb"), new Guid("925125b2-fa97-4e51-99b8-8e243d2bc4dc"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("e9283f6e-2263-44ea-ad9e-2b8a4d824cbe"), new Guid("f93405a9-0d50-4b5b-b639-fa2226b52af5"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("f6192563-f76b-43ca-a94e-75f8dea83b6c"), new Guid("d61fe411-2e22-4702-8db6-d1e4887fde89"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("fc365a2b-7aff-4b2d-906f-718aaf01bd52"), new Guid("d61fe411-2e22-4702-8db6-d1e4887fde89"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("00c07437-c848-47fd-9ff3-540b72d0b4f4"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("1a8439f6-5fec-4cca-ab9b-650a8053fc93"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("2fb5b82d-ff43-4fd5-9eab-6429e733e6a8"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("3db1101e-cb95-4f6b-bff0-628c360ee6d3"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("3e8a613b-ef63-4845-9083-e0e6929d3a4b"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("431bb696-158b-4754-a3d9-fe3e512076a6"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("46bb040a-03bd-4d55-8f13-28fb713e9a25"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("4a445298-1d50-4914-94ad-a00702a138b9"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("503a794b-30dc-476d-9345-f5cc0ea0d8fe"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7bc7f0ff-8a14-4426-b9b6-ca1c3c5f8517"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7e0702a4-2ec6-43fc-b778-99cfbb59654b"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("90fd7268-598c-4591-afb1-4f3f70e4f6e0"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("9517ad63-d1e1-4eed-a774-713f734aee3b"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("b4b5648e-a120-424c-9de0-7d5ef064d15e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("b766430b-90ae-43d9-bed1-0a813fe14a82"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("dfb833d3-2109-438e-8c77-0006d2d91381"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e642fa09-a2b4-4ea9-98f7-88e69649f330"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e793dc15-c6c6-4523-96f7-6ec7c648f34f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e7e455f0-1990-4014-8e01-28a8fee50dfb"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("e9283f6e-2263-44ea-ad9e-2b8a4d824cbe"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("f6192563-f76b-43ca-a94e-75f8dea83b6c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("fc365a2b-7aff-4b2d-906f-718aaf01bd52"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("8cf62615-22d8-4735-aa97-8cb7451a87b5"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("925125b2-fa97-4e51-99b8-8e243d2bc4dc"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0762d36-592c-41e1-a438-d6a636615712"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("d61fe411-2e22-4702-8db6-d1e4887fde89"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("f93405a9-0d50-4b5b-b639-fa2226b52af5"));

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
    }
}
