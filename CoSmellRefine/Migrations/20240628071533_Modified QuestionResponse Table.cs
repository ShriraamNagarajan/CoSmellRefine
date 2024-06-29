using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoSmellRefine.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedQuestionResponseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodeSmellCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeSmellCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefactoringTechniques",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefactoringTechniques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeSnippet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportIssues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscussionItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscussionType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportIssues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportIssues_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "CodeSmells",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeSmellCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeSmells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodeSmells_CodeSmellCategories_CodeSmellCategoryId",
                        column: x => x.CodeSmellCategoryId,
                        principalTable: "CodeSmellCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionImages_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionRefactoringTechnique",
                columns: table => new
                {
                    QuestionListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefactoringTechniquesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionRefactoringTechnique", x => new { x.QuestionListId, x.RefactoringTechniquesId });
                    table.ForeignKey(
                        name: "FK_QuestionRefactoringTechnique_Questions_QuestionListId",
                        column: x => x.QuestionListId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionRefactoringTechnique_RefactoringTechniques_RefactoringTechniquesId",
                        column: x => x.RefactoringTechniquesId,
                        principalTable: "RefactoringTechniques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeSnippet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Responses_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Responses_Questions_QuestionId1",
                        column: x => x.QuestionId1,
                        principalTable: "Questions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CodeSmellQuestion",
                columns: table => new
                {
                    CodeSmellListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeSmellQuestion", x => new { x.CodeSmellListId, x.QuestionListId });
                    table.ForeignKey(
                        name: "FK_CodeSmellQuestion_CodeSmells_CodeSmellListId",
                        column: x => x.CodeSmellListId,
                        principalTable: "CodeSmells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CodeSmellQuestion_Questions_QuestionListId",
                        column: x => x.QuestionListId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CodeSmellRefactoringTechnique",
                columns: table => new
                {
                    CodeSmellListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefactoringTechniqueListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeSmellRefactoringTechnique", x => new { x.CodeSmellListId, x.RefactoringTechniqueListId });
                    table.ForeignKey(
                        name: "FK_CodeSmellRefactoringTechnique_CodeSmells_CodeSmellListId",
                        column: x => x.CodeSmellListId,
                        principalTable: "CodeSmells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CodeSmellRefactoringTechnique_RefactoringTechniques_RefactoringTechniqueListId",
                        column: x => x.RefactoringTechniqueListId,
                        principalTable: "RefactoringTechniques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeSmellId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeSmellCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadingContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_CodeSmellCategories_CodeSmellCategoryId",
                        column: x => x.CodeSmellCategoryId,
                        principalTable: "CodeSmellCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modules_CodeSmells_CodeSmellId",
                        column: x => x.CodeSmellId,
                        principalTable: "CodeSmells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CodeSmellQuestionResponse",
                columns: table => new
                {
                    CodeSmellListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResponseListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeSmellQuestionResponse", x => new { x.CodeSmellListId, x.ResponseListId });
                    table.ForeignKey(
                        name: "FK_CodeSmellQuestionResponse_CodeSmells_CodeSmellListId",
                        column: x => x.CodeSmellListId,
                        principalTable: "CodeSmells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CodeSmellQuestionResponse_Responses_ResponseListId",
                        column: x => x.ResponseListId,
                        principalTable: "Responses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionResponseRefactoringTechnique",
                columns: table => new
                {
                    RefactoringTechniquesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResponseListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionResponseRefactoringTechnique", x => new { x.RefactoringTechniquesId, x.ResponseListId });
                    table.ForeignKey(
                        name: "FK_QuestionResponseRefactoringTechnique_RefactoringTechniques_RefactoringTechniquesId",
                        column: x => x.RefactoringTechniquesId,
                        principalTable: "RefactoringTechniques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionResponseRefactoringTechnique_Responses_ResponseListId",
                        column: x => x.ResponseListId,
                        principalTable: "Responses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponseComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ResponseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponseComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponseComments_Responses_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "Responses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ResponseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUpvote = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votes_Responses_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "Responses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "ModuleCompletion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleCompletion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleCompletion_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleCompletion_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleVideos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleVideos_Modules_ModuleId",
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
                    Choices = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "QuizResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizResults_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizResults_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06b0066a-4de5-412e-9d62-0dda4d0cc709", "06b0066a-4de5-412e-9d62-0dda4d0cc709", "Developer", "Developer" },
                    { "5f74cbd8-bd98-46d9-9760-bdad0ec7c033", "5f74cbd8-bd98-46d9-9760-bdad0ec7c033", "Moderator", "Moderator" },
                    { "80abfbab-92b8-454d-b82b-50b4a1568ec2", "80abfbab-92b8-454d-b82b-50b4a1568ec2", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0bb96526-4ffd-4846-8e00-ac29d53671d0", 0, "e8a0137c-1329-4b1d-b3e5-7f8cd013f51c", "admin@cosmellrefine.com", false, false, null, "ADMIN@COSMELLREFINE.COM", "ADMIN@COSMELLREFINE.COM", "AQAAAAIAAYagAAAAECKDynbvEM6JUN1wEiYI7maXgLiX+LcoLn7sP9uT/2tiVC6UJscEiJ/k57Mb4vltMQ==", null, false, "dbc5dd6f-78eb-4dd0-9571-7065344e674b", false, "admin@cosmellrefine.com" },
                    { "680a7849-11d6-44d1-8ec5-fdac6ca72260", 0, "912b22b9-9e81-4451-9ac0-95982ec43906", "developer@cosmellrefine.com", false, false, null, "DEVELOPER@COSMELLREFINE.COM", "DEVELOPER@COSMELLREFINE.COM", "AQAAAAIAAYagAAAAEGV9dmMnJjGAVbClsm+TaeqpDqgoR7zFY53Jny531OtUif/HNwKFEhO75RagX2caWg==", null, false, "2cc18f23-90fe-44e2-9bf2-13094ca882ab", false, "developer@cosmellrefine.com" },
                    { "9411a478-8335-4360-9a4c-9640eb2e18cd", 0, "26b07bd3-789b-4e69-a787-0b2a02c81693", "moderator@cosmellrefine.com", false, false, null, "MODERATOR@COSMELLREFINE.COM", "MODERATOR@COSMELLREFINE.COM", "AQAAAAIAAYagAAAAEFtFYAL+BXQ1BEuxjaFT8AtQ5CV2ahfZ4fjDIncY9fIUQpC+9477eFKV92osXjUtaQ==", null, false, "fea9f2e9-b8e4-4a32-b9ad-36162d8150b7", false, "moderator@cosmellrefine.com" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmellCategories",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("24426aca-b747-4915-a561-2e05090c6d6e"), "All these code smells result from the incomplete or incorrect application of object-oriented programming principles.", "https://finance-blog-post.s3.amazonaws.com/object_orientation_abusers.png", "Object Orientation Abusers" },
                    { new Guid("91a8b163-a434-41d5-83be-08121482b66e"), "These code smells indicate that changing one part of the code requires multiple changes elsewhere, making program development more complex and costly.", "https://finance-blog-post.s3.amazonaws.com/change_preventers.png", "Change Preventers" },
                    { new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "Bloaters are code, methods, and classes that become excessively large and difficult to manage. These issues typically develop gradually as the program evolves, especially if no effort is made to address them.", "https://finance-blog-post.s3.amazonaws.com/bloaters.png", "Bloaters" },
                    { new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"), "All the smells in this group contribute to excessive coupling between classes or result from replacing coupling with excessive delegation.", "https://finance-blog-post.s3.amazonaws.com/couplers.png", "Couplers" },
                    { new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "A dispensable is an unnecessary element whose removal would make the code cleaner, more efficient, and easier to understand.", "https://finance-blog-post.s3.amazonaws.com/dispensables.png", "Dispensables" }
                });

            migrationBuilder.InsertData(
                table: "RefactoringTechniques",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("136e97b3-6d1e-4dc5-9b2c-916a2a448e14"), "Use inheritance to formalize the relationship if the intimacy is between a subclass and its superclass.", "Replace Delegation with Inheritance" },
                    { new Guid("169cc71d-297d-412d-97eb-6ddd844a90d1"), "Use polymorphism to replace the switch statement.", "Replace Conditional with Polymorphism" },
                    { new Guid("2abeb85f-5c5e-4dc3-bb05-359da6cfeae8"), "Hide public fields from direct access by using getters and setters.", "Encapsulate Field" },
                    { new Guid("2d92ebe4-8259-40c0-a8ed-cc3922b361bb"), "Create a local extension of the library class to extend and modify it to meet your needs while keeping the original library intact.", "Introduce Local Extension" },
                    { new Guid("3088ddf2-48f7-4411-bcb3-0e64372d67bf"), "Choose the best algorithm and replace others with it if two methods do the same thing but use different algorithms.", "Substitute Algorithm" },
                    { new Guid("53b3e61e-08ff-409c-9805-9fe86ef306a1"), "Use assertions to make rules about a necessary state explicit in the code.", "Introduce Assertion" },
                    { new Guid("64d6b2c3-4a0c-4ffd-b87f-58a461c97606"), "Move methods and data into a new class to isolate changes to specific parts of the system.", "Extract Class" },
                    { new Guid("66de5e0c-91be-4983-ae3c-628e62378fc7"), "Move parts of one class to the class where they are used, but only if the first class truly doesn't need them.", "Move Field" },
                    { new Guid("67f191cb-a7a5-40c2-b269-6848eb22e434"), "Add methods externally to a library class to provide the needed functionality without modifying the original class.", "Introduce Foreign Method" },
                    { new Guid("6a3fbf51-16c0-4ad0-87e8-c339312da0a3"), "Simplify methods by removing unneeded parameters.", "Remove Parameter" },
                    { new Guid("7218f03e-b0fd-459a-8258-39f82c5d9d7d"), "Replace type code with subclassing or state/strategy patterns.", "Replace Type Code with Subclass" },
                    { new Guid("7daedb76-a49c-4792-a02c-bcbd0594afd2"), "Extract part of a method into a separate method and move it to the appropriate class.", "Extract Method" },
                    { new Guid("8191f1cc-d01f-470c-8c46-d1d6303f1d07"), "Reduce dependency by changing mutually interdependent classes to unidirectional relationships.", "Change Bidirectional Association to Unidirectional" },
                    { new Guid("a6a54b81-199e-450e-a430-7d1447c574aa"), "Merge multiple conditional expressions performing the same code into a single condition and extract the common code into a new method.", "Consolidate Conditional Expression" },
                    { new Guid("ba15f373-31a3-480e-91ee-ac5c7974a94c"), "Move common code outside of the conditional expression if it is performed in all branches.", "Consolidate Duplicate Conditional Fragments" },
                    { new Guid("ca862571-a0a3-4be3-9010-f372743635f2"), "Use the Template Method pattern if the same code is found in two subclasses at the same level but isn't completely identical.", "Form Template Method" },
                    { new Guid("e2ec1973-c21a-4020-bf43-7f33de5cda52"), "Merge a subclass into its parent class to simplify the hierarchy.", "Collapse Hierarchy" },
                    { new Guid("e34fc05e-69ef-4ed1-864b-fe3120484216"), "Move a method to another class if it clearly belongs there.", "Move Method" },
                    { new Guid("ee12a9e5-3b2d-49e1-87b2-c1fada2831e0"), "Simplify client code by hiding the message chain, providing a single method that handles the entire chain.", "Hide Delegate" },
                    { new Guid("f4cd659b-1842-4adf-a9b6-daf27fbf4672"), "Merge the components of a near-useless class into another class and remove the empty class.", "Inline Class" },
                    { new Guid("f7a7e663-3c24-48ba-bb11-c865397f46a9"), "Use the Null Object pattern to handle default or missing cases in a switch statement.", "Introduce Null Object" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80abfbab-92b8-454d-b82b-50b4a1568ec2", "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { "06b0066a-4de5-412e-9d62-0dda4d0cc709", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { "5f74cbd8-bd98-46d9-9760-bdad0ec7c033", "9411a478-8335-4360-9a4c-9640eb2e18cd" }
                });

            migrationBuilder.InsertData(
                table: "CodeSmells",
                columns: new[] { "Id", "CodeSmellCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00d8c1e7-cce7-4690-8c96-4a6051c9ce71"), new Guid("24426aca-b747-4915-a561-2e05090c6d6e"), "Temporary Fields are fields in a class that get their values only under certain circumstances and remain empty the rest of the time.", "Temporary Field" },
                    { new Guid("275fea78-2c91-4c25-a5f7-9ed038660ff7"), new Guid("91a8b163-a434-41d5-83be-08121482b66e"), "Parallel Inheritance Hierarchy occurs when creating a subclass for one class requires you to create a subclass for another class.", "Parallel Inheritance Hierarchies" },
                    { new Guid("29b1e6bf-dd7b-4177-80b0-fe6b0966f232"), new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "A Long Parameter List occurs when a method has more than three or four parameters.", "Long Parameter List" },
                    { new Guid("414774eb-8236-49ba-bf30-e6f7a0b89edb"), new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "Primitive Obsession occurs when you use primitive data types for tasks that could be better handled by small objects.", "Primitive Obsession" },
                    { new Guid("42dd99d5-9a0e-4dee-999b-e70bbcc15b0a"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "A Lazy Class is a class that doesn't do enough to justify its existence in your codebase.", "Lazy Class" },
                    { new Guid("4a4ab2d1-09f4-4388-8754-6ee627ce1b5e"), new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "A Long Method is a method that contains too many lines of code.", "Long Method" },
                    { new Guid("511c614f-3cad-4c4c-872d-9b44d4ee4384"), new Guid("24426aca-b747-4915-a561-2e05090c6d6e"), "Switch Statements are defined by the presence of a complex switch operator or a sequence of if statements.", "Switch Statements" },
                    { new Guid("56dd4b0f-2f61-415c-815b-d5a4b232bb4d"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "Dead Code refers to any variable, parameter, field, method, or class that is no longer used in your program.", "Dead Code" },
                    { new Guid("60731cec-9492-404f-8ecd-64b0a555ae65"), new Guid("24426aca-b747-4915-a561-2e05090c6d6e"), "Alternative Classes with Different Interfaces occur when two classes perform identical functions but have different method names.", "Alternative Classes with Different Interfaces" },
                    { new Guid("618947af-ce54-4d66-8c15-3c67fa63d3ef"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "A Data Class is a class that contains only fields and crude methods for accessing them, such as getters and setters.", "Data Class" },
                    { new Guid("62b91c50-aa6c-497e-87ec-bf6efa7bbc19"), new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"), "A Message Chain occurs when you see a series of calls like $a->b()->c()->d() in your code.", "Message Chains" },
                    { new Guid("63f82595-340c-41f7-a804-a11e3a60bf6e"), new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"), "Inappropriate Intimacy occurs when one class uses the internal fields and methods of another class.", "Inappropriate Intimacy" },
                    { new Guid("68ce32ae-88f2-41d2-827d-bb1e1f912aee"), new Guid("91a8b163-a434-41d5-83be-08121482b66e"), "Divergent Change occurs when you find yourself having to change many unrelated methods whenever you make changes to a class.", "Divergent Change" },
                    { new Guid("750da832-b5ce-41a6-b1a9-d88e5e5b214b"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "It's when two or more code fragments in your program are nearly or entirely the same.", "Duplicate Code" },
                    { new Guid("8302ce0b-3327-49fb-b503-59b27fd21b79"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "Speculative Generality occurs when there’s an unused class, method, field, or parameter in your code.", "Speculative Generality" },
                    { new Guid("85de4761-3f3e-42b5-a012-25fd6e553745"), new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"), "It's a situation where a method in one class is overly interested in the data of another class, indicating that the method might belong in the other class.", "Feature Envy" },
                    { new Guid("8b1ceccc-fe12-4e3a-a145-986b29d951cc"), new Guid("91a8b163-a434-41d5-83be-08121482b66e"), "Shotgun Surgery occurs when making any modification requires you to make many small changes to many different classes.", "Shotgun Surgery" },
                    { new Guid("9052108c-0571-4956-8943-195b4633d2b3"), new Guid("be8c8f13-a6a3-4589-984b-8e709e1fb5df"), "Comments in code are meant to explain what the code does, but they can also be a sign of underlying issues.", "Comments" },
                    { new Guid("97dfd496-b438-44af-9515-c4679cfd72a2"), new Guid("24426aca-b747-4915-a561-2e05090c6d6e"), "Refused Bequest occurs when a subclass uses only some of the methods and properties inherited from its parent class.", "Refused Bequest" },
                    { new Guid("ce602344-eafd-4dd1-b52e-878b7eefbce8"), new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "A Large Class is a class that contains too many fields, methods, or lines of code.", "Large Class" },
                    { new Guid("e0dcf502-9b15-4a76-8d4f-d53a7d7125d3"), new Guid("a1a825a0-901f-4615-8e18-78367d2448fa"), "It's a class that exists solely to pass messages to another class, without adding any real value itself.", "Middle Man" },
                    { new Guid("eeb3097c-1fe9-4e17-8d7b-4438787b2f2d"), new Guid("9c37b76d-d3e7-476b-9a60-c167f3618d49"), "Data Clumps occur when identical groups of variables appear in different parts of the code.", "Data Clumps" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsRead", "Message", "SentTime", "UserId" },
                values: new object[,]
                {
                    { new Guid("55b68b3a-c98e-4814-9c32-48b2dfa37b5d"), true, "This is your second notification", new DateTime(2024, 6, 27, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(514), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("7fe86c8b-f2fb-414c-a09a-86912886aa2b"), false, "This is your first notification", new DateTime(2024, 6, 25, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(516), "0bb96526-4ffd-4846-8e00-ac29d53671d0" },
                    { new Guid("f001d9b6-8293-4a63-bc32-ed8c8dc94e0d"), false, "This is your first notification", new DateTime(2024, 6, 26, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(502), "0bb96526-4ffd-4846-8e00-ac29d53671d0" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Body", "CodeSnippet", "IsDeleted", "ModifiedDate", "PostedDate", "Status", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a38e6b2-8103-4703-9653-b3e4a7e9cd9f"), "Body of question 2", "CodeSnippet2", false, new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(539), new DateTime(2024, 6, 27, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(539), "Open", "Question 2", "Refactoring Technique Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("61c606af-95a6-4afa-9f4e-a202d0a64a72"), "Body of question 1", "CodeSnippet1", false, new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(534), new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(533), "Closed", "Question 1", "Code Smell Identification", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "ReportIssues",
                columns: new[] { "Id", "DiscussionItemId", "DiscussionType", "Reason", "ReportDate", "Status", "StatusReason", "UserId" },
                values: new object[,]
                {
                    { new Guid("4c740216-4b6e-46bf-8ab3-756125a114f4"), new Guid("0a38e6b2-8103-4703-9653-b3e4a7e9cd9f"), "Response", "Spam", new DateTime(2024, 6, 28, 5, 15, 32, 972, DateTimeKind.Utc).AddTicks(763), "No Action Needed", "The content is appropriate", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("755c67e9-0b7f-48d7-b164-75c75ae93922"), new Guid("61c606af-95a6-4afa-9f4e-a202d0a64a72"), "Question", "Inappropriate content", new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(761), "In Review", "None", "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("81faa546-4e4c-453d-a614-5a149cce6dc1"), new Guid("0a38e6b2-8103-4703-9653-b3e4a7e9cd9f"), "Question", "Duplicate content", new DateTime(2024, 6, 28, 6, 15, 32, 972, DateTimeKind.Utc).AddTicks(766), "Warned User", "User comment is inappropriate", "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Body", "CodeSnippet", "IsDeleted", "PostedDate", "QuestionId", "QuestionId1", "UserId" },
                values: new object[,]
                {
                    { new Guid("08e92f41-113c-40b5-9e9f-bca311e29431"), "Response to question 1", "Console.WriteLine(\"Hello World\");", false, new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(581), new Guid("61c606af-95a6-4afa-9f4e-a202d0a64a72"), null, "680a7849-11d6-44d1-8ec5-fdac6ca72260" },
                    { new Guid("9f79c66d-54b5-496c-9b58-15dc8e8528f6"), "Another response to question 1", "Console.WriteLine(\"Hello World\");", false, new DateTime(2024, 6, 28, 6, 45, 32, 972, DateTimeKind.Utc).AddTicks(587), new Guid("0a38e6b2-8103-4703-9653-b3e4a7e9cd9f"), null, "680a7849-11d6-44d1-8ec5-fdac6ca72260" }
                });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "Id", "IsUpvote", "ResponseId", "UserId", "VoteDate" },
                values: new object[,]
                {
                    { new Guid("049818f4-fcaf-400f-a42f-a2db9a3718ed"), false, new Guid("08e92f41-113c-40b5-9e9f-bca311e29431"), "680a7849-11d6-44d1-8ec5-fdac6ca72260", new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(738) },
                    { new Guid("0d5a3705-3b07-4887-b5f0-45292d95c66b"), true, new Guid("9f79c66d-54b5-496c-9b58-15dc8e8528f6"), "680a7849-11d6-44d1-8ec5-fdac6ca72260", new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(740) },
                    { new Guid("4cf08bbd-141e-49c5-97cf-eb357f1e536a"), true, new Guid("08e92f41-113c-40b5-9e9f-bca311e29431"), "680a7849-11d6-44d1-8ec5-fdac6ca72260", new DateTime(2024, 6, 28, 7, 15, 32, 972, DateTimeKind.Utc).AddTicks(736) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSmellQuestion_QuestionListId",
                table: "CodeSmellQuestion",
                column: "QuestionListId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSmellQuestionResponse_ResponseListId",
                table: "CodeSmellQuestionResponse",
                column: "ResponseListId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSmellRefactoringTechnique_RefactoringTechniqueListId",
                table: "CodeSmellRefactoringTechnique",
                column: "RefactoringTechniqueListId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSmells_CodeSmellCategoryId",
                table: "CodeSmells",
                column: "CodeSmellCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Flashcards_ModuleId",
                table: "Flashcards",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleCompletion_ModuleId",
                table: "ModuleCompletion",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleCompletion_UserId",
                table: "ModuleCompletion",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CodeSmellCategoryId",
                table: "Modules",
                column: "CodeSmellCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CodeSmellId",
                table: "Modules",
                column: "CodeSmellId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleVideos_ModuleId",
                table: "ModuleVideos",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionImages_QuestionId",
                table: "QuestionImages",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionRefactoringTechnique_RefactoringTechniquesId",
                table: "QuestionRefactoringTechnique",
                column: "RefactoringTechniquesId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionResponseRefactoringTechnique_ResponseListId",
                table: "QuestionResponseRefactoringTechnique",
                column: "ResponseListId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_UserId",
                table: "Questions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_ModuleId",
                table: "Quiz",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizResults_ModuleId",
                table: "QuizResults",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizResults_UserId",
                table: "QuizResults",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportIssues_UserId",
                table: "ReportIssues",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseComments_ResponseId",
                table: "ResponseComments",
                column: "ResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseComments_UserId",
                table: "ResponseComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_QuestionId",
                table: "Responses",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_QuestionId1",
                table: "Responses",
                column: "QuestionId1");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_UserId",
                table: "Responses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfileImages_UserID",
                table: "UserProfileImages",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ResponseId",
                table: "Votes",
                column: "ResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_UserId",
                table: "Votes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CodeSmellQuestion");

            migrationBuilder.DropTable(
                name: "CodeSmellQuestionResponse");

            migrationBuilder.DropTable(
                name: "CodeSmellRefactoringTechnique");

            migrationBuilder.DropTable(
                name: "Flashcards");

            migrationBuilder.DropTable(
                name: "ModuleCompletion");

            migrationBuilder.DropTable(
                name: "ModuleVideos");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "QuestionImages");

            migrationBuilder.DropTable(
                name: "QuestionRefactoringTechnique");

            migrationBuilder.DropTable(
                name: "QuestionResponseRefactoringTechnique");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "QuizResults");

            migrationBuilder.DropTable(
                name: "ReportIssues");

            migrationBuilder.DropTable(
                name: "ResponseComments");

            migrationBuilder.DropTable(
                name: "UserProfileImages");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "RefactoringTechniques");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "CodeSmells");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "CodeSmellCategories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
