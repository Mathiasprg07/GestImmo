using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestImmo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bails_Biens_BienId",
                table: "Bails");

            migrationBuilder.AlterColumn<int>(
                name: "BienId",
                table: "Bails",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bails_Biens_BienId",
                table: "Bails",
                column: "BienId",
                principalTable: "Biens",
                principalColumn: "BienId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bails_Biens_BienId",
                table: "Bails");

            migrationBuilder.AlterColumn<int>(
                name: "BienId",
                table: "Bails",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Bails_Biens_BienId",
                table: "Bails",
                column: "BienId",
                principalTable: "Biens",
                principalColumn: "BienId");
        }
    }
}
