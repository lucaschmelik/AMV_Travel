using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMV_Travel.Migrations
{
    public partial class Creacion_de_campos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paquetes_Excursiones_ExcursionId",
                table: "Paquetes");

            migrationBuilder.DropForeignKey(
                name: "FK_Paquetes_Hoteles_HotelId",
                table: "Paquetes");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Paquetes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExcursionId",
                table: "Paquetes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Paquetes_Excursiones_ExcursionId",
                table: "Paquetes",
                column: "ExcursionId",
                principalTable: "Excursiones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paquetes_Hoteles_HotelId",
                table: "Paquetes",
                column: "HotelId",
                principalTable: "Hoteles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paquetes_Excursiones_ExcursionId",
                table: "Paquetes");

            migrationBuilder.DropForeignKey(
                name: "FK_Paquetes_Hoteles_HotelId",
                table: "Paquetes");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Paquetes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExcursionId",
                table: "Paquetes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Paquetes_Excursiones_ExcursionId",
                table: "Paquetes",
                column: "ExcursionId",
                principalTable: "Excursiones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paquetes_Hoteles_HotelId",
                table: "Paquetes",
                column: "HotelId",
                principalTable: "Hoteles",
                principalColumn: "Id");
        }
    }
}
