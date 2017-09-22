using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CinemaTickets.Infrastructure.Data.Migrations
{
    public partial class _2ndMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionPrices_MovieSessions",
                table: "SessionPrices");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionPrices_MovieSessions",
                table: "SessionPrices",
                column: "MovieSessionId",
                principalTable: "MovieSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionPrices_MovieSessions",
                table: "SessionPrices");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionPrices_MovieSessions",
                table: "SessionPrices",
                column: "MovieSessionId",
                principalTable: "MovieSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
