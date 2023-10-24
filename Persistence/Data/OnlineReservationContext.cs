using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using Core.Models.User;
using Core.Models;
using Microsoft.Extensions.Configuration;

namespace Persistence.Data
{
    public class OnlineReservationContext : DbContext
    {
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Restaurant> Restaurants => Set<Restaurant>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<RestaurantCategory> RestaurantCategories => Set<RestaurantCategory>();
        public DbSet<RestaurantTable> RestaurantTables => Set<RestaurantTable>();
        public DbSet<RestaurantOpeningTime> RestaurantOpeningTimes => Set<RestaurantOpeningTime>();
        public DbSet<ZipCode> Zipcodes => Set<ZipCode>();
        public DbSet<Reservation> Reservations => Set<Reservation>();

        public DbSet<RestaurantPicture> RestaurantPictures => Set<RestaurantPicture>();

        public OnlineReservationContext(DbContextOptions<OnlineReservationContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Restaurant> restaurants = new()
            {
                new Restaurant() {
                    Id = 1,
                    Name = "La Trattoria",
                    Description = "Genießen Sie authentische italienische Küche in einer gemütlichen Atmosphäre. Von hausgemachten Pastagerichten bis hin zu frisch zubereiteten Pizzen bieten wir eine Vielzahl von Optionen für jeden Geschmack.",
                    Address = "Hauptstraße",
                    StreetNr = "123",
                    ZipCodeId = 1
                },
                new Restaurant() {
                    Id = 2,
                    Name = "Sushi Corner",
                    Description = "Tauchen Sie ein in die Welt des Sushis und erleben Sie eine Fusion aus traditionellen und modernen japanischen Geschmacksrichtungen. Unsere Sushi-Rollen und frischen Meeresfrüchte werden Sie begeistern.",
                    Address = "Bahnhofstraße",
                    StreetNr = "456",
                    ZipCodeId = 1
                },
                new Restaurant() {
                    Id = 3,
                    Name = "Le Bistro Français",
                    Description = "Lassen Sie sich von der französischen Küche verführen. Unsere raffinierten Gerichte, inspiriert von den Aromen Frankreichs, werden Ihren Gaumen verwöhnen. Genießen Sie ein Glas Wein aus unserer umfangreichen Weinkarte.",
                    Address = "Kirchplatz",
                    StreetNr = "789",
                    ZipCodeId = 1
                },
                new Restaurant() {
                    Id = 4,
                    Name = "Spice Paradise",
                    Description = "Erleben Sie die exotischen Aromen der indischen Küche in unserem Restaurant. Von würzigen Currygerichten bis hin zu köstlichen andoori-Spezialitäten bieten wir eine Vielzahl von Gerichten, die Ihre Sinne begeistern werden.",
                    Address = "Gartenweg",
                    StreetNr = "234",
                    ZipCodeId = 1
                },
                new Restaurant() {
                    Id = 5,
                    Name = "Steakhouse Deluxe",
                    Description = "Freuen Sie sich auf saftige Steaks, perfekt gegrillt nach Ihren Wünschen. Unser Steakhaus bietet eine rustikale Atmosphäre und eine Auswahl an hochwertigen Fleischsorten. Begleitet von Beilagen und Saucen wird Ihr Besuch zu einem kulinarischen Erlebnis.",
                    Address = "Marktstraße",
                    StreetNr = "567",
                    ZipCodeId = 1
                },
                new Restaurant() {
                    Id = 6,
                    Name = "Chez Pierre",
                    Description = "Chez Pierre ist ein elegantes französisches Restaurant, das sich auf klassische französische Küche spezialisiert hat. Mit einer raffinierten Atmosphäre und einer umfangreichen Weinkarte bietet Chez Pierre ein unvergessliches kulinarisches Erlebnis.",
                    Address = "Rue de la Paix",
                    StreetNr = "10",
                    ZipCodeId = 1

                },
                new Restaurant() {
                    Id = 7,
                    Name = "The Spice Garden",
                    Description = "The Spice Garden entführt Sie auf eine kulinarische Reise durch die Aromen Indiens. Von würzigen Currygerichten bis hin zu delikaten Vorspeisen bieten wir eine vielfältige Auswahl an indischen Spezialitäten, die Ihre Geschmacksknospen verzaubern werden.",
                    Address = "Main Street",
                    StreetNr = "10",
                    ZipCodeId = 1

                },
                new Restaurant() {
                    Id = 8,
                    Name = "Sushi Zen",
                    Description = "Erleben Sie den Geschmack von Mexiko bei El Rancho. Unser lebhaftes Restaurant serviert authentische mexikanische Gerichte wie Tacos, Enchiladas und frittierte Nachos, begleitet von erfrischenden Margaritas und traditionellen lateinamerikanischen Getränken.",
                    Address = "Shibuya-ku, Shibuya",
                    StreetNr = "3-1-1",
                    ZipCodeId = 1
                },
                new Restaurant() {
                    Id = 9,
                    Name = "El Rancho",
                    Description = "Erleben Sie die exotischen Aromen der indischen Küche in unserem Restaurant. Von würzigen Currygerichten bis hin zu köstlichen andoori-Spezialitäten bieten wir eine Vielzahl von Gerichten, die Ihre Sinne begeistern werden.",
                    Address = "Calle Principal",
                    StreetNr = "20",
                    ZipCodeId = 1
                },
                new Restaurant() {
                    Id = 10,
                    Name = "Bella Italia",
                    Description = "Bella Italia ist ein charmantes italienisches Restaurant, das köstliche Pasta, Pizza und Antipasti anbietet. Mit frischen Zutaten und traditionellen Rezepten möchten wir Ihnen ein Stück Italien inmitten der Stadt präsentieren.",
                    Address = "Via Roma",
                    StreetNr = "5a",
                    ZipCodeId = 1
                }
            };

            List<Category> categories = new()
            {
                new Category() { Id = 1, Name = "Italienisch" },
                new Category() { Id = 2, Name = "Französisch" },
                new Category() { Id = 3, Name = "Mexikanisch" },
                new Category() { Id = 4, Name = "Japanisch" },
                new Category() { Id = 5, Name = "Chinesisch" },
                new Category() { Id = 6, Name = "Indisch" },
                new Category() { Id = 7, Name = "Griechisch" },
                new Category() { Id = 8, Name = "Thailändisch" },
                new Category() { Id = 9, Name = "Spanisch" },
                new Category() { Id = 10, Name = "Deutsch" },
                new Category() { Id = 11, Name = "Amerikanisch" },
                new Category() { Id = 12, Name = "Brasilianisch" },
                new Category() { Id = 13, Name = "Türkisch" },
                new Category() { Id = 14, Name = "Koreanisch" },
                new Category() { Id = 15, Name = "Vietnamesisch" },
                new Category() { Id = 16, Name = "Libanesisch" },
                new Category() { Id = 17, Name = "Argentinisch" },
                new Category() { Id = 18, Name = "Vegetarisch/Vegan" },
                new Category() { Id = 19, Name = "Meeresfrüchte" },
                new Category() { Id = 20, Name = "Steakhouse" },
                new Category() { Id = 21, Name = "Pizzeria" },
                new Category() { Id = 22, Name = "Fast Food" },
                new Category() { Id = 23, Name = "Café" },
                new Category() { Id = 24, Name = "Bäckerei" },
                new Category() { Id = 25, Name = "Pub/Gastropub" },
                new Category() { Id = 26, Name = "Barbecue/Grill" },
                new Category() { Id = 27, Name = "Sushi" },
                new Category() { Id = 28, Name = "Tapas" },
                new Category() { Id = 29, Name = "Fine Dining" },
                new Category() { Id = 30, Name = "Street Food" }
            };

            List<ZipCode> zipCodes = new()
            {

                new ZipCode() {
                        Id = 1,
                        District = "Linz-Land",
                        Location = "Leonding",
                        ZipCodeNr = "4020"
                },
                new ZipCode() {
                        Id = 2,
                        District = "Linz",
                        Location = "Linz",
                        ZipCodeNr = "4020"
                },
                new ZipCode() {
                        Id = 3,
                        District = "Linz",
                        Location = "Linz",
                        ZipCodeNr = "4030"
                },
                new ZipCode() {
                        Id = 4,
                        District = "Urfahr-Umgebung",
                        Location = "Altenberg bei Linz",
                        ZipCodeNr = "4040"
                },
                new ZipCode() {
                        Id = 5,
                        District = "Urfahr-Umgebung",
                        Location = "Gramastetten",
                        ZipCodeNr = "4040"
                },
                new ZipCode() {
                        Id = 6,
                        District = "Urfahr-Umgebung",
                        Location = "Kirchschlag bei Linz",
                        ZipCodeNr = "4040"
                },
                new ZipCode() {
                        Id = 7,
                        District = "Urfahr-Umgebung",
                        Location = "Lichtenberg",
                        ZipCodeNr = "4040"
                },
                new ZipCode() {
                        Id = 8,
                        District = "Linz",
                        Location = "Linz",
                        ZipCodeNr = "4040"
                },
                new ZipCode() {
                        Id = 9,
                        District = "Urfahr-Umgebung",
                        Location = "Steyregg",
                        ZipCodeNr = "4040"
                },
                new ZipCode() {
                        Id = 10,
                        District = "Urfahr-Umgebung",
                        Location = "Puchenau",
                        ZipCodeNr = "4048"
                },
                new ZipCode() {
                        Id = 11,
                        District = "Linz-Land",
                        Location = "Traun",
                        ZipCodeNr = "4050"
                },
                new ZipCode() {
                        Id = 12,
                        District = "Linz-Land",
                        Location = "Ansfelden",
                        ZipCodeNr = "4052"
                },
                new ZipCode() {
                        Id = 13,
                        District = "Linz",
                        Location = "Linz",
                        ZipCodeNr = "4052"
                },
                new ZipCode() {
                        Id = 14,
                        District = "Linz-Land",
                        Location = "Ansfelden",
                        ZipCodeNr = "4053"
                },
                new ZipCode() {
                        Id = 15,
                        District = "Linz-Land",
                        Location = "Neuhofen an der Krems",
                        ZipCodeNr = "4053"
                },
                new ZipCode() {
                        Id = 16,
                        District = "Linz-Land",
                        Location = "Pucking",
                        ZipCodeNr = "4055"
                },
                new ZipCode() {
                        Id = 17,
                        District = "Linz-Land",
                        Location = "Leonding",
                        ZipCodeNr = "4060"
                },
                new ZipCode() {
                        Id = 18,
                        District = "Linz-Land",
                        Location = "Leonding",
                        ZipCodeNr = "4061"
                },
                new ZipCode() {
                        Id = 19,
                        District = "Linz-Land",
                        Location = "Pasching",
                        ZipCodeNr = "4061"
                },
                new ZipCode() {
                        Id = 20,
                        District = "Linz-Land",
                        Location = "Wilhering",
                        ZipCodeNr = "4061"
                },
                new ZipCode() {
                        Id = 21,
                        District = "Linz-Land",
                        Location = "Kirchberg-Thening",
                        ZipCodeNr = "4062"
                },
                new ZipCode() {
                        Id = 22,
                        District = "Linz-Land",
                        Location = "Hörsching",
                        ZipCodeNr = "4063"
                },
                new ZipCode() {
                        Id = 23,
                        District = "Linz-Land",
                        Location = "Traun",
                        ZipCodeNr = "4063"
                },
                new ZipCode() {
                        Id = 24,
                        District = "Linz-Land",
                        Location = "Oftering",
                        ZipCodeNr = "4064"
                },
                new ZipCode() {
                        Id = 25,
                        District = "Eferding",
                        Location = "Eferding",
                        ZipCodeNr = "4070"
                },
                new ZipCode() {
                        Id = 26,
                        District = "Eferding",
                        Location = "Fraham",
                        ZipCodeNr = "4070"
                },
                new ZipCode() {
                        Id = 27,
                        District = "Eferding",
                        Location = "Hartkirchen",
                        ZipCodeNr = "4070"
                },
                new ZipCode() {
                        Id = 28,
                        District = "Eferding",
                        Location = "Hinzenbach",
                        ZipCodeNr = "4070"
                },
                new ZipCode() {
                        Id = 29,
                        District = "Eferding",
                        Location = "Prambachkirchen",
                        ZipCodeNr = "4070"
                },
                new ZipCode() {
                        Id = 30,
                        District = "Eferding",
                        Location = "Pupping",
                        ZipCodeNr = "4070"
                },
                new ZipCode() {
                        Id = 31,
                        District = "Eferding",
                        Location = "Stroheim",
                        ZipCodeNr = "4070"
                },
                new ZipCode() {
                        Id = 32,
                        District = "Eferding",
                        Location = "Alkoven",
                        ZipCodeNr = "4072"
                },
                new ZipCode() {
                        Id = 33,
                        District = "Linz-Land",
                        Location = "Wilhering",
                        ZipCodeNr = "4073"
                },
                new ZipCode() {
                        Id = 34,
                        District = "Eferding",
                        Location = "Hartkirchen",
                        ZipCodeNr = "4074"
                },
                new ZipCode() {
                        Id = 35,
                        District = "Eferding",
                        Location = "Prambachkirchen",
                        ZipCodeNr = "4074"
                },
                new ZipCode() {
                        Id = 36,
                        District = "Eferding",
                        Location = "Stroheim",
                        ZipCodeNr = "4074"
                },
                new ZipCode() {
                        Id = 37,
                        District = "Eferding",
                        Location = "Fraham",
                        ZipCodeNr = "4075"
                },
                new ZipCode() {
                        Id = 38,
                        District = "Eferding",
                        Location = "St. Marienkirchen an der Polsenz",
                        ZipCodeNr = "4076"
                },
                new ZipCode() {
                        Id = 39,
                        District = "Eferding",
                        Location = "Hartkirchen",
                        ZipCodeNr = "4081"
                },
                new ZipCode() {
                        Id = 40,
                        District = "Eferding",
                        Location = "Pupping",
                        ZipCodeNr = "4081"
                },
                new ZipCode() {
                        Id = 41,
                        District = "Eferding",
                        Location = "Stroheim",
                        ZipCodeNr = "4081"
                },
                new ZipCode() {
                        Id = 42,
                        District = "Eferding",
                        Location = "Aschach an der Donau",
                        ZipCodeNr = "4082"
                },
                new ZipCode() {
                        Id = 43,
                        District = "Eferding",
                        Location = "Haibach ob der Donau",
                        ZipCodeNr = "4083"
                },
                new ZipCode() {
                        Id = 44,
                        District = "Grieskirchen",
                        Location = "St. Agatha",
                        ZipCodeNr = "4083"
                },
                new ZipCode() {
                        Id = 45,
                        District = "Grieskirchen",
                        Location = "Eschenau im Hausruckkreis",
                        ZipCodeNr = "4084"
                },
                new ZipCode() {
                        Id = 46,
                        District = "Grieskirchen",
                        Location = "St. Agatha",
                        ZipCodeNr = "4084"
                },
                new ZipCode() {
                        Id = 47,
                        District = "Grieskirchen",
                        Location = "Eschenau im Hausruckkreis",
                        ZipCodeNr = "4085"
                },
                new ZipCode() {
                        Id = 48,
                        District = "Rohrbach",
                        Location = "Hofkirchen im Mühlkreis",
                        ZipCodeNr = "4085"
                },
                new ZipCode() {
                        Id = 49,
                        District = "Rohrbach",
                        Location = "Neustift im Mühlkreis",
                        ZipCodeNr = "4085"
                },
                new ZipCode() {
                        Id = 50,
                        District = "Rohrbach",
                        Location = "Pfarrkirchen im Mühlkreis",
                        ZipCodeNr = "4085"
                },
                new ZipCode() {
                        Id = 51,
                        District = "Schärding",
                        Location = "Waldkirchen am Wesen",
                        ZipCodeNr = "4085"
                },
                new ZipCode() {
                        Id = 52,
                        District = "Schärding",
                        Location = "Engelhartszell",
                        ZipCodeNr = "4090"
                },
                new ZipCode() {
                        Id = 53,
                        District = "Schärding",
                        Location = "St. Roman",
                        ZipCodeNr = "4091"
                },
                new ZipCode() {
                        Id = 54,
                        District = "Schärding",
                        Location = "Vichtenstein",
                        ZipCodeNr = "4091"
                },
                new ZipCode() {
                        Id = 55,
                        District = "Schärding",
                        Location = "Esternberg",
                        ZipCodeNr = "4092"
                },
                new ZipCode() {
                        Id = 56,
                        District = "Urfahr-Umgebung",
                        Location = "Gramastetten",
                        ZipCodeNr = "4100"
                },
                new ZipCode() {
                        Id = 57,
                        District = "Urfahr-Umgebung",
                        Location = "Ottensheim",
                        ZipCodeNr = "4100"
                },
                new ZipCode() {
                        Id = 58,
                        District = "Urfahr-Umgebung",
                        Location = "Feldkirchen an der Donau",
                        ZipCodeNr = "4101"
                },
                new ZipCode() {
                        Id = 59,
                        District = "Urfahr-Umgebung",
                        Location = "Herzogsdorf",
                        ZipCodeNr = "4101"
                },
                new ZipCode() {
                        Id = 60,
                        District = "Urfahr-Umgebung",
                        Location = "Goldwörth",
                        ZipCodeNr = "4102"
                },
                new ZipCode() {
                        Id = 61,
                        District = "Urfahr-Umgebung",
                        Location = "Gramastetten",
                        ZipCodeNr = "4111"
                },
                new ZipCode() {
                        Id = 62,
                        District = "Urfahr-Umgebung",
                        Location = "Walding",
                        ZipCodeNr = "4111"
                },
                new ZipCode() {
                        Id = 63,
                        District = "Urfahr-Umgebung",
                        Location = "Gramastetten",
                        ZipCodeNr = "4112"
                },
                new ZipCode() {
                        Id = 64,
                        District = "Urfahr-Umgebung",
                        Location = "St. Gotthard im Mühlkreis",
                        ZipCodeNr = "4112"
                },
                new ZipCode() {
                        Id = 65,
                        District = "Urfahr-Umgebung",
                        Location = "Feldkirchen an der Donau",
                        ZipCodeNr = "4113"
                },
                new ZipCode() {
                        Id = 66,
                        District = "Rohrbach",
                        Location = "Niederwaldkirchen",
                        ZipCodeNr = "4113"
                },
                new ZipCode() {
                        Id = 67,
                        District = "Rohrbach",
                        Location = "St. Martin im Mühlkreis",
                        ZipCodeNr = "4113"
                },
                new ZipCode() {
                        Id = 68,
                        District = "Rohrbach",
                        Location = "Kirchberg ob der Donau",
                        ZipCodeNr = "4114"
                },
                new ZipCode() {
                        Id = 69,
                        District = "Rohrbach",
                        Location = "Kleinzell im Mühlkreis",
                        ZipCodeNr = "4114"
                },
                new ZipCode() {
                        Id = 70,
                        District = "Rohrbach",
                        Location = "St. Martin im Mühlkreis",
                        ZipCodeNr = "4114"
                },
                new ZipCode() {
                        Id = 71,
                        District = "Rohrbach",
                        Location = "Kirchberg ob der Donau",
                        ZipCodeNr = "4115"
                },
                new ZipCode() {
                        Id = 72,
                        District = "Rohrbach",
                        Location = "Kleinzell im Mühlkreis",
                        ZipCodeNr = "4115"
                },
                new ZipCode() {
                        Id = 73,
                        District = "Rohrbach",
                        Location = "St. Ulrich im Mühlkreis",
                        ZipCodeNr = "4116"
                },
                new ZipCode() {
                        Id = 74,
                        District = "Rohrbach",
                        Location = "Altenfelden",
                        ZipCodeNr = "4120"
                },
                new ZipCode() {
                        Id = 75,
                        District = "Rohrbach",
                        Location = "Kleinzell im Mühlkreis",
                        ZipCodeNr = "4120"
                },
                new ZipCode() {
                        Id = 76,
                        District = "Rohrbach",
                        Location = "Neufelden",
                        ZipCodeNr = "4120"
                },
                new ZipCode() {
                        Id = 77,
                        District = "Rohrbach",
                        Location = "Altenfelden",
                        ZipCodeNr = "4121"
                },
                new ZipCode() {
                        Id = 78,
                        District = "Rohrbach",
                        Location = "Arnreit",
                        ZipCodeNr = "4121"
                },
                new ZipCode() {
                        Id = 79,
                        District = "Rohrbach",
                        Location = "Hörbich",
                        ZipCodeNr = "4121"
                },
                new ZipCode() {
                        Id = 80,
                        District = "Rohrbach",
                        Location = "Neufelden",
                        ZipCodeNr = "4121"
                },
                new ZipCode() {
                        Id = 81,
                        District = "Rohrbach",
                        Location = "Arnreit",
                        ZipCodeNr = "4122"
                },
                new ZipCode() {
                        Id = 82,
                        District = "Rohrbach",
                        Location = "Kirchberg ob der Donau",
                        ZipCodeNr = "4131"
                },
                new ZipCode() {
                        Id = 83,
                        District = "Rohrbach",
                        Location = "Lembach im Mühlkreis",
                        ZipCodeNr = "4131"
                },
                new ZipCode() {
                        Id = 84,
                        District = "Rohrbach",
                        Location = "Niederkappel",
                        ZipCodeNr = "4131"
                },
                new ZipCode() {
                        Id = 85,
                        District = "Rohrbach",
                        Location = "Hörbich",
                        ZipCodeNr = "4132"
                },
                new ZipCode() {
                        Id = 86,
                        District = "Rohrbach",
                        Location = "Lembach im Mühlkreis",
                        ZipCodeNr = "4132"
                },
                new ZipCode() {
                        Id = 87,
                        District = "Rohrbach",
                        Location = "Niederkappel",
                        ZipCodeNr = "4132"
                },
                new ZipCode() {
                        Id = 88,
                        District = "Rohrbach",
                        Location = "Putzleinsdorf",
                        ZipCodeNr = "4132"
                },
                new ZipCode() {
                        Id = 89,
                        District = "Rohrbach",
                        Location = "Hofkirchen im Mühlkreis",
                        ZipCodeNr = "4133"
                },
                new ZipCode() {
                        Id = 90,
                        District = "Rohrbach",
                        Location = "Niederkappel",
                        ZipCodeNr = "4133"
                },
                new ZipCode() {
                        Id = 91,
                        District = "Rohrbach",
                        Location = "Putzleinsdorf",
                        ZipCodeNr = "4133"
                },
                new ZipCode() {
                        Id = 92,
                        District = "Rohrbach",
                        Location = "Atzesberg",
                        ZipCodeNr = "4134"
                },
                new ZipCode() {
                        Id = 93,
                        District = "Rohrbach",
                        Location = "Hörbich",
                        ZipCodeNr = "4134"
                },
                new ZipCode() {
                        Id = 94,
                        District = "Rohrbach",
                        Location = "Putzleinsdorf",
                        ZipCodeNr = "4134"
                },
                new ZipCode() {
                        Id = 95,
                        District = "Rohrbach",
                        Location = "Pfarrkirchen im Mühlkreis",
                        ZipCodeNr = "4141"
                },
                new ZipCode() {
                        Id = 96,
                        District = "Rohrbach",
                        Location = "Putzleinsdorf",
                        ZipCodeNr = "4141"
                },
                new ZipCode() {
                        Id = 97,
                        District = "Rohrbach",
                        Location = "Hofkirchen im Mühlkreis",
                        ZipCodeNr = "4142"
                },
                new ZipCode() {
                        Id = 98,
                        District = "Rohrbach",
                        Location = "Pfarrkirchen im Mühlkreis",
                        ZipCodeNr = "4142"
                },
                new ZipCode() {
                        Id = 99,
                        District = "Rohrbach",
                        Location = "Neustift im Mühlkreis",
                        ZipCodeNr = "4143"
                },
                new ZipCode() {
                        Id = 100,
                        District = "Rohrbach",
                        Location = "Neustift im Mühlkreis",
                        ZipCodeNr = "4144"
                },
                new ZipCode() {
                        Id = 101,
                        District = "Rohrbach",
                        Location = "Oberkappel",
                        ZipCodeNr = "4144"
                },
                new ZipCode() {
                        Id = 102,
                        District = "Rohrbach",
                        Location = "Pfarrkirchen im Mühlkreis",
                        ZipCodeNr = "4144"
                },
                new ZipCode() {
                        Id = 103,
                        District = "Rohrbach",
                        Location = "Rohrbach-Berg",
                        ZipCodeNr = "4150"
                },
                new ZipCode() {
                        Id = 104,
                        District = "Rohrbach",
                        Location = "Sarleinsbach",
                        ZipCodeNr = "4150"
                },
                new ZipCode() {
                        Id = 105,
                        District = "Rohrbach",
                        Location = "Oepping",
                        ZipCodeNr = "4151"
                },
                new ZipCode() {
                        Id = 106,
                        District = "Rohrbach",
                        Location = "Atzesberg",
                        ZipCodeNr = "4152"
                },
                new ZipCode() {
                        Id = 107,
                        District = "Rohrbach",
                        Location = "Hörbich",
                        ZipCodeNr = "4152"
                },
                new ZipCode() {
                        Id = 108,
                        District = "Rohrbach",
                        Location = "Kollerschlag",
                        ZipCodeNr = "4152"
                },
                new ZipCode() {
                        Id = 109,
                        District = "Rohrbach",
                        Location = "Oberkappel",
                        ZipCodeNr = "4152"
                },
                new ZipCode() {
                        Id = 110,
                        District = "Rohrbach",
                        Location = "Sarleinsbach",
                        ZipCodeNr = "4152"
                },
                new ZipCode() {
                        Id = 111,
                        District = "Rohrbach",
                        Location = "Julbach",
                        ZipCodeNr = "4153"
                },
                new ZipCode() {
                        Id = 112,
                        District = "Rohrbach",
                        Location = "Peilstein im Mühlviertel",
                        ZipCodeNr = "4153"
                },
                new ZipCode() {
                        Id = 113,
                        District = "Rohrbach",
                        Location = "Kollerschlag",
                        ZipCodeNr = "4154"
                },
                new ZipCode() {
                        Id = 114,
                        District = "Rohrbach",
                        Location = "Oberkappel",
                        ZipCodeNr = "4154"
                },
                new ZipCode() {
                        Id = 115,
                        District = "Rohrbach",
                        Location = "Julbach",
                        ZipCodeNr = "4155"
                },
                new ZipCode() {
                        Id = 116,
                        District = "Rohrbach",
                        Location = "Nebelberg",
                        ZipCodeNr = "4155"
                },
                new ZipCode() {
                        Id = 117,
                        District = "Rohrbach",
                        Location = "Aigen-Schlägl",
                        ZipCodeNr = "4160"
                },
                new ZipCode() {
                        Id = 118,
                        District = "Rohrbach",
                        Location = "Ulrichsberg",
                        ZipCodeNr = "4160"
                },
                new ZipCode() {
                        Id = 119,
                        District = "Rohrbach",
                        Location = "Aigen-Schlägl",
                        ZipCodeNr = "4161"
                },
                new ZipCode() {
                        Id = 120,
                        District = "Rohrbach",
                        Location = "Schwarzenberg am Böhmerwald",
                        ZipCodeNr = "4161"
                },
                new ZipCode() {
                        Id = 121,
                        District = "Rohrbach",
                        Location = "Ulrichsberg",
                        ZipCodeNr = "4161"
                },
                new ZipCode() {
                        Id = 122,
                        District = "Rohrbach",
                        Location = "Julbach",
                        ZipCodeNr = "4162"
                },
                new ZipCode() {
                        Id = 123,
                        District = "Rohrbach",
                        Location = "Peilstein im Mühlviertel",
                        ZipCodeNr = "4162"
                },
                new ZipCode() {
                        Id = 124,
                        District = "Rohrbach",
                        Location = "Ulrichsberg",
                        ZipCodeNr = "4162"
                },
                new ZipCode() {
                        Id = 125,
                        District = "Rohrbach",
                        Location = "Klaffer am Hochficht",
                        ZipCodeNr = "4163"
                },
                new ZipCode() {
                        Id = 126,
                        District = "Rohrbach",
                        Location = "Ulrichsberg",
                        ZipCodeNr = "4163"
                },
                new ZipCode() {
                        Id = 127,
                        District = "Rohrbach",
                        Location = "Schwarzenberg am Böhmerwald",
                        ZipCodeNr = "4164"
                },
                new ZipCode() {
                        Id = 128,
                        District = "Rohrbach",
                        Location = "Auberg",
                        ZipCodeNr = "4170"
                },
                new ZipCode() {
                        Id = 129,
                        District = "Rohrbach",
                        Location = "Haslach an der Mühl",
                        ZipCodeNr = "4170"
                },
                new ZipCode() {
                        Id = 130,
                        District = "Rohrbach",
                        Location = "Lichtenau im Mühlkreis",
                        ZipCodeNr = "4170"
                },
                new ZipCode() {
                        Id = 131,
                        District = "Rohrbach",
                        Location = "Rohrbach-Berg",
                        ZipCodeNr = "4170"
                },
                new ZipCode() {
                        Id = 132,
                        District = "Rohrbach",
                        Location = "St. Oswald bei Haslach",
                        ZipCodeNr = "4170"
                },
                new ZipCode() {
                        Id = 133,
                        District = "Rohrbach",
                        Location = "St. Peter am Wimberg",
                        ZipCodeNr = "4170"
                },
                new ZipCode() {
                        Id = 134,
                        District = "Rohrbach",
                        Location = "St. Stefan-Afiesl",
                        ZipCodeNr = "4170"
                },
                new ZipCode() {
                        Id = 135,
                        District = "Rohrbach",
                        Location = "Auberg",
                        ZipCodeNr = "4171"
                },
                new ZipCode() {
                        Id = 136,
                        District = "Rohrbach",
                        Location = "St. Peter am Wimberg",
                        ZipCodeNr = "4171"
                },
                new ZipCode() {
                        Id = 137,
                        District = "Rohrbach",
                        Location = "St. Stefan-Afiesl",
                        ZipCodeNr = "4171"
                },
                new ZipCode() {
                        Id = 138,
                        District = "Rohrbach",
                        Location = "St. Johann am Wimberg",
                        ZipCodeNr = "4172"
                },
                new ZipCode() {
                        Id = 139,
                        District = "Rohrbach",
                        Location = "St. Veit im Mühlkreis",
                        ZipCodeNr = "4173"
                },
                new ZipCode() {
                        Id = 140,
                        District = "Rohrbach",
                        Location = "Niederwaldkirchen",
                        ZipCodeNr = "4174"
                },
                new ZipCode() {
                        Id = 141,
                        District = "Rohrbach",
                        Location = "St. Veit im Mühlkreis",
                        ZipCodeNr = "4174"
                },
                new ZipCode() {
                        Id = 142,
                        District = "Urfahr-Umgebung",
                        Location = "Herzogsdorf",
                        ZipCodeNr = "4175"
                },
                new ZipCode() {
                        Id = 143,
                        District = "Rohrbach",
                        Location = "St. Veit im Mühlkreis",
                        ZipCodeNr = "4175"
                },
                new ZipCode() {
                        Id = 144,
                        District = "Urfahr-Umgebung",
                        Location = "Reichenau im Mühlkreis",
                        ZipCodeNr = "4180"
                },
                new ZipCode() {
                        Id = 145,
                        District = "Urfahr-Umgebung",
                        Location = "Sonnberg im Mühlkreis",
                        ZipCodeNr = "4180"
                },
                new ZipCode() {
                        Id = 146,
                        District = "Urfahr-Umgebung",
                        Location = "Zwettl an der Rodl",
                        ZipCodeNr = "4180"
                },
                new ZipCode() {
                        Id = 147,
                        District = "Urfahr-Umgebung",
                        Location = "Herzogsdorf",
                        ZipCodeNr = "4181"
                },
                new ZipCode() {
                        Id = 148,
                        District = "Urfahr-Umgebung",
                        Location = "Oberneukirchen",
                        ZipCodeNr = "4181"
                },
                new ZipCode() {
                        Id = 149,
                        District = "Urfahr-Umgebung",
                        Location = "Zwettl an der Rodl",
                        ZipCodeNr = "4181"
                },
                new ZipCode() {
                        Id = 150,
                        District = "Rohrbach",
                        Location = "Helfenberg",
                        ZipCodeNr = "4182"
                },
                new ZipCode() {
                        Id = 151,
                        District = "Urfahr-Umgebung",
                        Location = "Oberneukirchen",
                        ZipCodeNr = "4182"
                },
                new ZipCode() {
                        Id = 152,
                        District = "Rohrbach",
                        Location = "Helfenberg",
                        ZipCodeNr = "4183"
                },
                new ZipCode() {
                        Id = 153,
                        District = "Urfahr-Umgebung",
                        Location = "Oberneukirchen",
                        ZipCodeNr = "4183"
                },
                new ZipCode() {
                        Id = 154,
                        District = "Urfahr-Umgebung",
                        Location = "Vorderweißenbach",
                        ZipCodeNr = "4183"
                },
                new ZipCode() {
                        Id = 155,
                        District = "Rohrbach",
                        Location = "Helfenberg",
                        ZipCodeNr = "4184"
                },
                new ZipCode() {
                        Id = 156,
                        District = "Rohrbach",
                        Location = "St. Johann am Wimberg",
                        ZipCodeNr = "4184"
                },
                new ZipCode() {
                        Id = 157,
                        District = "Rohrbach",
                        Location = "St. Peter am Wimberg",
                        ZipCodeNr = "4184"
                },
                new ZipCode() {
                        Id = 158,
                        District = "Rohrbach",
                        Location = "St. Stefan-Afiesl",
                        ZipCodeNr = "4184"
                },
                new ZipCode() {
                        Id = 159,
                        District = "Urfahr-Umgebung",
                        Location = "Vorderweißenbach",
                        ZipCodeNr = "4184"
                },
                new ZipCode() {
                        Id = 160,
                        District = "Urfahr-Umgebung",
                        Location = "Bad Leonfelden",
                        ZipCodeNr = "4190"
                },
                new ZipCode() {
                        Id = 161,
                        District = "Urfahr-Umgebung",
                        Location = "Vorderweißenbach",
                        ZipCodeNr = "4190"
                },
                new ZipCode() {
                        Id = 162,
                        District = "Urfahr-Umgebung",
                        Location = "Vorderweißenbach",
                        ZipCodeNr = "4191"
                },
                new ZipCode() {
                        Id = 163,
                        District = "Freistadt",
                        Location = "Hirschbach im Mühlkreis",
                        ZipCodeNr = "4192"
                },
                new ZipCode() {
                        Id = 164,
                        District = "Urfahr-Umgebung",
                        Location = "Schenkenfelden",
                        ZipCodeNr = "4192"
                },
                new ZipCode() {
                        Id = 165,
                        District = "Freistadt",
                        Location = "Hirschbach im Mühlkreis",
                        ZipCodeNr = "4193"
                },
                new ZipCode() {
                        Id = 166,
                        District = "Freistadt",
                        Location = "Rainbach im Mühlkreis",
                        ZipCodeNr = "4193"
                },
                new ZipCode() {
                        Id = 167,
                        District = "Urfahr-Umgebung",
                        Location = "Reichenthal",
                        ZipCodeNr = "4193"
                },
                new ZipCode() {
                        Id = 168,
                        District = "Freistadt",
                        Location = "Waldburg",
                        ZipCodeNr = "4193"
                },
                new ZipCode() {
                        Id = 169,
                        District = "Urfahr-Umgebung",
                        Location = "Eidenberg",
                        ZipCodeNr = "4201"
                },
                new ZipCode() {
                        Id = 170,
                        District = "Urfahr-Umgebung",
                        Location = "Gramastetten",
                        ZipCodeNr = "4201"
                },
                new ZipCode() {
                        Id = 171,
                        District = "Urfahr-Umgebung",
                        Location = "Kirchschlag bei Linz",
                        ZipCodeNr = "4201"
                },
                new ZipCode() {
                        Id = 172,
                        District = "Urfahr-Umgebung",
                        Location = "Lichtenberg",
                        ZipCodeNr = "4201"
                },
                new ZipCode() {
                        Id = 173,
                        District = "Urfahr-Umgebung",
                        Location = "Zwettl an der Rodl",
                        ZipCodeNr = "4201"
                },
                new ZipCode() {
                        Id = 174,
                        District = "Urfahr-Umgebung",
                        Location = "Alberndorf in der Riedmark",
                        ZipCodeNr = "4202"
                },
                new ZipCode() {
                        Id = 175,
                        District = "Urfahr-Umgebung",
                        Location = "Altenberg bei Linz",
                        ZipCodeNr = "4202"
                },
                new ZipCode() {
                        Id = 176,
                        District = "Urfahr-Umgebung",
                        Location = "Eidenberg",
                        ZipCodeNr = "4202"
                },
                new ZipCode() {
                        Id = 177,
                        District = "Urfahr-Umgebung",
                        Location = "Hellmonsödt",
                        ZipCodeNr = "4202"
                },
                new ZipCode() {
                        Id = 178,
                        District = "Urfahr-Umgebung",
                        Location = "Kirchschlag bei Linz",
                        ZipCodeNr = "4202"
                },
                new ZipCode() {
                        Id = 179,
                        District = "Urfahr-Umgebung",
                        Location = "Sonnberg im Mühlkreis",
                        ZipCodeNr = "4202"
                },
                new ZipCode() {
                        Id = 180,
                        District = "Urfahr-Umgebung",
                        Location = "Altenberg bei Linz",
                        ZipCodeNr = "4203"
                },
                new ZipCode() {
                        Id = 181,
                        District = "Urfahr-Umgebung",
                        Location = "Haibach im Mühlkreis",
                        ZipCodeNr = "4204"
                },
                new ZipCode() {
                        Id = 182,
                        District = "Urfahr-Umgebung",
                        Location = "Ottenschlag im Mühlkreis",
                        ZipCodeNr = "4204"
                },
                new ZipCode() {
                        Id = 183,
                        District = "Urfahr-Umgebung",
                        Location = "Reichenau im Mühlkreis",
                        ZipCodeNr = "4204"
                },
                new ZipCode() {
                        Id = 184,
                        District = "Urfahr-Umgebung",
                        Location = "Altenberg bei Linz",
                        ZipCodeNr = "4209"
                },
                new ZipCode() {
                        Id = 185,
                        District = "Urfahr-Umgebung",
                        Location = "Engerwitzdorf",
                        ZipCodeNr = "4209"
                },
                new ZipCode() {
                        Id = 186,
                        District = "Urfahr-Umgebung",
                        Location = "Altenberg bei Linz",
                        ZipCodeNr = "4210"
                },
                new ZipCode() {
                        Id = 187,
                        District = "Urfahr-Umgebung",
                        Location = "Gallneukirchen",
                        ZipCodeNr = "4210"
                },
                new ZipCode() {
                        Id = 188,
                        District = "Urfahr-Umgebung",
                        Location = "Alberndorf in der Riedmark",
                        ZipCodeNr = "4211"
                },
                new ZipCode() {
                        Id = 189,
                        District = "Urfahr-Umgebung",
                        Location = "Altenberg bei Linz",
                        ZipCodeNr = "4211"
                },
                new ZipCode() {
                        Id = 190,
                        District = "Freistadt",
                        Location = "Neumarkt im Mühlkreis",
                        ZipCodeNr = "4211"
                },
                new ZipCode() {
                        Id = 191,
                        District = "Freistadt",
                        Location = "Kefermarkt",
                        ZipCodeNr = "4212"
                },
                new ZipCode() {
                        Id = 192,
                        District = "Freistadt",
                        Location = "Neumarkt im Mühlkreis",
                        ZipCodeNr = "4212"
                },
                new ZipCode() {
                        Id = 193,
                        District = "Freistadt",
                        Location = "Unterweitersdorf",
                        ZipCodeNr = "4213"
                },
                new ZipCode() {
                        Id = 194,
                        District = "Urfahr-Umgebung",
                        Location = "Steyregg",
                        ZipCodeNr = "4221"
                },
                new ZipCode() {
                        Id = 195,
                        District = "Urfahr-Umgebung",
                        Location = "Engerwitzdorf",
                        ZipCodeNr = "4222"
                },
                new ZipCode() {
                        Id = 196,
                        District = "Perg",
                        Location = "Langenstein",
                        ZipCodeNr = "4222"
                },
                new ZipCode() {
                        Id = 197,
                        District = "Perg",
                        Location = "St. Georgen an der Gusen",
                        ZipCodeNr = "4222"
                },
                new ZipCode() {
                        Id = 198,
                        District = "Perg",
                        Location = "Katsdorf",
                        ZipCodeNr = "4223"
                },
                new ZipCode() {
                        Id = 199,
                        District = "Perg",
                        Location = "St. Georgen an der Gusen",
                        ZipCodeNr = "4223"
                },
                new ZipCode() {
                        Id = 200,
                        District = "Perg",
                        Location = "Katsdorf",
                        ZipCodeNr = "4224"
                },
                new ZipCode() {
                        Id = 201,
                        District = "Freistadt",
                        Location = "Wartberg ob der Aist",
                        ZipCodeNr = "4224"
                },
                new ZipCode() {
                        Id = 202,
                        District = "Perg",
                        Location = "Luftenberg an der Donau",
                        ZipCodeNr = "4225"
                },
                new ZipCode() {
                        Id = 203,
                        District = "Freistadt",
                        Location = "Gutau",
                        ZipCodeNr = "4230"
                },
                new ZipCode() {
                        Id = 204,
                        District = "Freistadt",
                        Location = "Hagenberg im Mühlkreis",
                        ZipCodeNr = "4230"
                },
                new ZipCode() {
                        Id = 205,
                        District = "Freistadt",
                        Location = "Pregarten",
                        ZipCodeNr = "4230"
                },
                new ZipCode() {
                        Id = 206,
                        District = "Freistadt",
                        Location = "Tragwein",
                        ZipCodeNr = "4230"
                },
                new ZipCode() {
                        Id = 207,
                        District = "Freistadt",
                        Location = "Hagenberg im Mühlkreis",
                        ZipCodeNr = "4232"
                },
                new ZipCode() {
                        Id = 208,
                        District = "Freistadt",
                        Location = "Freistadt",
                        ZipCodeNr = "4240"
                },
                new ZipCode() {
                        Id = 209,
                        District = "Freistadt",
                        Location = "Kefermarkt",
                        ZipCodeNr = "4240"
                },
                new ZipCode() {
                        Id = 210,
                        District = "Freistadt",
                        Location = "Lasberg",
                        ZipCodeNr = "4240"
                },
                new ZipCode() {
                        Id = 211,
                        District = "Urfahr-Umgebung",
                        Location = "Reichenthal",
                        ZipCodeNr = "4240"
                },
                new ZipCode() {
                        Id = 212,
                        District = "Freistadt",
                        Location = "Waldburg",
                        ZipCodeNr = "4240"
                },
                new ZipCode() {
                        Id = 213,
                        District = "Freistadt",
                        Location = "Hirschbach im Mühlkreis",
                        ZipCodeNr = "4242"
                },
                new ZipCode() {
                        Id = 214,
                        District = "Freistadt",
                        Location = "Sandl",
                        ZipCodeNr = "4251"
                },
                new ZipCode() {
                        Id = 215,
                        District = "Freistadt",
                        Location = "Liebenau",
                        ZipCodeNr = "4252"
                },
                new ZipCode() {
                        Id = 216,
                        District = "Freistadt",
                        Location = "Grünbach",
                        ZipCodeNr = "4261"
                },
                new ZipCode() {
                        Id = 217,
                        District = "Freistadt",
                        Location = "Rainbach im Mühlkreis",
                        ZipCodeNr = "4261"
                },
                new ZipCode() {
                        Id = 218,
                        District = "Freistadt",
                        Location = "Leopoldschlag",
                        ZipCodeNr = "4262"
                },
                new ZipCode() {
                        Id = 219,
                        District = "Freistadt",
                        Location = "Sandl",
                        ZipCodeNr = "4263"
                },
                new ZipCode() {
                        Id = 220,
                        District = "Freistadt",
                        Location = "Windhaag bei Freistadt",
                        ZipCodeNr = "4263"
                },
                new ZipCode() {
                        Id = 221,
                        District = "Freistadt",
                        Location = "Grünbach",
                        ZipCodeNr = "4264"
                },
                new ZipCode() {
                        Id = 222,
                        District = "Freistadt",
                        Location = "Lasberg",
                        ZipCodeNr = "4264"
                },
                new ZipCode() {
                        Id = 223,
                        District = "Freistadt",
                        Location = "Lasberg",
                        ZipCodeNr = "4271"
                },
                new ZipCode() {
                        Id = 224,
                        District = "Freistadt",
                        Location = "St. Oswald bei Freistadt",
                        ZipCodeNr = "4271"
                },
                new ZipCode() {
                        Id = 225,
                        District = "Freistadt",
                        Location = "St. Leonhard bei Freistadt",
                        ZipCodeNr = "4272"
                },
                new ZipCode() {
                        Id = 226,
                        District = "Freistadt",
                        Location = "Weitersfelden",
                        ZipCodeNr = "4272"
                },
                new ZipCode() {
                        Id = 227,
                        District = "Freistadt",
                        Location = "Kaltenberg",
                        ZipCodeNr = "4273"
                },
                new ZipCode() {
                        Id = 228,
                        District = "Freistadt",
                        Location = "Unterweißenbach",
                        ZipCodeNr = "4273"
                },
                new ZipCode() {
                        Id = 229,
                        District = "Freistadt",
                        Location = "Bad Zell",
                        ZipCodeNr = "4274"
                },
                new ZipCode() {
                        Id = 230,
                        District = "Freistadt",
                        Location = "Pierbach",
                        ZipCodeNr = "4274"
                },
                new ZipCode() {
                        Id = 231,
                        District = "Freistadt",
                        Location = "Schönau im Mühlkreis",
                        ZipCodeNr = "4274"
                },
                new ZipCode() {
                        Id = 232,
                        District = "Freistadt",
                        Location = "Königswiesen",
                        ZipCodeNr = "4280"
                },
                new ZipCode() {
                        Id = 233,
                        District = "Freistadt",
                        Location = "Königswiesen",
                        ZipCodeNr = "4281"
                },
                new ZipCode() {
                        Id = 234,
                        District = "Perg",
                        Location = "Pabneukirchen",
                        ZipCodeNr = "4281"
                },
                new ZipCode() {
                        Id = 235,
                        District = "Freistadt",
                        Location = "Pierbach",
                        ZipCodeNr = "4281"
                },
                new ZipCode() {
                        Id = 236,
                        District = "Freistadt",
                        Location = "Königswiesen",
                        ZipCodeNr = "4282"
                },
                new ZipCode() {
                        Id = 237,
                        District = "Freistadt",
                        Location = "Pierbach",
                        ZipCodeNr = "4282"
                },
                new ZipCode() {
                        Id = 238,
                        District = "Freistadt",
                        Location = "Schönau im Mühlkreis",
                        ZipCodeNr = "4282"
                },
                new ZipCode() {
                        Id = 239,
                        District = "Perg",
                        Location = "St. Thomas am Blasenstein",
                        ZipCodeNr = "4282"
                },
                new ZipCode() {
                        Id = 240,
                        District = "Freistadt",
                        Location = "Bad Zell",
                        ZipCodeNr = "4283"
                },
                new ZipCode() {
                        Id = 241,
                        District = "Perg",
                        Location = "Allerheiligen im Mühlkreis",
                        ZipCodeNr = "4284"
                },
                new ZipCode() {
                        Id = 242,
                        District = "Freistadt",
                        Location = "Tragwein",
                        ZipCodeNr = "4284"
                },
                new ZipCode() {
                        Id = 243,
                        District = "Freistadt",
                        Location = "Kefermarkt",
                        ZipCodeNr = "4291"
                },
                new ZipCode() {
                        Id = 244,
                        District = "Freistadt",
                        Location = "Lasberg",
                        ZipCodeNr = "4291"
                },
                new ZipCode() {
                        Id = 245,
                        District = "Freistadt",
                        Location = "Gutau",
                        ZipCodeNr = "4292"
                },
                new ZipCode() {
                        Id = 246,
                        District = "Freistadt",
                        Location = "Kefermarkt",
                        ZipCodeNr = "4292"
                },
                new ZipCode() {
                        Id = 247,
                        District = "Freistadt",
                        Location = "Lasberg",
                        ZipCodeNr = "4292"
                },
                new ZipCode() {
                        Id = 248,
                        District = "Freistadt",
                        Location = "Pregarten",
                        ZipCodeNr = "4292"
                },
                new ZipCode() {
                        Id = 249,
                        District = "Freistadt",
                        Location = "Bad Zell",
                        ZipCodeNr = "4293"
                },
                new ZipCode() {
                        Id = 250,
                        District = "Freistadt",
                        Location = "Gutau",
                        ZipCodeNr = "4293"
                },
                new ZipCode() {
                        Id = 251,
                        District = "Freistadt",
                        Location = "Schönau im Mühlkreis",
                        ZipCodeNr = "4293"
                },
                new ZipCode() {
                        Id = 252,
                        District = "Freistadt",
                        Location = "St. Leonhard bei Freistadt",
                        ZipCodeNr = "4293"
                },
                new ZipCode() {
                        Id = 253,
                        District = "Freistadt",
                        Location = "Tragwein",
                        ZipCodeNr = "4293"
                },
                new ZipCode() {
                        Id = 254,
                        District = "Freistadt",
                        Location = "Gutau",
                        ZipCodeNr = "4294"
                },
                new ZipCode() {
                        Id = 255,
                        District = "Freistadt",
                        Location = "Schönau im Mühlkreis",
                        ZipCodeNr = "4294"
                },
                new ZipCode() {
                        Id = 256,
                        District = "Freistadt",
                        Location = "St. Leonhard bei Freistadt",
                        ZipCodeNr = "4294"
                },
                new ZipCode() {
                        Id = 257,
                        District = "Freistadt",
                        Location = "St. Oswald bei Freistadt",
                        ZipCodeNr = "4294"
                },
                new ZipCode() {
                        Id = 258,
                        District = "Amstetten",
                        Location = "Ernsthofen",
                        ZipCodeNr = "4300"
                },
                new ZipCode() {
                        Id = 259,
                        District = "Amstetten",
                        Location = "St. Valentin",
                        ZipCodeNr = "4300"
                },
                new ZipCode() {
                        Id = 260,
                        District = "Amstetten",
                        Location = "St. Pantaleon-Erla",
                        ZipCodeNr = "4303"
                },
                new ZipCode() {
                        Id = 261,
                        District = "Perg",
                        Location = "Langenstein",
                        ZipCodeNr = "4310"
                },
                new ZipCode() {
                        Id = 262,
                        District = "Perg",
                        Location = "Mauthausen",
                        ZipCodeNr = "4310"
                },
                new ZipCode() {
                        Id = 263,
                        District = "Perg",
                        Location = "Naarn im Machlande",
                        ZipCodeNr = "4311"
                },
                new ZipCode() {
                        Id = 264,
                        District = "Perg",
                        Location = "Ried in der Riedmark",
                        ZipCodeNr = "4311"
                },
                new ZipCode() {
                        Id = 265,
                        District = "Perg",
                        Location = "Schwertberg",
                        ZipCodeNr = "4311"
                },
                new ZipCode() {
                        Id = 266,
                        District = "Freistadt",
                        Location = "Tragwein",
                        ZipCodeNr = "4311"
                },
                new ZipCode() {
                        Id = 267,
                        District = "Perg",
                        Location = "Langenstein",
                        ZipCodeNr = "4312"
                },
                new ZipCode() {
                        Id = 268,
                        District = "Perg",
                        Location = "Mauthausen",
                        ZipCodeNr = "4312"
                },
                new ZipCode() {
                        Id = 269,
                        District = "Perg",
                        Location = "Ried in der Riedmark",
                        ZipCodeNr = "4312"
                },
                new ZipCode() {
                        Id = 270,
                        District = "Perg",
                        Location = "Schwertberg",
                        ZipCodeNr = "4312"
                },
                new ZipCode() {
                        Id = 271,
                        District = "Perg",
                        Location = "Allerheiligen im Mühlkreis",
                        ZipCodeNr = "4320"
                },
                new ZipCode() {
                        Id = 272,
                        District = "Perg",
                        Location = "Naarn im Machlande",
                        ZipCodeNr = "4320"
                },
                new ZipCode() {
                        Id = 273,
                        District = "Perg",
                        Location = "Perg",
                        ZipCodeNr = "4320"
                },
                new ZipCode() {
                        Id = 274,
                        District = "Perg",
                        Location = "Windhaag bei Perg",
                        ZipCodeNr = "4320"
                },
                new ZipCode() {
                        Id = 275,
                        District = "Perg",
                        Location = "St. Thomas am Blasenstein",
                        ZipCodeNr = "4322"
                },
                new ZipCode() {
                        Id = 276,
                        District = "Perg",
                        Location = "Windhaag bei Perg",
                        ZipCodeNr = "4322"
                },
                new ZipCode() {
                        Id = 277,
                        District = "Perg",
                        Location = "Arbing",
                        ZipCodeNr = "4323"
                },
                new ZipCode() {
                        Id = 278,
                        District = "Perg",
                        Location = "Bad Kreuzen",
                        ZipCodeNr = "4323"
                },
                new ZipCode() {
                        Id = 279,
                        District = "Perg",
                        Location = "Münzbach",
                        ZipCodeNr = "4323"
                },
                new ZipCode() {
                        Id = 280,
                        District = "Perg",
                        Location = "Rechberg",
                        ZipCodeNr = "4323"
                },
                new ZipCode() {
                        Id = 281,
                        District = "Perg",
                        Location = "Windhaag bei Perg",
                        ZipCodeNr = "4323"
                },
                new ZipCode() {
                        Id = 282,
                        District = "Perg",
                        Location = "Rechberg",
                        ZipCodeNr = "4324"
                },
                new ZipCode() {
                        Id = 283,
                        District = "Perg",
                        Location = "Naarn im Machlande",
                        ZipCodeNr = "4331"
                },
                new ZipCode() {
                        Id = 284,
                        District = "Perg",
                        Location = "Naarn im Machlande",
                        ZipCodeNr = "4332"
                },
                new ZipCode() {
                        Id = 285,
                        District = "Perg",
                        Location = "Arbing",
                        ZipCodeNr = "4341"
                },
                new ZipCode() {
                        Id = 286,
                        District = "Perg",
                        Location = "Baumgartenberg",
                        ZipCodeNr = "4341"
                },
                new ZipCode() {
                        Id = 287,
                        District = "Perg",
                        Location = "Arbing",
                        ZipCodeNr = "4342"
                },
                new ZipCode() {
                        Id = 288,
                        District = "Perg",
                        Location = "Baumgartenberg",
                        ZipCodeNr = "4342"
                },
                new ZipCode() {
                        Id = 289,
                        District = "Perg",
                        Location = "Münzbach",
                        ZipCodeNr = "4342"
                },
                new ZipCode() {
                        Id = 290,
                        District = "Perg",
                        Location = "Mitterkirchen im Machland",
                        ZipCodeNr = "4343"
                },
                new ZipCode() {
                        Id = 291,
                        District = "Perg",
                        Location = "Baumgartenberg",
                        ZipCodeNr = "4351"
                },
                new ZipCode() {
                        Id = 292,
                        District = "Perg",
                        Location = "Saxen",
                        ZipCodeNr = "4351"
                },
                new ZipCode() {
                        Id = 293,
                        District = "Perg",
                        Location = "Bad Kreuzen",
                        ZipCodeNr = "4352"
                },
                new ZipCode() {
                        Id = 294,
                        District = "Perg",
                        Location = "Klam",
                        ZipCodeNr = "4352"
                },
                new ZipCode() {
                        Id = 295,
                        District = "Perg",
                        Location = "Münzbach",
                        ZipCodeNr = "4352"
                },
                new ZipCode() {
                        Id = 296,
                        District = "Perg",
                        Location = "Saxen",
                        ZipCodeNr = "4352"
                },
                new ZipCode() {
                        Id = 297,
                        District = "Perg",
                        Location = "Bad Kreuzen",
                        ZipCodeNr = "4360"
                },
                new ZipCode() {
                        Id = 298,
                        District = "Perg",
                        Location = "Grein",
                        ZipCodeNr = "4360"
                },
                new ZipCode() {
                        Id = 299,
                        District = "Perg",
                        Location = "Waldhausen im Strudengau",
                        ZipCodeNr = "4360"
                },
                new ZipCode() {
                        Id = 300,
                        District = "Perg",
                        Location = "Bad Kreuzen",
                        ZipCodeNr = "4362"
                },
                new ZipCode() {
                        Id = 301,
                        District = "Perg",
                        Location = "Pabneukirchen",
                        ZipCodeNr = "4362"
                },
                new ZipCode() {
                        Id = 302,
                        District = "Perg",
                        Location = "St. Thomas am Blasenstein",
                        ZipCodeNr = "4362"
                },
                new ZipCode() {
                        Id = 303,
                        District = "Perg",
                        Location = "Pabneukirchen",
                        ZipCodeNr = "4363"
                },
                new ZipCode() {
                        Id = 304,
                        District = "Perg",
                        Location = "St. Thomas am Blasenstein",
                        ZipCodeNr = "4363"
                },
                new ZipCode() {
                        Id = 305,
                        District = "Perg",
                        Location = "St. Thomas am Blasenstein",
                        ZipCodeNr = "4364"
                },
                new ZipCode() {
                        Id = 306,
                        District = "Perg",
                        Location = "Dimbach",
                        ZipCodeNr = "4371"
                },
                new ZipCode() {
                        Id = 307,
                        District = "Perg",
                        Location = "Pabneukirchen",
                        ZipCodeNr = "4371"
                },
                new ZipCode() {
                        Id = 308,
                        District = "Perg",
                        Location = "St. Georgen am Walde",
                        ZipCodeNr = "4371"
                },
                new ZipCode() {
                        Id = 309,
                        District = "Zwettl",
                        Location = "Altmelon",
                        ZipCodeNr = "4372"
                },
                new ZipCode() {
                        Id = 310,
                        District = "Perg",
                        Location = "Pabneukirchen",
                        ZipCodeNr = "4372"
                },
                new ZipCode() {
                        Id = 311,
                        District = "Perg",
                        Location = "St. Georgen am Walde",
                        ZipCodeNr = "4372"
                },
                new ZipCode() {
                        Id = 312,
                        District = "Perg",
                        Location = "St. Nikola an der Donau",
                        ZipCodeNr = "4381"
                },
                new ZipCode() {
                        Id = 313,
                        District = "Perg",
                        Location = "St. Nikola an der Donau",
                        ZipCodeNr = "4382"
                },
                new ZipCode() {
                        Id = 314,
                        District = "Perg",
                        Location = "Waldhausen im Strudengau",
                        ZipCodeNr = "4382"
                },
                new ZipCode() {
                        Id = 315,
                        District = "Perg",
                        Location = "Waldhausen im Strudengau",
                        ZipCodeNr = "4391"
                },
                new ZipCode() {
                        Id = 316,
                        District = "Melk",
                        Location = "Dorfstetten",
                        ZipCodeNr = "4392"
                },
                new ZipCode() {
                        Id = 317,
                        District = "Perg",
                        Location = "Waldhausen im Strudengau",
                        ZipCodeNr = "4392"
                },
                new ZipCode() {
                        Id = 318,
                        District = "Steyr-Land",
                        Location = "Garsten",
                        ZipCodeNr = "4400"
                },
                new ZipCode() {
                        Id = 319,
                        District = "Steyr-Land",
                        Location = "St. Ulrich bei Steyr",
                        ZipCodeNr = "4400"
                },
                new ZipCode() {
                        Id = 320,
                        District = "Steyr",
                        Location = "Steyr",
                        ZipCodeNr = "4400"
                },
                new ZipCode() {
                        Id = 321,
                        District = "Steyr-Land",
                        Location = "Dietach",
                        ZipCodeNr = "4407"
                },
                new ZipCode() {
                        Id = 322,
                        District = "Steyr",
                        Location = "Steyr",
                        ZipCodeNr = "4407"
                },
                new ZipCode() {
                        Id = 323,
                        District = "Steyr-Land",
                        Location = "Aschach an der Steyr",
                        ZipCodeNr = "4421"
                },
                new ZipCode() {
                        Id = 324,
                        District = "Kirchdorf",
                        Location = "Steinbach an der Steyr",
                        ZipCodeNr = "4421"
                },
                new ZipCode() {
                        Id = 325,
                        District = "Amstetten",
                        Location = "Haidershofen",
                        ZipCodeNr = "4431"
                },
                new ZipCode() {
                        Id = 326,
                        District = "Amstetten",
                        Location = "Ernsthofen",
                        ZipCodeNr = "4432"
                },
                new ZipCode() {
                        Id = 327,
                        District = "Amstetten",
                        Location = "Behamberg",
                        ZipCodeNr = "4441"
                },
                new ZipCode() {
                        Id = 328,
                        District = "Steyr-Land",
                        Location = "Maria Neustift",
                        ZipCodeNr = "4442"
                },
                new ZipCode() {
                        Id = 329,
                        District = "Amstetten",
                        Location = "St. Peter in der Au",
                        ZipCodeNr = "4442"
                },
                new ZipCode() {
                        Id = 330,
                        District = "Steyr-Land",
                        Location = "St. Ulrich bei Steyr",
                        ZipCodeNr = "4442"
                },
                new ZipCode() {
                        Id = 331,
                        District = "Steyr-Land",
                        Location = "Großraming",
                        ZipCodeNr = "4443"
                },
                new ZipCode() {
                        Id = 332,
                        District = "Steyr-Land",
                        Location = "Maria Neustift",
                        ZipCodeNr = "4443"
                },
                new ZipCode() {
                        Id = 333,
                        District = "Amstetten",
                        Location = "St. Peter in der Au",
                        ZipCodeNr = "4443"
                },
                new ZipCode() {
                        Id = 334,
                        District = "Steyr-Land",
                        Location = "St. Ulrich bei Steyr",
                        ZipCodeNr = "4443"
                },
                new ZipCode() {
                        Id = 335,
                        District = "Steyr-Land",
                        Location = "Garsten",
                        ZipCodeNr = "4451"
                },
                new ZipCode() {
                        Id = 336,
                        District = "Steyr-Land",
                        Location = "St. Ulrich bei Steyr",
                        ZipCodeNr = "4451"
                },
                new ZipCode() {
                        Id = 337,
                        District = "Steyr",
                        Location = "Steyr",
                        ZipCodeNr = "4451"
                },
                new ZipCode() {
                        Id = 338,
                        District = "Steyr-Land",
                        Location = "Ternberg",
                        ZipCodeNr = "4451"
                },
                new ZipCode() {
                        Id = 339,
                        District = "Steyr-Land",
                        Location = "Ternberg",
                        ZipCodeNr = "4452"
                },
                new ZipCode() {
                        Id = 340,
                        District = "Steyr-Land",
                        Location = "Ternberg",
                        ZipCodeNr = "4453"
                },
                new ZipCode() {
                        Id = 341,
                        District = "Steyr-Land",
                        Location = "Laussa",
                        ZipCodeNr = "4460"
                },
                new ZipCode() {
                        Id = 342,
                        District = "Steyr-Land",
                        Location = "Losenstein",
                        ZipCodeNr = "4460"
                },
                new ZipCode() {
                        Id = 343,
                        District = "Steyr-Land",
                        Location = "Garsten",
                        ZipCodeNr = "4461"
                },
                new ZipCode() {
                        Id = 344,
                        District = "Steyr-Land",
                        Location = "Laussa",
                        ZipCodeNr = "4461"
                },
                new ZipCode() {
                        Id = 345,
                        District = "Steyr-Land",
                        Location = "Reichraming",
                        ZipCodeNr = "4462"
                },
                new ZipCode() {
                        Id = 346,
                        District = "Steyr-Land",
                        Location = "Großraming",
                        ZipCodeNr = "4463"
                },
                new ZipCode() {
                        Id = 347,
                        District = "Steyr-Land",
                        Location = "Laussa",
                        ZipCodeNr = "4463"
                },
                new ZipCode() {
                        Id = 348,
                        District = "Steyr-Land",
                        Location = "Weyer",
                        ZipCodeNr = "4464"
                },
                new ZipCode() {
                        Id = 349,
                        District = "Linz-Land",
                        Location = "Enns",
                        ZipCodeNr = "4470"
                },
                new ZipCode() {
                        Id = 350,
                        District = "Linz-Land",
                        Location = "Kronstorf",
                        ZipCodeNr = "4470"
                },
                new ZipCode() {
                        Id = 351,
                        District = "Linz-Land",
                        Location = "Asten",
                        ZipCodeNr = "4481"
                },
                new ZipCode() {
                        Id = 352,
                        District = "Linz-Land",
                        Location = "Enns",
                        ZipCodeNr = "4481"
                },
                new ZipCode() {
                        Id = 353,
                        District = "Perg",
                        Location = "Luftenberg an der Donau",
                        ZipCodeNr = "4481"
                },
                new ZipCode() {
                        Id = 354,
                        District = "Amstetten",
                        Location = "Ennsdorf",
                        ZipCodeNr = "4482"
                },
                new ZipCode() {
                        Id = 355,
                        District = "Amstetten",
                        Location = "St. Valentin",
                        ZipCodeNr = "4482"
                },
                new ZipCode() {
                        Id = 356,
                        District = "Linz-Land",
                        Location = "Hargelsberg",
                        ZipCodeNr = "4483"
                },
                new ZipCode() {
                        Id = 357,
                        District = "Linz-Land",
                        Location = "Kronstorf",
                        ZipCodeNr = "4483"
                },
                new ZipCode() {
                        Id = 358,
                        District = "Steyr-Land",
                        Location = "Dietach",
                        ZipCodeNr = "4484"
                },
                new ZipCode() {
                        Id = 359,
                        District = "Linz-Land",
                        Location = "Hargelsberg",
                        ZipCodeNr = "4484"
                },
                new ZipCode() {
                        Id = 360,
                        District = "Linz-Land",
                        Location = "Kronstorf",
                        ZipCodeNr = "4484"
                },
                new ZipCode() {
                        Id = 361,
                        District = "Linz-Land",
                        Location = "St. Florian",
                        ZipCodeNr = "4490"
                },
                new ZipCode() {
                        Id = 362,
                        District = "Linz-Land",
                        Location = "Hofkirchen im Traunkreis",
                        ZipCodeNr = "4491"
                },
                new ZipCode() {
                        Id = 363,
                        District = "Linz-Land",
                        Location = "Niederneukirchen",
                        ZipCodeNr = "4491"
                },
                new ZipCode() {
                        Id = 364,
                        District = "Linz-Land",
                        Location = "St. Marien",
                        ZipCodeNr = "4491"
                },
                new ZipCode() {
                        Id = 365,
                        District = "Linz-Land",
                        Location = "Hofkirchen im Traunkreis",
                        ZipCodeNr = "4492"
                },
                new ZipCode() {
                        Id = 366,
                        District = "Steyr-Land",
                        Location = "Schiedlberg",
                        ZipCodeNr = "4493"
                },
                new ZipCode() {
                        Id = 367,
                        District = "Steyr-Land",
                        Location = "Wolfern",
                        ZipCodeNr = "4493"
                },
                new ZipCode() {
                        Id = 368,
                        District = "Linz-Land",
                        Location = "Neuhofen an der Krems",
                        ZipCodeNr = "4501"
                },
                new ZipCode() {
                        Id = 369,
                        District = "Linz-Land",
                        Location = "St. Marien",
                        ZipCodeNr = "4502"
                },
                new ZipCode() {
                        Id = 370,
                        District = "Linz-Land",
                        Location = "Allhaming",
                        ZipCodeNr = "4511"
                },
                new ZipCode() {
                        Id = 371,
                        District = "Linz-Land",
                        Location = "Neuhofen an der Krems",
                        ZipCodeNr = "4511"
                },
                new ZipCode() {
                        Id = 372,
                        District = "Steyr-Land",
                        Location = "Schiedlberg",
                        ZipCodeNr = "4521"
                },
                new ZipCode() {
                        Id = 373,
                        District = "Linz-Land",
                        Location = "St. Marien",
                        ZipCodeNr = "4521"
                },
                new ZipCode() {
                        Id = 374,
                        District = "Steyr-Land",
                        Location = "Schiedlberg",
                        ZipCodeNr = "4522"
                },
                new ZipCode() {
                        Id = 375,
                        District = "Steyr-Land",
                        Location = "Sierning",
                        ZipCodeNr = "4522"
                },
                new ZipCode() {
                        Id = 376,
                        District = "Steyr-Land",
                        Location = "Aschach an der Steyr",
                        ZipCodeNr = "4523"
                },
                new ZipCode() {
                        Id = 377,
                        District = "Steyr-Land",
                        Location = "Garsten",
                        ZipCodeNr = "4523"
                },
                new ZipCode() {
                        Id = 378,
                        District = "Steyr-Land",
                        Location = "Sierning",
                        ZipCodeNr = "4523"
                },
                new ZipCode() {
                        Id = 379,
                        District = "Linz-Land",
                        Location = "Kematen an der Krems",
                        ZipCodeNr = "4531"
                },
                new ZipCode() {
                        Id = 380,
                        District = "Linz-Land",
                        Location = "Neuhofen an der Krems",
                        ZipCodeNr = "4531"
                },
                new ZipCode() {
                        Id = 381,
                        District = "Steyr-Land",
                        Location = "Sierning",
                        ZipCodeNr = "4531"
                },
                new ZipCode() {
                        Id = 382,
                        District = "Linz-Land",
                        Location = "Kematen an der Krems",
                        ZipCodeNr = "4532"
                },
                new ZipCode() {
                        Id = 383,
                        District = "Kirchdorf",
                        Location = "Kremsmünster",
                        ZipCodeNr = "4532"
                },
                new ZipCode() {
                        Id = 384,
                        District = "Steyr-Land",
                        Location = "Rohr im Kremstal",
                        ZipCodeNr = "4532"
                },
                new ZipCode() {
                        Id = 385,
                        District = "Linz-Land",
                        Location = "Piberbach",
                        ZipCodeNr = "4533"
                },
                new ZipCode() {
                        Id = 386,
                        District = "Steyr-Land",
                        Location = "Adlwang",
                        ZipCodeNr = "4540"
                },
                new ZipCode() {
                        Id = 387,
                        District = "Steyr-Land",
                        Location = "Bad Hall",
                        ZipCodeNr = "4540"
                },
                new ZipCode() {
                        Id = 388,
                        District = "Kirchdorf",
                        Location = "Kremsmünster",
                        ZipCodeNr = "4540"
                },
                new ZipCode() {
                        Id = 389,
                        District = "Steyr-Land",
                        Location = "Pfarrkirchen bei Bad Hall",
                        ZipCodeNr = "4540"
                },
                new ZipCode() {
                        Id = 390,
                        District = "Steyr-Land",
                        Location = "Adlwang",
                        ZipCodeNr = "4541"
                },
                new ZipCode() {
                        Id = 391,
                        District = "Kirchdorf",
                        Location = "Nußbach",
                        ZipCodeNr = "4542"
                },
                new ZipCode() {
                        Id = 392,
                        District = "Linz-Land",
                        Location = "Kematen an der Krems",
                        ZipCodeNr = "4550"
                },
                new ZipCode() {
                        Id = 393,
                        District = "Kirchdorf",
                        Location = "Kremsmünster",
                        ZipCodeNr = "4550"
                },
                new ZipCode() {
                        Id = 394,
                        District = "Steyr-Land",
                        Location = "Rohr im Kremstal",
                        ZipCodeNr = "4550"
                },
                new ZipCode() {
                        Id = 395,
                        District = "Kirchdorf",
                        Location = "Ried im Traunkreis",
                        ZipCodeNr = "4551"
                },
                new ZipCode() {
                        Id = 396,
                        District = "Steyr-Land",
                        Location = "Pfarrkirchen bei Bad Hall",
                        ZipCodeNr = "4552"
                },
                new ZipCode() {
                        Id = 397,
                        District = "Kirchdorf",
                        Location = "Wartberg an der Krems",
                        ZipCodeNr = "4552"
                },
                new ZipCode() {
                        Id = 398,
                        District = "Kirchdorf",
                        Location = "Schlierbach",
                        ZipCodeNr = "4553"
                },
                new ZipCode() {
                        Id = 399,
                        District = "Kirchdorf",
                        Location = "Oberschlierbach",
                        ZipCodeNr = "4554"
                },
                new ZipCode() {
                        Id = 400,
                        District = "Kirchdorf",
                        Location = "Kirchdorf an der Krems",
                        ZipCodeNr = "4560"
                },
                new ZipCode() {
                        Id = 401,
                        District = "Kirchdorf",
                        Location = "Steinbach am Ziehberg",
                        ZipCodeNr = "4562"
                },
                new ZipCode() {
                        Id = 402,
                        District = "Kirchdorf",
                        Location = "Kirchdorf an der Krems",
                        ZipCodeNr = "4563"
                },
                new ZipCode() {
                        Id = 403,
                        District = "Kirchdorf",
                        Location = "Micheldorf in Oberösterreich",
                        ZipCodeNr = "4563"
                },
                new ZipCode() {
                        Id = 404,
                        District = "Kirchdorf",
                        Location = "Klaus an der Pyhrnbahn",
                        ZipCodeNr = "4564"
                },
                new ZipCode() {
                        Id = 405,
                        District = "Kirchdorf",
                        Location = "Inzersdorf im Kremstal",
                        ZipCodeNr = "4565"
                },
                new ZipCode() {
                        Id = 406,
                        District = "Kirchdorf",
                        Location = "Klaus an der Pyhrnbahn",
                        ZipCodeNr = "4571"
                },
                new ZipCode() {
                        Id = 407,
                        District = "Kirchdorf",
                        Location = "Hinterstoder",
                        ZipCodeNr = "4572"
                },
                new ZipCode() {
                        Id = 408,
                        District = "Kirchdorf",
                        Location = "Klaus an der Pyhrnbahn",
                        ZipCodeNr = "4572"
                },
                new ZipCode() {
                        Id = 409,
                        District = "Kirchdorf",
                        Location = "St. Pankraz",
                        ZipCodeNr = "4572"
                },
                new ZipCode() {
                        Id = 410,
                        District = "Kirchdorf",
                        Location = "Hinterstoder",
                        ZipCodeNr = "4573"
                },
                new ZipCode() {
                        Id = 411,
                        District = "Kirchdorf",
                        Location = "Hinterstoder",
                        ZipCodeNr = "4574"
                },
                new ZipCode() {
                        Id = 412,
                        District = "Kirchdorf",
                        Location = "Vorderstoder",
                        ZipCodeNr = "4574"
                },
                new ZipCode() {
                        Id = 413,
                        District = "Kirchdorf",
                        Location = "Roßleithen",
                        ZipCodeNr = "4575"
                },
                new ZipCode() {
                        Id = 414,
                        District = "Kirchdorf",
                        Location = "Edlbach",
                        ZipCodeNr = "4580"
                },
                new ZipCode() {
                        Id = 415,
                        District = "Kirchdorf",
                        Location = "Windischgarsten",
                        ZipCodeNr = "4580"
                },
                new ZipCode() {
                        Id = 416,
                        District = "Kirchdorf",
                        Location = "Edlbach",
                        ZipCodeNr = "4581"
                },
                new ZipCode() {
                        Id = 417,
                        District = "Kirchdorf",
                        Location = "Rosenau am Hengstpaß",
                        ZipCodeNr = "4581"
                },
                new ZipCode() {
                        Id = 418,
                        District = "Kirchdorf",
                        Location = "Edlbach",
                        ZipCodeNr = "4582"
                },
                new ZipCode() {
                        Id = 419,
                        District = "Kirchdorf",
                        Location = "Spital am Pyhrn",
                        ZipCodeNr = "4582"
                },
                new ZipCode() {
                        Id = 420,
                        District = "Kirchdorf",
                        Location = "Molln",
                        ZipCodeNr = "4591"
                },
                new ZipCode() {
                        Id = 421,
                        District = "Kirchdorf",
                        Location = "Rosenau am Hengstpaß",
                        ZipCodeNr = "4591"
                },
                new ZipCode() {
                        Id = 422,
                        District = "Kirchdorf",
                        Location = "Grünburg",
                        ZipCodeNr = "4592"
                },
                new ZipCode() {
                        Id = 423,
                        District = "Kirchdorf",
                        Location = "Grünburg",
                        ZipCodeNr = "4593"
                },
                new ZipCode() {
                        Id = 424,
                        District = "Steyr-Land",
                        Location = "Aschach an der Steyr",
                        ZipCodeNr = "4594"
                },
                new ZipCode() {
                        Id = 425,
                        District = "Kirchdorf",
                        Location = "Grünburg",
                        ZipCodeNr = "4594"
                },
                new ZipCode() {
                        Id = 426,
                        District = "Kirchdorf",
                        Location = "Steinbach an der Steyr",
                        ZipCodeNr = "4594"
                },
                new ZipCode() {
                        Id = 427,
                        District = "Steyr-Land",
                        Location = "Waldneukirchen",
                        ZipCodeNr = "4595"
                },
                new ZipCode() {
                        Id = 428,
                        District = "Kirchdorf",
                        Location = "Steinbach an der Steyr",
                        ZipCodeNr = "4596"
                },
                new ZipCode() {
                        Id = 429,
                        District = "Steyr-Land",
                        Location = "Ternberg",
                        ZipCodeNr = "4596"
                },
                new ZipCode() {
                        Id = 430,
                        District = "Wels-Land",
                        Location = "Schleißheim",
                        ZipCodeNr = "4600"
                },
                new ZipCode() {
                        Id = 431,
                        District = "Wels-Land",
                        Location = "Thalheim bei Wels",
                        ZipCodeNr = "4600"
                },
                new ZipCode() {
                        Id = 432,
                        District = "Wels",
                        Location = "Wels",
                        ZipCodeNr = "4600"
                },
                new ZipCode() {
                        Id = 433,
                        District = "Wels-Land",
                        Location = "Buchkirchen",
                        ZipCodeNr = "4611"
                },
                new ZipCode() {
                        Id = 434,
                        District = "Grieskirchen",
                        Location = "Wallern an der Trattnach",
                        ZipCodeNr = "4611"
                },
                new ZipCode() {
                        Id = 435,
                        District = "Wels-Land",
                        Location = "Buchkirchen",
                        ZipCodeNr = "4612"
                },
                new ZipCode() {
                        Id = 436,
                        District = "Eferding",
                        Location = "Scharten",
                        ZipCodeNr = "4612"
                },
                new ZipCode() {
                        Id = 437,
                        District = "Wels-Land",
                        Location = "Buchkirchen",
                        ZipCodeNr = "4613"
                },
                new ZipCode() {
                        Id = 438,
                        District = "Wels-Land",
                        Location = "Marchtrenk",
                        ZipCodeNr = "4614"
                },
                new ZipCode() {
                        Id = 439,
                        District = "Wels-Land",
                        Location = "Holzhausen",
                        ZipCodeNr = "4615"
                },
                new ZipCode() {
                        Id = 440,
                        District = "Linz-Land",
                        Location = "Eggendorf im Traunkreis",
                        ZipCodeNr = "4616"
                },
                new ZipCode() {
                        Id = 441,
                        District = "Wels-Land",
                        Location = "Weißkirchen an der Traun",
                        ZipCodeNr = "4616"
                },
                new ZipCode() {
                        Id = 442,
                        District = "Kirchdorf",
                        Location = "Kremsmünster",
                        ZipCodeNr = "4621"
                },
                new ZipCode() {
                        Id = 443,
                        District = "Wels-Land",
                        Location = "Sipbachzell",
                        ZipCodeNr = "4621"
                },
                new ZipCode() {
                        Id = 444,
                        District = "Linz-Land",
                        Location = "Eggendorf im Traunkreis",
                        ZipCodeNr = "4622"
                },
                new ZipCode() {
                        Id = 445,
                        District = "Wels-Land",
                        Location = "Gunskirchen",
                        ZipCodeNr = "4623"
                },
                new ZipCode() {
                        Id = 446,
                        District = "Wels-Land",
                        Location = "Offenhausen",
                        ZipCodeNr = "4624"
                },
                new ZipCode() {
                        Id = 447,
                        District = "Wels-Land",
                        Location = "Pennewang",
                        ZipCodeNr = "4624"
                },
                new ZipCode() {
                        Id = 448,
                        District = "Grieskirchen",
                        Location = "Meggenhofen",
                        ZipCodeNr = "4625"
                },
                new ZipCode() {
                        Id = 449,
                        District = "Wels-Land",
                        Location = "Offenhausen",
                        ZipCodeNr = "4625"
                },
                new ZipCode() {
                        Id = 450,
                        District = "Wels-Land",
                        Location = "Pennewang",
                        ZipCodeNr = "4625"
                },
                new ZipCode() {
                        Id = 451,
                        District = "Wels-Land",
                        Location = "Buchkirchen",
                        ZipCodeNr = "4631"
                },
                new ZipCode() {
                        Id = 452,
                        District = "Wels-Land",
                        Location = "Krenglbach",
                        ZipCodeNr = "4631"
                },
                new ZipCode() {
                        Id = 453,
                        District = "Wels-Land",
                        Location = "Pichl bei Wels",
                        ZipCodeNr = "4631"
                },
                new ZipCode() {
                        Id = 454,
                        District = "Grieskirchen",
                        Location = "Wallern an der Trattnach",
                        ZipCodeNr = "4631"
                },
                new ZipCode() {
                        Id = 455,
                        District = "Grieskirchen",
                        Location = "Kematen am Innbach",
                        ZipCodeNr = "4632"
                },
                new ZipCode() {
                        Id = 456,
                        District = "Wels-Land",
                        Location = "Pichl bei Wels",
                        ZipCodeNr = "4632"
                },
                new ZipCode() {
                        Id = 457,
                        District = "Grieskirchen",
                        Location = "Schlüßlberg",
                        ZipCodeNr = "4632"
                },
                new ZipCode() {
                        Id = 458,
                        District = "Grieskirchen",
                        Location = "Kematen am Innbach",
                        ZipCodeNr = "4633"
                },
                new ZipCode() {
                        Id = 459,
                        District = "Wels-Land",
                        Location = "Pichl bei Wels",
                        ZipCodeNr = "4633"
                },
                new ZipCode() {
                        Id = 460,
                        District = "Wels-Land",
                        Location = "Fischlham",
                        ZipCodeNr = "4641"
                },
                new ZipCode() {
                        Id = 461,
                        District = "Wels-Land",
                        Location = "Steinhaus",
                        ZipCodeNr = "4641"
                },
                new ZipCode() {
                        Id = 462,
                        District = "Wels-Land",
                        Location = "Sattledt",
                        ZipCodeNr = "4642"
                },
                new ZipCode() {
                        Id = 463,
                        District = "Wels-Land",
                        Location = "Eberstalzell",
                        ZipCodeNr = "4643"
                },
                new ZipCode() {
                        Id = 464,
                        District = "Kirchdorf",
                        Location = "Pettenbach",
                        ZipCodeNr = "4643"
                },
                new ZipCode() {
                        Id = 465,
                        District = "Kirchdorf",
                        Location = "Ried im Traunkreis",
                        ZipCodeNr = "4643"
                },
                new ZipCode() {
                        Id = 466,
                        District = "Kirchdorf",
                        Location = "Steinbach am Ziehberg",
                        ZipCodeNr = "4643"
                },
                new ZipCode() {
                        Id = 467,
                        District = "Gmunden",
                        Location = "Grünau im Almtal",
                        ZipCodeNr = "4644"
                },
                new ZipCode() {
                        Id = 468,
                        District = "Gmunden",
                        Location = "Scharnstein",
                        ZipCodeNr = "4644"
                },
                new ZipCode() {
                        Id = 469,
                        District = "Gmunden",
                        Location = "St. Konrad",
                        ZipCodeNr = "4644"
                },
                new ZipCode() {
                        Id = 470,
                        District = "Gmunden",
                        Location = "Grünau im Almtal",
                        ZipCodeNr = "4645"
                },
                new ZipCode() {
                        Id = 471,
                        District = "Gmunden",
                        Location = "Scharnstein",
                        ZipCodeNr = "4645"
                },
                new ZipCode() {
                        Id = 472,
                        District = "Wels-Land",
                        Location = "Edt bei Lambach",
                        ZipCodeNr = "4650"
                },
                new ZipCode() {
                        Id = 473,
                        District = "Wels-Land",
                        Location = "Gunskirchen",
                        ZipCodeNr = "4650"
                },
                new ZipCode() {
                        Id = 474,
                        District = "Wels-Land",
                        Location = "Lambach",
                        ZipCodeNr = "4650"
                },
                new ZipCode() {
                        Id = 475,
                        District = "Wels-Land",
                        Location = "Stadl-Paura",
                        ZipCodeNr = "4651"
                },
                new ZipCode() {
                        Id = 476,
                        District = "Wels-Land",
                        Location = "Fischlham",
                        ZipCodeNr = "4652"
                },
                new ZipCode() {
                        Id = 477,
                        District = "Wels-Land",
                        Location = "Steinerkirchen an der Traun",
                        ZipCodeNr = "4652"
                },
                new ZipCode() {
                        Id = 478,
                        District = "Wels-Land",
                        Location = "Eberstalzell",
                        ZipCodeNr = "4653"
                },
                new ZipCode() {
                        Id = 479,
                        District = "Gmunden",
                        Location = "Vorchdorf",
                        ZipCodeNr = "4653"
                },
                new ZipCode() {
                        Id = 480,
                        District = "Wels-Land",
                        Location = "Bad Wimsbach-Neydharting",
                        ZipCodeNr = "4654"
                },
                new ZipCode() {
                        Id = 481,
                        District = "Gmunden",
                        Location = "Roitham am Traunfall",
                        ZipCodeNr = "4655"
                },
                new ZipCode() {
                        Id = 482,
                        District = "Wels-Land",
                        Location = "Steinerkirchen an der Traun",
                        ZipCodeNr = "4655"
                },
                new ZipCode() {
                        Id = 483,
                        District = "Gmunden",
                        Location = "Vorchdorf",
                        ZipCodeNr = "4655"
                },
                new ZipCode() {
                        Id = 484,
                        District = "Gmunden",
                        Location = "Kirchham",
                        ZipCodeNr = "4656"
                },
                new ZipCode() {
                        Id = 485,
                        District = "Gmunden",
                        Location = "Laakirchen",
                        ZipCodeNr = "4656"
                },
                new ZipCode() {
                        Id = 486,
                        District = "Gmunden",
                        Location = "Roitham am Traunfall",
                        ZipCodeNr = "4661"
                },
                new ZipCode() {
                        Id = 487,
                        District = "Gmunden",
                        Location = "Laakirchen",
                        ZipCodeNr = "4662"
                },
                new ZipCode() {
                        Id = 488,
                        District = "Gmunden",
                        Location = "Laakirchen",
                        ZipCodeNr = "4663"
                },
                new ZipCode() {
                        Id = 489,
                        District = "Gmunden",
                        Location = "Gschwandt",
                        ZipCodeNr = "4664"
                },
                new ZipCode() {
                        Id = 490,
                        District = "Gmunden",
                        Location = "Laakirchen",
                        ZipCodeNr = "4664"
                },
                new ZipCode() {
                        Id = 491,
                        District = "Wels-Land",
                        Location = "Aichkirchen",
                        ZipCodeNr = "4671"
                },
                new ZipCode() {
                        Id = 492,
                        District = "Wels-Land",
                        Location = "Neukirchen bei Lambach",
                        ZipCodeNr = "4671"
                },
                new ZipCode() {
                        Id = 493,
                        District = "Wels-Land",
                        Location = "Bachmanning",
                        ZipCodeNr = "4672"
                },
                new ZipCode() {
                        Id = 494,
                        District = "Grieskirchen",
                        Location = "Meggenhofen",
                        ZipCodeNr = "4672"
                },
                new ZipCode() {
                        Id = 495,
                        District = "Wels-Land",
                        Location = "Pennewang",
                        ZipCodeNr = "4672"
                },
                new ZipCode() {
                        Id = 496,
                        District = "Grieskirchen",
                        Location = "Gaspoltshofen",
                        ZipCodeNr = "4673"
                },
                new ZipCode() {
                        Id = 497,
                        District = "Grieskirchen",
                        Location = "Gaspoltshofen",
                        ZipCodeNr = "4674"
                },
                new ZipCode() {
                        Id = 498,
                        District = "Grieskirchen",
                        Location = "Weibern",
                        ZipCodeNr = "4675"
                },
                new ZipCode() {
                        Id = 499,
                        District = "Grieskirchen",
                        Location = "Aistersheim",
                        ZipCodeNr = "4676"
                },
                new ZipCode() {
                        Id = 500,
                        District = "Grieskirchen",
                        Location = "Gaspoltshofen",
                        ZipCodeNr = "4676"
                },
                new ZipCode() {
                        Id = 501,
                        District = "Ried",
                        Location = "Geiersberg",
                        ZipCodeNr = "4680"
                },
                new ZipCode() {
                        Id = 502,
                        District = "Grieskirchen",
                        Location = "Haag am Hausruck",
                        ZipCodeNr = "4680"
                },
                new ZipCode() {
                        Id = 503,
                        District = "Grieskirchen",
                        Location = "Weibern",
                        ZipCodeNr = "4680"
                },
                new ZipCode() {
                        Id = 504,
                        District = "Grieskirchen",
                        Location = "Rottenbach",
                        ZipCodeNr = "4681"
                },
                new ZipCode() {
                        Id = 505,
                        District = "Grieskirchen",
                        Location = "Gaspoltshofen",
                        ZipCodeNr = "4682"
                },
                new ZipCode() {
                        Id = 506,
                        District = "Grieskirchen",
                        Location = "Geboltskirchen",
                        ZipCodeNr = "4682"
                },
                new ZipCode() {
                        Id = 507,
                        District = "Vöcklabruck",
                        Location = "Oberndorf bei Schwanenstadt",
                        ZipCodeNr = "4690"
                },
                new ZipCode() {
                        Id = 508,
                        District = "Vöcklabruck",
                        Location = "Pitzenberg",
                        ZipCodeNr = "4690"
                },
                new ZipCode() {
                        Id = 509,
                        District = "Vöcklabruck",
                        Location = "Pühret",
                        ZipCodeNr = "4690"
                },
                new ZipCode() {
                        Id = 510,
                        District = "Vöcklabruck",
                        Location = "Rüstorf",
                        ZipCodeNr = "4690"
                },
                new ZipCode() {
                        Id = 511,
                        District = "Vöcklabruck",
                        Location = "Rutzenham",
                        ZipCodeNr = "4690"
                },
                new ZipCode() {
                        Id = 512,
                        District = "Vöcklabruck",
                        Location = "Schlatt",
                        ZipCodeNr = "4690"
                },
                new ZipCode() {
                        Id = 513,
                        District = "Vöcklabruck",
                        Location = "Schwanenstadt",
                        ZipCodeNr = "4690"
                },
                new ZipCode() {
                        Id = 514,
                        District = "Wels-Land",
                        Location = "Stadl-Paura",
                        ZipCodeNr = "4690"
                },
                new ZipCode() {
                        Id = 515,
                        District = "Vöcklabruck",
                        Location = "Niederthalheim",
                        ZipCodeNr = "4691"
                },
                new ZipCode() {
                        Id = 516,
                        District = "Vöcklabruck",
                        Location = "Schlatt",
                        ZipCodeNr = "4691"
                },
                new ZipCode() {
                        Id = 517,
                        District = "Grieskirchen",
                        Location = "Gaspoltshofen",
                        ZipCodeNr = "4692"
                },
                new ZipCode() {
                        Id = 518,
                        District = "Vöcklabruck",
                        Location = "Niederthalheim",
                        ZipCodeNr = "4692"
                },
                new ZipCode() {
                        Id = 519,
                        District = "Vöcklabruck",
                        Location = "Desselbrunn",
                        ZipCodeNr = "4693"
                },
                new ZipCode() {
                        Id = 520,
                        District = "Vöcklabruck",
                        Location = "Rüstorf",
                        ZipCodeNr = "4693"
                },
                new ZipCode() {
                        Id = 521,
                        District = "Gmunden",
                        Location = "Ohlsdorf",
                        ZipCodeNr = "4694"
                },
                new ZipCode() {
                        Id = 522,
                        District = "Grieskirchen",
                        Location = "Bad Schallerbach",
                        ZipCodeNr = "4701"
                },
                new ZipCode() {
                        Id = 523,
                        District = "Wels-Land",
                        Location = "Pichl bei Wels",
                        ZipCodeNr = "4701"
                },
                new ZipCode() {
                        Id = 524,
                        District = "Grieskirchen",
                        Location = "Wallern an der Trattnach",
                        ZipCodeNr = "4701"
                },
                new ZipCode() {
                        Id = 525,
                        District = "Grieskirchen",
                        Location = "Bad Schallerbach",
                        ZipCodeNr = "4702"
                },
                new ZipCode() {
                        Id = 526,
                        District = "Wels-Land",
                        Location = "Krenglbach",
                        ZipCodeNr = "4702"
                },
                new ZipCode() {
                        Id = 527,
                        District = "Wels-Land",
                        Location = "Pichl bei Wels",
                        ZipCodeNr = "4702"
                },
                new ZipCode() {
                        Id = 528,
                        District = "Grieskirchen",
                        Location = "Wallern an der Trattnach",
                        ZipCodeNr = "4702"
                },
                new ZipCode() {
                        Id = 529,
                        District = "Grieskirchen",
                        Location = "Grieskirchen",
                        ZipCodeNr = "4707"
                },
                new ZipCode() {
                        Id = 530,
                        District = "Grieskirchen",
                        Location = "Schlüßlberg",
                        ZipCodeNr = "4707"
                },
                new ZipCode() {
                        Id = 531,
                        District = "Grieskirchen",
                        Location = "Grieskirchen",
                        ZipCodeNr = "4710"
                },
                new ZipCode() {
                        Id = 532,
                        District = "Grieskirchen",
                        Location = "Pollham",
                        ZipCodeNr = "4710"
                },
                new ZipCode() {
                        Id = 533,
                        District = "Grieskirchen",
                        Location = "St. Georgen bei Grieskirchen",
                        ZipCodeNr = "4710"
                },
                new ZipCode() {
                        Id = 534,
                        District = "Grieskirchen",
                        Location = "Tollet",
                        ZipCodeNr = "4710"
                },
                new ZipCode() {
                        Id = 535,
                        District = "Grieskirchen",
                        Location = "Michaelnbach",
                        ZipCodeNr = "4712"
                },
                new ZipCode() {
                        Id = 536,
                        District = "Grieskirchen",
                        Location = "Tollet",
                        ZipCodeNr = "4712"
                },
                new ZipCode() {
                        Id = 537,
                        District = "Grieskirchen",
                        Location = "Waizenkirchen",
                        ZipCodeNr = "4712"
                },
                new ZipCode() {
                        Id = 538,
                        District = "Grieskirchen",
                        Location = "Gallspach",
                        ZipCodeNr = "4713"
                },
                new ZipCode() {
                        Id = 539,
                        District = "Grieskirchen",
                        Location = "Grieskirchen",
                        ZipCodeNr = "4713"
                },
                new ZipCode() {
                        Id = 540,
                        District = "Grieskirchen",
                        Location = "Kematen am Innbach",
                        ZipCodeNr = "4713"
                },
                new ZipCode() {
                        Id = 541,
                        District = "Grieskirchen",
                        Location = "Schlüßlberg",
                        ZipCodeNr = "4713"
                },
                new ZipCode() {
                        Id = 542,
                        District = "Grieskirchen",
                        Location = "St. Georgen bei Grieskirchen",
                        ZipCodeNr = "4713"
                },
                new ZipCode() {
                        Id = 543,
                        District = "Grieskirchen",
                        Location = "Gaspoltshofen",
                        ZipCodeNr = "4714"
                },
                new ZipCode() {
                        Id = 544,
                        District = "Grieskirchen",
                        Location = "Meggenhofen",
                        ZipCodeNr = "4714"
                },
                new ZipCode() {
                        Id = 545,
                        District = "Wels-Land",
                        Location = "Offenhausen",
                        ZipCodeNr = "4714"
                },
                new ZipCode() {
                        Id = 546,
                        District = "Grieskirchen",
                        Location = "St. Georgen bei Grieskirchen",
                        ZipCodeNr = "4715"
                },
                new ZipCode() {
                        Id = 547,
                        District = "Grieskirchen",
                        Location = "Taufkirchen an der Trattnach",
                        ZipCodeNr = "4715"
                },
                new ZipCode() {
                        Id = 548,
                        District = "Grieskirchen",
                        Location = "Tollet",
                        ZipCodeNr = "4715"
                },
                new ZipCode() {
                        Id = 549,
                        District = "Grieskirchen",
                        Location = "Hofkirchen an der Trattnach",
                        ZipCodeNr = "4716"
                },
                new ZipCode() {
                        Id = 550,
                        District = "Grieskirchen",
                        Location = "Kallham",
                        ZipCodeNr = "4720"
                },
                new ZipCode() {
                        Id = 551,
                        District = "Grieskirchen",
                        Location = "Michaelnbach",
                        ZipCodeNr = "4720"
                },
                new ZipCode() {
                        Id = 552,
                        District = "Grieskirchen",
                        Location = "Neumarkt im Hausruckkreis",
                        ZipCodeNr = "4720"
                },
                new ZipCode() {
                        Id = 553,
                        District = "Grieskirchen",
                        Location = "Pötting",
                        ZipCodeNr = "4720"
                },
                new ZipCode() {
                        Id = 554,
                        District = "Grieskirchen",
                        Location = "Wendling",
                        ZipCodeNr = "4720"
                },
                new ZipCode() {
                        Id = 555,
                        District = "Schärding",
                        Location = "Altschwendt",
                        ZipCodeNr = "4721"
                },
                new ZipCode() {
                        Id = 556,
                        District = "Grieskirchen",
                        Location = "Neukirchen am Walde",
                        ZipCodeNr = "4722"
                },
                new ZipCode() {
                        Id = 557,
                        District = "Grieskirchen",
                        Location = "Peuerbach",
                        ZipCodeNr = "4722"
                },
                new ZipCode() {
                        Id = 558,
                        District = "Grieskirchen",
                        Location = "Steegen",
                        ZipCodeNr = "4722"
                },
                new ZipCode() {
                        Id = 559,
                        District = "Schärding",
                        Location = "Kopfing im Innkreis",
                        ZipCodeNr = "4723"
                },
                new ZipCode() {
                        Id = 560,
                        District = "Grieskirchen",
                        Location = "Natternbach",
                        ZipCodeNr = "4723"
                },
                new ZipCode() {
                        Id = 561,
                        District = "Grieskirchen",
                        Location = "Eschenau im Hausruckkreis",
                        ZipCodeNr = "4724"
                },
                new ZipCode() {
                        Id = 562,
                        District = "Grieskirchen",
                        Location = "Neukirchen am Walde",
                        ZipCodeNr = "4724"
                },
                new ZipCode() {
                        Id = 563,
                        District = "Schärding",
                        Location = "Waldkirchen am Wesen",
                        ZipCodeNr = "4724"
                },
                new ZipCode() {
                        Id = 564,
                        District = "Schärding",
                        Location = "Engelhartszell",
                        ZipCodeNr = "4725"
                },
                new ZipCode() {
                        Id = 565,
                        District = "Schärding",
                        Location = "Kopfing im Innkreis",
                        ZipCodeNr = "4725"
                },
                new ZipCode() {
                        Id = 566,
                        District = "Schärding",
                        Location = "St. Aegidi",
                        ZipCodeNr = "4725"
                },
                new ZipCode() {
                        Id = 567,
                        District = "Schärding",
                        Location = "St. Roman",
                        ZipCodeNr = "4725"
                },
                new ZipCode() {
                        Id = 568,
                        District = "Eferding",
                        Location = "Prambachkirchen",
                        ZipCodeNr = "4730"
                },
                new ZipCode() {
                        Id = 569,
                        District = "Grieskirchen",
                        Location = "St. Agatha",
                        ZipCodeNr = "4730"
                },
                new ZipCode() {
                        Id = 570,
                        District = "Eferding",
                        Location = "Stroheim",
                        ZipCodeNr = "4730"
                },
                new ZipCode() {
                        Id = 571,
                        District = "Grieskirchen",
                        Location = "Waizenkirchen",
                        ZipCodeNr = "4730"
                },
                new ZipCode() {
                        Id = 572,
                        District = "Eferding",
                        Location = "Prambachkirchen",
                        ZipCodeNr = "4731"
                },
                new ZipCode() {
                        Id = 573,
                        District = "Eferding",
                        Location = "Stroheim",
                        ZipCodeNr = "4731"
                },
                new ZipCode() {
                        Id = 574,
                        District = "Grieskirchen",
                        Location = "Waizenkirchen",
                        ZipCodeNr = "4731"
                },
                new ZipCode() {
                        Id = 575,
                        District = "Grieskirchen",
                        Location = "Pollham",
                        ZipCodeNr = "4732"
                },
                new ZipCode() {
                        Id = 576,
                        District = "Eferding",
                        Location = "Prambachkirchen",
                        ZipCodeNr = "4732"
                },
                new ZipCode() {
                        Id = 577,
                        District = "Eferding",
                        Location = "St. Marienkirchen an der Polsenz",
                        ZipCodeNr = "4732"
                },
                new ZipCode() {
                        Id = 578,
                        District = "Grieskirchen",
                        Location = "St. Thomas",
                        ZipCodeNr = "4732"
                },
                new ZipCode() {
                        Id = 579,
                        District = "Grieskirchen",
                        Location = "Heiligenberg",
                        ZipCodeNr = "4733"
                },
                new ZipCode() {
                        Id = 580,
                        District = "Grieskirchen",
                        Location = "Hofkirchen an der Trattnach",
                        ZipCodeNr = "4741"
                },
                new ZipCode() {
                        Id = 581,
                        District = "Grieskirchen",
                        Location = "Rottenbach",
                        ZipCodeNr = "4741"
                },
                new ZipCode() {
                        Id = 582,
                        District = "Grieskirchen",
                        Location = "Wendling",
                        ZipCodeNr = "4741"
                },
                new ZipCode() {
                        Id = 583,
                        District = "Grieskirchen",
                        Location = "Pram",
                        ZipCodeNr = "4742"
                },
                new ZipCode() {
                        Id = 584,
                        District = "Ried",
                        Location = "Peterskirchen",
                        ZipCodeNr = "4743"
                },
                new ZipCode() {
                        Id = 585,
                        District = "Schärding",
                        Location = "Dorf an der Pram",
                        ZipCodeNr = "4751"
                },
                new ZipCode() {
                        Id = 586,
                        District = "Ried",
                        Location = "Taiskirchen im Innkreis",
                        ZipCodeNr = "4751"
                },
                new ZipCode() {
                        Id = 587,
                        District = "Ried",
                        Location = "Lambrechten",
                        ZipCodeNr = "4752"
                },
                new ZipCode() {
                        Id = 588,
                        District = "Schärding",
                        Location = "Riedau",
                        ZipCodeNr = "4752"
                },
                new ZipCode() {
                        Id = 589,
                        District = "Ried",
                        Location = "Lambrechten",
                        ZipCodeNr = "4753"
                },
                new ZipCode() {
                        Id = 590,
                        District = "Ried",
                        Location = "Taiskirchen im Innkreis",
                        ZipCodeNr = "4753"
                },
                new ZipCode() {
                        Id = 591,
                        District = "Ried",
                        Location = "Andrichsfurt",
                        ZipCodeNr = "4754"
                },
                new ZipCode() {
                        Id = 592,
                        District = "Ried",
                        Location = "Peterskirchen",
                        ZipCodeNr = "4754"
                },
                new ZipCode() {
                        Id = 593,
                        District = "Ried",
                        Location = "Utzenaich",
                        ZipCodeNr = "4754"
                },
                new ZipCode() {
                        Id = 594,
                        District = "Schärding",
                        Location = "Altschwendt",
                        ZipCodeNr = "4755"
                },
                new ZipCode() {
                        Id = 595,
                        District = "Schärding",
                        Location = "Zell an der Pram",
                        ZipCodeNr = "4755"
                },
                new ZipCode() {
                        Id = 596,
                        District = "Schärding",
                        Location = "Raab",
                        ZipCodeNr = "4760"
                },
                new ZipCode() {
                        Id = 597,
                        District = "Schärding",
                        Location = "St. Willibald",
                        ZipCodeNr = "4760"
                },
                new ZipCode() {
                        Id = 598,
                        District = "Schärding",
                        Location = "Enzenkirchen",
                        ZipCodeNr = "4761"
                },
                new ZipCode() {
                        Id = 599,
                        District = "Schärding",
                        Location = "Enzenkirchen",
                        ZipCodeNr = "4762"
                },
                new ZipCode() {
                        Id = 600,
                        District = "Grieskirchen",
                        Location = "Natternbach",
                        ZipCodeNr = "4762"
                },
                new ZipCode() {
                        Id = 601,
                        District = "Schärding",
                        Location = "St. Willibald",
                        ZipCodeNr = "4762"
                },
                new ZipCode() {
                        Id = 602,
                        District = "Schärding",
                        Location = "Andorf",
                        ZipCodeNr = "4770"
                },
                new ZipCode() {
                        Id = 603,
                        District = "Schärding",
                        Location = "Enzenkirchen",
                        ZipCodeNr = "4771"
                },
                new ZipCode() {
                        Id = 604,
                        District = "Schärding",
                        Location = "Sigharting",
                        ZipCodeNr = "4771"
                },
                new ZipCode() {
                        Id = 605,
                        District = "Schärding",
                        Location = "Andorf",
                        ZipCodeNr = "4772"
                },
                new ZipCode() {
                        Id = 606,
                        District = "Ried",
                        Location = "Lambrechten",
                        ZipCodeNr = "4772"
                },
                new ZipCode() {
                        Id = 607,
                        District = "Ried",
                        Location = "Utzenaich",
                        ZipCodeNr = "4772"
                },
                new ZipCode() {
                        Id = 608,
                        District = "Schärding",
                        Location = "Eggerding",
                        ZipCodeNr = "4773"
                },
                new ZipCode() {
                        Id = 609,
                        District = "Schärding",
                        Location = "St. Marienkirchen bei Schärding",
                        ZipCodeNr = "4773"
                },
                new ZipCode() {
                        Id = 610,
                        District = "Schärding",
                        Location = "St. Marienkirchen bei Schärding",
                        ZipCodeNr = "4774"
                },
                new ZipCode() {
                        Id = 611,
                        District = "Schärding",
                        Location = "Taufkirchen an der Pram",
                        ZipCodeNr = "4774"
                },
                new ZipCode() {
                        Id = 612,
                        District = "Schärding",
                        Location = "Eggerding",
                        ZipCodeNr = "4775"
                },
                new ZipCode() {
                        Id = 613,
                        District = "Schärding",
                        Location = "Taufkirchen an der Pram",
                        ZipCodeNr = "4775"
                },
                new ZipCode() {
                        Id = 614,
                        District = "Schärding",
                        Location = "Diersbach",
                        ZipCodeNr = "4776"
                },
                new ZipCode() {
                        Id = 615,
                        District = "Schärding",
                        Location = "Rainbach im Innkreis",
                        ZipCodeNr = "4776"
                },
                new ZipCode() {
                        Id = 616,
                        District = "Schärding",
                        Location = "Mayrhof",
                        ZipCodeNr = "4777"
                },
                new ZipCode() {
                        Id = 617,
                        District = "Schärding",
                        Location = "Schärding",
                        ZipCodeNr = "4780"
                },
                new ZipCode() {
                        Id = 618,
                        District = "Schärding",
                        Location = "St. Florian am Inn",
                        ZipCodeNr = "4782"
                },
                new ZipCode() {
                        Id = 619,
                        District = "Schärding",
                        Location = "Schardenberg",
                        ZipCodeNr = "4783"
                },
                new ZipCode() {
                        Id = 620,
                        District = "Schärding",
                        Location = "Wernstein am Inn",
                        ZipCodeNr = "4783"
                },
                new ZipCode() {
                        Id = 621,
                        District = "Schärding",
                        Location = "Schardenberg",
                        ZipCodeNr = "4784"
                },
                new ZipCode() {
                        Id = 622,
                        District = "Schärding",
                        Location = "Wernstein am Inn",
                        ZipCodeNr = "4784"
                },
                new ZipCode() {
                        Id = 623,
                        District = "Schärding",
                        Location = "Freinberg",
                        ZipCodeNr = "4785"
                },
                new ZipCode() {
                        Id = 624,
                        District = "Schärding",
                        Location = "Schardenberg",
                        ZipCodeNr = "4785"
                },
                new ZipCode() {
                        Id = 625,
                        District = "Schärding",
                        Location = "Brunnenthal",
                        ZipCodeNr = "4786"
                },
                new ZipCode() {
                        Id = 626,
                        District = "Schärding",
                        Location = "Rainbach im Innkreis",
                        ZipCodeNr = "4791"
                },
                new ZipCode() {
                        Id = 627,
                        District = "Schärding",
                        Location = "Schardenberg",
                        ZipCodeNr = "4791"
                },
                new ZipCode() {
                        Id = 628,
                        District = "Schärding",
                        Location = "Taufkirchen an der Pram",
                        ZipCodeNr = "4791"
                },
                new ZipCode() {
                        Id = 629,
                        District = "Schärding",
                        Location = "Münzkirchen",
                        ZipCodeNr = "4792"
                },
                new ZipCode() {
                        Id = 630,
                        District = "Schärding",
                        Location = "Schardenberg",
                        ZipCodeNr = "4792"
                },
                new ZipCode() {
                        Id = 631,
                        District = "Schärding",
                        Location = "St. Roman",
                        ZipCodeNr = "4792"
                },
                new ZipCode() {
                        Id = 632,
                        District = "Schärding",
                        Location = "Kopfing im Innkreis",
                        ZipCodeNr = "4793"
                },
                new ZipCode() {
                        Id = 633,
                        District = "Schärding",
                        Location = "St. Roman",
                        ZipCodeNr = "4793"
                },
                new ZipCode() {
                        Id = 634,
                        District = "Schärding",
                        Location = "Enzenkirchen",
                        ZipCodeNr = "4794"
                },
                new ZipCode() {
                        Id = 635,
                        District = "Schärding",
                        Location = "Kopfing im Innkreis",
                        ZipCodeNr = "4794"
                },
                new ZipCode() {
                        Id = 636,
                        District = "Schärding",
                        Location = "St. Aegidi",
                        ZipCodeNr = "4794"
                },
                new ZipCode() {
                        Id = 637,
                        District = "Vöcklabruck",
                        Location = "Attnang-Puchheim",
                        ZipCodeNr = "4800"
                },
                new ZipCode() {
                        Id = 638,
                        District = "Vöcklabruck",
                        Location = "Desselbrunn",
                        ZipCodeNr = "4800"
                },
                new ZipCode() {
                        Id = 639,
                        District = "Vöcklabruck",
                        Location = "Pilsbach",
                        ZipCodeNr = "4800"
                },
                new ZipCode() {
                        Id = 640,
                        District = "Vöcklabruck",
                        Location = "Pühret",
                        ZipCodeNr = "4800"
                },
                new ZipCode() {
                        Id = 641,
                        District = "Vöcklabruck",
                        Location = "Regau",
                        ZipCodeNr = "4800"
                },
                new ZipCode() {
                        Id = 642,
                        District = "Gmunden",
                        Location = "Altmünster",
                        ZipCodeNr = "4801"
                },
                new ZipCode() {
                        Id = 643,
                        District = "Gmunden",
                        Location = "Traunkirchen",
                        ZipCodeNr = "4801"
                },
                new ZipCode() {
                        Id = 644,
                        District = "Gmunden",
                        Location = "Ebensee am Traunsee",
                        ZipCodeNr = "4802"
                },
                new ZipCode() {
                        Id = 645,
                        District = "Gmunden",
                        Location = "Altmünster",
                        ZipCodeNr = "4810"
                },
                new ZipCode() {
                        Id = 646,
                        District = "Gmunden",
                        Location = "Gmunden",
                        ZipCodeNr = "4810"
                },
                new ZipCode() {
                        Id = 647,
                        District = "Gmunden",
                        Location = "Gschwandt",
                        ZipCodeNr = "4810"
                },
                new ZipCode() {
                        Id = 648,
                        District = "Gmunden",
                        Location = "Pinsdorf",
                        ZipCodeNr = "4810"
                },
                new ZipCode() {
                        Id = 649,
                        District = "Gmunden",
                        Location = "Altmünster",
                        ZipCodeNr = "4812"
                },
                new ZipCode() {
                        Id = 650,
                        District = "Gmunden",
                        Location = "Pinsdorf",
                        ZipCodeNr = "4812"
                },
                new ZipCode() {
                        Id = 651,
                        District = "Vöcklabruck",
                        Location = "Regau",
                        ZipCodeNr = "4812"
                },
                new ZipCode() {
                        Id = 652,
                        District = "Gmunden",
                        Location = "Altmünster",
                        ZipCodeNr = "4813"
                },
                new ZipCode() {
                        Id = 653,
                        District = "Gmunden",
                        Location = "Altmünster",
                        ZipCodeNr = "4814"
                },
                new ZipCode() {
                        Id = 654,
                        District = "Vöcklabruck",
                        Location = "Aurach am Hongar",
                        ZipCodeNr = "4814"
                },
                new ZipCode() {
                        Id = 655,
                        District = "Gmunden",
                        Location = "Gschwandt",
                        ZipCodeNr = "4816"
                },
                new ZipCode() {
                        Id = 656,
                        District = "Gmunden",
                        Location = "Laakirchen",
                        ZipCodeNr = "4816"
                },
                new ZipCode() {
                        Id = 657,
                        District = "Gmunden",
                        Location = "Gschwandt",
                        ZipCodeNr = "4817"
                },
                new ZipCode() {
                        Id = 658,
                        District = "Gmunden",
                        Location = "Kirchham",
                        ZipCodeNr = "4817"
                },
                new ZipCode() {
                        Id = 659,
                        District = "Gmunden",
                        Location = "Scharnstein",
                        ZipCodeNr = "4817"
                },
                new ZipCode() {
                        Id = 660,
                        District = "Gmunden",
                        Location = "St. Konrad",
                        ZipCodeNr = "4817"
                },
                new ZipCode() {
                        Id = 661,
                        District = "Gmunden",
                        Location = "Bad Ischl",
                        ZipCodeNr = "4820"
                },
                new ZipCode() {
                        Id = 662,
                        District = "Gmunden",
                        Location = "Bad Ischl",
                        ZipCodeNr = "4821"
                },
                new ZipCode() {
                        Id = 663,
                        District = "Gmunden",
                        Location = "Bad Goisern am Hallstättersee",
                        ZipCodeNr = "4822"
                },
                new ZipCode() {
                        Id = 664,
                        District = "Gmunden",
                        Location = "Hallstatt",
                        ZipCodeNr = "4823"
                },
                new ZipCode() {
                        Id = 665,
                        District = "Gmunden",
                        Location = "Gosau",
                        ZipCodeNr = "4824"
                },
                new ZipCode() {
                        Id = 666,
                        District = "Gmunden",
                        Location = "Gosau",
                        ZipCodeNr = "4825"
                },
                new ZipCode() {
                        Id = 667,
                        District = "Gmunden",
                        Location = "Hallstatt",
                        ZipCodeNr = "4830"
                },
                new ZipCode() {
                        Id = 668,
                        District = "Gmunden",
                        Location = "Obertraun",
                        ZipCodeNr = "4831"
                },
                new ZipCode() {
                        Id = 669,
                        District = "Vöcklabruck",
                        Location = "Pilsbach",
                        ZipCodeNr = "4840"
                },
                new ZipCode() {
                        Id = 670,
                        District = "Vöcklabruck",
                        Location = "Vöcklabruck",
                        ZipCodeNr = "4840"
                },
                new ZipCode() {
                        Id = 671,
                        District = "Vöcklabruck",
                        Location = "Pilsbach",
                        ZipCodeNr = "4841"
                },
                new ZipCode() {
                        Id = 672,
                        District = "Vöcklabruck",
                        Location = "Timelkam",
                        ZipCodeNr = "4841"
                },
                new ZipCode() {
                        Id = 673,
                        District = "Vöcklabruck",
                        Location = "Ungenach",
                        ZipCodeNr = "4841"
                },
                new ZipCode() {
                        Id = 674,
                        District = "Vöcklabruck",
                        Location = "Vöcklabruck",
                        ZipCodeNr = "4841"
                },
                new ZipCode() {
                        Id = 675,
                        District = "Vöcklabruck",
                        Location = "Zell am Pettenfirst",
                        ZipCodeNr = "4842"
                },
                new ZipCode() {
                        Id = 676,
                        District = "Vöcklabruck",
                        Location = "Ampflwang im Hausruckwald",
                        ZipCodeNr = "4843"
                },
                new ZipCode() {
                        Id = 677,
                        District = "Vöcklabruck",
                        Location = "Aurach am Hongar",
                        ZipCodeNr = "4844"
                },
                new ZipCode() {
                        Id = 678,
                        District = "Vöcklabruck",
                        Location = "Regau",
                        ZipCodeNr = "4844"
                },
                new ZipCode() {
                        Id = 679,
                        District = "Gmunden",
                        Location = "Pinsdorf",
                        ZipCodeNr = "4845"
                },
                new ZipCode() {
                        Id = 680,
                        District = "Vöcklabruck",
                        Location = "Regau",
                        ZipCodeNr = "4845"
                },
                new ZipCode() {
                        Id = 681,
                        District = "Vöcklabruck",
                        Location = "Redlham",
                        ZipCodeNr = "4846"
                },
                new ZipCode() {
                        Id = 682,
                        District = "Vöcklabruck",
                        Location = "Puchkirchen am Trattberg",
                        ZipCodeNr = "4849"
                },
                new ZipCode() {
                        Id = 683,
                        District = "Vöcklabruck",
                        Location = "Neukirchen an der Vöckla",
                        ZipCodeNr = "4850"
                },
                new ZipCode() {
                        Id = 684,
                        District = "Vöcklabruck",
                        Location = "Timelkam",
                        ZipCodeNr = "4850"
                },
                new ZipCode() {
                        Id = 685,
                        District = "Vöcklabruck",
                        Location = "Ungenach",
                        ZipCodeNr = "4850"
                },
                new ZipCode() {
                        Id = 686,
                        District = "Vöcklabruck",
                        Location = "Vöcklabruck",
                        ZipCodeNr = "4850"
                },
                new ZipCode() {
                        Id = 687,
                        District = "Vöcklabruck",
                        Location = "Gampern",
                        ZipCodeNr = "4851"
                },
                new ZipCode() {
                        Id = 688,
                        District = "Vöcklabruck",
                        Location = "Seewalchen am Attersee",
                        ZipCodeNr = "4851"
                },
                new ZipCode() {
                        Id = 689,
                        District = "Vöcklabruck",
                        Location = "Weyregg am Attersee",
                        ZipCodeNr = "4852"
                },
                new ZipCode() {
                        Id = 690,
                        District = "Vöcklabruck",
                        Location = "Steinbach am Attersee",
                        ZipCodeNr = "4853"
                },
                new ZipCode() {
                        Id = 691,
                        District = "Salzburg-Umgebung",
                        Location = "Sankt Gilgen",
                        ZipCodeNr = "4854"
                },
                new ZipCode() {
                        Id = 692,
                        District = "Vöcklabruck",
                        Location = "Steinbach am Attersee",
                        ZipCodeNr = "4854"
                },
                new ZipCode() {
                        Id = 693,
                        District = "Vöcklabruck",
                        Location = "Lenzing",
                        ZipCodeNr = "4860"
                },
                new ZipCode() {
                        Id = 694,
                        District = "Vöcklabruck",
                        Location = "Regau",
                        ZipCodeNr = "4860"
                },
                new ZipCode() {
                        Id = 695,
                        District = "Vöcklabruck",
                        Location = "Timelkam",
                        ZipCodeNr = "4860"
                },
                new ZipCode() {
                        Id = 696,
                        District = "Vöcklabruck",
                        Location = "Aurach am Hongar",
                        ZipCodeNr = "4861"
                },
                new ZipCode() {
                        Id = 697,
                        District = "Vöcklabruck",
                        Location = "Schörfling am Attersee",
                        ZipCodeNr = "4861"
                },
                new ZipCode() {
                        Id = 698,
                        District = "Vöcklabruck",
                        Location = "Weyregg am Attersee",
                        ZipCodeNr = "4861"
                },
                new ZipCode() {
                        Id = 699,
                        District = "Vöcklabruck",
                        Location = "Berg im Attergau",
                        ZipCodeNr = "4863"
                },
                new ZipCode() {
                        Id = 700,
                        District = "Vöcklabruck",
                        Location = "Seewalchen am Attersee",
                        ZipCodeNr = "4863"
                },
                new ZipCode() {
                        Id = 701,
                        District = "Vöcklabruck",
                        Location = "Attersee am Attersee",
                        ZipCodeNr = "4864"
                },
                new ZipCode() {
                        Id = 702,
                        District = "Vöcklabruck",
                        Location = "Nußdorf am Attersee",
                        ZipCodeNr = "4865"
                },
                new ZipCode() {
                        Id = 703,
                        District = "Vöcklabruck",
                        Location = "Innerschwand am Mondsee",
                        ZipCodeNr = "4866"
                },
                new ZipCode() {
                        Id = 704,
                        District = "Salzburg-Umgebung",
                        Location = "Sankt Gilgen",
                        ZipCodeNr = "4866"
                },
                new ZipCode() {
                        Id = 705,
                        District = "Vöcklabruck",
                        Location = "Unterach am Attersee",
                        ZipCodeNr = "4866"
                },
                new ZipCode() {
                        Id = 706,
                        District = "Vöcklabruck",
                        Location = "Pfaffing",
                        ZipCodeNr = "4870"
                },
                new ZipCode() {
                        Id = 707,
                        District = "Vöcklabruck",
                        Location = "Vöcklamarkt",
                        ZipCodeNr = "4870"
                },
                new ZipCode() {
                        Id = 708,
                        District = "Vöcklabruck",
                        Location = "Frankenburg am Hausruck",
                        ZipCodeNr = "4871"
                },
                new ZipCode() {
                        Id = 709,
                        District = "Vöcklabruck",
                        Location = "Gampern",
                        ZipCodeNr = "4871"
                },
                new ZipCode() {
                        Id = 710,
                        District = "Vöcklabruck",
                        Location = "Neukirchen an der Vöckla",
                        ZipCodeNr = "4871"
                },
                new ZipCode() {
                        Id = 711,
                        District = "Vöcklabruck",
                        Location = "Pfaffing",
                        ZipCodeNr = "4871"
                },
                new ZipCode() {
                        Id = 712,
                        District = "Vöcklabruck",
                        Location = "Vöcklamarkt",
                        ZipCodeNr = "4871"
                },
                new ZipCode() {
                        Id = 713,
                        District = "Vöcklabruck",
                        Location = "Neukirchen an der Vöckla",
                        ZipCodeNr = "4872"
                },
                new ZipCode() {
                        Id = 714,
                        District = "Vöcklabruck",
                        Location = "Frankenburg am Hausruck",
                        ZipCodeNr = "4873"
                },
                new ZipCode() {
                        Id = 715,
                        District = "Vöcklabruck",
                        Location = "Neukirchen an der Vöckla",
                        ZipCodeNr = "4873"
                },
                new ZipCode() {
                        Id = 716,
                        District = "Vöcklabruck",
                        Location = "Redleiten",
                        ZipCodeNr = "4873"
                },
                new ZipCode() {
                        Id = 717,
                        District = "Vöcklabruck",
                        Location = "Berg im Attergau",
                        ZipCodeNr = "4880"
                },
                new ZipCode() {
                        Id = 718,
                        District = "Vöcklabruck",
                        Location = "Seewalchen am Attersee",
                        ZipCodeNr = "4880"
                },
                new ZipCode() {
                        Id = 719,
                        District = "Vöcklabruck",
                        Location = "St. Georgen im Attergau",
                        ZipCodeNr = "4880"
                },
                new ZipCode() {
                        Id = 720,
                        District = "Vöcklabruck",
                        Location = "Straß im Attergau",
                        ZipCodeNr = "4881"
                },
                new ZipCode() {
                        Id = 721,
                        District = "Vöcklabruck",
                        Location = "Oberwang",
                        ZipCodeNr = "4882"
                },
                new ZipCode() {
                        Id = 722,
                        District = "Vöcklabruck",
                        Location = "Fornach",
                        ZipCodeNr = "4890"
                },
                new ZipCode() {
                        Id = 723,
                        District = "Vöcklabruck",
                        Location = "Frankenmarkt",
                        ZipCodeNr = "4890"
                },
                new ZipCode() {
                        Id = 724,
                        District = "Vöcklabruck",
                        Location = "Vöcklamarkt",
                        ZipCodeNr = "4890"
                },
                new ZipCode() {
                        Id = 725,
                        District = "Vöcklabruck",
                        Location = "Weißenkirchen im Attergau",
                        ZipCodeNr = "4890"
                },
                new ZipCode() {
                        Id = 726,
                        District = "Vöcklabruck",
                        Location = "Frankenmarkt",
                        ZipCodeNr = "4891"
                },
                new ZipCode() {
                        Id = 727,
                        District = "Vöcklabruck",
                        Location = "Pöndorf",
                        ZipCodeNr = "4891"
                },
                new ZipCode() {
                        Id = 728,
                        District = "Vöcklabruck",
                        Location = "Weißenkirchen im Attergau",
                        ZipCodeNr = "4891"
                },
                new ZipCode() {
                        Id = 729,
                        District = "Vöcklabruck",
                        Location = "Fornach",
                        ZipCodeNr = "4892"
                },
                new ZipCode() {
                        Id = 730,
                        District = "Vöcklabruck",
                        Location = "Pfaffing",
                        ZipCodeNr = "4892"
                },
                new ZipCode() {
                        Id = 731,
                        District = "Vöcklabruck",
                        Location = "Oberhofen am Irrsee",
                        ZipCodeNr = "4893"
                },
                new ZipCode() {
                        Id = 732,
                        District = "Vöcklabruck",
                        Location = "Tiefgraben",
                        ZipCodeNr = "4893"
                },
                new ZipCode() {
                        Id = 733,
                        District = "Vöcklabruck",
                        Location = "Zell am Moos",
                        ZipCodeNr = "4893"
                },
                new ZipCode() {
                        Id = 734,
                        District = "Vöcklabruck",
                        Location = "Oberhofen am Irrsee",
                        ZipCodeNr = "4894"
                },
                new ZipCode() {
                        Id = 735,
                        District = "Vöcklabruck",
                        Location = "Ottnang am Hausruck",
                        ZipCodeNr = "4901"
                },
                new ZipCode() {
                        Id = 736,
                        District = "Grieskirchen",
                        Location = "Gaspoltshofen",
                        ZipCodeNr = "4902"
                },
                new ZipCode() {
                        Id = 737,
                        District = "Vöcklabruck",
                        Location = "Niederthalheim",
                        ZipCodeNr = "4902"
                },
                new ZipCode() {
                        Id = 738,
                        District = "Vöcklabruck",
                        Location = "Wolfsegg am Hausruck",
                        ZipCodeNr = "4902"
                },
                new ZipCode() {
                        Id = 739,
                        District = "Vöcklabruck",
                        Location = "Manning",
                        ZipCodeNr = "4903"
                },
                new ZipCode() {
                        Id = 740,
                        District = "Vöcklabruck",
                        Location = "Atzbach",
                        ZipCodeNr = "4904"
                },
                new ZipCode() {
                        Id = 741,
                        District = "Ried",
                        Location = "Eberschwang",
                        ZipCodeNr = "4906"
                },
                new ZipCode() {
                        Id = 742,
                        District = "Ried",
                        Location = "Aurolzmünster",
                        ZipCodeNr = "4910"
                },
                new ZipCode() {
                        Id = 743,
                        District = "Ried",
                        Location = "Mehrnbach",
                        ZipCodeNr = "4910"
                },
                new ZipCode() {
                        Id = 744,
                        District = "Ried",
                        Location = "Pattigham",
                        ZipCodeNr = "4910"
                },
                new ZipCode() {
                        Id = 745,
                        District = "Ried",
                        Location = "Ried im Innkreis",
                        ZipCodeNr = "4910"
                },
                new ZipCode() {
                        Id = 746,
                        District = "Ried",
                        Location = "Tumeltsham",
                        ZipCodeNr = "4911"
                },
                new ZipCode() {
                        Id = 747,
                        District = "Ried",
                        Location = "Neuhofen im Innkreis",
                        ZipCodeNr = "4912"
                },
                new ZipCode() {
                        Id = 748,
                        District = "Ried",
                        Location = "Schildorn",
                        ZipCodeNr = "4920"
                },
                new ZipCode() {
                        Id = 749,
                        District = "Ried",
                        Location = "Hohenzell",
                        ZipCodeNr = "4921"
                },
                new ZipCode() {
                        Id = 750,
                        District = "Ried",
                        Location = "Geiersberg",
                        ZipCodeNr = "4922"
                },
                new ZipCode() {
                        Id = 751,
                        District = "Ried",
                        Location = "Lohnsburg am Kobernaußerwald",
                        ZipCodeNr = "4923"
                },
                new ZipCode() {
                        Id = 752,
                        District = "Ried",
                        Location = "Waldzell",
                        ZipCodeNr = "4924"
                },
                new ZipCode() {
                        Id = 753,
                        District = "Ried",
                        Location = "Pattigham",
                        ZipCodeNr = "4925"
                },
                new ZipCode() {
                        Id = 754,
                        District = "Ried",
                        Location = "Pramet",
                        ZipCodeNr = "4925"
                },
                new ZipCode() {
                        Id = 755,
                        District = "Ried",
                        Location = "St. Marienkirchen am Hausruck",
                        ZipCodeNr = "4926"
                },
                new ZipCode() {
                        Id = 756,
                        District = "Braunau",
                        Location = "Aspach",
                        ZipCodeNr = "4931"
                },
                new ZipCode() {
                        Id = 757,
                        District = "Ried",
                        Location = "Mettmach",
                        ZipCodeNr = "4931"
                },
                new ZipCode() {
                        Id = 758,
                        District = "Braunau",
                        Location = "Aspach",
                        ZipCodeNr = "4932"
                },
                new ZipCode() {
                        Id = 759,
                        District = "Ried",
                        Location = "Kirchheim im Innkreis",
                        ZipCodeNr = "4932"
                },
                new ZipCode() {
                        Id = 760,
                        District = "Braunau",
                        Location = "Aspach",
                        ZipCodeNr = "4933"
                },
                new ZipCode() {
                        Id = 761,
                        District = "Ried",
                        Location = "Mehrnbach",
                        ZipCodeNr = "4941"
                },
                new ZipCode() {
                        Id = 762,
                        District = "Ried",
                        Location = "Ried im Innkreis",
                        ZipCodeNr = "4941"
                },
                new ZipCode() {
                        Id = 763,
                        District = "Ried",
                        Location = "Gurten",
                        ZipCodeNr = "4942"
                },
                new ZipCode() {
                        Id = 764,
                        District = "Ried",
                        Location = "Wippenham",
                        ZipCodeNr = "4942"
                },
                new ZipCode() {
                        Id = 765,
                        District = "Ried",
                        Location = "Geinberg",
                        ZipCodeNr = "4943"
                },
                new ZipCode() {
                        Id = 766,
                        District = "Ried",
                        Location = "Gurten",
                        ZipCodeNr = "4943"
                },
                new ZipCode() {
                        Id = 767,
                        District = "Ried",
                        Location = "Kirchdorf am Inn",
                        ZipCodeNr = "4943"
                },
                new ZipCode() {
                        Id = 768,
                        District = "Braunau",
                        Location = "Polling im Innkreis",
                        ZipCodeNr = "4943"
                },
                new ZipCode() {
                        Id = 769,
                        District = "Braunau",
                        Location = "Altheim",
                        ZipCodeNr = "4950"
                },
                new ZipCode() {
                        Id = 770,
                        District = "Braunau",
                        Location = "Weng im Innkreis",
                        ZipCodeNr = "4950"
                },
                new ZipCode() {
                        Id = 771,
                        District = "Ried",
                        Location = "Geinberg",
                        ZipCodeNr = "4951"
                },
                new ZipCode() {
                        Id = 772,
                        District = "Braunau",
                        Location = "Polling im Innkreis",
                        ZipCodeNr = "4951"
                },
                new ZipCode() {
                        Id = 773,
                        District = "Braunau",
                        Location = "Altheim",
                        ZipCodeNr = "4952"
                },
                new ZipCode() {
                        Id = 774,
                        District = "Braunau",
                        Location = "Moosbach",
                        ZipCodeNr = "4952"
                },
                new ZipCode() {
                        Id = 775,
                        District = "Braunau",
                        Location = "Weng im Innkreis",
                        ZipCodeNr = "4952"
                },
                new ZipCode() {
                        Id = 776,
                        District = "Ried",
                        Location = "Mühlheim am Inn",
                        ZipCodeNr = "4961"
                },
                new ZipCode() {
                        Id = 777,
                        District = "Braunau",
                        Location = "Weng im Innkreis",
                        ZipCodeNr = "4961"
                },
                new ZipCode() {
                        Id = 778,
                        District = "Braunau",
                        Location = "Mining",
                        ZipCodeNr = "4962"
                },
                new ZipCode() {
                        Id = 779,
                        District = "Braunau",
                        Location = "St. Peter am Hart",
                        ZipCodeNr = "4962"
                },
                new ZipCode() {
                        Id = 780,
                        District = "Braunau",
                        Location = "Burgkirchen",
                        ZipCodeNr = "4963"
                },
                new ZipCode() {
                        Id = 781,
                        District = "Braunau",
                        Location = "St. Peter am Hart",
                        ZipCodeNr = "4963"
                },
                new ZipCode() {
                        Id = 782,
                        District = "Ried",
                        Location = "Eitzing",
                        ZipCodeNr = "4970"
                },
                new ZipCode() {
                        Id = 783,
                        District = "Ried",
                        Location = "Andrichsfurt",
                        ZipCodeNr = "4971"
                },
                new ZipCode() {
                        Id = 784,
                        District = "Ried",
                        Location = "Aurolzmünster",
                        ZipCodeNr = "4971"
                },
                new ZipCode() {
                        Id = 785,
                        District = "Ried",
                        Location = "Mehrnbach",
                        ZipCodeNr = "4971"
                },
                new ZipCode() {
                        Id = 786,
                        District = "Ried",
                        Location = "Utzenaich",
                        ZipCodeNr = "4971"
                },
                new ZipCode() {
                        Id = 787,
                        District = "Ried",
                        Location = "Andrichsfurt",
                        ZipCodeNr = "4972"
                },
                new ZipCode() {
                        Id = 788,
                        District = "Ried",
                        Location = "Aurolzmünster",
                        ZipCodeNr = "4972"
                },
                new ZipCode() {
                        Id = 789,
                        District = "Ried",
                        Location = "Utzenaich",
                        ZipCodeNr = "4972"
                },
                new ZipCode() {
                        Id = 790,
                        District = "Ried",
                        Location = "Aurolzmünster",
                        ZipCodeNr = "4973"
                },
                new ZipCode() {
                        Id = 791,
                        District = "Ried",
                        Location = "Mörschwang",
                        ZipCodeNr = "4973"
                },
                new ZipCode() {
                        Id = 792,
                        District = "Ried",
                        Location = "Reichersberg",
                        ZipCodeNr = "4973"
                },
                new ZipCode() {
                        Id = 793,
                        District = "Ried",
                        Location = "Senftenbach",
                        ZipCodeNr = "4973"
                },
                new ZipCode() {
                        Id = 794,
                        District = "Ried",
                        Location = "St. Martin im Innkreis",
                        ZipCodeNr = "4973"
                },
                new ZipCode() {
                        Id = 795,
                        District = "Ried",
                        Location = "Utzenaich",
                        ZipCodeNr = "4973"
                },
                new ZipCode() {
                        Id = 796,
                        District = "Ried",
                        Location = "Lambrechten",
                        ZipCodeNr = "4974"
                },
                new ZipCode() {
                        Id = 797,
                        District = "Ried",
                        Location = "Ort im Innkreis",
                        ZipCodeNr = "4974"
                },
                new ZipCode() {
                        Id = 798,
                        District = "Ried",
                        Location = "Reichersberg",
                        ZipCodeNr = "4974"
                },
                new ZipCode() {
                        Id = 799,
                        District = "Schärding",
                        Location = "Suben",
                        ZipCodeNr = "4975"
                },
                new ZipCode() {
                        Id = 800,
                        District = "Ried",
                        Location = "Antiesenhofen",
                        ZipCodeNr = "4980"
                },
                new ZipCode() {
                        Id = 801,
                        District = "Schärding",
                        Location = "Eggerding",
                        ZipCodeNr = "4980"
                },
                new ZipCode() {
                        Id = 802,
                        District = "Ried",
                        Location = "Reichersberg",
                        ZipCodeNr = "4980"
                },
                new ZipCode() {
                        Id = 803,
                        District = "Ried",
                        Location = "Reichersberg",
                        ZipCodeNr = "4981"
                },
                new ZipCode() {
                        Id = 804,
                        District = "Ried",
                        Location = "Kirchdorf am Inn",
                        ZipCodeNr = "4982"
                },
                new ZipCode() {
                        Id = 805,
                        District = "Ried",
                        Location = "Mörschwang",
                        ZipCodeNr = "4982"
                },
                new ZipCode() {
                        Id = 806,
                        District = "Ried",
                        Location = "Obernberg am Inn",
                        ZipCodeNr = "4982"
                },
                new ZipCode() {
                        Id = 807,
                        District = "Ried",
                        Location = "St. Georgen bei Obernberg am Inn",
                        ZipCodeNr = "4983"
                },
                new ZipCode() {
                        Id = 808,
                        District = "Ried",
                        Location = "Mörschwang",
                        ZipCodeNr = "4984"
                },
                new ZipCode() {
                        Id = 809,
                        District = "Ried",
                        Location = "Weilbach",
                        ZipCodeNr = "4984"
                },

            };

            List<RestaurantCategory> restaurant_category = new()
            {
                new RestaurantCategory()
                {
                    Id = 1,
                    RestaurantId = 1,
                    CategoryId = 1
                },
                new RestaurantCategory()
                {
                    Id = 2,
                    RestaurantId = 2,
                    CategoryId = 27
                },
                new RestaurantCategory()
                {
                    Id = 3,
                    RestaurantId = 3,
                    CategoryId = 2
                },
                new RestaurantCategory()
                {
                    Id = 4,
                    RestaurantId = 4,
                    CategoryId = 6
                },
                new RestaurantCategory()
                {
                    Id = 5,
                    RestaurantId = 5,
                    CategoryId = 20
                },
                new RestaurantCategory()
                {
                    Id = 6,
                    RestaurantId = 6,
                    CategoryId = 2
                },
                new RestaurantCategory()
                {
                    Id = 7,
                    RestaurantId = 7,
                    CategoryId = 6
                },
                new RestaurantCategory()
                {
                    Id = 8,
                    RestaurantId = 8,
                    CategoryId = 3
                },
                new RestaurantCategory()
                {
                    Id = 9,
                    RestaurantId = 9,
                    CategoryId = 6
                },
                new RestaurantCategory()
                {
                    Id = 10,
                    RestaurantId = 10,
                    CategoryId = 1
                }
            };

            List<RestaurantOpeningTime> openingTime = new()
            {
                new RestaurantOpeningTime()
                {
                    Id = 1,
                    OpeningTime = new DateTime(2023, 5, 26, 8, 0, 0),
                    ClosingTime = new DateTime(2023, 5, 26, 18, 0, 0),
                    Day = (int)DayOfWeek.Monday,
                    RestaurantId = 1
                },
                new RestaurantOpeningTime()
                {
                    Id = 2,
                    OpeningTime = new DateTime(2023, 5, 26, 8, 0, 0),
                    ClosingTime = new DateTime(2023, 5, 26, 18, 0, 0),
                    Day = (int)DayOfWeek.Tuesday,
                    RestaurantId = 1
                },
                new RestaurantOpeningTime()
                {
                    Id = 3,
                    OpeningTime = new DateTime(2023, 5, 26, 8, 0, 0),
                    ClosingTime = new DateTime(2023, 5, 26, 18, 0, 0),
                    Day = (int)DayOfWeek.Wednesday,
                    RestaurantId = 1
                },
                new RestaurantOpeningTime()
                {
                    Id = 4,
                    OpeningTime = new DateTime(2023, 5, 26, 8, 0, 0),
                    ClosingTime = new DateTime(2023, 5, 26, 18, 0, 0),
                    Day = (int)DayOfWeek.Thursday,
                    RestaurantId = 1
                },
                new RestaurantOpeningTime()
                {
                    Id = 5,
                    OpeningTime = new DateTime(2023, 5, 26, 8, 0, 0),
                    ClosingTime = new DateTime(2023, 5, 26, 18, 0, 0),
                    Day = (int)DayOfWeek.Friday,
                    RestaurantId = 1
                },
                new RestaurantOpeningTime()
                {
                    Id = 6,
                    OpeningTime = new DateTime(2023, 5, 27, 8, 0, 0),
                    ClosingTime = new DateTime(2023, 5, 27, 17, 0, 0),
                    Day = (int)DayOfWeek.Saturday,
                    RestaurantId = 1
                },
                new RestaurantOpeningTime()
                {
                    Id = 7,
                    OpeningTime = new DateTime(2023, 5, 28, 10, 0, 0),
                    ClosingTime = new DateTime(2023, 5, 28, 16, 0, 0),
                    Day = (int)DayOfWeek.Sunday,
                    RestaurantId = 1
                }
            };

            List<RestaurantTable> tableList = new()
            {
                new RestaurantTable { Id = 1, SeatPlaces = 6, RestaurantId = 1 },
                new RestaurantTable { Id = 2, SeatPlaces = 8, RestaurantId = 2 },
                new RestaurantTable { Id = 3, SeatPlaces = 5, RestaurantId = 3 },
                new RestaurantTable { Id = 4, SeatPlaces = 6, RestaurantId = 4 },
                new RestaurantTable { Id = 5, SeatPlaces = 7, RestaurantId = 5 },
                new RestaurantTable { Id = 6, SeatPlaces = 6, RestaurantId = 6 },
                new RestaurantTable { Id = 7, SeatPlaces = 9, RestaurantId = 7 },
                new RestaurantTable { Id = 8, SeatPlaces = 5, RestaurantId = 8 },
                new RestaurantTable { Id = 9, SeatPlaces = 6, RestaurantId = 9 },
                new RestaurantTable { Id = 10, SeatPlaces = 7, RestaurantId = 10 },
                new RestaurantTable { Id = 11, SeatPlaces = 6, RestaurantId = 1 },
                new RestaurantTable { Id = 12, SeatPlaces = 8, RestaurantId = 2 },
                new RestaurantTable { Id = 13, SeatPlaces = 5, RestaurantId = 3 },
                new RestaurantTable { Id = 14, SeatPlaces = 6, RestaurantId = 4 },
                new RestaurantTable { Id = 15, SeatPlaces = 7, RestaurantId = 5 },
                new RestaurantTable { Id = 16, SeatPlaces = 6, RestaurantId = 6 },
                new RestaurantTable { Id = 17, SeatPlaces = 9, RestaurantId = 7 },
                new RestaurantTable { Id = 18, SeatPlaces = 5, RestaurantId = 8 },
                new RestaurantTable { Id = 19, SeatPlaces = 6, RestaurantId = 9 },
                new RestaurantTable { Id = 20, SeatPlaces = 7, RestaurantId = 10 },
                new RestaurantTable { Id = 21, SeatPlaces = 6, RestaurantId = 1 },
                new RestaurantTable { Id = 22, SeatPlaces = 7, RestaurantId = 2 },
                new RestaurantTable { Id = 23, SeatPlaces = 5, RestaurantId = 3 },
                new RestaurantTable { Id = 24, SeatPlaces = 6, RestaurantId = 4 },
                new RestaurantTable { Id = 25, SeatPlaces = 8, RestaurantId = 5 },
                new RestaurantTable { Id = 26, SeatPlaces = 6, RestaurantId = 6 },
                new RestaurantTable { Id = 27, SeatPlaces = 9, RestaurantId = 7 },
                new RestaurantTable { Id = 28, SeatPlaces = 5, RestaurantId = 8 },
                new RestaurantTable { Id = 29, SeatPlaces = 6, RestaurantId = 9 },
                new RestaurantTable { Id = 30, SeatPlaces = 7, RestaurantId = 10 },
                new RestaurantTable { Id = 31, SeatPlaces = 6, RestaurantId = 1 },
                new RestaurantTable { Id = 32, SeatPlaces = 7, RestaurantId = 2 },
                new RestaurantTable { Id = 33, SeatPlaces = 5, RestaurantId = 3 },
                new RestaurantTable { Id = 34, SeatPlaces = 6, RestaurantId = 4 },
                new RestaurantTable { Id = 35, SeatPlaces = 8, RestaurantId = 5 },
                new RestaurantTable { Id = 36, SeatPlaces = 6, RestaurantId = 6 },
                new RestaurantTable { Id = 37, SeatPlaces = 9, RestaurantId = 7 },
                new RestaurantTable { Id = 38, SeatPlaces = 5, RestaurantId = 8 },
                new RestaurantTable { Id = 39, SeatPlaces = 6, RestaurantId = 9 },
                new RestaurantTable { Id = 40, SeatPlaces = 7, RestaurantId = 10 },
                new RestaurantTable { Id = 41, SeatPlaces = 7, RestaurantId = 1 },
                new RestaurantTable { Id = 42, SeatPlaces = 9, RestaurantId = 2 },
                new RestaurantTable { Id = 43, SeatPlaces = 6, RestaurantId = 3 },
                new RestaurantTable { Id = 44, SeatPlaces = 8, RestaurantId = 4 },
                new RestaurantTable { Id = 45, SeatPlaces = 5, RestaurantId = 5 },
                new RestaurantTable { Id = 46, SeatPlaces = 7, RestaurantId = 6 },
                new RestaurantTable { Id = 47, SeatPlaces = 6, RestaurantId = 7 },
                new RestaurantTable { Id = 48, SeatPlaces = 8, RestaurantId = 8 },
                new RestaurantTable { Id = 49, SeatPlaces = 9, RestaurantId = 9 },
                new RestaurantTable { Id = 50, SeatPlaces = 5, RestaurantId = 10 },
                new RestaurantTable { Id = 51, SeatPlaces = 6, RestaurantId = 1 },
                new RestaurantTable { Id = 52, SeatPlaces = 7, RestaurantId = 2 },
                new RestaurantTable { Id = 53, SeatPlaces = 5, RestaurantId = 3 },
                new RestaurantTable { Id = 54, SeatPlaces = 6, RestaurantId = 4 },
                new RestaurantTable { Id = 55, SeatPlaces = 8, RestaurantId = 5 },
                new RestaurantTable { Id = 56, SeatPlaces = 6, RestaurantId = 6 },
                new RestaurantTable { Id = 57, SeatPlaces = 9, RestaurantId = 7 },
                new RestaurantTable { Id = 58, SeatPlaces = 5, RestaurantId = 8 },
                new RestaurantTable { Id = 59, SeatPlaces = 6, RestaurantId = 9 },
                new RestaurantTable { Id = 60, SeatPlaces = 7, RestaurantId = 10 },
                new RestaurantTable { Id = 61, SeatPlaces = 6, RestaurantId = 1 },
                new RestaurantTable { Id = 62, SeatPlaces = 7, RestaurantId = 2 },
                new RestaurantTable { Id = 63, SeatPlaces = 5, RestaurantId = 3 },
                new RestaurantTable { Id = 64, SeatPlaces = 6, RestaurantId = 4 },
                new RestaurantTable { Id = 65, SeatPlaces = 8, RestaurantId = 5 },
                new RestaurantTable { Id = 66, SeatPlaces = 6, RestaurantId = 6 },
                new RestaurantTable { Id = 67, SeatPlaces = 9, RestaurantId = 7 },
                new RestaurantTable { Id = 68, SeatPlaces = 5, RestaurantId = 8 },
                new RestaurantTable { Id = 69, SeatPlaces = 6, RestaurantId = 9 },
                new RestaurantTable { Id = 70, SeatPlaces = 7, RestaurantId = 10 }
            };


            foreach (var restaurant in restaurants)
            {
                modelBuilder.Entity<Restaurant>().HasData(restaurant);
            }

            foreach (var category in categories)
            {
                modelBuilder.Entity<Category>().HasData(category);
            }

            foreach (var zipCode in zipCodes)
            {
                modelBuilder.Entity<ZipCode>().HasData(zipCode);
            }

            foreach(var restaurantCategory in restaurant_category)
            {
                modelBuilder.Entity<RestaurantCategory>().HasData(restaurantCategory);
            }

            foreach (var table in tableList)
            {
                modelBuilder.Entity<RestaurantTable>().HasData(table);
            }

            foreach (var time in openingTime)
            {
                modelBuilder.Entity<RestaurantOpeningTime>().HasData(time);
            }
        }
    }
}
