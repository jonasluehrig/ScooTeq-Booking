using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScooTeqBooking.Migrations
{
    public partial class DatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT COLLATE NOCASE", nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    TripDistance = table.Column<double>(nullable: true),
                    TotalTripCost = table.Column<double>(nullable: false),
                    TripDiscountPercentage = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 1, "Demo", true, "Admin", "qQnYyvK/vjABTZvbbL7ZeSWpaRx6OoDY:nZ1pFR3XGgp3+NyrbW7Xrt56kWiZ91F2fSIFHt1yQwo0E9BuSa4vuLvbQuBJk7WFA2ILpUaxoARMPoh8uu2EHw==", "admin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 73, "Jesus", false, "Carter", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Jesus52" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 72, "John", false, "Rogahn", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "John12" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 71, "Karen", false, "Schultz", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Karen_Schultz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 70, "Percy", false, "Friesen", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Percy_Friesen20" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 69, "Dawn", false, "Spinka", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Dawn_Spinka40" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 68, "Gerard", false, "Boyle", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Gerard_Boyle36" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 67, "Leah", false, "Muller", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Leah45" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 66, "Courtney", false, "White", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Courtney.White65" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 65, "Arthur", false, "Champlin", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Arthur.Champlin80" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 64, "Ollie", false, "Abshire", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Ollie60" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 63, "Hubert", false, "Spinka", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Hubert_Spinka99" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 62, "Kelly", false, "Quigley", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Kelly_Quigley" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 61, "Robin", false, "Blanda", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Robin_Blanda" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 60, "Sophie", false, "Murray", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Sophie_Murray" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 59, "Constance", false, "Schimmel", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Constance72" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 58, "Kirk", false, "Hand", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Kirk13" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 57, "Lori", false, "Graham", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Lori.Graham" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 56, "Doyle", false, "Bode", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Doyle_Bode" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 55, "Carlton", false, "Paucek", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Carlton.Paucek" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 54, "Jodi", false, "Russel", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Jodi21" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 53, "Jill", false, "Huels", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Jill.Huels44" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 74, "Gwen", false, "Jast", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Gwen_Jast" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 75, "Sidney", false, "Smith", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Sidney0" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 76, "Donald", false, "Legros", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Donald88" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 77, "Orville", false, "Kuhic", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Orville_Kuhic" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 99, "Bobbie", false, "Donnelly", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Bobbie.Donnelly" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 98, "Rodney", false, "Willms", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Rodney_Willms" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 97, "Cheryl", false, "Wyman", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Cheryl_Wyman" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 96, "Kathy", false, "Stracke", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Kathy14" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 95, "Byron", false, "Hayes", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Byron.Hayes49" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 94, "Donna", false, "Wunsch", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Donna92" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 93, "Leigh", false, "Hickle", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Leigh_Hickle" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 92, "Judith", false, "Nolan", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Judith.Nolan" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 91, "Larry", false, "Powlowski", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Larry21" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 90, "Inez", false, "Gleason", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Inez.Gleason76" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 52, "Edith", false, "Watsica", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Edith_Watsica" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 89, "Lowell", false, "Zieme", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Lowell21" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 87, "Keith", false, "Koepp", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Keith21" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 86, "Jeffrey", false, "Nicolas", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Jeffrey_Nicolas" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 85, "Caleb", false, "Altenwerth", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Caleb23" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 84, "Janie", false, "Bins", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Janie28" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 83, "Alberta", false, "Wiza", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Alberta.Wiza" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 82, "Irene", false, "Pagac", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Irene38" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 81, "Renee", false, "Hettinger", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Renee_Hettinger" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 80, "Yvonne", false, "Watsica", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Yvonne59" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 79, "Marion", false, "Kertzmann", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Marion26" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 78, "Anthony", false, "Casper", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Anthony98" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 88, "Rene", false, "Kautzer", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Rene_Kautzer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 100, "Teresa", false, "Quigley", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Teresa_Quigley" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 51, "Brenda", false, "Cormier", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Brenda_Cormier8" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 49, "Sheri", false, "Lind", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Sheri.Lind" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 22, "Darnell", false, "Moen", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Darnell_Moen47" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 21, "Karla", false, "McGlynn", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Karla37" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 20, "Velma", false, "McClure", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Velma20" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 19, "Irvin", false, "Douglas", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Irvin_Douglas" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 18, "Kristine", false, "Buckridge", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Kristine_Buckridge81" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 17, "Ana", false, "Spinka", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Ana_Spinka82" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 16, "Josefina", false, "Gorczany", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Josefina0" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 15, "Guadalupe", false, "Murazik", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Guadalupe.Murazik53" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 14, "Jenna", false, "Treutel", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Jenna63" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 13, "Sheryl", false, "Dicki", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Sheryl_Dicki13" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 12, "Daisy", false, "Brakus", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Daisy25" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 11, "Abel", false, "Swift", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Abel.Swift54" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 10, "Arturo", false, "Steuber", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Arturo71" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 9, "Cassandra", false, "Goldner", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Cassandra_Goldner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 8, "Dianne", false, "Powlowski", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Dianne.Powlowski57" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 7, "Kristin", false, "Trantow", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Kristin.Trantow" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 6, "Benny", false, "Gulgowski", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Benny.Gulgowski63" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 5, "Salvador", false, "Fritsch", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Salvador_Fritsch46" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 4, "Nina", false, "Russel", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Nina.Russel" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 3, "Lydia", false, "Stroman", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Lydia51" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 2, "Douglas", false, "Shanahan", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Douglas72" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 23, "Joanne", false, "Schamberger", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Joanne98" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 24, "Noah", false, "Labadie", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Noah_Labadie20" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 25, "Tonya", false, "Kunze", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Tonya.Kunze32" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 26, "Louise", false, "Gorczany", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Louise96" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 48, "Toni", false, "Armstrong", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Toni.Armstrong" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 47, "Sheila", false, "Wintheiser", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Sheila_Wintheiser89" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 46, "Angie", false, "Satterfield", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Angie.Satterfield" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 45, "Alicia", false, "Runolfsdottir", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Alicia.Runolfsdottir" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 44, "Karen", false, "Larkin", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Karen.Larkin4" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 43, "Karl", false, "Ward", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Karl.Ward" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 42, "Edith", false, "McDermott", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Edith.McDermott" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 41, "Fredrick", false, "Ratke", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Fredrick.Ratke" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 40, "Joseph", false, "Runolfsson", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Joseph_Runolfsson25" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 39, "Silvia", false, "Larson", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Silvia_Larson34" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 50, "Robin", false, "Johnson", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Robin_Johnson" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 38, "Pedro", false, "Collier", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Pedro90" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 36, "Mike", false, "Hamill", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Mike94" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 35, "Emma", false, "Dicki", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Emma_Dicki" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 34, "Amy", false, "Kessler", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Amy.Kessler19" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 33, "Timmy", false, "Glover", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Timmy72" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 32, "Margarita", false, "Rodriguez", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Margarita.Rodriguez" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 31, "Fredrick", false, "Quitzon", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Fredrick94" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 30, "Angelica", false, "Robel", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Angelica_Robel" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 29, "Nadine", false, "Cole", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Nadine34" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 28, "Lora", false, "Witting", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Lora_Witting" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 27, "Betty", false, "Reichert", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Betty_Reichert87" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 37, "Mike", false, "Reilly", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Mike.Reilly2" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 101, "Christian", false, "Hessel", "rsLxtxsnwNez924mH8l6vCqEiPWRfE/2:InCOMn7X76HAYf0Y9YTVAdwkJp8hE1QMUhUW7al+80CWqO0EGjerZWuJ6N4KksSKiouxn3fs/rqY6yEp7s/SPA==", "Christian29" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserName",
                table: "Customers",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
