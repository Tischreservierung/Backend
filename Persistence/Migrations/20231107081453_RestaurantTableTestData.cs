using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantTableTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RestaurantTables",
                columns: new[] { "Id", "RestaurantId", "SeatPlaces" },
                values: new object[,]
                {
                    { 100, 1, 6 },
                    { 101, 1, 8 },
                    { 102, 1, 4 },
                    { 103, 1, 10 },
                    { 104, 1, 12 },
                    { 105, 1, 14 },
                    { 106, 1, 16 },
                    { 107, 1, 6 },
                    { 108, 1, 6 },
                    { 109, 1, 2 },
                    { 110, 1, 6 },
                    { 111, 1, 8 },
                    { 112, 1, 4 },
                    { 113, 1, 12 },
                    { 200, 2, 4 },
                    { 201, 2, 6 },
                    { 202, 2, 10 },
                    { 203, 2, 12 },
                    { 204, 2, 14 },
                    { 205, 2, 16 },
                    { 206, 2, 6 },
                    { 207, 2, 6 },
                    { 208, 2, 2 },
                    { 209, 2, 6 },
                    { 210, 2, 8 },
                    { 211, 2, 4 },
                    { 212, 2, 12 },
                    { 300, 3, 2 },
                    { 301, 3, 4 },
                    { 302, 3, 6 },
                    { 303, 3, 8 },
                    { 304, 3, 10 },
                    { 305, 3, 12 },
                    { 306, 3, 14 },
                    { 307, 3, 16 },
                    { 308, 3, 6 },
                    { 309, 3, 6 },
                    { 310, 3, 2 },
                    { 311, 3, 6 },
                    { 312, 3, 8 },
                    { 313, 3, 4 },
                    { 314, 3, 12 },
                    { 400, 4, 8 },
                    { 401, 4, 10 },
                    { 402, 4, 12 },
                    { 403, 4, 14 },
                    { 404, 4, 16 },
                    { 405, 4, 6 },
                    { 406, 4, 6 },
                    { 407, 4, 2 },
                    { 408, 4, 6 },
                    { 409, 4, 8 },
                    { 410, 4, 4 },
                    { 411, 4, 12 },
                    { 500, 5, 10 },
                    { 501, 5, 12 },
                    { 502, 5, 14 },
                    { 503, 5, 16 },
                    { 504, 5, 6 },
                    { 505, 5, 6 },
                    { 506, 5, 2 },
                    { 507, 5, 6 },
                    { 508, 5, 8 },
                    { 509, 5, 4 },
                    { 510, 5, 12 },
                    { 600, 6, 6 },
                    { 601, 6, 8 },
                    { 602, 6, 4 },
                    { 603, 6, 10 },
                    { 604, 6, 12 },
                    { 605, 6, 14 },
                    { 606, 6, 16 },
                    { 607, 6, 6 },
                    { 608, 6, 6 },
                    { 609, 6, 2 },
                    { 610, 6, 6 },
                    { 611, 6, 8 },
                    { 612, 6, 4 },
                    { 613, 6, 12 },
                    { 700, 7, 4 },
                    { 701, 7, 6 },
                    { 702, 7, 10 },
                    { 703, 7, 12 },
                    { 704, 7, 14 },
                    { 705, 7, 16 },
                    { 706, 7, 6 },
                    { 707, 7, 6 },
                    { 708, 7, 2 },
                    { 709, 7, 6 },
                    { 710, 7, 8 },
                    { 711, 7, 4 },
                    { 712, 7, 12 },
                    { 800, 8, 2 },
                    { 801, 8, 4 },
                    { 802, 8, 6 },
                    { 803, 8, 8 },
                    { 804, 8, 10 },
                    { 805, 8, 12 },
                    { 806, 8, 14 },
                    { 807, 8, 16 },
                    { 808, 8, 6 },
                    { 809, 8, 6 },
                    { 810, 8, 2 },
                    { 811, 8, 6 },
                    { 812, 8, 8 },
                    { 813, 8, 4 },
                    { 814, 8, 12 },
                    { 900, 9, 8 },
                    { 901, 9, 10 },
                    { 902, 9, 12 },
                    { 903, 9, 14 },
                    { 904, 9, 16 },
                    { 905, 9, 6 },
                    { 906, 9, 6 },
                    { 907, 9, 2 },
                    { 908, 9, 6 },
                    { 909, 9, 8 },
                    { 910, 9, 4 },
                    { 911, 9, 12 },
                    { 1000, 10, 10 },
                    { 1001, 10, 12 },
                    { 1002, 10, 14 },
                    { 1003, 10, 16 },
                    { 1004, 10, 6 },
                    { 1005, 10, 6 },
                    { 1006, 10, 2 },
                    { 1007, 10, 6 },
                    { 1008, 10, 8 },
                    { 1009, 10, 4 },
                    { 1010, 10, 12 },
                    { 1100, 11, 7 },
                    { 1101, 11, 9 },
                    { 1102, 11, 5 },
                    { 1103, 11, 5 },
                    { 1104, 11, 6 },
                    { 1105, 11, 2 },
                    { 1106, 11, 4 },
                    { 1107, 11, 16 },
                    { 1108, 11, 4 },
                    { 1109, 11, 6 },
                    { 1110, 11, 6 },
                    { 1111, 11, 6 },
                    { 1112, 11, 8 },
                    { 1200, 12, 5 },
                    { 1201, 12, 7 },
                    { 1202, 12, 5 },
                    { 1203, 12, 6 },
                    { 1204, 12, 2 },
                    { 1205, 12, 4 },
                    { 1206, 12, 16 },
                    { 1207, 12, 4 },
                    { 1208, 12, 6 },
                    { 1209, 12, 6 },
                    { 1210, 12, 6 },
                    { 1211, 12, 8 },
                    { 1300, 13, 3 },
                    { 1301, 13, 5 },
                    { 1302, 13, 7 },
                    { 1303, 13, 9 },
                    { 1304, 13, 5 },
                    { 1305, 13, 6 },
                    { 1306, 13, 2 },
                    { 1307, 13, 4 },
                    { 1308, 13, 16 },
                    { 1309, 13, 4 },
                    { 1310, 13, 6 },
                    { 1311, 13, 6 },
                    { 1312, 13, 6 },
                    { 1313, 13, 8 },
                    { 1400, 14, 9 },
                    { 1401, 14, 5 },
                    { 1402, 14, 6 },
                    { 1403, 14, 2 },
                    { 1404, 14, 4 },
                    { 1405, 14, 16 },
                    { 1406, 14, 4 },
                    { 1407, 14, 6 },
                    { 1408, 14, 6 },
                    { 1409, 14, 6 },
                    { 1410, 14, 8 },
                    { 1500, 15, 5 },
                    { 1501, 15, 6 },
                    { 1502, 15, 2 },
                    { 1503, 15, 4 },
                    { 1504, 15, 16 },
                    { 1505, 15, 4 },
                    { 1506, 15, 6 },
                    { 1507, 15, 6 },
                    { 1508, 15, 6 },
                    { 1509, 15, 8 },
                    { 1600, 16, 7 },
                    { 1601, 16, 9 },
                    { 1602, 16, 5 },
                    { 1603, 16, 5 },
                    { 1604, 16, 6 },
                    { 1605, 16, 2 },
                    { 1606, 16, 4 },
                    { 1607, 16, 16 },
                    { 1608, 16, 4 },
                    { 1609, 16, 6 },
                    { 1610, 16, 6 },
                    { 1611, 16, 6 },
                    { 1612, 16, 8 },
                    { 1700, 17, 5 },
                    { 1701, 17, 7 },
                    { 1702, 17, 5 },
                    { 1703, 17, 6 },
                    { 1704, 17, 2 },
                    { 1705, 17, 4 },
                    { 1706, 17, 16 },
                    { 1707, 17, 4 },
                    { 1708, 17, 6 },
                    { 1709, 17, 6 },
                    { 1710, 17, 6 },
                    { 1711, 17, 8 },
                    { 1800, 18, 3 },
                    { 1801, 18, 5 },
                    { 1802, 18, 7 },
                    { 1803, 18, 9 },
                    { 1804, 18, 5 },
                    { 1805, 18, 6 },
                    { 1806, 18, 2 },
                    { 1807, 18, 4 },
                    { 1808, 18, 16 },
                    { 1809, 18, 4 },
                    { 1810, 18, 6 },
                    { 1811, 18, 6 },
                    { 1812, 18, 6 },
                    { 1813, 18, 8 },
                    { 1900, 19, 9 },
                    { 1901, 19, 5 },
                    { 1902, 19, 6 },
                    { 1903, 19, 2 },
                    { 1904, 19, 4 },
                    { 1905, 19, 16 },
                    { 1906, 19, 4 },
                    { 1907, 19, 6 },
                    { 1908, 19, 6 },
                    { 1909, 19, 6 },
                    { 1910, 19, 8 },
                    { 2000, 20, 5 },
                    { 2001, 20, 6 },
                    { 2002, 20, 2 },
                    { 2003, 20, 4 },
                    { 2004, 20, 16 },
                    { 2005, 20, 4 },
                    { 2006, 20, 6 },
                    { 2007, 20, 6 },
                    { 2008, 20, 6 },
                    { 2009, 20, 8 },
                    { 2100, 21, 6 },
                    { 2101, 21, 8 },
                    { 2102, 21, 4 },
                    { 2103, 21, 10 },
                    { 2104, 21, 12 },
                    { 2105, 21, 14 },
                    { 2106, 21, 16 },
                    { 2107, 21, 6 },
                    { 2108, 21, 6 },
                    { 2109, 21, 2 },
                    { 2110, 21, 6 },
                    { 2111, 21, 8 },
                    { 2112, 21, 4 },
                    { 2113, 21, 12 },
                    { 2200, 22, 4 },
                    { 2201, 22, 6 },
                    { 2202, 22, 10 },
                    { 2203, 22, 12 },
                    { 2204, 22, 14 },
                    { 2205, 22, 16 },
                    { 2206, 22, 6 },
                    { 2207, 22, 6 },
                    { 2208, 22, 2 },
                    { 2209, 22, 6 },
                    { 2210, 22, 8 },
                    { 2211, 22, 4 },
                    { 2212, 22, 12 },
                    { 2300, 23, 2 },
                    { 2301, 23, 4 },
                    { 2302, 23, 6 },
                    { 2303, 23, 8 },
                    { 2304, 23, 10 },
                    { 2305, 23, 12 },
                    { 2306, 23, 14 },
                    { 2307, 23, 16 },
                    { 2308, 23, 6 },
                    { 2309, 23, 6 },
                    { 2310, 23, 2 },
                    { 2311, 23, 6 },
                    { 2312, 23, 8 },
                    { 2313, 23, 4 },
                    { 2314, 23, 12 },
                    { 2400, 24, 8 },
                    { 2401, 24, 10 },
                    { 2402, 24, 12 },
                    { 2403, 24, 14 },
                    { 2404, 24, 16 },
                    { 2405, 24, 6 },
                    { 2406, 24, 6 },
                    { 2407, 24, 2 },
                    { 2408, 24, 6 },
                    { 2409, 24, 8 },
                    { 2410, 24, 4 },
                    { 2411, 24, 12 },
                    { 2500, 25, 10 },
                    { 2501, 25, 12 },
                    { 2502, 25, 14 },
                    { 2503, 25, 16 },
                    { 2504, 25, 6 },
                    { 2505, 25, 6 },
                    { 2506, 25, 2 },
                    { 2507, 25, 6 },
                    { 2508, 25, 8 },
                    { 2509, 25, 4 },
                    { 2510, 25, 12 },
                    { 2600, 26, 6 },
                    { 2601, 26, 8 },
                    { 2602, 26, 4 },
                    { 2603, 26, 10 },
                    { 2604, 26, 12 },
                    { 2605, 26, 14 },
                    { 2606, 26, 16 },
                    { 2607, 26, 6 },
                    { 2608, 26, 6 },
                    { 2609, 26, 2 },
                    { 2610, 26, 6 },
                    { 2611, 26, 8 },
                    { 2612, 26, 4 },
                    { 2613, 26, 12 },
                    { 2700, 27, 4 },
                    { 2701, 27, 6 },
                    { 2702, 27, 10 },
                    { 2703, 27, 12 },
                    { 2704, 27, 14 },
                    { 2705, 27, 16 },
                    { 2706, 27, 6 },
                    { 2707, 27, 6 },
                    { 2708, 27, 2 },
                    { 2709, 27, 6 },
                    { 2710, 27, 8 },
                    { 2711, 27, 4 },
                    { 2712, 27, 12 },
                    { 2800, 28, 2 },
                    { 2801, 28, 4 },
                    { 2802, 28, 6 },
                    { 2803, 28, 8 },
                    { 2804, 28, 10 },
                    { 2805, 28, 12 },
                    { 2806, 28, 14 },
                    { 2807, 28, 16 },
                    { 2808, 28, 6 },
                    { 2809, 28, 6 },
                    { 2810, 28, 2 },
                    { 2811, 28, 6 },
                    { 2812, 28, 8 },
                    { 2813, 28, 4 },
                    { 2814, 28, 12 },
                    { 2900, 29, 8 },
                    { 2901, 29, 10 },
                    { 2902, 29, 12 },
                    { 2903, 29, 14 },
                    { 2904, 29, 16 },
                    { 2905, 29, 6 },
                    { 2906, 29, 6 },
                    { 2907, 29, 2 },
                    { 2908, 29, 6 },
                    { 2909, 29, 8 },
                    { 2910, 29, 4 },
                    { 2911, 29, 12 },
                    { 3000, 30, 10 },
                    { 3001, 30, 12 },
                    { 3002, 30, 14 },
                    { 3003, 30, 16 },
                    { 3004, 30, 6 },
                    { 3005, 30, 6 },
                    { 3006, 30, 2 },
                    { 3007, 30, 6 },
                    { 3008, 30, 8 },
                    { 3009, 30, 4 },
                    { 3010, 30, 12 },
                    { 3100, 31, 7 },
                    { 3101, 31, 9 },
                    { 3102, 31, 5 },
                    { 3103, 31, 5 },
                    { 3104, 31, 6 },
                    { 3105, 31, 2 },
                    { 3106, 31, 4 },
                    { 3107, 31, 16 },
                    { 3108, 31, 4 },
                    { 3109, 31, 6 },
                    { 3110, 31, 6 },
                    { 3111, 31, 6 },
                    { 3112, 31, 8 },
                    { 3200, 32, 5 },
                    { 3201, 32, 7 },
                    { 3202, 32, 5 },
                    { 3203, 32, 6 },
                    { 3204, 32, 2 },
                    { 3205, 32, 4 },
                    { 3206, 32, 16 },
                    { 3207, 32, 4 },
                    { 3208, 32, 6 },
                    { 3209, 32, 6 },
                    { 3210, 32, 6 },
                    { 3211, 32, 8 },
                    { 3300, 33, 3 },
                    { 3301, 33, 5 },
                    { 3302, 33, 7 },
                    { 3303, 33, 9 },
                    { 3304, 33, 5 },
                    { 3305, 33, 6 },
                    { 3306, 33, 2 },
                    { 3307, 33, 4 },
                    { 3308, 33, 16 },
                    { 3309, 33, 4 },
                    { 3310, 33, 6 },
                    { 3311, 33, 6 },
                    { 3312, 33, 6 },
                    { 3313, 33, 8 },
                    { 3400, 34, 9 },
                    { 3401, 34, 5 },
                    { 3402, 34, 6 },
                    { 3403, 34, 2 },
                    { 3404, 34, 4 },
                    { 3405, 34, 16 },
                    { 3406, 34, 4 },
                    { 3407, 34, 6 },
                    { 3408, 34, 6 },
                    { 3409, 34, 6 },
                    { 3410, 34, 8 },
                    { 3500, 35, 5 },
                    { 3501, 35, 6 },
                    { 3502, 35, 2 },
                    { 3503, 35, 4 },
                    { 3504, 35, 16 },
                    { 3505, 35, 4 },
                    { 3506, 35, 6 },
                    { 3507, 35, 6 },
                    { 3508, 35, 6 },
                    { 3509, 35, 8 },
                    { 3600, 36, 7 },
                    { 3601, 36, 9 },
                    { 3602, 36, 5 },
                    { 3603, 36, 5 },
                    { 3604, 36, 6 },
                    { 3605, 36, 2 },
                    { 3606, 36, 4 },
                    { 3607, 36, 16 },
                    { 3608, 36, 4 },
                    { 3609, 36, 6 },
                    { 3610, 36, 6 },
                    { 3611, 36, 6 },
                    { 3612, 36, 8 },
                    { 3700, 37, 5 },
                    { 3701, 37, 7 },
                    { 3702, 37, 5 },
                    { 3703, 37, 6 },
                    { 3704, 37, 2 },
                    { 3705, 37, 4 },
                    { 3706, 37, 16 },
                    { 3707, 37, 4 },
                    { 3708, 37, 6 },
                    { 3709, 37, 6 },
                    { 3710, 37, 6 },
                    { 3711, 37, 8 },
                    { 3800, 38, 3 },
                    { 3801, 38, 5 },
                    { 3802, 38, 7 },
                    { 3803, 38, 9 },
                    { 3804, 38, 5 },
                    { 3805, 38, 6 },
                    { 3806, 38, 2 },
                    { 3807, 38, 4 },
                    { 3808, 38, 16 },
                    { 3809, 38, 4 },
                    { 3810, 38, 6 },
                    { 3811, 38, 6 },
                    { 3812, 38, 6 },
                    { 3813, 38, 8 },
                    { 3900, 39, 9 },
                    { 3901, 39, 5 },
                    { 3902, 39, 6 },
                    { 3903, 39, 2 },
                    { 3904, 39, 4 },
                    { 3905, 39, 16 },
                    { 3906, 39, 4 },
                    { 3907, 39, 6 },
                    { 3908, 39, 6 },
                    { 3909, 39, 6 },
                    { 3910, 39, 8 },
                    { 4000, 40, 5 },
                    { 4001, 40, 6 },
                    { 4002, 40, 2 },
                    { 4003, 40, 4 },
                    { 4004, 40, 16 },
                    { 4005, 40, 4 },
                    { 4006, 40, 6 },
                    { 4007, 40, 6 },
                    { 4008, 40, 6 },
                    { 4009, 40, 8 },
                    { 4100, 41, 4 },
                    { 4101, 41, 6 },
                    { 4102, 41, 8 },
                    { 4103, 41, 10 },
                    { 4104, 41, 12 },
                    { 4105, 41, 14 },
                    { 4106, 41, 16 },
                    { 4107, 41, 6 },
                    { 4108, 41, 6 },
                    { 4109, 41, 2 },
                    { 4110, 41, 6 },
                    { 4111, 41, 8 },
                    { 4112, 41, 4 },
                    { 4113, 41, 12 },
                    { 4200, 42, 6 },
                    { 4201, 42, 8 },
                    { 4202, 42, 4 },
                    { 4203, 42, 10 },
                    { 4204, 42, 12 },
                    { 4205, 42, 14 },
                    { 4206, 42, 16 },
                    { 4207, 42, 6 },
                    { 4208, 42, 6 },
                    { 4209, 42, 2 },
                    { 4210, 42, 6 },
                    { 4211, 42, 8 },
                    { 4212, 42, 4 },
                    { 4213, 42, 12 },
                    { 4300, 43, 2 },
                    { 4301, 43, 4 },
                    { 4302, 43, 6 },
                    { 4303, 43, 8 },
                    { 4304, 43, 10 },
                    { 4305, 43, 12 },
                    { 4306, 43, 14 },
                    { 4307, 43, 16 },
                    { 4308, 43, 6 },
                    { 4309, 43, 6 },
                    { 4310, 43, 2 },
                    { 4311, 43, 6 },
                    { 4312, 43, 8 },
                    { 4313, 43, 4 },
                    { 4314, 43, 12 },
                    { 4400, 44, 10 },
                    { 4401, 44, 12 },
                    { 4402, 44, 14 },
                    { 4403, 44, 16 },
                    { 4404, 44, 6 },
                    { 4405, 44, 6 },
                    { 4406, 44, 2 },
                    { 4407, 44, 6 },
                    { 4408, 44, 8 },
                    { 4409, 44, 4 },
                    { 4410, 44, 12 },
                    { 4500, 45, 3 },
                    { 4501, 45, 5 },
                    { 4502, 45, 7 },
                    { 4503, 45, 9 },
                    { 4504, 45, 5 },
                    { 4505, 45, 6 },
                    { 4506, 45, 2 },
                    { 4507, 45, 4 },
                    { 4508, 45, 16 },
                    { 4509, 45, 4 },
                    { 4510, 45, 6 },
                    { 4511, 45, 6 },
                    { 4512, 45, 6 },
                    { 4513, 45, 8 },
                    { 4600, 46, 8 },
                    { 4601, 46, 10 },
                    { 4602, 46, 12 },
                    { 4603, 46, 14 },
                    { 4604, 46, 16 },
                    { 4605, 46, 6 },
                    { 4606, 46, 6 },
                    { 4607, 46, 2 },
                    { 4608, 46, 6 },
                    { 4609, 46, 8 },
                    { 4610, 46, 4 },
                    { 4611, 46, 12 },
                    { 4700, 47, 7 },
                    { 4701, 47, 9 },
                    { 4702, 47, 5 },
                    { 4703, 47, 6 },
                    { 4704, 47, 2 },
                    { 4705, 47, 4 },
                    { 4706, 47, 16 },
                    { 4707, 47, 4 },
                    { 4708, 47, 6 },
                    { 4709, 47, 6 },
                    { 4710, 47, 6 },
                    { 4711, 47, 8 },
                    { 4800, 48, 9 },
                    { 4801, 48, 5 },
                    { 4802, 48, 6 },
                    { 4803, 48, 2 },
                    { 4804, 48, 4 },
                    { 4805, 48, 16 },
                    { 4806, 48, 4 },
                    { 4807, 48, 6 },
                    { 4808, 48, 6 },
                    { 4809, 48, 6 },
                    { 4810, 48, 8 },
                    { 4900, 49, 5 },
                    { 4901, 49, 6 },
                    { 4902, 49, 2 },
                    { 4903, 49, 4 },
                    { 4904, 49, 16 },
                    { 4905, 49, 4 },
                    { 4906, 49, 6 },
                    { 4907, 49, 6 },
                    { 4908, 49, 6 },
                    { 4909, 49, 8 },
                    { 5000, 50, 4 },
                    { 5001, 50, 6 },
                    { 5002, 50, 8 },
                    { 5003, 50, 10 },
                    { 5004, 50, 12 },
                    { 5005, 50, 14 },
                    { 5006, 50, 16 },
                    { 5007, 50, 6 },
                    { 5008, 50, 6 },
                    { 5009, 50, 2 },
                    { 5010, 50, 6 },
                    { 5011, 50, 8 },
                    { 5012, 50, 4 },
                    { 5013, 50, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2201);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2202);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2203);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2204);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2205);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2206);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2207);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2208);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2209);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2210);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2212);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2301);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2302);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2303);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2304);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2305);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2306);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2307);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2308);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2309);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2310);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2311);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2312);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2313);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2314);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2400);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2401);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2402);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2403);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2404);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2405);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2406);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2407);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2408);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2409);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2410);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2411);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2500);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2501);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2502);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2503);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2504);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2505);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2506);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2507);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2508);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2509);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2510);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2600);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2601);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2602);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2603);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2604);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2605);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2606);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2607);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2608);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2609);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2610);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2611);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2612);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2613);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2700);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2701);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2702);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2703);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2704);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2705);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2706);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2707);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2708);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2709);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2710);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2711);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2712);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2800);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2801);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2802);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2803);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2804);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2805);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2806);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2807);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2808);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2809);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2810);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2811);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2812);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2813);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2814);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2900);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2901);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2902);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2903);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2904);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2905);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2906);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2907);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2908);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2909);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2910);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 2911);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3001);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3002);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3003);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3004);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3005);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3006);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3007);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3008);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3009);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3010);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3100);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3101);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3102);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3103);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3104);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3105);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3106);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3107);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3108);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3109);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3110);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3111);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3112);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3200);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3201);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3202);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3203);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3204);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3205);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3206);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3207);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3208);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3209);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3210);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3211);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3300);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3301);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3302);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3303);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3304);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3305);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3306);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3307);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3308);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3309);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3310);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3311);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3312);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3313);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3400);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3401);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3402);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3403);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3404);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3405);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3406);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3407);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3408);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3409);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3410);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3500);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3501);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3502);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3503);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3504);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3505);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3506);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3507);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3508);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3509);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3600);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3601);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3602);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3603);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3604);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3605);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3606);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3607);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3608);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3609);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3610);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3611);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3612);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3700);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3701);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3702);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3703);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3704);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3705);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3706);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3707);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3708);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3709);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3710);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3711);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3800);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3801);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3802);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3803);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3804);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3805);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3806);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3807);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3808);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3809);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3810);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3811);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3812);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3813);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3900);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3901);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3902);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3903);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3904);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3905);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3906);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3907);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3908);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3909);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 3910);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4001);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4002);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4003);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4004);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4005);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4006);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4007);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4008);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4009);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4100);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4101);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4102);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4103);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4104);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4105);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4106);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4107);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4108);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4109);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4110);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4111);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4112);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4113);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4200);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4201);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4202);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4203);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4204);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4205);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4206);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4207);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4208);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4209);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4210);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4211);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4212);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4213);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4300);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4301);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4302);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4303);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4304);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4305);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4306);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4307);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4308);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4309);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4310);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4311);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4312);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4313);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4314);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4400);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4401);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4402);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4403);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4404);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4405);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4406);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4407);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4408);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4409);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4410);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4500);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4501);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4502);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4503);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4504);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4505);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4506);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4507);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4508);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4509);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4510);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4511);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4512);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4513);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4600);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4601);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4602);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4603);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4604);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4605);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4606);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4607);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4608);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4609);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4610);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4611);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4700);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4701);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4702);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4703);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4704);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4705);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4706);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4707);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4708);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4709);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4710);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4711);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4800);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4801);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4802);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4803);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4804);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4805);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4806);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4807);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4808);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4809);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4810);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4900);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4901);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4902);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4903);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4904);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4905);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4906);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4907);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4908);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 4909);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5000);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5001);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5002);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5003);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5004);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5005);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5006);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5007);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5008);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5009);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5010);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5011);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5012);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "Id",
                keyValue: 5013);
        }
    }
}
