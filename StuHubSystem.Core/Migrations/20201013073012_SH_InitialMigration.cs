using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StuHubSystem.Core.Migrations
{
    public partial class SH_InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyGroupImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyGroupColor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudyFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyGroupId = table.Column<int>(type: "int", nullable: true),
                    StudyFieldName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyFields_StudyGroups_StudyGroupId",
                        column: x => x.StudyGroupId,
                        principalTable: "StudyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolLogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolBackgroundImages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirlPercentage = table.Column<int>(type: "int", nullable: false),
                    BoyPercentage = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CollegeSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyGroupId = table.Column<int>(type: "int", nullable: true),
                    StudyFieldId = table.Column<int>(type: "int", nullable: true),
                    SchoolId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollegeSubjects_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CollegeSubjects_StudyFields_StudyFieldId",
                        column: x => x.StudyFieldId,
                        principalTable: "StudyFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CollegeSubjects_StudyGroups_StudyGroupId",
                        column: x => x.StudyGroupId,
                        principalTable: "StudyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CollegeSubjectRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollegeSubjectId = table.Column<int>(type: "int", nullable: true),
                    DateUpload = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Teacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeWork = table.Column<bool>(type: "bit", nullable: false),
                    Presentation = table.Column<bool>(type: "bit", nullable: false),
                    Laboratory = table.Column<bool>(type: "bit", nullable: false),
                    LearningCityId = table.Column<int>(type: "int", nullable: true),
                    LearningDistrictId = table.Column<int>(type: "int", nullable: true),
                    PaymentTimeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeSubjectRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollegeSubjectRequests_Cities_LearningCityId",
                        column: x => x.LearningCityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CollegeSubjectRequests_CollegeSubjects_CollegeSubjectId",
                        column: x => x.CollegeSubjectId,
                        principalTable: "CollegeSubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CollegeSubjectRequests_Districts_LearningDistrictId",
                        column: x => x.LearningDistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollegeSubjectRequests_CollegeSubjectId",
                table: "CollegeSubjectRequests",
                column: "CollegeSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeSubjectRequests_LearningCityId",
                table: "CollegeSubjectRequests",
                column: "LearningCityId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeSubjectRequests_LearningDistrictId",
                table: "CollegeSubjectRequests",
                column: "LearningDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeSubjects_SchoolId",
                table: "CollegeSubjects",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeSubjects_StudyFieldId",
                table: "CollegeSubjects",
                column: "StudyFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeSubjects_StudyGroupId",
                table: "CollegeSubjects",
                column: "StudyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_CityId",
                table: "Schools",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_DistrictId",
                table: "Schools",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyFields_StudyGroupId",
                table: "StudyFields",
                column: "StudyGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeSubjectRequests");

            migrationBuilder.DropTable(
                name: "CollegeSubjects");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "StudyFields");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "StudyGroups");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
