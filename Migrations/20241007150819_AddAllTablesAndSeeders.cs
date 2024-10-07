using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelApiRestFull.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTablesAndSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    identification_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "guests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    identification_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    birthdate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guests", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "room_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_types", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    room_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price_per_night = table.Column<double>(type: "double", nullable: false),
                    availability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    max_occupancy_persons = table.Column<int>(type: "int", nullable: false),
                    room_type_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.id);
                    table.ForeignKey(
                        name: "FK_rooms_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    room_id = table.Column<int>(type: "int", nullable: false),
                    guest_id = table.Column<int>(type: "int", nullable: false),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    total_cost = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.id);
                    table.ForeignKey(
                        name: "FK_bookings_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_guests_guest_id",
                        column: x => x.guest_id,
                        principalTable: "guests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_rooms_room_id",
                        column: x => x.room_id,
                        principalTable: "rooms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Una acogedora habitación básica con una cama individual, ideal para viajeros solos.", "Habitacion Simple" },
                    { 2, "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.", "Habitacion Doble" },
                    { 3, "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.", "Habitacion Suite" },
                    { 4, "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.", "Habitacion Familiar" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "room_number", "max_occupancy_persons", "price_per_night", "room_type_id" },
                values: new object[,]
                {
                    { 1, true, "101", 1, 50.0, 1 },
                    { 2, true, "102", 1, 50.0, 1 },
                    { 3, true, "103", 1, 50.0, 1 },
                    { 4, true, "104", 1, 50.0, 1 },
                    { 5, true, "105", 1, 50.0, 1 },
                    { 6, true, "106", 1, 50.0, 1 },
                    { 7, true, "107", 1, 50.0, 1 },
                    { 8, true, "108", 1, 50.0, 1 },
                    { 9, true, "109", 1, 50.0, 1 },
                    { 10, true, "110", 1, 50.0, 1 },
                    { 11, true, "201", 2, 80.0, 2 },
                    { 12, true, "202", 2, 80.0, 2 },
                    { 13, true, "203", 2, 80.0, 2 },
                    { 14, true, "204", 2, 80.0, 2 },
                    { 15, true, "205", 2, 80.0, 2 },
                    { 16, true, "206", 2, 80.0, 2 },
                    { 17, true, "207", 2, 80.0, 2 },
                    { 18, true, "208", 2, 80.0, 2 },
                    { 19, true, "209", 2, 80.0, 2 },
                    { 20, true, "210", 2, 80.0, 2 },
                    { 21, true, "301", 2, 80.0, 2 },
                    { 22, true, "302", 2, 80.0, 2 },
                    { 23, true, "303", 2, 80.0, 2 },
                    { 24, true, "304", 2, 80.0, 2 },
                    { 25, true, "305", 2, 80.0, 2 },
                    { 26, true, "306", 2, 150.0, 3 },
                    { 27, true, "307", 2, 150.0, 3 },
                    { 28, true, "308", 2, 150.0, 3 },
                    { 29, true, "309", 2, 150.0, 3 },
                    { 30, true, "310", 2, 150.0, 3 },
                    { 31, true, "401", 2, 150.0, 3 },
                    { 32, true, "402", 2, 150.0, 3 },
                    { 33, true, "403", 2, 150.0, 3 },
                    { 34, true, "404", 2, 150.0, 3 },
                    { 35, true, "405", 2, 150.0, 3 },
                    { 36, true, "406", 2, 150.0, 3 },
                    { 37, true, "407", 2, 150.0, 3 },
                    { 38, true, "408", 2, 150.0, 3 },
                    { 39, true, "409", 2, 150.0, 3 },
                    { 40, true, "410", 2, 150.0, 3 },
                    { 41, true, "501", 4, 200.0, 4 },
                    { 42, true, "502", 4, 200.0, 4 },
                    { 43, true, "503", 4, 200.0, 4 },
                    { 44, true, "504", 4, 200.0, 4 },
                    { 45, true, "505", 4, 200.0, 4 },
                    { 46, true, "506", 4, 200.0, 4 },
                    { 47, true, "507", 4, 200.0, 4 },
                    { 48, true, "508", 4, 200.0, 4 },
                    { 49, true, "509", 4, 200.0, 4 },
                    { 50, true, "510", 4, 200.0, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_employee_id",
                table: "bookings",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_guest_id",
                table: "bookings",
                column: "guest_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_room_id",
                table: "bookings",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_room_type_id",
                table: "rooms",
                column: "room_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "guests");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "room_types");
        }
    }
}
