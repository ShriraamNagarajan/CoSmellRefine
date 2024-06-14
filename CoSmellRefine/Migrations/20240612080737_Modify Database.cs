using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class ModifyDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CodeSmellCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Flashcards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flashcards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flashcards_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quiz_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Flashcards_ModuleId",
                table: "Flashcards",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_ModuleId",
                table: "Quiz",
                column: "ModuleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flashcards");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CodeSmellCategories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb96526-4ffd-4846-8e00-ac29d53671d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "230bd48b-b48c-4a6a-a027-6854573aafa1", "AQAAAAIAAYagAAAAEAcGqqNdW4dy77UNINWU2WJy/11Iewd77U/KP7sNb7yoTctVEQgx8MkE/pH3pU99GA==", "0a8981f5-92b3-42d8-92d8-1d00c55a50f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9411a478-8335-4360-9a4c-9640eb2e18cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de3df656-9665-4d27-b886-98d0f351d9be", "AQAAAAIAAYagAAAAEGzn2ewtD21tvp4lS7rhnXOcoRG2OWziYiGkek8HHwO89gv1hwcub0flVBovJjbYaA==", "2b0c8a0a-c483-4b66-98e3-327dd2960e9a" });
        }
    }
}
