using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetCards.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ParentPostID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Posts_ParentPostID",
                        column: x => x.ParentPostID,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    PostText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostDetails_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Date", "IsDeleted", "ParentPostID", "Title" },
                values: new object[] { 1, new DateTime(2021, 12, 7, 23, 7, 45, 524, DateTimeKind.Local).AddTicks(5826), false, null, "Post1" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Date", "IsDeleted", "ParentPostID", "Title" },
                values: new object[] { 2, new DateTime(2021, 12, 7, 23, 7, 45, 525, DateTimeKind.Local).AddTicks(7650), false, null, "Post2" });

            migrationBuilder.InsertData(
                table: "PostDetails",
                columns: new[] { "Id", "PostID", "PostText" },
                values: new object[] { 1, 1, "Post Detail 1" });

            migrationBuilder.InsertData(
                table: "PostDetails",
                columns: new[] { "Id", "PostID", "PostText" },
                values: new object[] { 2, 2, "Post Detail 2" });

            migrationBuilder.CreateIndex(
                name: "IX_PostDetails_PostID",
                table: "PostDetails",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ParentPostID",
                table: "Posts",
                column: "ParentPostID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostDetails");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
