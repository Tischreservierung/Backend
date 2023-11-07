using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zipcodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZipCodeNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zipcodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCodeId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_Zipcodes_ZipCodeId",
                        column: x => x.ZipCodeId,
                        principalTable: "Zipcodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryRestaurant",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    RestaurantsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryRestaurant", x => new { x.CategoriesId, x.RestaurantsId });
                    table.ForeignKey(
                        name: "FK_CategoryRestaurant_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryRestaurant_Restaurants_RestaurantsId",
                        column: x => x.RestaurantsId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantCategories_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantOpeningTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false),
                    OpeningTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ClosingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantOpeningTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantOpeningTimes_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatPlaces = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantTables_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RestaurantTableId = table.Column<int>(type: "int", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Persons_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_RestaurantTables_RestaurantTableId",
                        column: x => x.RestaurantTableId,
                        principalTable: "RestaurantTables",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Italienisch" },
                    { 2, "Französisch" },
                    { 3, "Mexikanisch" },
                    { 4, "Japanisch" },
                    { 5, "Chinesisch" },
                    { 6, "Indisch" },
                    { 7, "Griechisch" },
                    { 8, "Thailändisch" },
                    { 9, "Spanisch" },
                    { 10, "Deutsch" },
                    { 11, "Amerikanisch" },
                    { 12, "Brasilianisch" },
                    { 13, "Türkisch" },
                    { 14, "Koreanisch" },
                    { 15, "Vietnamesisch" },
                    { 16, "Libanesisch" },
                    { 17, "Argentinisch" },
                    { 18, "Vegetarisch/Vegan" },
                    { 19, "Meeresfrüchte" },
                    { 20, "Steakhouse" },
                    { 21, "Pizzeria" },
                    { 22, "Fast Food" },
                    { 23, "Café" },
                    { 24, "Bäckerei" },
                    { 25, "Pub/Gastropub" },
                    { 26, "Barbecue/Grill" },
                    { 27, "Sushi" },
                    { 28, "Tapas" },
                    { 29, "Fine Dining" },
                    { 30, "Street Food" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 1, "Linz-Land", "Leonding", "4020" },
                    { 2, "Linz", "Linz", "4020" },
                    { 3, "Linz", "Linz", "4030" },
                    { 4, "Urfahr-Umgebung", "Altenberg bei Linz", "4040" },
                    { 5, "Urfahr-Umgebung", "Gramastetten", "4040" },
                    { 6, "Urfahr-Umgebung", "Kirchschlag bei Linz", "4040" },
                    { 7, "Urfahr-Umgebung", "Lichtenberg", "4040" },
                    { 8, "Linz", "Linz", "4040" },
                    { 9, "Urfahr-Umgebung", "Steyregg", "4040" },
                    { 10, "Urfahr-Umgebung", "Puchenau", "4048" },
                    { 11, "Linz-Land", "Traun", "4050" },
                    { 12, "Linz-Land", "Ansfelden", "4052" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 13, "Linz", "Linz", "4052" },
                    { 14, "Linz-Land", "Ansfelden", "4053" },
                    { 15, "Linz-Land", "Neuhofen an der Krems", "4053" },
                    { 16, "Linz-Land", "Pucking", "4055" },
                    { 17, "Linz-Land", "Leonding", "4060" },
                    { 18, "Linz-Land", "Leonding", "4061" },
                    { 19, "Linz-Land", "Pasching", "4061" },
                    { 20, "Linz-Land", "Wilhering", "4061" },
                    { 21, "Linz-Land", "Kirchberg-Thening", "4062" },
                    { 22, "Linz-Land", "Hörsching", "4063" },
                    { 23, "Linz-Land", "Traun", "4063" },
                    { 24, "Linz-Land", "Oftering", "4064" },
                    { 25, "Eferding", "Eferding", "4070" },
                    { 26, "Eferding", "Fraham", "4070" },
                    { 27, "Eferding", "Hartkirchen", "4070" },
                    { 28, "Eferding", "Hinzenbach", "4070" },
                    { 29, "Eferding", "Prambachkirchen", "4070" },
                    { 30, "Eferding", "Pupping", "4070" },
                    { 31, "Eferding", "Stroheim", "4070" },
                    { 32, "Eferding", "Alkoven", "4072" },
                    { 33, "Linz-Land", "Wilhering", "4073" },
                    { 34, "Eferding", "Hartkirchen", "4074" },
                    { 35, "Eferding", "Prambachkirchen", "4074" },
                    { 36, "Eferding", "Stroheim", "4074" },
                    { 37, "Eferding", "Fraham", "4075" },
                    { 38, "Eferding", "St. Marienkirchen an der Polsenz", "4076" },
                    { 39, "Eferding", "Hartkirchen", "4081" },
                    { 40, "Eferding", "Pupping", "4081" },
                    { 41, "Eferding", "Stroheim", "4081" },
                    { 42, "Eferding", "Aschach an der Donau", "4082" },
                    { 43, "Eferding", "Haibach ob der Donau", "4083" },
                    { 44, "Grieskirchen", "St. Agatha", "4083" },
                    { 45, "Grieskirchen", "Eschenau im Hausruckkreis", "4084" },
                    { 46, "Grieskirchen", "St. Agatha", "4084" },
                    { 47, "Grieskirchen", "Eschenau im Hausruckkreis", "4085" },
                    { 48, "Rohrbach", "Hofkirchen im Mühlkreis", "4085" },
                    { 49, "Rohrbach", "Neustift im Mühlkreis", "4085" },
                    { 50, "Rohrbach", "Pfarrkirchen im Mühlkreis", "4085" },
                    { 51, "Schärding", "Waldkirchen am Wesen", "4085" },
                    { 52, "Schärding", "Engelhartszell", "4090" },
                    { 53, "Schärding", "St. Roman", "4091" },
                    { 54, "Schärding", "Vichtenstein", "4091" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 55, "Schärding", "Esternberg", "4092" },
                    { 56, "Urfahr-Umgebung", "Gramastetten", "4100" },
                    { 57, "Urfahr-Umgebung", "Ottensheim", "4100" },
                    { 58, "Urfahr-Umgebung", "Feldkirchen an der Donau", "4101" },
                    { 59, "Urfahr-Umgebung", "Herzogsdorf", "4101" },
                    { 60, "Urfahr-Umgebung", "Goldwörth", "4102" },
                    { 61, "Urfahr-Umgebung", "Gramastetten", "4111" },
                    { 62, "Urfahr-Umgebung", "Walding", "4111" },
                    { 63, "Urfahr-Umgebung", "Gramastetten", "4112" },
                    { 64, "Urfahr-Umgebung", "St. Gotthard im Mühlkreis", "4112" },
                    { 65, "Urfahr-Umgebung", "Feldkirchen an der Donau", "4113" },
                    { 66, "Rohrbach", "Niederwaldkirchen", "4113" },
                    { 67, "Rohrbach", "St. Martin im Mühlkreis", "4113" },
                    { 68, "Rohrbach", "Kirchberg ob der Donau", "4114" },
                    { 69, "Rohrbach", "Kleinzell im Mühlkreis", "4114" },
                    { 70, "Rohrbach", "St. Martin im Mühlkreis", "4114" },
                    { 71, "Rohrbach", "Kirchberg ob der Donau", "4115" },
                    { 72, "Rohrbach", "Kleinzell im Mühlkreis", "4115" },
                    { 73, "Rohrbach", "St. Ulrich im Mühlkreis", "4116" },
                    { 74, "Rohrbach", "Altenfelden", "4120" },
                    { 75, "Rohrbach", "Kleinzell im Mühlkreis", "4120" },
                    { 76, "Rohrbach", "Neufelden", "4120" },
                    { 77, "Rohrbach", "Altenfelden", "4121" },
                    { 78, "Rohrbach", "Arnreit", "4121" },
                    { 79, "Rohrbach", "Hörbich", "4121" },
                    { 80, "Rohrbach", "Neufelden", "4121" },
                    { 81, "Rohrbach", "Arnreit", "4122" },
                    { 82, "Rohrbach", "Kirchberg ob der Donau", "4131" },
                    { 83, "Rohrbach", "Lembach im Mühlkreis", "4131" },
                    { 84, "Rohrbach", "Niederkappel", "4131" },
                    { 85, "Rohrbach", "Hörbich", "4132" },
                    { 86, "Rohrbach", "Lembach im Mühlkreis", "4132" },
                    { 87, "Rohrbach", "Niederkappel", "4132" },
                    { 88, "Rohrbach", "Putzleinsdorf", "4132" },
                    { 89, "Rohrbach", "Hofkirchen im Mühlkreis", "4133" },
                    { 90, "Rohrbach", "Niederkappel", "4133" },
                    { 91, "Rohrbach", "Putzleinsdorf", "4133" },
                    { 92, "Rohrbach", "Atzesberg", "4134" },
                    { 93, "Rohrbach", "Hörbich", "4134" },
                    { 94, "Rohrbach", "Putzleinsdorf", "4134" },
                    { 95, "Rohrbach", "Pfarrkirchen im Mühlkreis", "4141" },
                    { 96, "Rohrbach", "Putzleinsdorf", "4141" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 97, "Rohrbach", "Hofkirchen im Mühlkreis", "4142" },
                    { 98, "Rohrbach", "Pfarrkirchen im Mühlkreis", "4142" },
                    { 99, "Rohrbach", "Neustift im Mühlkreis", "4143" },
                    { 100, "Rohrbach", "Neustift im Mühlkreis", "4144" },
                    { 101, "Rohrbach", "Oberkappel", "4144" },
                    { 102, "Rohrbach", "Pfarrkirchen im Mühlkreis", "4144" },
                    { 103, "Rohrbach", "Rohrbach-Berg", "4150" },
                    { 104, "Rohrbach", "Sarleinsbach", "4150" },
                    { 105, "Rohrbach", "Oepping", "4151" },
                    { 106, "Rohrbach", "Atzesberg", "4152" },
                    { 107, "Rohrbach", "Hörbich", "4152" },
                    { 108, "Rohrbach", "Kollerschlag", "4152" },
                    { 109, "Rohrbach", "Oberkappel", "4152" },
                    { 110, "Rohrbach", "Sarleinsbach", "4152" },
                    { 111, "Rohrbach", "Julbach", "4153" },
                    { 112, "Rohrbach", "Peilstein im Mühlviertel", "4153" },
                    { 113, "Rohrbach", "Kollerschlag", "4154" },
                    { 114, "Rohrbach", "Oberkappel", "4154" },
                    { 115, "Rohrbach", "Julbach", "4155" },
                    { 116, "Rohrbach", "Nebelberg", "4155" },
                    { 117, "Rohrbach", "Aigen-Schlägl", "4160" },
                    { 118, "Rohrbach", "Ulrichsberg", "4160" },
                    { 119, "Rohrbach", "Aigen-Schlägl", "4161" },
                    { 120, "Rohrbach", "Schwarzenberg am Böhmerwald", "4161" },
                    { 121, "Rohrbach", "Ulrichsberg", "4161" },
                    { 122, "Rohrbach", "Julbach", "4162" },
                    { 123, "Rohrbach", "Peilstein im Mühlviertel", "4162" },
                    { 124, "Rohrbach", "Ulrichsberg", "4162" },
                    { 125, "Rohrbach", "Klaffer am Hochficht", "4163" },
                    { 126, "Rohrbach", "Ulrichsberg", "4163" },
                    { 127, "Rohrbach", "Schwarzenberg am Böhmerwald", "4164" },
                    { 128, "Rohrbach", "Auberg", "4170" },
                    { 129, "Rohrbach", "Haslach an der Mühl", "4170" },
                    { 130, "Rohrbach", "Lichtenau im Mühlkreis", "4170" },
                    { 131, "Rohrbach", "Rohrbach-Berg", "4170" },
                    { 132, "Rohrbach", "St. Oswald bei Haslach", "4170" },
                    { 133, "Rohrbach", "St. Peter am Wimberg", "4170" },
                    { 134, "Rohrbach", "St. Stefan-Afiesl", "4170" },
                    { 135, "Rohrbach", "Auberg", "4171" },
                    { 136, "Rohrbach", "St. Peter am Wimberg", "4171" },
                    { 137, "Rohrbach", "St. Stefan-Afiesl", "4171" },
                    { 138, "Rohrbach", "St. Johann am Wimberg", "4172" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 139, "Rohrbach", "St. Veit im Mühlkreis", "4173" },
                    { 140, "Rohrbach", "Niederwaldkirchen", "4174" },
                    { 141, "Rohrbach", "St. Veit im Mühlkreis", "4174" },
                    { 142, "Urfahr-Umgebung", "Herzogsdorf", "4175" },
                    { 143, "Rohrbach", "St. Veit im Mühlkreis", "4175" },
                    { 144, "Urfahr-Umgebung", "Reichenau im Mühlkreis", "4180" },
                    { 145, "Urfahr-Umgebung", "Sonnberg im Mühlkreis", "4180" },
                    { 146, "Urfahr-Umgebung", "Zwettl an der Rodl", "4180" },
                    { 147, "Urfahr-Umgebung", "Herzogsdorf", "4181" },
                    { 148, "Urfahr-Umgebung", "Oberneukirchen", "4181" },
                    { 149, "Urfahr-Umgebung", "Zwettl an der Rodl", "4181" },
                    { 150, "Rohrbach", "Helfenberg", "4182" },
                    { 151, "Urfahr-Umgebung", "Oberneukirchen", "4182" },
                    { 152, "Rohrbach", "Helfenberg", "4183" },
                    { 153, "Urfahr-Umgebung", "Oberneukirchen", "4183" },
                    { 154, "Urfahr-Umgebung", "Vorderweißenbach", "4183" },
                    { 155, "Rohrbach", "Helfenberg", "4184" },
                    { 156, "Rohrbach", "St. Johann am Wimberg", "4184" },
                    { 157, "Rohrbach", "St. Peter am Wimberg", "4184" },
                    { 158, "Rohrbach", "St. Stefan-Afiesl", "4184" },
                    { 159, "Urfahr-Umgebung", "Vorderweißenbach", "4184" },
                    { 160, "Urfahr-Umgebung", "Bad Leonfelden", "4190" },
                    { 161, "Urfahr-Umgebung", "Vorderweißenbach", "4190" },
                    { 162, "Urfahr-Umgebung", "Vorderweißenbach", "4191" },
                    { 163, "Freistadt", "Hirschbach im Mühlkreis", "4192" },
                    { 164, "Urfahr-Umgebung", "Schenkenfelden", "4192" },
                    { 165, "Freistadt", "Hirschbach im Mühlkreis", "4193" },
                    { 166, "Freistadt", "Rainbach im Mühlkreis", "4193" },
                    { 167, "Urfahr-Umgebung", "Reichenthal", "4193" },
                    { 168, "Freistadt", "Waldburg", "4193" },
                    { 169, "Urfahr-Umgebung", "Eidenberg", "4201" },
                    { 170, "Urfahr-Umgebung", "Gramastetten", "4201" },
                    { 171, "Urfahr-Umgebung", "Kirchschlag bei Linz", "4201" },
                    { 172, "Urfahr-Umgebung", "Lichtenberg", "4201" },
                    { 173, "Urfahr-Umgebung", "Zwettl an der Rodl", "4201" },
                    { 174, "Urfahr-Umgebung", "Alberndorf in der Riedmark", "4202" },
                    { 175, "Urfahr-Umgebung", "Altenberg bei Linz", "4202" },
                    { 176, "Urfahr-Umgebung", "Eidenberg", "4202" },
                    { 177, "Urfahr-Umgebung", "Hellmonsödt", "4202" },
                    { 178, "Urfahr-Umgebung", "Kirchschlag bei Linz", "4202" },
                    { 179, "Urfahr-Umgebung", "Sonnberg im Mühlkreis", "4202" },
                    { 180, "Urfahr-Umgebung", "Altenberg bei Linz", "4203" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 181, "Urfahr-Umgebung", "Haibach im Mühlkreis", "4204" },
                    { 182, "Urfahr-Umgebung", "Ottenschlag im Mühlkreis", "4204" },
                    { 183, "Urfahr-Umgebung", "Reichenau im Mühlkreis", "4204" },
                    { 184, "Urfahr-Umgebung", "Altenberg bei Linz", "4209" },
                    { 185, "Urfahr-Umgebung", "Engerwitzdorf", "4209" },
                    { 186, "Urfahr-Umgebung", "Altenberg bei Linz", "4210" },
                    { 187, "Urfahr-Umgebung", "Gallneukirchen", "4210" },
                    { 188, "Urfahr-Umgebung", "Alberndorf in der Riedmark", "4211" },
                    { 189, "Urfahr-Umgebung", "Altenberg bei Linz", "4211" },
                    { 190, "Freistadt", "Neumarkt im Mühlkreis", "4211" },
                    { 191, "Freistadt", "Kefermarkt", "4212" },
                    { 192, "Freistadt", "Neumarkt im Mühlkreis", "4212" },
                    { 193, "Freistadt", "Unterweitersdorf", "4213" },
                    { 194, "Urfahr-Umgebung", "Steyregg", "4221" },
                    { 195, "Urfahr-Umgebung", "Engerwitzdorf", "4222" },
                    { 196, "Perg", "Langenstein", "4222" },
                    { 197, "Perg", "St. Georgen an der Gusen", "4222" },
                    { 198, "Perg", "Katsdorf", "4223" },
                    { 199, "Perg", "St. Georgen an der Gusen", "4223" },
                    { 200, "Perg", "Katsdorf", "4224" },
                    { 201, "Freistadt", "Wartberg ob der Aist", "4224" },
                    { 202, "Perg", "Luftenberg an der Donau", "4225" },
                    { 203, "Freistadt", "Gutau", "4230" },
                    { 204, "Freistadt", "Hagenberg im Mühlkreis", "4230" },
                    { 205, "Freistadt", "Pregarten", "4230" },
                    { 206, "Freistadt", "Tragwein", "4230" },
                    { 207, "Freistadt", "Hagenberg im Mühlkreis", "4232" },
                    { 208, "Freistadt", "Freistadt", "4240" },
                    { 209, "Freistadt", "Kefermarkt", "4240" },
                    { 210, "Freistadt", "Lasberg", "4240" },
                    { 211, "Urfahr-Umgebung", "Reichenthal", "4240" },
                    { 212, "Freistadt", "Waldburg", "4240" },
                    { 213, "Freistadt", "Hirschbach im Mühlkreis", "4242" },
                    { 214, "Freistadt", "Sandl", "4251" },
                    { 215, "Freistadt", "Liebenau", "4252" },
                    { 216, "Freistadt", "Grünbach", "4261" },
                    { 217, "Freistadt", "Rainbach im Mühlkreis", "4261" },
                    { 218, "Freistadt", "Leopoldschlag", "4262" },
                    { 219, "Freistadt", "Sandl", "4263" },
                    { 220, "Freistadt", "Windhaag bei Freistadt", "4263" },
                    { 221, "Freistadt", "Grünbach", "4264" },
                    { 222, "Freistadt", "Lasberg", "4264" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 223, "Freistadt", "Lasberg", "4271" },
                    { 224, "Freistadt", "St. Oswald bei Freistadt", "4271" },
                    { 225, "Freistadt", "St. Leonhard bei Freistadt", "4272" },
                    { 226, "Freistadt", "Weitersfelden", "4272" },
                    { 227, "Freistadt", "Kaltenberg", "4273" },
                    { 228, "Freistadt", "Unterweißenbach", "4273" },
                    { 229, "Freistadt", "Bad Zell", "4274" },
                    { 230, "Freistadt", "Pierbach", "4274" },
                    { 231, "Freistadt", "Schönau im Mühlkreis", "4274" },
                    { 232, "Freistadt", "Königswiesen", "4280" },
                    { 233, "Freistadt", "Königswiesen", "4281" },
                    { 234, "Perg", "Pabneukirchen", "4281" },
                    { 235, "Freistadt", "Pierbach", "4281" },
                    { 236, "Freistadt", "Königswiesen", "4282" },
                    { 237, "Freistadt", "Pierbach", "4282" },
                    { 238, "Freistadt", "Schönau im Mühlkreis", "4282" },
                    { 239, "Perg", "St. Thomas am Blasenstein", "4282" },
                    { 240, "Freistadt", "Bad Zell", "4283" },
                    { 241, "Perg", "Allerheiligen im Mühlkreis", "4284" },
                    { 242, "Freistadt", "Tragwein", "4284" },
                    { 243, "Freistadt", "Kefermarkt", "4291" },
                    { 244, "Freistadt", "Lasberg", "4291" },
                    { 245, "Freistadt", "Gutau", "4292" },
                    { 246, "Freistadt", "Kefermarkt", "4292" },
                    { 247, "Freistadt", "Lasberg", "4292" },
                    { 248, "Freistadt", "Pregarten", "4292" },
                    { 249, "Freistadt", "Bad Zell", "4293" },
                    { 250, "Freistadt", "Gutau", "4293" },
                    { 251, "Freistadt", "Schönau im Mühlkreis", "4293" },
                    { 252, "Freistadt", "St. Leonhard bei Freistadt", "4293" },
                    { 253, "Freistadt", "Tragwein", "4293" },
                    { 254, "Freistadt", "Gutau", "4294" },
                    { 255, "Freistadt", "Schönau im Mühlkreis", "4294" },
                    { 256, "Freistadt", "St. Leonhard bei Freistadt", "4294" },
                    { 257, "Freistadt", "St. Oswald bei Freistadt", "4294" },
                    { 258, "Amstetten", "Ernsthofen", "4300" },
                    { 259, "Amstetten", "St. Valentin", "4300" },
                    { 260, "Amstetten", "St. Pantaleon-Erla", "4303" },
                    { 261, "Perg", "Langenstein", "4310" },
                    { 262, "Perg", "Mauthausen", "4310" },
                    { 263, "Perg", "Naarn im Machlande", "4311" },
                    { 264, "Perg", "Ried in der Riedmark", "4311" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 265, "Perg", "Schwertberg", "4311" },
                    { 266, "Freistadt", "Tragwein", "4311" },
                    { 267, "Perg", "Langenstein", "4312" },
                    { 268, "Perg", "Mauthausen", "4312" },
                    { 269, "Perg", "Ried in der Riedmark", "4312" },
                    { 270, "Perg", "Schwertberg", "4312" },
                    { 271, "Perg", "Allerheiligen im Mühlkreis", "4320" },
                    { 272, "Perg", "Naarn im Machlande", "4320" },
                    { 273, "Perg", "Perg", "4320" },
                    { 274, "Perg", "Windhaag bei Perg", "4320" },
                    { 275, "Perg", "St. Thomas am Blasenstein", "4322" },
                    { 276, "Perg", "Windhaag bei Perg", "4322" },
                    { 277, "Perg", "Arbing", "4323" },
                    { 278, "Perg", "Bad Kreuzen", "4323" },
                    { 279, "Perg", "Münzbach", "4323" },
                    { 280, "Perg", "Rechberg", "4323" },
                    { 281, "Perg", "Windhaag bei Perg", "4323" },
                    { 282, "Perg", "Rechberg", "4324" },
                    { 283, "Perg", "Naarn im Machlande", "4331" },
                    { 284, "Perg", "Naarn im Machlande", "4332" },
                    { 285, "Perg", "Arbing", "4341" },
                    { 286, "Perg", "Baumgartenberg", "4341" },
                    { 287, "Perg", "Arbing", "4342" },
                    { 288, "Perg", "Baumgartenberg", "4342" },
                    { 289, "Perg", "Münzbach", "4342" },
                    { 290, "Perg", "Mitterkirchen im Machland", "4343" },
                    { 291, "Perg", "Baumgartenberg", "4351" },
                    { 292, "Perg", "Saxen", "4351" },
                    { 293, "Perg", "Bad Kreuzen", "4352" },
                    { 294, "Perg", "Klam", "4352" },
                    { 295, "Perg", "Münzbach", "4352" },
                    { 296, "Perg", "Saxen", "4352" },
                    { 297, "Perg", "Bad Kreuzen", "4360" },
                    { 298, "Perg", "Grein", "4360" },
                    { 299, "Perg", "Waldhausen im Strudengau", "4360" },
                    { 300, "Perg", "Bad Kreuzen", "4362" },
                    { 301, "Perg", "Pabneukirchen", "4362" },
                    { 302, "Perg", "St. Thomas am Blasenstein", "4362" },
                    { 303, "Perg", "Pabneukirchen", "4363" },
                    { 304, "Perg", "St. Thomas am Blasenstein", "4363" },
                    { 305, "Perg", "St. Thomas am Blasenstein", "4364" },
                    { 306, "Perg", "Dimbach", "4371" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 307, "Perg", "Pabneukirchen", "4371" },
                    { 308, "Perg", "St. Georgen am Walde", "4371" },
                    { 309, "Zwettl", "Altmelon", "4372" },
                    { 310, "Perg", "Pabneukirchen", "4372" },
                    { 311, "Perg", "St. Georgen am Walde", "4372" },
                    { 312, "Perg", "St. Nikola an der Donau", "4381" },
                    { 313, "Perg", "St. Nikola an der Donau", "4382" },
                    { 314, "Perg", "Waldhausen im Strudengau", "4382" },
                    { 315, "Perg", "Waldhausen im Strudengau", "4391" },
                    { 316, "Melk", "Dorfstetten", "4392" },
                    { 317, "Perg", "Waldhausen im Strudengau", "4392" },
                    { 318, "Steyr-Land", "Garsten", "4400" },
                    { 319, "Steyr-Land", "St. Ulrich bei Steyr", "4400" },
                    { 320, "Steyr", "Steyr", "4400" },
                    { 321, "Steyr-Land", "Dietach", "4407" },
                    { 322, "Steyr", "Steyr", "4407" },
                    { 323, "Steyr-Land", "Aschach an der Steyr", "4421" },
                    { 324, "Kirchdorf", "Steinbach an der Steyr", "4421" },
                    { 325, "Amstetten", "Haidershofen", "4431" },
                    { 326, "Amstetten", "Ernsthofen", "4432" },
                    { 327, "Amstetten", "Behamberg", "4441" },
                    { 328, "Steyr-Land", "Maria Neustift", "4442" },
                    { 329, "Amstetten", "St. Peter in der Au", "4442" },
                    { 330, "Steyr-Land", "St. Ulrich bei Steyr", "4442" },
                    { 331, "Steyr-Land", "Großraming", "4443" },
                    { 332, "Steyr-Land", "Maria Neustift", "4443" },
                    { 333, "Amstetten", "St. Peter in der Au", "4443" },
                    { 334, "Steyr-Land", "St. Ulrich bei Steyr", "4443" },
                    { 335, "Steyr-Land", "Garsten", "4451" },
                    { 336, "Steyr-Land", "St. Ulrich bei Steyr", "4451" },
                    { 337, "Steyr", "Steyr", "4451" },
                    { 338, "Steyr-Land", "Ternberg", "4451" },
                    { 339, "Steyr-Land", "Ternberg", "4452" },
                    { 340, "Steyr-Land", "Ternberg", "4453" },
                    { 341, "Steyr-Land", "Laussa", "4460" },
                    { 342, "Steyr-Land", "Losenstein", "4460" },
                    { 343, "Steyr-Land", "Garsten", "4461" },
                    { 344, "Steyr-Land", "Laussa", "4461" },
                    { 345, "Steyr-Land", "Reichraming", "4462" },
                    { 346, "Steyr-Land", "Großraming", "4463" },
                    { 347, "Steyr-Land", "Laussa", "4463" },
                    { 348, "Steyr-Land", "Weyer", "4464" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 349, "Linz-Land", "Enns", "4470" },
                    { 350, "Linz-Land", "Kronstorf", "4470" },
                    { 351, "Linz-Land", "Asten", "4481" },
                    { 352, "Linz-Land", "Enns", "4481" },
                    { 353, "Perg", "Luftenberg an der Donau", "4481" },
                    { 354, "Amstetten", "Ennsdorf", "4482" },
                    { 355, "Amstetten", "St. Valentin", "4482" },
                    { 356, "Linz-Land", "Hargelsberg", "4483" },
                    { 357, "Linz-Land", "Kronstorf", "4483" },
                    { 358, "Steyr-Land", "Dietach", "4484" },
                    { 359, "Linz-Land", "Hargelsberg", "4484" },
                    { 360, "Linz-Land", "Kronstorf", "4484" },
                    { 361, "Linz-Land", "St. Florian", "4490" },
                    { 362, "Linz-Land", "Hofkirchen im Traunkreis", "4491" },
                    { 363, "Linz-Land", "Niederneukirchen", "4491" },
                    { 364, "Linz-Land", "St. Marien", "4491" },
                    { 365, "Linz-Land", "Hofkirchen im Traunkreis", "4492" },
                    { 366, "Steyr-Land", "Schiedlberg", "4493" },
                    { 367, "Steyr-Land", "Wolfern", "4493" },
                    { 368, "Linz-Land", "Neuhofen an der Krems", "4501" },
                    { 369, "Linz-Land", "St. Marien", "4502" },
                    { 370, "Linz-Land", "Allhaming", "4511" },
                    { 371, "Linz-Land", "Neuhofen an der Krems", "4511" },
                    { 372, "Steyr-Land", "Schiedlberg", "4521" },
                    { 373, "Linz-Land", "St. Marien", "4521" },
                    { 374, "Steyr-Land", "Schiedlberg", "4522" },
                    { 375, "Steyr-Land", "Sierning", "4522" },
                    { 376, "Steyr-Land", "Aschach an der Steyr", "4523" },
                    { 377, "Steyr-Land", "Garsten", "4523" },
                    { 378, "Steyr-Land", "Sierning", "4523" },
                    { 379, "Linz-Land", "Kematen an der Krems", "4531" },
                    { 380, "Linz-Land", "Neuhofen an der Krems", "4531" },
                    { 381, "Steyr-Land", "Sierning", "4531" },
                    { 382, "Linz-Land", "Kematen an der Krems", "4532" },
                    { 383, "Kirchdorf", "Kremsmünster", "4532" },
                    { 384, "Steyr-Land", "Rohr im Kremstal", "4532" },
                    { 385, "Linz-Land", "Piberbach", "4533" },
                    { 386, "Steyr-Land", "Adlwang", "4540" },
                    { 387, "Steyr-Land", "Bad Hall", "4540" },
                    { 388, "Kirchdorf", "Kremsmünster", "4540" },
                    { 389, "Steyr-Land", "Pfarrkirchen bei Bad Hall", "4540" },
                    { 390, "Steyr-Land", "Adlwang", "4541" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 391, "Kirchdorf", "Nußbach", "4542" },
                    { 392, "Linz-Land", "Kematen an der Krems", "4550" },
                    { 393, "Kirchdorf", "Kremsmünster", "4550" },
                    { 394, "Steyr-Land", "Rohr im Kremstal", "4550" },
                    { 395, "Kirchdorf", "Ried im Traunkreis", "4551" },
                    { 396, "Steyr-Land", "Pfarrkirchen bei Bad Hall", "4552" },
                    { 397, "Kirchdorf", "Wartberg an der Krems", "4552" },
                    { 398, "Kirchdorf", "Schlierbach", "4553" },
                    { 399, "Kirchdorf", "Oberschlierbach", "4554" },
                    { 400, "Kirchdorf", "Kirchdorf an der Krems", "4560" },
                    { 401, "Kirchdorf", "Steinbach am Ziehberg", "4562" },
                    { 402, "Kirchdorf", "Kirchdorf an der Krems", "4563" },
                    { 403, "Kirchdorf", "Micheldorf in Oberösterreich", "4563" },
                    { 404, "Kirchdorf", "Klaus an der Pyhrnbahn", "4564" },
                    { 405, "Kirchdorf", "Inzersdorf im Kremstal", "4565" },
                    { 406, "Kirchdorf", "Klaus an der Pyhrnbahn", "4571" },
                    { 407, "Kirchdorf", "Hinterstoder", "4572" },
                    { 408, "Kirchdorf", "Klaus an der Pyhrnbahn", "4572" },
                    { 409, "Kirchdorf", "St. Pankraz", "4572" },
                    { 410, "Kirchdorf", "Hinterstoder", "4573" },
                    { 411, "Kirchdorf", "Hinterstoder", "4574" },
                    { 412, "Kirchdorf", "Vorderstoder", "4574" },
                    { 413, "Kirchdorf", "Roßleithen", "4575" },
                    { 414, "Kirchdorf", "Edlbach", "4580" },
                    { 415, "Kirchdorf", "Windischgarsten", "4580" },
                    { 416, "Kirchdorf", "Edlbach", "4581" },
                    { 417, "Kirchdorf", "Rosenau am Hengstpaß", "4581" },
                    { 418, "Kirchdorf", "Edlbach", "4582" },
                    { 419, "Kirchdorf", "Spital am Pyhrn", "4582" },
                    { 420, "Kirchdorf", "Molln", "4591" },
                    { 421, "Kirchdorf", "Rosenau am Hengstpaß", "4591" },
                    { 422, "Kirchdorf", "Grünburg", "4592" },
                    { 423, "Kirchdorf", "Grünburg", "4593" },
                    { 424, "Steyr-Land", "Aschach an der Steyr", "4594" },
                    { 425, "Kirchdorf", "Grünburg", "4594" },
                    { 426, "Kirchdorf", "Steinbach an der Steyr", "4594" },
                    { 427, "Steyr-Land", "Waldneukirchen", "4595" },
                    { 428, "Kirchdorf", "Steinbach an der Steyr", "4596" },
                    { 429, "Steyr-Land", "Ternberg", "4596" },
                    { 430, "Wels-Land", "Schleißheim", "4600" },
                    { 431, "Wels-Land", "Thalheim bei Wels", "4600" },
                    { 432, "Wels", "Wels", "4600" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 433, "Wels-Land", "Buchkirchen", "4611" },
                    { 434, "Grieskirchen", "Wallern an der Trattnach", "4611" },
                    { 435, "Wels-Land", "Buchkirchen", "4612" },
                    { 436, "Eferding", "Scharten", "4612" },
                    { 437, "Wels-Land", "Buchkirchen", "4613" },
                    { 438, "Wels-Land", "Marchtrenk", "4614" },
                    { 439, "Wels-Land", "Holzhausen", "4615" },
                    { 440, "Linz-Land", "Eggendorf im Traunkreis", "4616" },
                    { 441, "Wels-Land", "Weißkirchen an der Traun", "4616" },
                    { 442, "Kirchdorf", "Kremsmünster", "4621" },
                    { 443, "Wels-Land", "Sipbachzell", "4621" },
                    { 444, "Linz-Land", "Eggendorf im Traunkreis", "4622" },
                    { 445, "Wels-Land", "Gunskirchen", "4623" },
                    { 446, "Wels-Land", "Offenhausen", "4624" },
                    { 447, "Wels-Land", "Pennewang", "4624" },
                    { 448, "Grieskirchen", "Meggenhofen", "4625" },
                    { 449, "Wels-Land", "Offenhausen", "4625" },
                    { 450, "Wels-Land", "Pennewang", "4625" },
                    { 451, "Wels-Land", "Buchkirchen", "4631" },
                    { 452, "Wels-Land", "Krenglbach", "4631" },
                    { 453, "Wels-Land", "Pichl bei Wels", "4631" },
                    { 454, "Grieskirchen", "Wallern an der Trattnach", "4631" },
                    { 455, "Grieskirchen", "Kematen am Innbach", "4632" },
                    { 456, "Wels-Land", "Pichl bei Wels", "4632" },
                    { 457, "Grieskirchen", "Schlüßlberg", "4632" },
                    { 458, "Grieskirchen", "Kematen am Innbach", "4633" },
                    { 459, "Wels-Land", "Pichl bei Wels", "4633" },
                    { 460, "Wels-Land", "Fischlham", "4641" },
                    { 461, "Wels-Land", "Steinhaus", "4641" },
                    { 462, "Wels-Land", "Sattledt", "4642" },
                    { 463, "Wels-Land", "Eberstalzell", "4643" },
                    { 464, "Kirchdorf", "Pettenbach", "4643" },
                    { 465, "Kirchdorf", "Ried im Traunkreis", "4643" },
                    { 466, "Kirchdorf", "Steinbach am Ziehberg", "4643" },
                    { 467, "Gmunden", "Grünau im Almtal", "4644" },
                    { 468, "Gmunden", "Scharnstein", "4644" },
                    { 469, "Gmunden", "St. Konrad", "4644" },
                    { 470, "Gmunden", "Grünau im Almtal", "4645" },
                    { 471, "Gmunden", "Scharnstein", "4645" },
                    { 472, "Wels-Land", "Edt bei Lambach", "4650" },
                    { 473, "Wels-Land", "Gunskirchen", "4650" },
                    { 474, "Wels-Land", "Lambach", "4650" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 475, "Wels-Land", "Stadl-Paura", "4651" },
                    { 476, "Wels-Land", "Fischlham", "4652" },
                    { 477, "Wels-Land", "Steinerkirchen an der Traun", "4652" },
                    { 478, "Wels-Land", "Eberstalzell", "4653" },
                    { 479, "Gmunden", "Vorchdorf", "4653" },
                    { 480, "Wels-Land", "Bad Wimsbach-Neydharting", "4654" },
                    { 481, "Gmunden", "Roitham am Traunfall", "4655" },
                    { 482, "Wels-Land", "Steinerkirchen an der Traun", "4655" },
                    { 483, "Gmunden", "Vorchdorf", "4655" },
                    { 484, "Gmunden", "Kirchham", "4656" },
                    { 485, "Gmunden", "Laakirchen", "4656" },
                    { 486, "Gmunden", "Roitham am Traunfall", "4661" },
                    { 487, "Gmunden", "Laakirchen", "4662" },
                    { 488, "Gmunden", "Laakirchen", "4663" },
                    { 489, "Gmunden", "Gschwandt", "4664" },
                    { 490, "Gmunden", "Laakirchen", "4664" },
                    { 491, "Wels-Land", "Aichkirchen", "4671" },
                    { 492, "Wels-Land", "Neukirchen bei Lambach", "4671" },
                    { 493, "Wels-Land", "Bachmanning", "4672" },
                    { 494, "Grieskirchen", "Meggenhofen", "4672" },
                    { 495, "Wels-Land", "Pennewang", "4672" },
                    { 496, "Grieskirchen", "Gaspoltshofen", "4673" },
                    { 497, "Grieskirchen", "Gaspoltshofen", "4674" },
                    { 498, "Grieskirchen", "Weibern", "4675" },
                    { 499, "Grieskirchen", "Aistersheim", "4676" },
                    { 500, "Grieskirchen", "Gaspoltshofen", "4676" },
                    { 501, "Ried", "Geiersberg", "4680" },
                    { 502, "Grieskirchen", "Haag am Hausruck", "4680" },
                    { 503, "Grieskirchen", "Weibern", "4680" },
                    { 504, "Grieskirchen", "Rottenbach", "4681" },
                    { 505, "Grieskirchen", "Gaspoltshofen", "4682" },
                    { 506, "Grieskirchen", "Geboltskirchen", "4682" },
                    { 507, "Vöcklabruck", "Oberndorf bei Schwanenstadt", "4690" },
                    { 508, "Vöcklabruck", "Pitzenberg", "4690" },
                    { 509, "Vöcklabruck", "Pühret", "4690" },
                    { 510, "Vöcklabruck", "Rüstorf", "4690" },
                    { 511, "Vöcklabruck", "Rutzenham", "4690" },
                    { 512, "Vöcklabruck", "Schlatt", "4690" },
                    { 513, "Vöcklabruck", "Schwanenstadt", "4690" },
                    { 514, "Wels-Land", "Stadl-Paura", "4690" },
                    { 515, "Vöcklabruck", "Niederthalheim", "4691" },
                    { 516, "Vöcklabruck", "Schlatt", "4691" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 517, "Grieskirchen", "Gaspoltshofen", "4692" },
                    { 518, "Vöcklabruck", "Niederthalheim", "4692" },
                    { 519, "Vöcklabruck", "Desselbrunn", "4693" },
                    { 520, "Vöcklabruck", "Rüstorf", "4693" },
                    { 521, "Gmunden", "Ohlsdorf", "4694" },
                    { 522, "Grieskirchen", "Bad Schallerbach", "4701" },
                    { 523, "Wels-Land", "Pichl bei Wels", "4701" },
                    { 524, "Grieskirchen", "Wallern an der Trattnach", "4701" },
                    { 525, "Grieskirchen", "Bad Schallerbach", "4702" },
                    { 526, "Wels-Land", "Krenglbach", "4702" },
                    { 527, "Wels-Land", "Pichl bei Wels", "4702" },
                    { 528, "Grieskirchen", "Wallern an der Trattnach", "4702" },
                    { 529, "Grieskirchen", "Grieskirchen", "4707" },
                    { 530, "Grieskirchen", "Schlüßlberg", "4707" },
                    { 531, "Grieskirchen", "Grieskirchen", "4710" },
                    { 532, "Grieskirchen", "Pollham", "4710" },
                    { 533, "Grieskirchen", "St. Georgen bei Grieskirchen", "4710" },
                    { 534, "Grieskirchen", "Tollet", "4710" },
                    { 535, "Grieskirchen", "Michaelnbach", "4712" },
                    { 536, "Grieskirchen", "Tollet", "4712" },
                    { 537, "Grieskirchen", "Waizenkirchen", "4712" },
                    { 538, "Grieskirchen", "Gallspach", "4713" },
                    { 539, "Grieskirchen", "Grieskirchen", "4713" },
                    { 540, "Grieskirchen", "Kematen am Innbach", "4713" },
                    { 541, "Grieskirchen", "Schlüßlberg", "4713" },
                    { 542, "Grieskirchen", "St. Georgen bei Grieskirchen", "4713" },
                    { 543, "Grieskirchen", "Gaspoltshofen", "4714" },
                    { 544, "Grieskirchen", "Meggenhofen", "4714" },
                    { 545, "Wels-Land", "Offenhausen", "4714" },
                    { 546, "Grieskirchen", "St. Georgen bei Grieskirchen", "4715" },
                    { 547, "Grieskirchen", "Taufkirchen an der Trattnach", "4715" },
                    { 548, "Grieskirchen", "Tollet", "4715" },
                    { 549, "Grieskirchen", "Hofkirchen an der Trattnach", "4716" },
                    { 550, "Grieskirchen", "Kallham", "4720" },
                    { 551, "Grieskirchen", "Michaelnbach", "4720" },
                    { 552, "Grieskirchen", "Neumarkt im Hausruckkreis", "4720" },
                    { 553, "Grieskirchen", "Pötting", "4720" },
                    { 554, "Grieskirchen", "Wendling", "4720" },
                    { 555, "Schärding", "Altschwendt", "4721" },
                    { 556, "Grieskirchen", "Neukirchen am Walde", "4722" },
                    { 557, "Grieskirchen", "Peuerbach", "4722" },
                    { 558, "Grieskirchen", "Steegen", "4722" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 559, "Schärding", "Kopfing im Innkreis", "4723" },
                    { 560, "Grieskirchen", "Natternbach", "4723" },
                    { 561, "Grieskirchen", "Eschenau im Hausruckkreis", "4724" },
                    { 562, "Grieskirchen", "Neukirchen am Walde", "4724" },
                    { 563, "Schärding", "Waldkirchen am Wesen", "4724" },
                    { 564, "Schärding", "Engelhartszell", "4725" },
                    { 565, "Schärding", "Kopfing im Innkreis", "4725" },
                    { 566, "Schärding", "St. Aegidi", "4725" },
                    { 567, "Schärding", "St. Roman", "4725" },
                    { 568, "Eferding", "Prambachkirchen", "4730" },
                    { 569, "Grieskirchen", "St. Agatha", "4730" },
                    { 570, "Eferding", "Stroheim", "4730" },
                    { 571, "Grieskirchen", "Waizenkirchen", "4730" },
                    { 572, "Eferding", "Prambachkirchen", "4731" },
                    { 573, "Eferding", "Stroheim", "4731" },
                    { 574, "Grieskirchen", "Waizenkirchen", "4731" },
                    { 575, "Grieskirchen", "Pollham", "4732" },
                    { 576, "Eferding", "Prambachkirchen", "4732" },
                    { 577, "Eferding", "St. Marienkirchen an der Polsenz", "4732" },
                    { 578, "Grieskirchen", "St. Thomas", "4732" },
                    { 579, "Grieskirchen", "Heiligenberg", "4733" },
                    { 580, "Grieskirchen", "Hofkirchen an der Trattnach", "4741" },
                    { 581, "Grieskirchen", "Rottenbach", "4741" },
                    { 582, "Grieskirchen", "Wendling", "4741" },
                    { 583, "Grieskirchen", "Pram", "4742" },
                    { 584, "Ried", "Peterskirchen", "4743" },
                    { 585, "Schärding", "Dorf an der Pram", "4751" },
                    { 586, "Ried", "Taiskirchen im Innkreis", "4751" },
                    { 587, "Ried", "Lambrechten", "4752" },
                    { 588, "Schärding", "Riedau", "4752" },
                    { 589, "Ried", "Lambrechten", "4753" },
                    { 590, "Ried", "Taiskirchen im Innkreis", "4753" },
                    { 591, "Ried", "Andrichsfurt", "4754" },
                    { 592, "Ried", "Peterskirchen", "4754" },
                    { 593, "Ried", "Utzenaich", "4754" },
                    { 594, "Schärding", "Altschwendt", "4755" },
                    { 595, "Schärding", "Zell an der Pram", "4755" },
                    { 596, "Schärding", "Raab", "4760" },
                    { 597, "Schärding", "St. Willibald", "4760" },
                    { 598, "Schärding", "Enzenkirchen", "4761" },
                    { 599, "Schärding", "Enzenkirchen", "4762" },
                    { 600, "Grieskirchen", "Natternbach", "4762" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 601, "Schärding", "St. Willibald", "4762" },
                    { 602, "Schärding", "Andorf", "4770" },
                    { 603, "Schärding", "Enzenkirchen", "4771" },
                    { 604, "Schärding", "Sigharting", "4771" },
                    { 605, "Schärding", "Andorf", "4772" },
                    { 606, "Ried", "Lambrechten", "4772" },
                    { 607, "Ried", "Utzenaich", "4772" },
                    { 608, "Schärding", "Eggerding", "4773" },
                    { 609, "Schärding", "St. Marienkirchen bei Schärding", "4773" },
                    { 610, "Schärding", "St. Marienkirchen bei Schärding", "4774" },
                    { 611, "Schärding", "Taufkirchen an der Pram", "4774" },
                    { 612, "Schärding", "Eggerding", "4775" },
                    { 613, "Schärding", "Taufkirchen an der Pram", "4775" },
                    { 614, "Schärding", "Diersbach", "4776" },
                    { 615, "Schärding", "Rainbach im Innkreis", "4776" },
                    { 616, "Schärding", "Mayrhof", "4777" },
                    { 617, "Schärding", "Schärding", "4780" },
                    { 618, "Schärding", "St. Florian am Inn", "4782" },
                    { 619, "Schärding", "Schardenberg", "4783" },
                    { 620, "Schärding", "Wernstein am Inn", "4783" },
                    { 621, "Schärding", "Schardenberg", "4784" },
                    { 622, "Schärding", "Wernstein am Inn", "4784" },
                    { 623, "Schärding", "Freinberg", "4785" },
                    { 624, "Schärding", "Schardenberg", "4785" },
                    { 625, "Schärding", "Brunnenthal", "4786" },
                    { 626, "Schärding", "Rainbach im Innkreis", "4791" },
                    { 627, "Schärding", "Schardenberg", "4791" },
                    { 628, "Schärding", "Taufkirchen an der Pram", "4791" },
                    { 629, "Schärding", "Münzkirchen", "4792" },
                    { 630, "Schärding", "Schardenberg", "4792" },
                    { 631, "Schärding", "St. Roman", "4792" },
                    { 632, "Schärding", "Kopfing im Innkreis", "4793" },
                    { 633, "Schärding", "St. Roman", "4793" },
                    { 634, "Schärding", "Enzenkirchen", "4794" },
                    { 635, "Schärding", "Kopfing im Innkreis", "4794" },
                    { 636, "Schärding", "St. Aegidi", "4794" },
                    { 637, "Vöcklabruck", "Attnang-Puchheim", "4800" },
                    { 638, "Vöcklabruck", "Desselbrunn", "4800" },
                    { 639, "Vöcklabruck", "Pilsbach", "4800" },
                    { 640, "Vöcklabruck", "Pühret", "4800" },
                    { 641, "Vöcklabruck", "Regau", "4800" },
                    { 642, "Gmunden", "Altmünster", "4801" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 643, "Gmunden", "Traunkirchen", "4801" },
                    { 644, "Gmunden", "Ebensee am Traunsee", "4802" },
                    { 645, "Gmunden", "Altmünster", "4810" },
                    { 646, "Gmunden", "Gmunden", "4810" },
                    { 647, "Gmunden", "Gschwandt", "4810" },
                    { 648, "Gmunden", "Pinsdorf", "4810" },
                    { 649, "Gmunden", "Altmünster", "4812" },
                    { 650, "Gmunden", "Pinsdorf", "4812" },
                    { 651, "Vöcklabruck", "Regau", "4812" },
                    { 652, "Gmunden", "Altmünster", "4813" },
                    { 653, "Gmunden", "Altmünster", "4814" },
                    { 654, "Vöcklabruck", "Aurach am Hongar", "4814" },
                    { 655, "Gmunden", "Gschwandt", "4816" },
                    { 656, "Gmunden", "Laakirchen", "4816" },
                    { 657, "Gmunden", "Gschwandt", "4817" },
                    { 658, "Gmunden", "Kirchham", "4817" },
                    { 659, "Gmunden", "Scharnstein", "4817" },
                    { 660, "Gmunden", "St. Konrad", "4817" },
                    { 661, "Gmunden", "Bad Ischl", "4820" },
                    { 662, "Gmunden", "Bad Ischl", "4821" },
                    { 663, "Gmunden", "Bad Goisern am Hallstättersee", "4822" },
                    { 664, "Gmunden", "Hallstatt", "4823" },
                    { 665, "Gmunden", "Gosau", "4824" },
                    { 666, "Gmunden", "Gosau", "4825" },
                    { 667, "Gmunden", "Hallstatt", "4830" },
                    { 668, "Gmunden", "Obertraun", "4831" },
                    { 669, "Vöcklabruck", "Pilsbach", "4840" },
                    { 670, "Vöcklabruck", "Vöcklabruck", "4840" },
                    { 671, "Vöcklabruck", "Pilsbach", "4841" },
                    { 672, "Vöcklabruck", "Timelkam", "4841" },
                    { 673, "Vöcklabruck", "Ungenach", "4841" },
                    { 674, "Vöcklabruck", "Vöcklabruck", "4841" },
                    { 675, "Vöcklabruck", "Zell am Pettenfirst", "4842" },
                    { 676, "Vöcklabruck", "Ampflwang im Hausruckwald", "4843" },
                    { 677, "Vöcklabruck", "Aurach am Hongar", "4844" },
                    { 678, "Vöcklabruck", "Regau", "4844" },
                    { 679, "Gmunden", "Pinsdorf", "4845" },
                    { 680, "Vöcklabruck", "Regau", "4845" },
                    { 681, "Vöcklabruck", "Redlham", "4846" },
                    { 682, "Vöcklabruck", "Puchkirchen am Trattberg", "4849" },
                    { 683, "Vöcklabruck", "Neukirchen an der Vöckla", "4850" },
                    { 684, "Vöcklabruck", "Timelkam", "4850" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 685, "Vöcklabruck", "Ungenach", "4850" },
                    { 686, "Vöcklabruck", "Vöcklabruck", "4850" },
                    { 687, "Vöcklabruck", "Gampern", "4851" },
                    { 688, "Vöcklabruck", "Seewalchen am Attersee", "4851" },
                    { 689, "Vöcklabruck", "Weyregg am Attersee", "4852" },
                    { 690, "Vöcklabruck", "Steinbach am Attersee", "4853" },
                    { 691, "Salzburg-Umgebung", "Sankt Gilgen", "4854" },
                    { 692, "Vöcklabruck", "Steinbach am Attersee", "4854" },
                    { 693, "Vöcklabruck", "Lenzing", "4860" },
                    { 694, "Vöcklabruck", "Regau", "4860" },
                    { 695, "Vöcklabruck", "Timelkam", "4860" },
                    { 696, "Vöcklabruck", "Aurach am Hongar", "4861" },
                    { 697, "Vöcklabruck", "Schörfling am Attersee", "4861" },
                    { 698, "Vöcklabruck", "Weyregg am Attersee", "4861" },
                    { 699, "Vöcklabruck", "Berg im Attergau", "4863" },
                    { 700, "Vöcklabruck", "Seewalchen am Attersee", "4863" },
                    { 701, "Vöcklabruck", "Attersee am Attersee", "4864" },
                    { 702, "Vöcklabruck", "Nußdorf am Attersee", "4865" },
                    { 703, "Vöcklabruck", "Innerschwand am Mondsee", "4866" },
                    { 704, "Salzburg-Umgebung", "Sankt Gilgen", "4866" },
                    { 705, "Vöcklabruck", "Unterach am Attersee", "4866" },
                    { 706, "Vöcklabruck", "Pfaffing", "4870" },
                    { 707, "Vöcklabruck", "Vöcklamarkt", "4870" },
                    { 708, "Vöcklabruck", "Frankenburg am Hausruck", "4871" },
                    { 709, "Vöcklabruck", "Gampern", "4871" },
                    { 710, "Vöcklabruck", "Neukirchen an der Vöckla", "4871" },
                    { 711, "Vöcklabruck", "Pfaffing", "4871" },
                    { 712, "Vöcklabruck", "Vöcklamarkt", "4871" },
                    { 713, "Vöcklabruck", "Neukirchen an der Vöckla", "4872" },
                    { 714, "Vöcklabruck", "Frankenburg am Hausruck", "4873" },
                    { 715, "Vöcklabruck", "Neukirchen an der Vöckla", "4873" },
                    { 716, "Vöcklabruck", "Redleiten", "4873" },
                    { 717, "Vöcklabruck", "Berg im Attergau", "4880" },
                    { 718, "Vöcklabruck", "Seewalchen am Attersee", "4880" },
                    { 719, "Vöcklabruck", "St. Georgen im Attergau", "4880" },
                    { 720, "Vöcklabruck", "Straß im Attergau", "4881" },
                    { 721, "Vöcklabruck", "Oberwang", "4882" },
                    { 722, "Vöcklabruck", "Fornach", "4890" },
                    { 723, "Vöcklabruck", "Frankenmarkt", "4890" },
                    { 724, "Vöcklabruck", "Vöcklamarkt", "4890" },
                    { 725, "Vöcklabruck", "Weißenkirchen im Attergau", "4890" },
                    { 726, "Vöcklabruck", "Frankenmarkt", "4891" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 727, "Vöcklabruck", "Pöndorf", "4891" },
                    { 728, "Vöcklabruck", "Weißenkirchen im Attergau", "4891" },
                    { 729, "Vöcklabruck", "Fornach", "4892" },
                    { 730, "Vöcklabruck", "Pfaffing", "4892" },
                    { 731, "Vöcklabruck", "Oberhofen am Irrsee", "4893" },
                    { 732, "Vöcklabruck", "Tiefgraben", "4893" },
                    { 733, "Vöcklabruck", "Zell am Moos", "4893" },
                    { 734, "Vöcklabruck", "Oberhofen am Irrsee", "4894" },
                    { 735, "Vöcklabruck", "Ottnang am Hausruck", "4901" },
                    { 736, "Grieskirchen", "Gaspoltshofen", "4902" },
                    { 737, "Vöcklabruck", "Niederthalheim", "4902" },
                    { 738, "Vöcklabruck", "Wolfsegg am Hausruck", "4902" },
                    { 739, "Vöcklabruck", "Manning", "4903" },
                    { 740, "Vöcklabruck", "Atzbach", "4904" },
                    { 741, "Ried", "Eberschwang", "4906" },
                    { 742, "Ried", "Aurolzmünster", "4910" },
                    { 743, "Ried", "Mehrnbach", "4910" },
                    { 744, "Ried", "Pattigham", "4910" },
                    { 745, "Ried", "Ried im Innkreis", "4910" },
                    { 746, "Ried", "Tumeltsham", "4911" },
                    { 747, "Ried", "Neuhofen im Innkreis", "4912" },
                    { 748, "Ried", "Schildorn", "4920" },
                    { 749, "Ried", "Hohenzell", "4921" },
                    { 750, "Ried", "Geiersberg", "4922" },
                    { 751, "Ried", "Lohnsburg am Kobernaußerwald", "4923" },
                    { 752, "Ried", "Waldzell", "4924" },
                    { 753, "Ried", "Pattigham", "4925" },
                    { 754, "Ried", "Pramet", "4925" },
                    { 755, "Ried", "St. Marienkirchen am Hausruck", "4926" },
                    { 756, "Braunau", "Aspach", "4931" },
                    { 757, "Ried", "Mettmach", "4931" },
                    { 758, "Braunau", "Aspach", "4932" },
                    { 759, "Ried", "Kirchheim im Innkreis", "4932" },
                    { 760, "Braunau", "Aspach", "4933" },
                    { 761, "Ried", "Mehrnbach", "4941" },
                    { 762, "Ried", "Ried im Innkreis", "4941" },
                    { 763, "Ried", "Gurten", "4942" },
                    { 764, "Ried", "Wippenham", "4942" },
                    { 765, "Ried", "Geinberg", "4943" },
                    { 766, "Ried", "Gurten", "4943" },
                    { 767, "Ried", "Kirchdorf am Inn", "4943" },
                    { 768, "Braunau", "Polling im Innkreis", "4943" }
                });

            migrationBuilder.InsertData(
                table: "Zipcodes",
                columns: new[] { "Id", "District", "Location", "ZipCodeNr" },
                values: new object[,]
                {
                    { 769, "Braunau", "Altheim", "4950" },
                    { 770, "Braunau", "Weng im Innkreis", "4950" },
                    { 771, "Ried", "Geinberg", "4951" },
                    { 772, "Braunau", "Polling im Innkreis", "4951" },
                    { 773, "Braunau", "Altheim", "4952" },
                    { 774, "Braunau", "Moosbach", "4952" },
                    { 775, "Braunau", "Weng im Innkreis", "4952" },
                    { 776, "Ried", "Mühlheim am Inn", "4961" },
                    { 777, "Braunau", "Weng im Innkreis", "4961" },
                    { 778, "Braunau", "Mining", "4962" },
                    { 779, "Braunau", "St. Peter am Hart", "4962" },
                    { 780, "Braunau", "Burgkirchen", "4963" },
                    { 781, "Braunau", "St. Peter am Hart", "4963" },
                    { 782, "Ried", "Eitzing", "4970" },
                    { 783, "Ried", "Andrichsfurt", "4971" },
                    { 784, "Ried", "Aurolzmünster", "4971" },
                    { 785, "Ried", "Mehrnbach", "4971" },
                    { 786, "Ried", "Utzenaich", "4971" },
                    { 787, "Ried", "Andrichsfurt", "4972" },
                    { 788, "Ried", "Aurolzmünster", "4972" },
                    { 789, "Ried", "Utzenaich", "4972" },
                    { 790, "Ried", "Aurolzmünster", "4973" },
                    { 791, "Ried", "Mörschwang", "4973" },
                    { 792, "Ried", "Reichersberg", "4973" },
                    { 793, "Ried", "Senftenbach", "4973" },
                    { 794, "Ried", "St. Martin im Innkreis", "4973" },
                    { 795, "Ried", "Utzenaich", "4973" },
                    { 796, "Ried", "Lambrechten", "4974" },
                    { 797, "Ried", "Ort im Innkreis", "4974" },
                    { 798, "Ried", "Reichersberg", "4974" },
                    { 799, "Schärding", "Suben", "4975" },
                    { 800, "Ried", "Antiesenhofen", "4980" },
                    { 801, "Schärding", "Eggerding", "4980" },
                    { 802, "Ried", "Reichersberg", "4980" },
                    { 803, "Ried", "Reichersberg", "4981" },
                    { 804, "Ried", "Kirchdorf am Inn", "4982" },
                    { 805, "Ried", "Mörschwang", "4982" },
                    { 806, "Ried", "Obernberg am Inn", "4982" },
                    { 807, "Ried", "St. Georgen bei Obernberg am Inn", "4983" },
                    { 808, "Ried", "Mörschwang", "4984" },
                    { 809, "Ried", "Weilbach", "4984" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "Description", "Name", "StreetNr", "ZipCodeId" },
                values: new object[,]
                {
                    { 1, "Hauptstraße", "Genießen Sie authentische italienische Küche in einer gemütlichen Atmosphäre. Von hausgemachten Pastagerichten bis hin zu frisch zubereiteten Pizzen bieten wir eine Vielzahl von Optionen für jeden Geschmack.", "La Trattoria", "123", 1 },
                    { 2, "Bahnhofstraße", "Tauchen Sie ein in die Welt des Sushis und erleben Sie eine Fusion aus traditionellen und modernen japanischen Geschmacksrichtungen. Unsere Sushi-Rollen und frischen Meeresfrüchte werden Sie begeistern.", "Sushi Corner", "456", 1 },
                    { 3, "Kirchplatz", "Lassen Sie sich von der französischen Küche verführen. Unsere raffinierten Gerichte, inspiriert von den Aromen Frankreichs, werden Ihren Gaumen verwöhnen. Genießen Sie ein Glas Wein aus unserer umfangreichen Weinkarte.", "Le Bistro Français", "789", 1 },
                    { 4, "Gartenweg", "Erleben Sie die exotischen Aromen der indischen Küche in unserem Restaurant. Von würzigen Currygerichten bis hin zu köstlichen andoori-Spezialitäten bieten wir eine Vielzahl von Gerichten, die Ihre Sinne begeistern werden.", "Spice Paradise", "234", 1 },
                    { 5, "Marktstraße", "Freuen Sie sich auf saftige Steaks, perfekt gegrillt nach Ihren Wünschen. Unser Steakhaus bietet eine rustikale Atmosphäre und eine Auswahl an hochwertigen Fleischsorten. Begleitet von Beilagen und Saucen wird Ihr Besuch zu einem kulinarischen Erlebnis.", "Steakhouse Deluxe", "567", 1 },
                    { 6, "Rue de la Paix", "Chez Pierre ist ein elegantes französisches Restaurant, das sich auf klassische französische Küche spezialisiert hat. Mit einer raffinierten Atmosphäre und einer umfangreichen Weinkarte bietet Chez Pierre ein unvergessliches kulinarisches Erlebnis.", "Chez Pierre", "10", 1 },
                    { 7, "Main Street", "The Spice Garden entführt Sie auf eine kulinarische Reise durch die Aromen Indiens. Von würzigen Currygerichten bis hin zu delikaten Vorspeisen bieten wir eine vielfältige Auswahl an indischen Spezialitäten, die Ihre Geschmacksknospen verzaubern werden.", "The Spice Garden", "10", 1 },
                    { 8, "Shibuya-ku, Shibuya", "Erleben Sie den Geschmack von Mexiko bei El Rancho. Unser lebhaftes Restaurant serviert authentische mexikanische Gerichte wie Tacos, Enchiladas und frittierte Nachos, begleitet von erfrischenden Margaritas und traditionellen lateinamerikanischen Getränken.", "Sushi Zen", "3-1-1", 1 },
                    { 9, "Calle Principal", "Erleben Sie die exotischen Aromen der indischen Küche in unserem Restaurant. Von würzigen Currygerichten bis hin zu köstlichen andoori-Spezialitäten bieten wir eine Vielzahl von Gerichten, die Ihre Sinne begeistern werden.", "El Rancho", "20", 1 },
                    { 10, "Via Roma", "Bella Italia ist ein charmantes italienisches Restaurant, das köstliche Pasta, Pizza und Antipasti anbietet. Mit frischen Zutaten und traditionellen Rezepten möchten wir Ihnen ein Stück Italien inmitten der Stadt präsentieren.", "Bella Italia", "5a", 1 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantCategories",
                columns: new[] { "Id", "CategoryId", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 27, 2 },
                    { 3, 2, 3 },
                    { 4, 6, 4 },
                    { 5, 20, 5 },
                    { 6, 2, 6 },
                    { 7, 6, 7 },
                    { 8, 3, 8 },
                    { 9, 6, 9 },
                    { 10, 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantOpeningTimes",
                columns: new[] { "Id", "ClosingTime", "Day", "OpeningTime", "RestaurantId" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 2, new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 3, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 4, new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 5, new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 6, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 7, new TimeSpan(0, 16, 0, 0, 0), 0, new TimeSpan(0, 10, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTables",
                columns: new[] { "Id", "RestaurantId", "SeatPlaces" },
                values: new object[,]
                {
                    { 1, 1, 6 },
                    { 2, 2, 8 },
                    { 3, 3, 5 },
                    { 4, 4, 6 },
                    { 5, 5, 7 },
                    { 6, 6, 6 },
                    { 7, 7, 9 },
                    { 8, 8, 5 },
                    { 9, 9, 6 },
                    { 10, 10, 7 },
                    { 11, 1, 6 },
                    { 12, 2, 8 },
                    { 13, 3, 5 },
                    { 14, 4, 6 },
                    { 15, 5, 7 },
                    { 16, 6, 6 },
                    { 17, 7, 9 },
                    { 18, 8, 5 },
                    { 19, 9, 6 },
                    { 20, 10, 7 },
                    { 21, 1, 6 },
                    { 22, 2, 7 },
                    { 23, 3, 5 },
                    { 24, 4, 6 },
                    { 25, 5, 8 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTables",
                columns: new[] { "Id", "RestaurantId", "SeatPlaces" },
                values: new object[,]
                {
                    { 26, 6, 6 },
                    { 27, 7, 9 },
                    { 28, 8, 5 },
                    { 29, 9, 6 },
                    { 30, 10, 7 },
                    { 31, 1, 6 },
                    { 32, 2, 7 },
                    { 33, 3, 5 },
                    { 34, 4, 6 },
                    { 35, 5, 8 },
                    { 36, 6, 6 },
                    { 37, 7, 9 },
                    { 38, 8, 5 },
                    { 39, 9, 6 },
                    { 40, 10, 7 },
                    { 41, 1, 7 },
                    { 42, 2, 9 },
                    { 43, 3, 6 },
                    { 44, 4, 8 },
                    { 45, 5, 5 },
                    { 46, 6, 7 },
                    { 47, 7, 6 },
                    { 48, 8, 8 },
                    { 49, 9, 9 },
                    { 50, 10, 5 },
                    { 51, 1, 6 },
                    { 52, 2, 7 },
                    { 53, 3, 5 },
                    { 54, 4, 6 },
                    { 55, 5, 8 },
                    { 56, 6, 6 },
                    { 57, 7, 9 },
                    { 58, 8, 5 },
                    { 59, 9, 6 },
                    { 60, 10, 7 },
                    { 61, 1, 6 },
                    { 62, 2, 7 },
                    { 63, 3, 5 },
                    { 64, 4, 6 },
                    { 65, 5, 8 },
                    { 66, 6, 6 },
                    { 67, 7, 9 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTables",
                columns: new[] { "Id", "RestaurantId", "SeatPlaces" },
                values: new object[] { 68, 8, 5 });

            migrationBuilder.InsertData(
                table: "RestaurantTables",
                columns: new[] { "Id", "RestaurantId", "SeatPlaces" },
                values: new object[] { 69, 9, 6 });

            migrationBuilder.InsertData(
                table: "RestaurantTables",
                columns: new[] { "Id", "RestaurantId", "SeatPlaces" },
                values: new object[] { 70, 10, 7 });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryRestaurant_RestaurantsId",
                table: "CategoryRestaurant",
                column: "RestaurantsId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CustomerNumber",
                table: "Persons",
                column: "CustomerNumber",
                unique: true,
                filter: "[CustomerNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_EMail",
                table: "Persons",
                column: "EMail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_RestaurantId",
                table: "Persons",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RestaurantId",
                table: "Reservations",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RestaurantTableId",
                table: "Reservations",
                column: "RestaurantTableId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCategories_CategoryId",
                table: "RestaurantCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCategories_RestaurantId",
                table: "RestaurantCategories",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantOpeningTimes_RestaurantId",
                table: "RestaurantOpeningTimes",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_ZipCodeId",
                table: "Restaurants",
                column: "ZipCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantTables_RestaurantId",
                table: "RestaurantTables",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryRestaurant");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "RestaurantCategories");

            migrationBuilder.DropTable(
                name: "RestaurantOpeningTimes");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "RestaurantTables");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Zipcodes");
        }
    }
}
