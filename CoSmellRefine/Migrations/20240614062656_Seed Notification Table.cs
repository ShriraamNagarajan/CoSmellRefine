using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class SeedNotificationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
