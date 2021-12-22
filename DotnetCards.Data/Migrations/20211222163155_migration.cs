using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetCards.Data.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostDetails_Posts_PostID",
                table: "PostDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Posts_ParentPostID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "ParentPostID",
                table: "Posts",
                newName: "ParentPostId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_ParentPostID",
                table: "Posts",
                newName: "IX_Posts_ParentPostId");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "PostDetails",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_PostDetails_PostID",
                table: "PostDetails",
                newName: "IX_PostDetails_PostId");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 12, 22, 19, 31, 54, 756, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 12, 22, 19, 31, 54, 758, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.AddForeignKey(
                name: "FK_PostDetails_Posts_PostId",
                table: "PostDetails",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Posts_ParentPostId",
                table: "Posts",
                column: "ParentPostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostDetails_Posts_PostId",
                table: "PostDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Posts_ParentPostId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "ParentPostId",
                table: "Posts",
                newName: "ParentPostID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_ParentPostId",
                table: "Posts",
                newName: "IX_Posts_ParentPostID");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "PostDetails",
                newName: "PostID");

            migrationBuilder.RenameIndex(
                name: "IX_PostDetails_PostId",
                table: "PostDetails",
                newName: "IX_PostDetails_PostID");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 12, 7, 23, 7, 45, 524, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 12, 7, 23, 7, 45, 525, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.AddForeignKey(
                name: "FK_PostDetails_Posts_PostID",
                table: "PostDetails",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Posts_ParentPostID",
                table: "Posts",
                column: "ParentPostID",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
