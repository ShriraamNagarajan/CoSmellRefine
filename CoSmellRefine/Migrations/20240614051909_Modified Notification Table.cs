using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedNotificationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Notifications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "SentTime",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9b1a9c5-9065-4bd5-9636-be37aa5e130a", "AQAAAAIAAYagAAAAEDgT1mAzSlRb9ODrU2VrhTcQJ8aJzSoQj9cSuNq3Z4aS2w3eXWvY7vye1jxA58RzCg==", "d7db2f74-f45b-428f-ba3d-86ed34a4c34e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb682952-7e11-4d4f-a636-935c366eea3c", "AQAAAAIAAYagAAAAEDJaHt6us8MKfHnRpzfiVcPlLqU9EzuOh//mL6xQvboK1IwG5GqA8KcW1iievuaKaA==", "33d83ee3-0ce0-4bb1-9784-3e6a6565ae06" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("51aee3be-78be-4505-8f76-ab55202db224"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "Dispensables" },
                    { new Guid("6429b0f0-7fff-4461-8d4f-814336464fbd"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "Object Orientation Abusers" },
                    { new Guid("832dcfd8-234f-4673-a91c-847df85b9648"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "Change Preventers" },
                    { new Guid("b381a379-88ee-4757-9e0d-960f8da13b0a"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "Bloaters" },
                    { new Guid("e237c92a-2d2a-49c1-9fb1-ba747a0c179f"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "Couplers" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0441a57d-7b15-4dc7-a680-2eb4c621affb"), new Guid("832dcfd8-234f-4673-a91c-847df85b9648"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("0ff04ce9-1a5a-415c-bc28-7e51d2dd5c55"), new Guid("b381a379-88ee-4757-9e0d-960f8da13b0a"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" },
                    { new Guid("1d0402cb-5ed3-4d7c-bfce-39f0fbe68360"), new Guid("51aee3be-78be-4505-8f76-ab55202db224"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("33cb29b6-1a93-44ac-9134-6bba3ee08477"), new Guid("e237c92a-2d2a-49c1-9fb1-ba747a0c179f"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("38def138-4dc2-4364-8341-e0ce43eef138"), new Guid("6429b0f0-7fff-4461-8d4f-814336464fbd"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("4ef93592-ac02-4a82-87f2-0acd1f7c7d9b"), new Guid("b381a379-88ee-4757-9e0d-960f8da13b0a"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("557c4ab1-638d-4c44-99ce-30a883129b1c"), new Guid("6429b0f0-7fff-4461-8d4f-814336464fbd"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("667332a7-6b5c-4f43-98e4-baf179d05621"), new Guid("51aee3be-78be-4505-8f76-ab55202db224"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("6889eac1-6a34-4e21-87fa-5517c7e8257e"), new Guid("51aee3be-78be-4505-8f76-ab55202db224"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("7b5d5dd7-d548-4dd6-94de-466a348af6d7"), new Guid("b381a379-88ee-4757-9e0d-960f8da13b0a"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("7d27af29-b432-45ae-a2ab-5d0e0f6f02e4"), new Guid("e237c92a-2d2a-49c1-9fb1-ba747a0c179f"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("92a89345-73dd-4801-b9fe-47177af7e386"), new Guid("e237c92a-2d2a-49c1-9fb1-ba747a0c179f"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("a9b01b0a-70fa-431b-aae3-5829e7fa67de"), new Guid("51aee3be-78be-4505-8f76-ab55202db224"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("b3037e10-ba9d-4892-96b9-fa19eb3e44db"), new Guid("832dcfd8-234f-4673-a91c-847df85b9648"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("b6a4b552-ca04-428b-becc-45e7f88176d5"), new Guid("6429b0f0-7fff-4461-8d4f-814336464fbd"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("b6a65cde-e4eb-4a4a-9f4b-72b995047f35"), new Guid("51aee3be-78be-4505-8f76-ab55202db224"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("ba69e177-6279-4a5a-b749-e3269593d5a3"), new Guid("832dcfd8-234f-4673-a91c-847df85b9648"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("c972d193-a538-4535-a305-35db8027279f"), new Guid("b381a379-88ee-4757-9e0d-960f8da13b0a"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" },
                    { new Guid("cbb97a14-0a0f-4c81-8e9d-9cbd7903155d"), new Guid("b381a379-88ee-4757-9e0d-960f8da13b0a"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("d17fcfc9-bed1-42e0-a10c-37e804f7d0ca"), new Guid("e237c92a-2d2a-49c1-9fb1-ba747a0c179f"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("dff13f63-befa-470a-8926-3c24d7e06db6"), new Guid("51aee3be-78be-4505-8f76-ab55202db224"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("ed48310f-514f-4b3e-9b2b-1d09add7e69c"), new Guid("6429b0f0-7fff-4461-8d4f-814336464fbd"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("0441a57d-7b15-4dc7-a680-2eb4c621affb"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("0ff04ce9-1a5a-415c-bc28-7e51d2dd5c55"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("1d0402cb-5ed3-4d7c-bfce-39f0fbe68360"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("33cb29b6-1a93-44ac-9134-6bba3ee08477"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("38def138-4dc2-4364-8341-e0ce43eef138"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("4ef93592-ac02-4a82-87f2-0acd1f7c7d9b"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("557c4ab1-638d-4c44-99ce-30a883129b1c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("667332a7-6b5c-4f43-98e4-baf179d05621"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("6889eac1-6a34-4e21-87fa-5517c7e8257e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7b5d5dd7-d548-4dd6-94de-466a348af6d7"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7d27af29-b432-45ae-a2ab-5d0e0f6f02e4"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("92a89345-73dd-4801-b9fe-47177af7e386"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("a9b01b0a-70fa-431b-aae3-5829e7fa67de"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("b3037e10-ba9d-4892-96b9-fa19eb3e44db"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("b6a4b552-ca04-428b-becc-45e7f88176d5"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("b6a65cde-e4eb-4a4a-9f4b-72b995047f35"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ba69e177-6279-4a5a-b749-e3269593d5a3"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("c972d193-a538-4535-a305-35db8027279f"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("cbb97a14-0a0f-4c81-8e9d-9cbd7903155d"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("d17fcfc9-bed1-42e0-a10c-37e804f7d0ca"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("dff13f63-befa-470a-8926-3c24d7e06db6"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("ed48310f-514f-4b3e-9b2b-1d09add7e69c"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("51aee3be-78be-4505-8f76-ab55202db224"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("6429b0f0-7fff-4461-8d4f-814336464fbd"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("832dcfd8-234f-4673-a91c-847df85b9648"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("b381a379-88ee-4757-9e0d-960f8da13b0a"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("e237c92a-2d2a-49c1-9fb1-ba747a0c179f"));

            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "SentTime",
                table: "Notifications");

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
    }
}
