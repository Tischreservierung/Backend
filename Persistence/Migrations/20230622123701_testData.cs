using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class testData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RestaurantOpeningTimes",
                columns: new[] { "Id", "ClosingTime", "Day", "OpeningTime", "RestaurantId" },
                values: new object[,]
                {
                    { 8, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, new DateTime(2023, 5, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2023, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, new DateTime(2023, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2023, 5, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, new DateTime(2023, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 5, 26, 7, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, new DateTime(2023, 5, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, new DateTime(2023, 5, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, new DateTime(2023, 5, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2023, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, new DateTime(2023, 5, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2023, 5, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, new DateTime(2023, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 5, 26, 6, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, new DateTime(2023, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 5, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 5, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 5, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 5, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, new DateTime(2023, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, new DateTime(2023, 5, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2023, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, new DateTime(2023, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2023, 5, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "ZipCodeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "ZipCodeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "ZipCodeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "ZipCodeId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7,
                column: "ZipCodeId",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8,
                column: "ZipCodeId",
                value: 67);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9,
                column: "ZipCodeId",
                value: 17);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "ZipCodeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "ZipCodeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "ZipCodeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "ZipCodeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7,
                column: "ZipCodeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8,
                column: "ZipCodeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9,
                column: "ZipCodeId",
                value: 1);
        }
    }
}
