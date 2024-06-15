using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedReportIssueeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "DiscussionType",
                table: "ReportIssues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c13c6d15-83f4-4310-b32e-b82f03acbc47", "AQAAAAIAAYagAAAAEHV6KDIip0ITrWf6Mk1wmEVs7uRq9wwRUEBJ1CKsJ5GimiYkLHkpQfPSBgmlah0mVg==", "4a1cffd5-e840-4bf4-9f3e-dd95cc50e1ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "680a7849-11d6-44d1-8ec5-fdac6ca72260",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "034e39bb-ecfa-4feb-87a3-46a28aef0ad5", "AQAAAAIAAYagAAAAEOdrA4WBRuyrvggKWS65mwNe/pcPOW4OukZWryEhP5EOuvq0Clsi/vD19Gjlhw13fw==", "3add183a-cf9b-4d37-82fd-1980df244e28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccf611b6-8260-42cd-8119-589d28c57e1f", "AQAAAAIAAYagAAAAEGDXLLD88bkMeAu0766hRxLFN0AH+7kWAEkvOP+8bo8Ltk42aghantmdMrhCkENOCg==", "d29f8c81-4ddf-4190-834a-d8b3f6900dc4" });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("08fa036e-f85a-4e93-8ec1-2dc779f7c9ab"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "Bloaters" },
                    { new Guid("54e08bfc-fa4c-4580-ab68-acda50478cee"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "Couplers" },
                    { new Guid("70382632-6f92-43e0-be2a-ab8fe57ad1b1"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "Dispensables" },
                    { new Guid("86f99a41-3b20-4223-825a-6abf8155fec0"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "Object Orientation Abusers" },
                    { new Guid("9585af32-7fd6-41a1-8386-6085fee4e094"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "Change Preventers" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsRead", "Message", "SentTime", "UserId" },
                values: new object[,]
                {
                    { new Guid("5225579e-02c2-45b7-adbd-1a33572627ef"), false, "This is your first notification", new DateTime(2024, 6, 12, 7, 11, 2, 273, DateTimeKind.Utc).AddTicks(7131), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("547af4c5-979a-4ec6-b1e1-06f81fab732a"), false, "This is your first notification", new DateTime(2024, 6, 13, 7, 11, 2, 273, DateTimeKind.Utc).AddTicks(7117), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("55a784db-718d-4fcb-9667-1a5f02289a73"), true, "This is your second notification", new DateTime(2024, 6, 14, 7, 11, 2, 273, DateTimeKind.Utc).AddTicks(7129), "0bb96526-4ffd-4846-8e00-ac29d53671d0" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Body", "CodeSnippet", "ModifiedDate", "PostedDate", "Status", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("888dcae3-3d66-4dd5-b9c3-ceef60a8d6f4"), "Body of question 2", "CodeSnippet2", new DateTime(2024, 6, 15, 7, 11, 2, 273, DateTimeKind.Utc).AddTicks(7159), new DateTime(2024, 6, 14, 7, 11, 2, 273, DateTimeKind.Utc).AddTicks(7159), "Open", "Question 2", "Refactoring Technique Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("d1356ca7-8223-433e-b398-854e15820ec9"), "Body of question 1", "CodeSnippet1", new DateTime(2024, 6, 15, 7, 11, 2, 273, DateTimeKind.Utc).AddTicks(7154), new DateTime(2024, 6, 15, 7, 11, 2, 273, DateTimeKind.Utc).AddTicks(7152), "Closed", "Question 1", "Code Smell Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("12213938-3a50-4dba-8e23-5cde289f857c"), new Guid("08fa036e-f85a-4e93-8ec1-2dc779f7c9ab"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("1514aeba-a8fb-44db-beef-40869a15ffcb"), new Guid("08fa036e-f85a-4e93-8ec1-2dc779f7c9ab"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" },
                    { new Guid("191b4c83-fdfb-458f-b681-a43fec56a154"), new Guid("9585af32-7fd6-41a1-8386-6085fee4e094"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("1b3f4ed7-60ff-4e23-8384-ffbbf47a6f15"), new Guid("70382632-6f92-43e0-be2a-ab8fe57ad1b1"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("1f633d85-97ae-46f1-9310-dc77958d2fbd"), new Guid("54e08bfc-fa4c-4580-ab68-acda50478cee"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("2f8e3f3c-2bb0-40ad-b704-64cfbeab6f00"), new Guid("08fa036e-f85a-4e93-8ec1-2dc779f7c9ab"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" },
                    { new Guid("3344c66c-5c8f-4180-8462-de7b2747b123"), new Guid("54e08bfc-fa4c-4580-ab68-acda50478cee"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("383053a1-4391-4db2-aaa4-451c1ba4d629"), new Guid("86f99a41-3b20-4223-825a-6abf8155fec0"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("3aa2635e-c095-4799-bdd4-119ab1bb9896"), new Guid("9585af32-7fd6-41a1-8386-6085fee4e094"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("4d311d47-14d6-45e3-aac8-c6e59f28292b"), new Guid("70382632-6f92-43e0-be2a-ab8fe57ad1b1"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("4f338f1d-efb7-4422-adc9-81b7db3e08b1"), new Guid("70382632-6f92-43e0-be2a-ab8fe57ad1b1"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("607c586c-fc01-4922-a614-7fc3cdb7a9e8"), new Guid("54e08bfc-fa4c-4580-ab68-acda50478cee"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("6ef58499-98b5-4e5b-8253-4e025f0452c5"), new Guid("86f99a41-3b20-4223-825a-6abf8155fec0"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" },
                    { new Guid("784ccac3-a484-4293-af1c-4036aef989cb"), new Guid("54e08bfc-fa4c-4580-ab68-acda50478cee"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("79cda896-e19b-4fbe-a55f-53fe907309bf"), new Guid("08fa036e-f85a-4e93-8ec1-2dc779f7c9ab"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("7ee10897-2271-43bb-98cb-087c904b085a"), new Guid("9585af32-7fd6-41a1-8386-6085fee4e094"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("7fee4725-582e-4cce-912f-baeff4f0f5b4"), new Guid("86f99a41-3b20-4223-825a-6abf8155fec0"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("88f09ddb-e25e-4ee7-bf94-c0a377f3c58e"), new Guid("86f99a41-3b20-4223-825a-6abf8155fec0"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("978bea46-33e2-41cb-9726-a62c65d55710"), new Guid("70382632-6f92-43e0-be2a-ab8fe57ad1b1"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("d9f65905-e1a1-4115-b7ba-5c2239e0a17a"), new Guid("70382632-6f92-43e0-be2a-ab8fe57ad1b1"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("db131f84-ce04-4961-adb1-9eb0c57ce70d"), new Guid("70382632-6f92-43e0-be2a-ab8fe57ad1b1"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("f52ac43f-354e-4097-84a9-4112a38bc00d"), new Guid("08fa036e-f85a-4e93-8ec1-2dc779f7c9ab"), "A Long Method is a method that contains too many lines of code.", "Long Method" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Body", "PostedDate", "QuestionId", "QuestionId1", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b6fd1ae-ce4c-42de-b492-4237b4ad5499"), "Response to question 1", new DateTime(2024, 6, 15, 7, 11, 2, 273, DateTimeKind.Utc).AddTicks(7233), new Guid("d1356ca7-8223-433e-b398-854e15820ec9"), null, "Accepted", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("15225650-cfbd-4a1f-815e-357ab3446007"), "Another response to question 1", new DateTime(2024, 6, 15, 6, 41, 2, 273, DateTimeKind.Utc).AddTicks(7237), new Guid("888dcae3-3d66-4dd5-b9c3-ceef60a8d6f4"), null, "Pending", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("12213938-3a50-4dba-8e23-5cde289f857c"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("1514aeba-a8fb-44db-beef-40869a15ffcb"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("191b4c83-fdfb-458f-b681-a43fec56a154"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("1b3f4ed7-60ff-4e23-8384-ffbbf47a6f15"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("1f633d85-97ae-46f1-9310-dc77958d2fbd"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("2f8e3f3c-2bb0-40ad-b704-64cfbeab6f00"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("3344c66c-5c8f-4180-8462-de7b2747b123"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("383053a1-4391-4db2-aaa4-451c1ba4d629"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("3aa2635e-c095-4799-bdd4-119ab1bb9896"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("4d311d47-14d6-45e3-aac8-c6e59f28292b"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("4f338f1d-efb7-4422-adc9-81b7db3e08b1"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("607c586c-fc01-4922-a614-7fc3cdb7a9e8"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("6ef58499-98b5-4e5b-8253-4e025f0452c5"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("784ccac3-a484-4293-af1c-4036aef989cb"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("79cda896-e19b-4fbe-a55f-53fe907309bf"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7ee10897-2271-43bb-98cb-087c904b085a"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("7fee4725-582e-4cce-912f-baeff4f0f5b4"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("88f09ddb-e25e-4ee7-bf94-c0a377f3c58e"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("978bea46-33e2-41cb-9726-a62c65d55710"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("d9f65905-e1a1-4115-b7ba-5c2239e0a17a"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("db131f84-ce04-4961-adb1-9eb0c57ce70d"));

            migrationBuilder.DeleteData(
                table: "CodeSmells",
                keyColumn: "Id",
                keyValue: new Guid("f52ac43f-354e-4097-84a9-4112a38bc00d"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("5225579e-02c2-45b7-adbd-1a33572627ef"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("547af4c5-979a-4ec6-b1e1-06f81fab732a"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("55a784db-718d-4fcb-9667-1a5f02289a73"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("0b6fd1ae-ce4c-42de-b492-4237b4ad5499"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("15225650-cfbd-4a1f-815e-357ab3446007"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("08fa036e-f85a-4e93-8ec1-2dc779f7c9ab"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("54e08bfc-fa4c-4580-ab68-acda50478cee"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("70382632-6f92-43e0-be2a-ab8fe57ad1b1"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("86f99a41-3b20-4223-825a-6abf8155fec0"));

            migrationBuilder.DeleteData(
                table: "CodeSmellCategories",
                keyColumn: "Id",
                keyValue: new Guid("9585af32-7fd6-41a1-8386-6085fee4e094"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("888dcae3-3d66-4dd5-b9c3-ceef60a8d6f4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d1356ca7-8223-433e-b398-854e15820ec9"));

            migrationBuilder.DropColumn(
                name: "DiscussionType",
                table: "ReportIssues");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76de01f1-b52d-4a78-84a7-18d4a68a8151", "AQAAAAIAAYagAAAAELbZ9tvvBP/L1gLzq8SL/trWApAb9ZDCS58fGJriGVFNK8Bh+peshZ1eWlkY+VYFaQ==", "7428b89a-5471-4888-964d-d7a1de877264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "680a7849-11d6-44d1-8ec5-fdac6ca72260",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac8c426d-8b4e-4a0d-915e-a4fe0241aa47", "AQAAAAIAAYagAAAAED6cBW7xhFfc9AQn4or3Z7TL5UrHZrNJYjO70Jev49so0qRx9oZIn7C++T4E8o1Oxg==", "674b238a-3fbd-4ceb-b3e2-c9042b07e0d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03441c82-becd-4eab-9850-cac0e0a4a99f", "AQAAAAIAAYagAAAAEGugJ/12cqe12JcpXSVuPV4E6r/51o4rREP5oZEljmThniuFdSU5dJNknjL+31fe+A==", "33b20dd4-663b-4b12-ab0f-5a9132ed7b34" });

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
                table: "Questions",
                columns: new[] { "Id", "Body", "CodeSnippet", "ModifiedDate", "PostedDate", "Status", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("55193247-a474-4136-a1d3-e6473ac8630a"), "Body of question 2", "CodeSnippet2", new DateTime(2024, 6, 15, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6292), new DateTime(2024, 6, 14, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6291), "Open", "Question 2", "Refactoring Technique Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("a1b0853a-cd0d-42c6-9f46-c6f2255d1a4b"), "Body of question 1", "CodeSnippet1", new DateTime(2024, 6, 15, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6288), new DateTime(2024, 6, 15, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6287), "Closed", "Question 1", "Code Smell Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

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
                table: "Responses",
                columns: new[] { "Id", "Body", "PostedDate", "QuestionId", "QuestionId1", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c57129f-4184-479a-90d1-16f70b61dac4"), "Another response to question 1", new DateTime(2024, 6, 15, 5, 41, 54, 91, DateTimeKind.Utc).AddTicks(6357), new Guid("55193247-a474-4136-a1d3-e6473ac8630a"), null, "Pending", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("7301fb56-eeb9-495e-9934-e6967cb55a68"), "Response to question 1", new DateTime(2024, 6, 15, 6, 11, 54, 91, DateTimeKind.Utc).AddTicks(6355), new Guid("a1b0853a-cd0d-42c6-9f46-c6f2255d1a4b"), null, "Accepted", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });
        }
    }
}
