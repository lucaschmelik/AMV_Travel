using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMV_Travel.Migrations
{
    public partial class Creacion_de_seeds_ClienteExcursionHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Apellido", "Correo", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "García", "lucas@example.com", "Lucas", "123456789" },
                    { 2, "Pérez", "martin@example.com", "Martín", "987654321" },
                    { 3, "Rodríguez", "nicolas@example.com", "Nicolas", "555555555" },
                    { 4, "López", "alejandra@example.com", "Alejandra", "666666666" },
                    { 5, "Fernández", "camila@example.com", "Camila", "777777777" }
                });

            migrationBuilder.InsertData(
                table: "Excursiones",
                columns: new[] { "Id", "Descripcion", "FechaFin", "FechaInicio", "Precio" },
                values: new object[,]
                {
                    { 1, "Aventura en la montaña", new DateTime(2024, 2, 3, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2153), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2144), 100 },
                    { 2, "Tour histórico", new DateTime(2024, 2, 4, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2158), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2157), 150 },
                    { 3, "Exploración de la selva", new DateTime(2024, 2, 5, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2159), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2159), 120 },
                    { 4, "Viaje en globo aerostático", new DateTime(2024, 2, 6, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2160), 200 },
                    { 5, "Recorrido en bicicleta", new DateTime(2024, 2, 7, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2161), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2161), 180 }
                });

            migrationBuilder.InsertData(
                table: "Hoteles",
                columns: new[] { "Id", "Direccion", "FechaFin", "FechaInicio", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Calle de la Luna 123", new DateTime(2024, 2, 3, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2247), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2246), "Hotel Estrella", 200 },
                    { 2, "Avenida del Sol 456", new DateTime(2024, 2, 4, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2248), "Gran Hotel Oasis", 250 },
                    { 3, "Ruta de la Cima 789", new DateTime(2024, 2, 5, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2250), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2250), "Hotel de las Montañas", 220 },
                    { 4, "Camino al Bosque 101", new DateTime(2024, 2, 6, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2251), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2251), "Hotel Natura", 300 },
                    { 5, "Paseo Marítimo 202", new DateTime(2024, 2, 7, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2252), new DateTime(2024, 2, 1, 1, 29, 41, 112, DateTimeKind.Local).AddTicks(2252), "Hotel del Mar", 280 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Excursiones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hoteles",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
