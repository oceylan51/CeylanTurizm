﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CeylanTurizm.Data.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    BusId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusPlaque = table.Column<string>(type: "TEXT", nullable: true),
                    BusDriver = table.Column<string>(type: "TEXT", nullable: true),
                    BusSeatingCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    IsExpedition = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDelte = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.BusId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityNo = table.Column<int>(type: "INTEGER", nullable: false),
                    CityName = table.Column<string>(type: "TEXT", nullable: true),
                    CityImg = table.Column<string>(type: "TEXT", nullable: true),
                    CityTitle = table.Column<string>(type: "TEXT", nullable: true),
                    CityDescription = table.Column<string>(type: "TEXT", nullable: true),
                    CityDescription2 = table.Column<string>(type: "TEXT", nullable: true),
                    CityDescription3 = table.Column<string>(type: "TEXT", nullable: true),
                    CityDescription4 = table.Column<string>(type: "TEXT", nullable: true),
                    CityDescription5 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Expeditions",
                columns: table => new
                {
                    ExpeditionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusId = table.Column<int>(type: "INTEGER", nullable: false),
                    ExpeditionStart = table.Column<string>(type: "TEXT", nullable: true),
                    ExpeditionStation = table.Column<string>(type: "TEXT", nullable: true),
                    ExpeditionFinish = table.Column<string>(type: "TEXT", nullable: true),
                    ExpeditionDate = table.Column<string>(type: "TEXT", nullable: true),
                    ExpeditionHour = table.Column<string>(type: "TEXT", nullable: true),
                    ExpeditionPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsFinish = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expeditions", x => x.ExpeditionId);
                    table.ForeignKey(
                        name: "FK_Expeditions_Buses_BusId",
                        column: x => x.BusId,
                        principalTable: "Buses",
                        principalColumn: "BusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketSales",
                columns: table => new
                {
                    TicketSalesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExpeditionId = table.Column<int>(type: "INTEGER", nullable: false),
                    SeatNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    customerName = table.Column<string>(type: "TEXT", nullable: true),
                    customerSurname = table.Column<string>(type: "TEXT", nullable: true),
                    customerTelNo = table.Column<string>(type: "TEXT", nullable: true),
                    customerTcNo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketSales", x => x.TicketSalesId);
                    table.ForeignKey(
                        name: "FK_TicketSales_Expeditions_ExpeditionId",
                        column: x => x.ExpeditionId,
                        principalTable: "Expeditions",
                        principalColumn: "ExpeditionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expeditions_BusId",
                table: "Expeditions",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketSales_ExpeditionId",
                table: "TicketSales",
                column: "ExpeditionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "TicketSales");

            migrationBuilder.DropTable(
                name: "Expeditions");

            migrationBuilder.DropTable(
                name: "Buses");
        }
    }
}
