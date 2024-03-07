using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TableClosed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ClosedAt",
                table: "RestaurantTables",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StreetNr",
                table: "Restaurants",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurants",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Restaurants",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Restaurants",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 100,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 101,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 102,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 103,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 104,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 105,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 106,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 107,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 108,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 109,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 110,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 111,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 112,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 113,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 200,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 201,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 202,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 203,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 204,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 205,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 206,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 207,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 208,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 209,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 210,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 211,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 212,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 300,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 301,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 302,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 303,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 304,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 305,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 306,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 307,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 308,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 309,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 310,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 311,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 312,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 313,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 314,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 400,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 401,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 402,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 403,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 404,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 405,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 406,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 407,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 408,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 409,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 410,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 411,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 500,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 501,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 502,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 503,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 504,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 505,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 506,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 507,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 508,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 509,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 510,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 600,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 601,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 602,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 603,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 604,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 605,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 606,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 607,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 608,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 609,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 610,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 611,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 612,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 613,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 700,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 701,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 702,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 703,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 704,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 705,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 706,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 707,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 708,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 709,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 710,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 711,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 712,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 800,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 801,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 802,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 803,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 804,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 805,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 806,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 807,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 808,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 809,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 810,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 811,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 812,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 813,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 814,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 900,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 901,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 902,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 903,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 904,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 905,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 906,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 907,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 908,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 909,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 910,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 911,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1000,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1005,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1006,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1007,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1008,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1009,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1010,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1100,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1200,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1204,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1205,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1206,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1207,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1208,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1209,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1210,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1211,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1300,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1301,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1302,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1303,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1304,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1305,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1306,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1307,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1308,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1309,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1310,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1311,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1312,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1313,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1400,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1401,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1402,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1403,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1404,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1405,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1406,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1407,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1408,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1409,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1410,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1500,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1501,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1502,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1503,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1504,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1505,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1506,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1507,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1508,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1509,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1600,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1601,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1602,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1603,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1604,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1605,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1606,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1607,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1608,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1609,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1610,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1611,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1612,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1700,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1701,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1702,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1703,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1704,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1705,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1706,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1707,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1708,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1709,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1710,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1711,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1800,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1801,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1802,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1803,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1804,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1805,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1806,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1807,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1808,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1809,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1810,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1811,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1812,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1813,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1900,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1901,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1902,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1903,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1904,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1905,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1906,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1907,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1908,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1909,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1910,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2000,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2001,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2002,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2003,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2004,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2005,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2006,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2007,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2008,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2009,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2100,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2101,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2102,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2103,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2104,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2105,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2106,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2107,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2108,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2109,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2110,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2111,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2112,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2113,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2200,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2201,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2202,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2203,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2204,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2205,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2206,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2207,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2208,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2209,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2210,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2211,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2212,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2300,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2301,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2302,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2303,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2304,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2305,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2306,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2307,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2308,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2309,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2310,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2311,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2312,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2313,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2314,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2400,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2401,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2402,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2403,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2404,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2405,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2406,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2407,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2408,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2409,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2410,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2411,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2500,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2501,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2502,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2503,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2504,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2505,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2506,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2507,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2508,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2509,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2510,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2600,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2601,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2602,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2603,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2604,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2605,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2606,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2607,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2608,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2609,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2610,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2611,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2612,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2613,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2700,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2701,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2702,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2703,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2704,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2705,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2706,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2707,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2708,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2709,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2710,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2711,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2712,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2800,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2801,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2802,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2803,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2804,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2805,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2806,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2807,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2808,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2809,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2810,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2811,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2812,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2813,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2814,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2900,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2901,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2902,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2903,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2904,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2905,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2906,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2907,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2908,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2909,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2910,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2911,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3000,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3001,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3002,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3003,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3004,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3005,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3006,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3007,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3008,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3009,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3010,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3100,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3101,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3102,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3103,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3104,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3105,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3106,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3107,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3108,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3109,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3110,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3111,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3112,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3200,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3201,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3202,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3203,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3204,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3205,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3206,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3207,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3208,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3209,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3210,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3211,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3300,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3301,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3302,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3303,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3304,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3305,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3306,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3307,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3308,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3309,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3310,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3311,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3312,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3313,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3400,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3401,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3402,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3403,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3404,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3405,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3406,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3407,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3408,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3409,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3410,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3500,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3501,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3502,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3503,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3504,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3505,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3506,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3507,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3508,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3509,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3600,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3601,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3602,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3603,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3604,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3605,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3606,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3607,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3608,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3609,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3610,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3611,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3612,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3700,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3701,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3702,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3703,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3704,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3705,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3706,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3707,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3708,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3709,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3710,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3711,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3800,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3801,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3802,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3803,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3804,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3805,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3806,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3807,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3808,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3809,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3810,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3811,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3812,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3813,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3900,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3901,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3902,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3903,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3904,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3905,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3906,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3907,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3908,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3909,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3910,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4000,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4001,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4002,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4003,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4004,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4005,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4006,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4007,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4008,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4009,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4100,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4101,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4102,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4103,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4104,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4105,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4106,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4107,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4108,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4109,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4110,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4111,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4112,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4113,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4200,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4201,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4202,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4203,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4204,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4205,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4206,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4207,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4208,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4209,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4210,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4211,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4212,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4213,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4300,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4301,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4302,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4303,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4304,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4305,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4306,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4307,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4308,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4309,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4310,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4311,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4312,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4313,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4314,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4400,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4401,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4402,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4403,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4404,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4405,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4406,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4407,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4408,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4409,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4410,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4500,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4501,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4502,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4503,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4504,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4505,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4506,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4507,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4508,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4509,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4510,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4511,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4512,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4513,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4600,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4601,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4602,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4603,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4604,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4605,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4606,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4607,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4608,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4609,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4610,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4611,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4700,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4701,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4702,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4703,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4704,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4705,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4706,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4707,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4708,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4709,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4710,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4711,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4800,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4801,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4802,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4803,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4804,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4805,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4806,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4807,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4808,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4809,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4810,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4900,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4901,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4902,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4903,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4904,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4905,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4906,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4907,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4908,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4909,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5000,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5001,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5002,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5003,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5004,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5005,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5006,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5007,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5008,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5009,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5010,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5011,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5012,
                column: "ClosedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5013,
                column: "ClosedAt",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosedAt",
                table: "RestaurantTables");

            migrationBuilder.AlterColumn<string>(
                name: "StreetNr",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);
        }
    }
}
