using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantOpeningTimeTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RestaurantOpeningTimes",
                columns: new[] { "Id", "ClosingTime", "Day", "OpeningTime", "RestaurantId" },
                values: new object[,]
                {
                    { 100, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 110, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 120, new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 130, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 140, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 150, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 151, new TimeSpan(0, 20, 0, 0, 0), 5, new TimeSpan(0, 18, 0, 0, 0), 1 },
                    { 160, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 161, new TimeSpan(0, 20, 0, 0, 0), 6, new TimeSpan(0, 18, 0, 0, 0), 1 },
                    { 200, new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 210, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 220, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 230, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 240, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 260, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 261, new TimeSpan(0, 20, 0, 0, 0), 6, new TimeSpan(0, 18, 0, 0, 0), 2 },
                    { 300, new TimeSpan(0, 17, 30, 0, 0), 0, new TimeSpan(0, 8, 30, 0, 0), 3 },
                    { 310, new TimeSpan(0, 17, 30, 0, 0), 1, new TimeSpan(0, 8, 30, 0, 0), 3 },
                    { 320, new TimeSpan(0, 17, 30, 0, 0), 2, new TimeSpan(0, 8, 30, 0, 0), 3 },
                    { 330, new TimeSpan(0, 17, 30, 0, 0), 3, new TimeSpan(0, 8, 30, 0, 0), 3 },
                    { 340, new TimeSpan(0, 17, 30, 0, 0), 4, new TimeSpan(0, 8, 30, 0, 0), 3 },
                    { 350, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 360, new TimeSpan(0, 15, 30, 0, 0), 6, new TimeSpan(0, 10, 30, 0, 0), 3 },
                    { 361, new TimeSpan(0, 21, 0, 0, 0), 6, new TimeSpan(0, 18, 0, 0, 0), 3 },
                    { 400, new TimeSpan(0, 19, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 410, new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 420, new TimeSpan(0, 16, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 421, new TimeSpan(0, 23, 30, 0, 0), 2, new TimeSpan(0, 20, 0, 0, 0), 4 },
                    { 430, new TimeSpan(0, 16, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 431, new TimeSpan(0, 23, 30, 0, 0), 3, new TimeSpan(0, 20, 0, 0, 0), 4 },
                    { 440, new TimeSpan(0, 16, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 441, new TimeSpan(0, 23, 30, 0, 0), 4, new TimeSpan(0, 20, 0, 0, 0), 4 },
                    { 460, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 510, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 5 },
                    { 520, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 5 },
                    { 521, new TimeSpan(0, 22, 0, 0, 0), 2, new TimeSpan(0, 20, 0, 0, 0), 5 },
                    { 530, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 5 },
                    { 531, new TimeSpan(0, 22, 0, 0, 0), 3, new TimeSpan(0, 20, 0, 0, 0), 5 },
                    { 540, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 5 },
                    { 560, new TimeSpan(0, 15, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 600, new TimeSpan(0, 18, 30, 0, 0), 0, new TimeSpan(0, 9, 30, 0, 0), 6 },
                    { 610, new TimeSpan(0, 18, 30, 0, 0), 1, new TimeSpan(0, 9, 30, 0, 0), 6 },
                    { 620, new TimeSpan(0, 18, 30, 0, 0), 2, new TimeSpan(0, 9, 30, 0, 0), 6 },
                    { 630, new TimeSpan(0, 18, 30, 0, 0), 3, new TimeSpan(0, 9, 30, 0, 0), 6 },
                    { 640, new TimeSpan(0, 18, 30, 0, 0), 4, new TimeSpan(0, 9, 30, 0, 0), 6 },
                    { 660, new TimeSpan(0, 16, 30, 0, 0), 6, new TimeSpan(0, 10, 30, 0, 0), 6 },
                    { 700, new TimeSpan(0, 17, 30, 0, 0), 0, new TimeSpan(0, 10, 30, 0, 0), 7 },
                    { 710, new TimeSpan(0, 17, 30, 0, 0), 1, new TimeSpan(0, 10, 30, 0, 0), 7 },
                    { 720, new TimeSpan(0, 17, 30, 0, 0), 2, new TimeSpan(0, 10, 30, 0, 0), 7 },
                    { 740, new TimeSpan(0, 17, 30, 0, 0), 4, new TimeSpan(0, 10, 30, 0, 0), 7 },
                    { 750, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 12, 0, 0, 0), 7 },
                    { 760, new TimeSpan(0, 15, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 7 },
                    { 810, new TimeSpan(0, 16, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 8 },
                    { 820, new TimeSpan(0, 16, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 8 },
                    { 830, new TimeSpan(0, 16, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 8 },
                    { 840, new TimeSpan(0, 16, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0), 8 },
                    { 860, new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0), 8 },
                    { 900, new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0), 9 },
                    { 910, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 9 },
                    { 920, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 9 },
                    { 930, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 9 },
                    { 940, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 9 },
                    { 950, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 12, 0, 0, 0), 9 },
                    { 960, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 9 },
                    { 1000, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 10 },
                    { 1010, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 10 },
                    { 1020, new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0), 10 },
                    { 1030, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 10 },
                    { 1040, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 10 },
                    { 1060, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 10 },
                    { 1110, new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 11 },
                    { 1120, new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 11 },
                    { 1140, new TimeSpan(0, 19, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 11 },
                    { 1150, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 11 },
                    { 1200, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 12 },
                    { 1210, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 12 },
                    { 1230, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 12 },
                    { 1240, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 12 },
                    { 1250, new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 11, 0, 0, 0), 12 },
                    { 1310, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 13 },
                    { 1320, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 13 },
                    { 1330, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 13 },
                    { 1340, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0), 13 },
                    { 1360, new TimeSpan(0, 15, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0), 13 },
                    { 1400, new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0), 14 },
                    { 1410, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 14 },
                    { 1430, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 14 },
                    { 1440, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 14 },
                    { 1450, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 12, 0, 0, 0), 14 },
                    { 1460, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 14 },
                    { 1500, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 15 },
                    { 1510, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 15 },
                    { 1520, new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0), 15 },
                    { 1530, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 15 },
                    { 1540, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 15 },
                    { 1560, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 15 },
                    { 1610, new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 16 },
                    { 1620, new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 16 },
                    { 1630, new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 16 },
                    { 1640, new TimeSpan(0, 19, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 16 },
                    { 1650, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 16 },
                    { 1700, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 17 },
                    { 1710, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 17 },
                    { 1720, new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0), 17 },
                    { 1730, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 17 },
                    { 1740, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 17 },
                    { 1750, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 12, 0, 0, 0), 17 },
                    { 1760, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 17 },
                    { 1810, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 18 },
                    { 1820, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 18 },
                    { 1830, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 18 },
                    { 1840, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 18 },
                    { 1860, new TimeSpan(0, 15, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 18 },
                    { 1900, new TimeSpan(0, 18, 30, 0, 0), 0, new TimeSpan(0, 9, 30, 0, 0), 19 },
                    { 1910, new TimeSpan(0, 18, 30, 0, 0), 1, new TimeSpan(0, 9, 30, 0, 0), 19 },
                    { 1920, new TimeSpan(0, 18, 30, 0, 0), 2, new TimeSpan(0, 9, 30, 0, 0), 19 },
                    { 1930, new TimeSpan(0, 18, 30, 0, 0), 3, new TimeSpan(0, 9, 30, 0, 0), 19 },
                    { 1940, new TimeSpan(0, 18, 30, 0, 0), 4, new TimeSpan(0, 9, 30, 0, 0), 19 },
                    { 1960, new TimeSpan(0, 16, 30, 0, 0), 6, new TimeSpan(0, 10, 30, 0, 0), 19 },
                    { 2000, new TimeSpan(0, 17, 30, 0, 0), 0, new TimeSpan(0, 10, 30, 0, 0), 20 },
                    { 2010, new TimeSpan(0, 17, 30, 0, 0), 1, new TimeSpan(0, 10, 30, 0, 0), 20 },
                    { 2020, new TimeSpan(0, 17, 30, 0, 0), 2, new TimeSpan(0, 10, 30, 0, 0), 20 },
                    { 2030, new TimeSpan(0, 17, 30, 0, 0), 3, new TimeSpan(0, 10, 30, 0, 0), 20 },
                    { 2040, new TimeSpan(0, 17, 30, 0, 0), 4, new TimeSpan(0, 10, 30, 0, 0), 20 },
                    { 2060, new TimeSpan(0, 15, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 20 },
                    { 2110, new TimeSpan(0, 16, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 21 },
                    { 2120, new TimeSpan(0, 16, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 21 },
                    { 2130, new TimeSpan(0, 16, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 21 },
                    { 2140, new TimeSpan(0, 16, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0), 21 },
                    { 2160, new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0), 21 },
                    { 2161, new TimeSpan(0, 20, 0, 0, 0), 6, new TimeSpan(0, 18, 0, 0, 0), 21 },
                    { 2200, new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0), 22 },
                    { 2210, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 22 },
                    { 2220, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 22 },
                    { 2230, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 22 },
                    { 2240, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 22 },
                    { 2260, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 22 },
                    { 2300, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 23 },
                    { 2310, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 23 },
                    { 2320, new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0), 23 },
                    { 2330, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 23 },
                    { 2340, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 23 },
                    { 2360, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 23 },
                    { 2410, new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 24 },
                    { 2420, new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 24 },
                    { 2430, new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 24 },
                    { 2440, new TimeSpan(0, 19, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 24 },
                    { 2450, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 24 },
                    { 2500, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 25 },
                    { 2510, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 25 },
                    { 2520, new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0), 25 },
                    { 2540, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 25 },
                    { 2550, new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 11, 0, 0, 0), 25 },
                    { 2610, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 26 },
                    { 2620, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 26 },
                    { 2630, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 26 },
                    { 2640, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0), 26 },
                    { 2660, new TimeSpan(0, 15, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0), 26 },
                    { 2700, new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0), 27 },
                    { 2710, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 27 },
                    { 2730, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 27 },
                    { 2740, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 27 },
                    { 2750, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 12, 0, 0, 0), 27 },
                    { 2760, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 27 },
                    { 2800, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 28 },
                    { 2810, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 28 },
                    { 2820, new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0), 28 },
                    { 2830, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 28 },
                    { 2840, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 28 },
                    { 2860, new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 8, 0, 0, 0), 28 },
                    { 2861, new TimeSpan(0, 20, 0, 0, 0), 6, new TimeSpan(0, 18, 0, 0, 0), 28 },
                    { 2910, new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 29 },
                    { 2920, new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 29 },
                    { 2930, new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 29 },
                    { 2950, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 29 },
                    { 3000, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 30 },
                    { 3010, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 30 },
                    { 3020, new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0), 30 },
                    { 3030, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 30 },
                    { 3040, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 30 },
                    { 3050, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 12, 0, 0, 0), 30 },
                    { 3060, new TimeSpan(0, 18, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 30 },
                    { 3110, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 31 },
                    { 3120, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 31 },
                    { 3130, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 31 },
                    { 3140, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 31 },
                    { 3160, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 31 },
                    { 3210, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 32 },
                    { 3220, new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 32 },
                    { 3230, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 32 },
                    { 3240, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 32 },
                    { 3250, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 12, 0, 0, 0), 32 },
                    { 3260, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 32 },
                    { 3300, new TimeSpan(0, 14, 0, 0, 0), 0, new TimeSpan(0, 8, 0, 0, 0), 33 },
                    { 3301, new TimeSpan(0, 20, 0, 0, 0), 0, new TimeSpan(0, 18, 0, 0, 0), 33 },
                    { 3320, new TimeSpan(0, 14, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 33 },
                    { 3321, new TimeSpan(0, 20, 0, 0, 0), 2, new TimeSpan(0, 18, 0, 0, 0), 33 },
                    { 3330, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 33 },
                    { 3350, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 33 },
                    { 3360, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 33 },
                    { 3400, new TimeSpan(0, 17, 30, 0, 0), 0, new TimeSpan(0, 8, 30, 0, 0), 34 },
                    { 3410, new TimeSpan(0, 17, 30, 0, 0), 1, new TimeSpan(0, 8, 30, 0, 0), 34 },
                    { 3430, new TimeSpan(0, 17, 30, 0, 0), 3, new TimeSpan(0, 8, 30, 0, 0), 34 },
                    { 3440, new TimeSpan(0, 16, 0, 0, 0), 4, new TimeSpan(0, 12, 0, 0, 0), 34 },
                    { 3450, new TimeSpan(0, 15, 30, 0, 0), 5, new TimeSpan(0, 10, 30, 0, 0), 34 },
                    { 3451, new TimeSpan(0, 20, 0, 0, 0), 5, new TimeSpan(0, 18, 0, 0, 0), 34 },
                    { 3460, new TimeSpan(0, 15, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0), 34 },
                    { 3510, new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 35 },
                    { 3520, new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0), 35 },
                    { 3530, new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 35 },
                    { 3540, new TimeSpan(0, 19, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 35 },
                    { 3560, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 35 },
                    { 3600, new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 8, 0, 0, 0), 36 },
                    { 3610, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 36 },
                    { 3630, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 36 },
                    { 3640, new TimeSpan(0, 15, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 36 },
                    { 3650, new TimeSpan(0, 15, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 36 },
                    { 3660, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 12, 0, 0, 0), 36 },
                    { 3700, new TimeSpan(0, 18, 30, 0, 0), 0, new TimeSpan(0, 9, 30, 0, 0), 37 },
                    { 3710, new TimeSpan(0, 18, 30, 0, 0), 1, new TimeSpan(0, 9, 30, 0, 0), 37 },
                    { 3720, new TimeSpan(0, 18, 30, 0, 0), 2, new TimeSpan(0, 9, 30, 0, 0), 37 },
                    { 3730, new TimeSpan(0, 18, 30, 0, 0), 3, new TimeSpan(0, 9, 30, 0, 0), 37 },
                    { 3750, new TimeSpan(0, 16, 30, 0, 0), 5, new TimeSpan(0, 10, 30, 0, 0), 37 },
                    { 3760, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 37 },
                    { 3810, new TimeSpan(0, 17, 30, 0, 0), 1, new TimeSpan(0, 10, 30, 0, 0), 38 },
                    { 3820, new TimeSpan(0, 17, 30, 0, 0), 2, new TimeSpan(0, 10, 30, 0, 0), 38 },
                    { 3830, new TimeSpan(0, 17, 30, 0, 0), 3, new TimeSpan(0, 10, 30, 0, 0), 38 },
                    { 3840, new TimeSpan(0, 17, 30, 0, 0), 4, new TimeSpan(0, 10, 30, 0, 0), 38 },
                    { 3860, new TimeSpan(0, 15, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 38 },
                    { 3870, new TimeSpan(0, 14, 0, 0, 0), 7, new TimeSpan(0, 9, 0, 0, 0), 38 },
                    { 3900, new TimeSpan(0, 16, 0, 0, 0), 0, new TimeSpan(0, 8, 0, 0, 0), 39 },
                    { 3910, new TimeSpan(0, 16, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 39 },
                    { 3930, new TimeSpan(0, 16, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 39 },
                    { 3940, new TimeSpan(0, 14, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 39 },
                    { 3950, new TimeSpan(0, 15, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 39 },
                    { 3960, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 12, 0, 0, 0), 39 },
                    { 4000, new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0), 40 },
                    { 4010, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 40 },
                    { 4020, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 40 },
                    { 4040, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 40 },
                    { 4050, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 40 },
                    { 4060, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 40 },
                    { 4110, new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 41 },
                    { 4120, new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 41 },
                    { 4130, new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 41 },
                    { 4150, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 41 },
                    { 4160, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 12, 0, 0, 0), 41 },
                    { 4200, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0), 42 },
                    { 4210, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 42 },
                    { 4230, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 42 },
                    { 4240, new TimeSpan(0, 16, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 42 },
                    { 4250, new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 11, 0, 0, 0), 42 },
                    { 4260, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 12, 0, 0, 0), 42 },
                    { 4300, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 43 },
                    { 4310, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 43 },
                    { 4330, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 43 },
                    { 4340, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 11, 0, 0, 0), 43 },
                    { 4350, new TimeSpan(0, 15, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0), 43 },
                    { 4360, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 12, 0, 0, 0), 43 },
                    { 4410, new TimeSpan(0, 20, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 44 },
                    { 4420, new TimeSpan(0, 20, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 44 },
                    { 4430, new TimeSpan(0, 20, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 44 },
                    { 4440, new TimeSpan(0, 20, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 44 },
                    { 4450, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 44 },
                    { 4460, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 44 },
                    { 4500, new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 8, 0, 0, 0), 45 },
                    { 4510, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 45 },
                    { 4530, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 45 },
                    { 4540, new TimeSpan(0, 15, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 45 },
                    { 4550, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 45 },
                    { 4560, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 12, 0, 0, 0), 45 },
                    { 4600, new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0), 46 },
                    { 4610, new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 46 },
                    { 4630, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 46 },
                    { 4640, new TimeSpan(0, 16, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 46 },
                    { 4650, new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 11, 0, 0, 0), 46 },
                    { 4660, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 12, 0, 0, 0), 46 },
                    { 4710, new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 47 },
                    { 4720, new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 47 },
                    { 4730, new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 47 },
                    { 4750, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 47 },
                    { 4760, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 47 },
                    { 4800, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0), 48 },
                    { 4810, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 48 },
                    { 4830, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 48 },
                    { 4840, new TimeSpan(0, 16, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0), 48 },
                    { 4850, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 12, 0, 0, 0), 48 },
                    { 4860, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 48 },
                    { 4900, new TimeSpan(0, 18, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 49 },
                    { 4910, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0), 49 },
                    { 4930, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 49 },
                    { 4940, new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 11, 0, 0, 0), 49 },
                    { 4950, new TimeSpan(0, 15, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0), 49 },
                    { 4960, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 12, 0, 0, 0), 49 },
                    { 5010, new TimeSpan(0, 20, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 50 },
                    { 5020, new TimeSpan(0, 20, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 50 },
                    { 5030, new TimeSpan(0, 20, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0), 50 },
                    { 5040, new TimeSpan(0, 20, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 50 },
                    { 5050, new TimeSpan(0, 16, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 50 },
                    { 5060, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2160);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2161);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2210);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2230);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2240);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2260);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2310);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2320);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2330);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2340);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2360);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2410);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2420);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2430);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2440);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2450);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2500);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2510);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2520);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2540);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2550);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2610);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2620);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2630);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2640);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2660);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2700);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2710);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2730);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2740);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2750);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2760);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2800);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2810);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2820);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2830);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2840);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2860);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2861);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2910);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2920);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2930);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 2950);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3010);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3030);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3040);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3050);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3060);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3110);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3120);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3130);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3140);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3160);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3210);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3220);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3230);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3240);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3250);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3260);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3300);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3301);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3320);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3321);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3330);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3350);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3360);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3400);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3410);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3430);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3440);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3450);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3451);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3460);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3510);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3520);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3530);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3540);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3560);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3600);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3610);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3630);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3640);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3650);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3660);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3700);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3710);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3720);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3730);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3750);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3760);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3810);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3820);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3830);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3840);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3860);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3870);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3900);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3910);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3930);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3940);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3950);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 3960);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4010);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4020);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4040);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4050);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4060);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4110);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4120);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4130);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4150);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4160);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4200);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4210);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4230);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4240);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4250);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4260);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4300);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4310);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4330);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4340);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4350);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4360);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4410);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4420);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4430);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4440);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4450);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4460);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4500);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4510);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4530);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4540);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4550);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4560);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4600);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4610);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4630);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4640);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4650);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4660);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4710);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4720);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4730);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4750);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4760);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4800);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4810);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4830);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4840);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4850);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4860);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4900);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4910);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4930);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4940);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4950);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 4960);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 5010);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 5020);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 5030);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 5040);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 5050);

            migrationBuilder.DeleteData(
                table: "RestaurantOpeningTimes",
                keyColumn: "Id",
                keyValue: 5060);
        }
    }
}
