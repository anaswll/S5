using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobBoard.DataAccess.Migrations
{
    public partial class JobBoardv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "JBUser",
                columns: table => new
                {
                    userId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: false),
                    Adress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JBUser", x => x.userId);
                });

          

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    entrepriseId = table.Column<string>(nullable: false),
                    sectorField = table.Column<string>(nullable: false),
                    numOfEmployee = table.Column<long>(nullable: false),
                    creationDate = table.Column<DateTime>(nullable: false),
                    location = table.Column<string>(nullable: false),
                    capitalStock = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.entrepriseId);
                    table.ForeignKey(
                        name: "FK_Company_JBUser_entrepriseId",
                        column: x => x.entrepriseId,
                        principalTable: "JBUser",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    ResumeId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => x.ResumeId);
                    table.ForeignKey(
                        name: "FK_Resume_JBUser_UserId",
                        column: x => x.UserId,
                        principalTable: "JBUser",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    OfferId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    About = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.OfferId);
                    table.ForeignKey(
                        name: "FK_Offer_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "entrepriseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "education",
                columns: table => new
                {
                    EducationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    University = table.Column<string>(nullable: false),
                    AreaField = table.Column<string>(nullable: false),
                    Degree = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ResumeId = table.Column<int>(nullable: false),
                    ResumeId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_education", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_education_Resume_ResumeId1",
                        column: x => x.ResumeId1,
                        principalTable: "Resume",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageTitle = table.Column<string>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    ResumeId = table.Column<int>(nullable: false),
                    ResumeId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_language", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_language_Resume_ResumeId1",
                        column: x => x.ResumeId1,
                        principalTable: "Resume",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "skill",
                columns: table => new
                {
                    SkillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    YearExperience = table.Column<int>(nullable: false),
                    ResumeId = table.Column<int>(nullable: false),
                    ResumeId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_skill_Resume_ResumeId1",
                        column: x => x.ResumeId1,
                        principalTable: "Resume",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "workingexperience",
                columns: table => new
                {
                    WExperienceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: false),
                    Descritpion = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ResumeId = table.Column<int>(nullable: false),
                    ResumeId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workingexperience", x => x.WExperienceId);
                    table.ForeignKey(
                        name: "FK_workingexperience_Resume_ResumeId1",
                        column: x => x.ResumeId1,
                        principalTable: "Resume",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Restrict);
                });

          
            migrationBuilder.CreateIndex(
                name: "IX_education_ResumeId1",
                table: "education",
                column: "ResumeId1");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "JBUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "JBUser",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_language_ResumeId1",
                table: "language",
                column: "ResumeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_CompanyId",
                table: "Offer",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_UserId",
                table: "Resume",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_skill_ResumeId1",
                table: "skill",
                column: "ResumeId1");

            migrationBuilder.CreateIndex(
                name: "IX_workingexperience_ResumeId1",
                table: "workingexperience",
                column: "ResumeId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "education");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropTable(
                name: "Offer");

            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.DropTable(
                name: "workingexperience");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Resume");

            migrationBuilder.DropTable(
                name: "JBUser");
        }
    }
}
