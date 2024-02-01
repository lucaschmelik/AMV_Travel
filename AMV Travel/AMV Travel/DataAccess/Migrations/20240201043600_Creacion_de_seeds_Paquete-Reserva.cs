using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMV_Travel.Migrations
{
    public partial class Creacion_de_seeds_PaqueteReserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 3, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7006), new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 5, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7007), new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 6, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7009), new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 7, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7010), new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 3, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7111), new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 5, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7113), new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 6, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 7, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.InsertData(
                table: "Paquetes",
                columns: new[] { "Id", "Descripcion", "ExcursionId", "HotelId" },
                values: new object[,]
                {
                    { 1, "Paquete Aventura", 1, 1 },
                    { 2, "Paquete Histórico", 2, 2 },
                    { 3, "Paquete Naturaleza", 3, 3 },
                    { 4, "Paquete Romántico", 4, 4 },
                    { 5, "Paquete Relax", 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Reservas",
                columns: new[] { "Id", "ClienteId", "Estado", "FechaCreacion", "PaqueteId" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7381), 1 },
                    { 2, 2, 2, new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7383), 2 },
                    { 3, 3, 3, new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7384), 3 },
                    { 4, 4, 1, new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7385), 4 },
                    { 5, 5, 1, new DateTime(2024, 2, 1, 1, 35, 59, 989, DateTimeKind.Local).AddTicks(7386), 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Paquetes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Paquetes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Paquetes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Paquetes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Paquetes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 3, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2153), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2158), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 5, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2159), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 6, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 7, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2161), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 3, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2247), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 5, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2250), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 6, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2251), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 2, 7, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2252), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2252) });
        }
    }
}
