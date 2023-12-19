using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "Description", "Name", "StreetNr", "ZipCodeId" },
                values: new object[,]
                {
                    { 1, "Bergstraße", "Inmitten der malerischen Alpen gelegen, bietet unser Gasthaus einen atemberaubenden Blick auf die Berglandschaft. Genießen Sie hausgemachte österreichische Gerichte, frische Bergluft und herzliche Gastfreundschaft.", "Gasthaus Zum Bergblick", "2", 645 },
                    { 2, "Am Marktplatz", "Treten Sie ein in eine Oase mediterraner Genüsse. Unser Restaurant ist bekannt für seine hausgemachten Pasta-Gerichte, frischen Fisch und erstklassige Weinauswahl. Lassen Sie sich von den Aromen des Südens verzaubern.", "Das Mediterrane Flair", "7", 1 },
                    { 3, "Kunststraße", "Ein einzigartiger Ort, an dem Kunst und Kulinarik verschmelzen. Unsere Küche ist eine Leinwand, auf der unsere talentierten Küche mit Farben und Geschmacksrichtungen zaubern. Erleben Sie ein Fest für die Sinne in unserem Restaurant.", "Kunst und Kulinarik", "10", 17 },
                    { 4, "Gartenweg", "Umgeben von üppigen Gärten und blühenden Blumenbeeten, ist unser Restaurant der ideale Ort, um dem Alltag zu entfliehen. Genießen Sie Kaffee und Kuchen in einer idyllischen Umgebung und tanken Sie frische Energie.", "Das Grüne Paradies", "3", 4 },
                    { 5, "Weinstraße", "Unser Weinkeller ist gefällt mit erlesenen Weinen aus der Region und der ganzen Welt. Begleiten Sie Ihre Weinauswahl mit einer raffinierten Auswahl an Gerichten, die perfekt zu jedem Schluck passen. Ein wahres Paradies für Weinliebhaber.", "Zur Weintraube", "14", 1 },
                    { 6, "Gourmetplatz", "Willkommen in einem Ort, an dem kulinarische Kunstwerke geschaffen werden. Unsere Gerichte sind mehr als nur Mahlzeiten, sie sind eine Symphonie aus Aromen und Präsentation. Genießen Sie ein unvergessliches Feinschmecker-Erlebnis.", "Das Feinschmecker-Erlebnis", "5", 645 },
                    { 7, "Meeresweg", "Unsere Speisekarte bietet die Frische des Ozeans auf Ihrem Teller. Von frischem Sushi und Sashimi bis hin zu köstlichen Meeresfrüchten, bereiten wir für Sie Meeresdelikatessen zu, die Ihre Geschmacksnerven verwöhnen.", "Sushi & Meeresfrüchte", "12", 1 },
                    { 8, "Gasthausstraße", "In unserem rustikalen Gasthaus servieren wir traditionelle österreichische Gerichte in einem gemütlichen Ambiente. Genießen Sie knusprige Schnitzel, hausgemachte Suppen und herzhafte Beilagen, die Ihre Seele erwärmen.", "Das Rustikale Gasthaus", "8", 644 },
                    { 9, "Harmonieplatz", "Ein Café, in dem die Zeit stillzustehen scheint. Genießen Sie Kaffee und Kuchen in einem nostalgischen Ambiente, begleitet von Live-Jazzmusik. Ein Ort des Genusses und der Entspannung.", "Café Harmonie", "6", 17 },
                    { 10, "Flussuferstraße", "Unser Restaurant am Ufer des Donau bietet einen atemberaubenden Blick auf den Fluss. Genießen Sie frische Fischgerichte und eine Auswahl an internationalen Köstlichkeiten, während Sie die vorbeiziehenden Schiffe beobachten.", "Genuss am Flussufer", "9", 4 },
                    { 11, "Hauptstraße", "Ein charmantes Bistro im Herzen der Stadt, das französische Köstlichkeiten und eine erlesene Weinauswahl bietet.", "Chez Le Bistro", "3", 1 },
                    { 12, "Hauptstraße", "Ein charmantes italienisches Restaurant, das köstliche Pasta und Pizza serviert", "Ristorante Bellavita", "5", 1 },
                    { 13, "Uferweg", "Ein beliebter Biergarten mit Blick auf die Donau und eine große Auswahl an Biersorten", "Biergarten am Fluss", "12", 4 },
                    { 14, "Marktplatz", "Ein traditionelles Gasthaus, das herzhafte österreichische Gerichte und eine gemütliche Atmosphäre bietet", "Gasthaus zum Guten Essen", "8", 1 },
                    { 15, "Sushistraße", "Ein Sushi-Restaurant, das frische Sushi-Rollen und japanische Spezialitäten zubereitet", "SushiMeister", "3", 1 },
                    { 16, "Caféweg", "Ein gemütliches Café, in dem Sie Kaffee, Kuchen und eine entspannte Atmosphäre genießen können", "Café Sonnenschein", "6", 1 },
                    { 17, "Bergblickstraße", "Genießen Sie traditionelle Alpenüche und einen atemberaubenden Blick auf die Berge", "Alpenblick Stuben", "9", 644 },
                    { 18, "Lindenplatz", "Ein traditioneller Gasthof, der regionale Gerichte und Gastfreundschaft bietet", "Gasthof Zur Linde", "7", 645 },
                    { 19, "Chinatown", "Ein chinesisches Restaurant, das köstliche Peking-Ente und Szechuan-Gerichte serviert", "Peking Palast", "2", 1 },
                    { 20, "Meeresblick", "Ein Paradies für Meeresfrüchte-Liebhaber mit einer großen Auswahl an frischem Fisch und Meeresfrüchten", "Meeresfrüchteparadies", "4", 645 },
                    { 21, "Zeitlosplatz", "Ein zeitloses Café, das Kaffee, Kuchen und frische Backwaren in einer entspannten Umgebung bietet", "Café Zeitlos", "15", 4 },
                    { 22, "Biergartenallee", "Ein traditioneller bayerischer Biergarten mit bayerischer Küche und Live-Musik", "Bayerischer Biergarten", "11", 645 },
                    { 23, "Italienische Gasse", "Genießen Sie die Aromen Italiens in unserem Restaurant mit hausgemachter Pasta und Pizza", "Mediterraneo Trattoria", "14", 17 },
                    { 24, "Sonnenstraße", "Ein familienfreundlicher Gasthof mit traditioneller österreichischer Küche und einem sonnigen Biergarten", "Gasthof zur Sonne", "6", 17 },
                    { 25, "Amadeusplatz", "Ein charmantes Café, das Kaffee, Kuchen und Livemusik bietet", "Café Amadeus", "8", 642 },
                    { 26, "Schnitzelplatz", "Ein Paradies für Schnitzelliebhaber mit einer großen Auswahl an Schnitzelgerichten und Beilagen", "Schnitzelhaus Deluxe", "10", 642 },
                    { 27, "Süßstraße", "Eine Konditorei, die köstliche Torten, Torten und Pralinen anbietet", "Süße Versuchung Konditorei", "3", 645 },
                    { 28, "Kaisekistraße", "Ein Restaurant, das die Kunst des Kaiseki-Essens zelebriert und eine kulinarische Reise durch Japan bietet", "Kaiseki Kultur", "1", 17 },
                    { 29, "Gartenstraße", "Ein charmantes Café mit einem malerischen Garten, in dem Sie Kaffee und hausgemachte Desserts genießen können", "Garten Eden Café", "5", 4 },
                    { 30, "Burgerweg", "Ein Restaurant, das eine Auswahl an Gourmet-Burgern und handgemachten Pommes serviert", "Burgerparadies", "12", 1 },
                    { 31, "Sushiplatz", "Ein modernes Sushi-Restaurant mit einer großen Auswahl an Sushi-Rollen und japanischen Spezialitäten", "Sushi Lounge", "7", 17 },
                    { 32, "Seepromenade", "Ein elegantes Restaurant am See, das frische Fischgerichte und französische Küche serviert", "Brasserie Am See", "11", 1 },
                    { 33, "Griechenplatz", "Ein griechisches Restaurant, das traditionelle griechische Gerichte und Meeresfrüchte bietet", "Griechischer Genuss", "3", 645 },
                    { 34, "Harmoniestraße", "Ein Café mit entspannter Atmosphäre, das Kaffee, Kuchen und Live-Jazzmusik bietet", "Restaurant Genussoase", "9", 4 },
                    { 35, "Eichenweg", "Ein traditioneller Bierkeller mit einer Auswahl an Biersorten und herzhaften Brotzeiten", "Bierkeller zur Eiche", "14", 1 },
                    { 36, "Waldring", "Ein gastfreundliches Gasthaus im Wald, das herzhafte österreichische Speisen und Wandererlebnisse bietet", "Waldgasthaus Zur Rose", "6", 17 },
                    { 37, "Mamastraße", "Genießen Sie hausgemachte österreichische Gerichte, die nach den Rezepten von Mama zubereitet werden", "Mama's Küche", "5", 644 },
                    { 38, "Gartenparadiesweg", "Ein idyllischer Garten mit einer Vielzahl von Blumen und Pflanzen sowie einem gemütlichen Café", "Das Gartenparadies", "3", 642 },
                    { 39, "Sushiweg", "Ein trendiges Sushi-Restaurant im Herzen der Stadt, das frische Sushi und Sashimi serviert", "Sushi in der Stadt", "2", 4 },
                    { 40, "Kaminplatz", "Ein gemütliches Restaurant mit einem offenen Kamin und einer GourmetKüche", "Kulinarischer Kamin", "1", 645 },
                    { 41, "Hauptstraße", "Genießen Sie authentische italienische Küche in einer gemütlichen Atmosphäre. Von hausgemachten Pastagerichten bis hin zu frisch zubereiteten Pizzen bieten wir eine Vielzahl von Optionen für jeden Geschmack.", "La Trattoria", "123", 1 },
                    { 42, "Bahnhofstraße", "Tauchen Sie ein in die Welt des Sushis und erleben Sie eine Fusion aus traditionellen und modernen japanischen Geschmacksrichtungen. Unsere Sushi-Rollen und frischen Meeresfrüchte werden Sie begeistern.", "Sushi Corner", "456", 4 },
                    { 43, "Kirchplatz", "Lassen Sie sich von der französischen Küche verführen. Unsere raffinierten Gerichte inspiriert von den Aromen Frankreichs werden Ihren Gaumen verwöhnen. Genießen Sie ein Glas Wein aus unserer umfangreichen Weinkarte.", "Le Bistro Français", "789", 3 },
                    { 44, "Gartenweg", "Erleben Sie die exotischen Aromen der indischen Küche in unserem Restaurant. Von würzigen Currygerichten bis hin zu köstlichen andoori-Spezialitäten bieten wir eine Vielzahl von Gerichten die Ihre Sinne begeistern werden.", "Spice Paradise", "234", 22 },
                    { 45, "Marktstraße", "Freuen Sie sich auf saftige Steaks perfekt gegrillt nach Ihren Wünschen. Unser Steakhaus bietet eine rustikale Atmosphäre und eine Auswahl an hochwertigen Fleischsorten. Begleitet von Beilagen und Saucen wird Ihr Besuch zu einem kulinarischen Erlebnis.", "Steakhouse Deluxe", "567", 17 },
                    { 46, "Rue de la Paix", "Chez Pierre ist ein elegantes französisches Restaurant das sich auf klassische französische Küche spezialisiert hat. Mit einer raffinierten Atmosphäre und einer umfangreichen Weinkarte bietet Chez Pierre ein unvergessliches kulinarisches Erlebnis.", "Chez Pierre", "10", 1 },
                    { 47, "Main Street", "The Spice Garden entführt Sie auf eine kulinarische Reise durch die Aromen Indiens. Von würzigen Currygerichten bis hin zu delikaten Vorspeisen bieten wir eine vielfältige Auswahl an indischen Spezialitäten die Ihre Geschmacksknospen verzaubern werden.", "The Spice Garden", "10", 3 },
                    { 48, "Shibuya-ku Shibuya", "Erleben Sie den Geschmack von Mexiko bei El Rancho. Unser lebhaftes Restaurant serviert authentische mexikanische Gerichte wie Tacos Enchiladas und frittierte Nachos begleitet von erfrischenden Margaritas und traditionellen lateinamerikanischen Getränken.", "Sushi Zen", "3-1-1", 56 },
                    { 49, "Calle Principal", "Erleben Sie die exotischen Aromen der indischen Küche in unserem Restaurant. Von würzigen Currygerichten bis hin zu köstlichen andoori-Spezialitäten bieten wir eine Vielzahl von Gerichten die Ihre Sinne begeistern werden.", "El Rancho", "20", 4 },
                    { 50, "Via Roma", "Bella Italia ist ein charmantes italienisches Restaurant das köstliche Pasta Pizza und Antipasti anbietet. Mit frischen Zutaten und traditionellen Rezepten möchten wir Ihnen ein Stück Italien inmitten der Stadt präsentieren.", "Bella Italia", "5a", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
