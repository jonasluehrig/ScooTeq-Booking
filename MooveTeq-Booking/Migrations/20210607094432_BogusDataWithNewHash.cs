using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MooveTeqBooking.Migrations
{
    public partial class BogusDataWithNewHash : Migration
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
                    TripDistance = table.Column<int>(nullable: true),
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
                values: new object[] { 1, "Demo", true, "Admin", "s3avW9Ui/GGhyw9H/5hS1uNvgMKYCO0p:3e7fotqzOUEwq7Xyo1GP3/yE1hFGoS9Wc8QzpRYt/OxrHT+syDH2eXNWKGsTnHbk8O2Ml6ERk9pP+UNGLOt38A==", "admin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 73, "Bethany", false, "Ferry", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Bethany.Ferry" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 72, "Dexter", false, "Gislason", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Dexter86" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 71, "Monica", false, "Abbott", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Monica.Abbott12" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 70, "Sandra", false, "Koch", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Sandra_Koch" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 69, "Jake", false, "Walter", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Jake_Walter63" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 68, "Ray", false, "Glover", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Ray21" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 67, "Brandon", false, "Emmerich", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Brandon_Emmerich" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 66, "Tyrone", false, "Gottlieb", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Tyrone_Gottlieb" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 65, "Meredith", false, "Volkman", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Meredith59" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 64, "Patricia", false, "Lueilwitz", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Patricia97" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 63, "Marian", false, "Johns", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Marian47" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 62, "Pauline", false, "Adams", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Pauline.Adams" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 61, "Josephine", false, "Bednar", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Josephine.Bednar40" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 60, "Sammy", false, "Reinger", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Sammy.Reinger50" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 59, "Deanna", false, "Ullrich", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Deanna.Ullrich96" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 58, "Gerard", false, "Stoltenberg", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Gerard_Stoltenberg19" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 57, "Essie", false, "Green", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Essie91" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 56, "Frankie", false, "Gibson", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Frankie87" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 55, "Kelly", false, "Emard", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Kelly.Emard" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 54, "April", false, "Kuphal", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "April47" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 53, "Angela", false, "Welch", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Angela.Welch" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 74, "Melba", false, "Schuster", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Melba95" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 75, "Cecelia", false, "Reynolds", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Cecelia_Reynolds19" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 76, "Malcolm", false, "Morissette", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Malcolm_Morissette" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 77, "Ellis", false, "Schneider", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Ellis62" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 99, "Arturo", false, "Weissnat", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Arturo_Weissnat60" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 98, "Sherri", false, "Corwin", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Sherri96" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 97, "Brandon", false, "Kutch", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Brandon_Kutch" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 96, "Brad", false, "Senger", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Brad65" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 95, "Sonya", false, "Murray", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Sonya.Murray21" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 94, "Nicolas", false, "Von", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Nicolas_Von54" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 93, "Beulah", false, "Waelchi", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Beulah_Waelchi" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 92, "Loren", false, "Schaden", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Loren_Schaden34" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 91, "Willie", false, "Lueilwitz", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Willie25" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 90, "Jacob", false, "Runolfsson", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Jacob.Runolfsson" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 52, "Sean", false, "Gislason", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Sean_Gislason" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 89, "Timothy", false, "McCullough", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Timothy.McCullough84" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 87, "Laurence", false, "Dicki", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Laurence92" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 86, "Clay", false, "Haley", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Clay_Haley9" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 85, "Juana", false, "Cruickshank", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Juana.Cruickshank98" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 84, "Malcolm", false, "Heathcote", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Malcolm79" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 83, "Blanca", false, "Toy", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Blanca_Toy" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 82, "Geoffrey", false, "Boyer", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Geoffrey59" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 81, "Benny", false, "Powlowski", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Benny64" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 80, "Chelsea", false, "Schamberger", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Chelsea.Schamberger28" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 79, "Abel", false, "Abernathy", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Abel98" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 78, "Doug", false, "Beer", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Doug50" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 88, "Jordan", false, "Kulas", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Jordan93" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 100, "Salvador", false, "Roob", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Salvador_Roob81" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 51, "Erma", false, "Will", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Erma_Will" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 49, "Lillian", false, "Jakubowski", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Lillian_Jakubowski" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 22, "Melvin", false, "Legros", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Melvin.Legros" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 21, "Ollie", false, "Pollich", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Ollie_Pollich86" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 20, "Anita", false, "Bernier", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Anita38" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 19, "Ernesto", false, "Bailey", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Ernesto.Bailey" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 18, "Hector", false, "Feest", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Hector75" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 17, "Hannah", false, "Hayes", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Hannah.Hayes11" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 16, "Adam", false, "Hoeger", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Adam.Hoeger23" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 15, "Rochelle", false, "Gerlach", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Rochelle_Gerlach12" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 14, "Ada", false, "Armstrong", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Ada.Armstrong" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 13, "Juan", false, "Graham", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Juan.Graham33" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 12, "Jenna", false, "Dietrich", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Jenna_Dietrich" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 11, "Lorraine", false, "Renner", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Lorraine90" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 10, "Sheila", false, "Glover", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Sheila30" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 9, "Ethel", false, "Mitchell", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Ethel46" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 8, "Clifton", false, "Wisoky", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Clifton.Wisoky" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 7, "Jodi", false, "Moore", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Jodi.Moore17" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 6, "Clark", false, "Kulas", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Clark15" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 5, "Bobbie", false, "D'Amore", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Bobbie_DAmore" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 4, "Frederick", false, "Anderson", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Frederick73" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 3, "Felicia", false, "Koch", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Felicia40" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 2, "Debbie", false, "Gusikowski", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Debbie_Gusikowski74" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 23, "Cesar", false, "Crist", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Cesar10" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 24, "Vicky", false, "Hoppe", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Vicky_Hoppe" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 25, "Caroline", false, "Hermann", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Caroline_Hermann" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 26, "Ron", false, "Crona", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Ron_Crona" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 48, "Angel", false, "Wiza", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Angel94" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 47, "Ruben", false, "Stiedemann", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Ruben_Stiedemann43" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 46, "Duane", false, "O'Kon", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Duane.OKon57" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 45, "Tara", false, "Towne", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Tara.Towne92" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 44, "Stacy", false, "Kilback", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Stacy52" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 43, "Gerardo", false, "Blick", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Gerardo_Blick" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 42, "Enrique", false, "Barton", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Enrique54" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 41, "Julius", false, "Wunsch", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Julius_Wunsch47" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 40, "Marcella", false, "Leuschke", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Marcella_Leuschke" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 39, "Alyssa", false, "Bruen", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Alyssa61" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 50, "Betsy", false, "Haley", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Betsy12" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 38, "Cecil", false, "Shanahan", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Cecil22" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 36, "Viola", false, "Bosco", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Viola_Bosco90" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 35, "Marcia", false, "Lueilwitz", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Marcia_Lueilwitz43" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 34, "Pat", false, "Powlowski", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Pat34" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 33, "Guadalupe", false, "Mosciski", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Guadalupe55" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 32, "Dana", false, "Reichel", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Dana_Reichel" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 31, "Allan", false, "Spinka", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Allan.Spinka" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 30, "Miriam", false, "Kuhlman", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Miriam.Kuhlman38" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 29, "Javier", false, "Rowe", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Javier_Rowe" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 28, "Joanne", false, "Metz", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Joanne.Metz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 27, "Lena", false, "Trantow", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Lena_Trantow43" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 37, "Beatrice", false, "Predovic", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Beatrice_Predovic23" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 101, "Ashley", false, "Pollich", "ehEfflYUWfqO6mt6J2WrgmlCjIHViCkd:N5Tnz2m+GoVjcxewwZ2lxenoZNqrhjBC7lNyg46rUie26uAkpcZCRsBeEfC/ltNif8qIAnnj3pgosQn0zT7HXQ==", "Ashley44" });

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
