using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Class4_Journals.Migrations
{
    public partial class OwningAndEditingUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journal_User_UserNumber",
                table: "Journal");

            migrationBuilder.DropIndex(
                name: "IX_Journal_UserNumber",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "UserNumber",
                table: "Journal");

            migrationBuilder.AddColumn<int>(
                name: "EditingUserNumber",
                table: "Journal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwningUserNumber",
                table: "Journal",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Journal_EditingUserNumber",
                table: "Journal",
                column: "EditingUserNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_OwningUserNumber",
                table: "Journal",
                column: "OwningUserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_User_EditingUserNumber",
                table: "Journal",
                column: "EditingUserNumber",
                principalTable: "User",
                principalColumn: "UserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_User_OwningUserNumber",
                table: "Journal",
                column: "OwningUserNumber",
                principalTable: "User",
                principalColumn: "UserNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journal_User_EditingUserNumber",
                table: "Journal");

            migrationBuilder.DropForeignKey(
                name: "FK_Journal_User_OwningUserNumber",
                table: "Journal");

            migrationBuilder.DropIndex(
                name: "IX_Journal_EditingUserNumber",
                table: "Journal");

            migrationBuilder.DropIndex(
                name: "IX_Journal_OwningUserNumber",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "EditingUserNumber",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "OwningUserNumber",
                table: "Journal");

            migrationBuilder.AddColumn<int>(
                name: "UserNumber",
                table: "Journal",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Journal_UserNumber",
                table: "Journal",
                column: "UserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_User_UserNumber",
                table: "Journal",
                column: "UserNumber",
                principalTable: "User",
                principalColumn: "UserNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
