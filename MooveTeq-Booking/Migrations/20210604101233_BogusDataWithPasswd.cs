using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MooveTeqBooking.Migrations
{
    public partial class BogusDataWithPasswd : Migration
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
                values: new object[] { 1, "Demo", true, "Admin", "cYnsvE5m+9OpbgOK69x76wozBJuYV5Jm:uccBM5nX041hFULOsL/1adJg+UmY5/Jy61iV1QP6xiWX6eTwuxGJ81Dlal8y0gtVYaXE26orCGU+gNxeKZbx1Q==", "admin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 73, "Lori", false, "Ruecker", "zG81ILjsAhzJWTedkzBah6q5WAi47dQv:wpiizVKwCBQcPv+7d+J3uVJy+FY98ZsPV5EiNUHy2QaXp1+PO8q89NYrh5M391/eQQOTxSNUMAOHNJJQPlVpEQ==", "Lori.Ruecker" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 72, "Bernard", false, "Buckridge", "18Eg/dresTHAQArnGEgNYwtnEjYbhGgm:LNI1P8cmwY4VICIc/Q+nVvNTQHP69aIA0gdrxUogIlgZo8Habg7gtdvBoxAhbDk+rYaNg4M3SiGliUdx2p7H8g==", "Bernard_Buckridge80" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 71, "Dallas", false, "Reynolds", "IH2bmL1szhZD5SiXnmiAKnBTWOnJFwHe:L6RojA8IUJZo+G+u9R9dtScmEQ2QOdPmL8lPjE0vnJe/35v3V77TgQmMuNbh44iGZF7zTRW/xg+fKp2xMNXE9Q==", "Dallas.Reynolds17" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 70, "Stanley", false, "Gaylord", "jyCA90P+9vKhVUb1zmz0D9vxkAMO0kcC:ovsDNpcBRXo1xoCIzlhfQYLJkdvw8FpVTo5lxEpZkm5aH463TzI2Yuj2UrEYtcrIXBMya5+Wt0w7Iu2AsvmW2A==", "Stanley64" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 69, "Cody", false, "Kunde", "insHvi0GC52hVtIQkWHLyHyDAobvUh5L:HqdY59gp6mzDGyNd65HSOz3NKtqdCCjEQysScTZzlduEx7xhMNrrRNn0Qx1vfz29j0e22u83efBbzKcH0+oyJQ==", "Cody43" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 68, "Juana", false, "Ryan", "ttzTCNuN6GYJzuLcURICYl8lItEmEjkp:whOzdPGDvA0wR3zqV/fzcV7aFMAKqKDKfK0o4AseFf5h28U6J/Gvjbgy7POtgvAPUhbCPHm4lJUwvJkaCCrfsg==", "Juana.Ryan84" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 67, "Julian", false, "Grant", "PrrOwR9APSs48vzvjWoAE1Ss2WHl/md/:4poHGbTsMnjum8+9C3YR0nAluz0Zy2p9CFZadg4v6Ilh9Rr/QFtAy9M7sg1lpIStJJhRxTX1+qzyzHl0ddpp4g==", "Julian_Grant" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 66, "Carlos", false, "Brown", "4WFkt6j2swmGU5ETlLbBxF/zdht7YesV:S6LUf0m/t8fBrG2bhlAEBD1DopvwZw7fX6ge6Z/OrPfzkXiJDVGqShdOywZ5NWQIxKholzWrSdGcOoA2C1cukg==", "Carlos_Brown72" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 65, "Lynn", false, "Lowe", "hMgZnWuDCxeKt/HgpNEs2CBAKFFGbLf3:tBuWofSqRQtVW8PVz6Y7Rwv6auddIEne57jMrN256iXbiErNDvcdEHLiBBkO5ymKzuSTh0q7uQatz3poJYHJHA==", "Lynn_Lowe" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 64, "Margaret", false, "Torp", "fYY88EkvgbM47UdJntTdatnNvALDE2MI:1NCpwJNHXoK13XCRG5alXjlIjY0OkgBNvRBcKhZ9UA/LMOEoWeSBELhUjjMSVY55/s3UMDyJmrd/JUwEkMxzEQ==", "Margaret.Torp" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 63, "Rosie", false, "Reichert", "lLqJRQhndjNEN7RWMHl8cKmwm66D/eMB:cWu2I61p5yWW8mCK41yW33H9sJ3QVARv8eS0ag8EpjQHcs9zuFwJkFdj9O7vUM8/0pgL7j6P/Sc8F3/tX1a4IA==", "Rosie.Reichert" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 62, "Tracy", false, "Deckow", "0gJAT5DKwc3kBpyjPOxl3Dz51l/rjdni:cqJ7Tstp7rve1Oh40xCCo8MEkcsBLL1Z5PGKrzhU59yOD4S+0wEqQSSGQxCdyK4jJuPkqKRglB/cqk5DrN81kg==", "Tracy96" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 61, "Boyd", false, "Labadie", "cSzPeIuODRTD/cNYqEo9MiFD/DyeZHCL:7DUxy9Rzyep1sySybvWDc3owqKRZZ2kmqR7yI2t+b1Oq0XGYVM0db0CpAXN5ISSZ1XmKmvwxt2T8T+0Ja96tqg==", "Boyd.Labadie20" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 60, "Rachel", false, "Douglas", "0f1bwllafdOYmn24j4G79CofZdMEqeBs:2WMRMpTipo+V+YiCnF+rL5s1rQXvNN6s7yijG1AW+CCtu25TSqMQR8iGApDDa9nYSOndq6HEAwGPiqCcJrAYHg==", "Rachel_Douglas" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 59, "Victoria", false, "Yost", "ezzXe852RgoXNnnjMfb80o4xA6ET2sEC:q+DAedyyxab7fTwgYiIlE5uEDtEpmyG1e1kFIkDMQ3Ef30yjXRChuBYId30CqfUmYHEHfKUq9H2b/bnTSY8DxQ==", "Victoria32" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 58, "Jana", false, "Kozey", "FfGSDREAiAd2GODyx/AiDUa527FryxjL:RnITZpzGFhnDoAyA+N9EJV4Yc21z9V4TTcQaMRo3vZuAAmMuhzIaS0TaUQlkq+51OXl+luj8wd5Ym63MlC1eDA==", "Jana36" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 57, "Lucy", false, "Larkin", "y9Jw/dzQtxwV0h6MfWWeXEQ8FWtviS5I:4XLg9HFmLmPLdZoHWsv5i9ya5WW/g0egRJt9/94p4VNuNvyhZ1yQ+y1fwtZqNUUu1zu+8UyRThe6aBUGtRm/jA==", "Lucy47" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 56, "Mercedes", false, "Gibson", "F1OinBFfo9Nj8/GKlXCBf7CUzwsxR+OA:Wfy4q8qrU2RFzrle0nqYrMNhrNMtZmCEDAggCJjKxvkBidtgKVDnlqVY7VWPvunvHqPD7NJg42b+VQ9gnp+ZNg==", "Mercedes_Gibson" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 55, "Daisy", false, "Swaniawski", "d44XHjQeIQ1yZ4Lyyxhfhg+MFVPC+E9R:9H9oS/+17+UqFG8Q1mFPUDqnGfVf03lkogC/PhxVDG2XEz2YyuGP3kpSwdN30UX/bndmctvrXo85KlcJN4TLoQ==", "Daisy.Swaniawski13" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 54, "Jenny", false, "Marvin", "94zKV+Kp6cz5FlpBn9pbfO8dekjfcWaT:G7vPOQPol5YD+k3ajsr0wmInhHvfWaEEKJN3wc+Dv75LBXg6JNcckDBj8irB+QqkGDzXkN7ADqMfMkawPYLnvw==", "Jenny8" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 53, "Guy", false, "Rodriguez", "yF25lr6zQttUoWJbsDfKwXg4IB7Ul3Oz:oNFlkspe+MAKym2wilkjFA3ywrUCUvYXLAyO4qKUUHSZYLDk5AT3dKiomYIkH/bh2bY+EpyiC+mvAot47rpJgg==", "Guy.Rodriguez54" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 74, "Martin", false, "Rippin", "JFSSLMiuDjqQiisbSBCf4vCKk1Mh3o66:lmXw2ISqE4fBOMtmQjgVwQ1KAAudAeoiTH7HXjnMut7hdXhj4bAGOF5mXaOq1OkBk/CjqkeZ9Bk7hFhHE2iwZQ==", "Martin_Rippin37" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 75, "Nicolas", false, "Fritsch", "vMdFDRH7aVJNbbEGNs7IJAvPKkmtSZDg:nf5nMcnVJ8po8FlBZfVbz11KwCEE8EKerlv4pbTPT63Xbafql/43p1qcuOokArnR8HChZ9GeL8qyeV/HNb5INg==", "Nicolas70" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 76, "Ervin", false, "Weimann", "+Vh/K4FX9Lln87IByYWnYoWABke/Cn84:aLPqnqcz0v5lFG7mU72DLYEXSz8f4dJJzd8DWL3oOMTGynLRhozJbOBU/oZ0rwPloqqdLu61sCpZfhm1zCieVQ==", "Ervin31" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 77, "Kerry", false, "Hudson", "dChNfAzjIK/H3rgfZy2fwMQ6Z9VVrowh:u3o+uHj84sl/h6zD9Tmg6CiLeU608u/lzSMybRPJx8R/rupQP0Nj9EpuiA4VKXg1Rk1RotRPWldAVUoQV9hHzw==", "Kerry_Hudson94" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 99, "Tonya", false, "Hagenes", "bWEVl988TnOGPLS81fmnAncwf3vlkhAg:6zP3juV434PXo1rmUPu4Rz04rC4WT0h+PQWdniOuIVgo//xaL6icEEwHyPRpthBRoLH9eVYW68gXDu901JgHxA==", "Tonya_Hagenes30" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 98, "Harold", false, "Hettinger", "Im/9GSyDi/501Ho7s6IYNafLKG2cu71r:9h/8CeV8RCTGxNwPbJnsvPYUdyBoqKjaaZc/hRx8cPg2hUqoYDzWW34i7N38e93oApvFW3AmvmDsx+BrZPSWjw==", "Harold44" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 97, "Carlton", false, "Ledner", "oqLiwreqKg4mizkyDdXwMJoyOk9Wn4vB:3lTypBA4jaAGziFrEfm5t3dp0b1lSDUSdNDGR6/qBoJhIN6RKsvS1Nn4BAvDadp4OOE6UQdiPF+IlA893RBDwA==", "Carlton75" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 96, "Angie", false, "Hudson", "UYoIqZoyur5RI/lmFvYrmT87JzuKTYC+:kXiooo/SowuJnBXqBKED9cpzdVxVZA8P3YX+bsB4al7RG9cL14G8PTjIznCK6Mvw7XzRkuNtKULNqIHfPE3d9g==", "Angie_Hudson" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 95, "Melody", false, "Will", "+6VhAmQxCqCtpqosfC9Q20yxiNAO8wK8:3M4pdpKrz5aFZ2jjfPCYtqrYh43/NEUZDWy/wPvqipzpzhwebA+IHCfDCdvAfO+ZJlq5/zihVfXFSWZRYkzIOQ==", "Melody8" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 94, "Cristina", false, "Frami", "4KHO+il26L+6piVN3wZ1lFDUzWvoSFNG:ivw/MYOt3LmKebPOhUW4oaYH3AXDi5anz6lXz62TyVKsxFekpvRMjr9UzgpXHaJt77xAyzvTZK8vr8gC81ps4A==", "Cristina.Frami67" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 93, "Ben", false, "O'Conner", "j6rFAEw7UewEOoT6P3yaSQrbq7MrMnEI:RhXoFx43Y88aPDjJXloPt3Am/3CY6YzEAAx7A7/nforaqzl/CCL4l9Tzv3yhx4tIwSjF2U4+MLxUM9lUO8o5Pw==", "Ben_OConner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 92, "Terrence", false, "Effertz", "jGSRKMarmF4Lf11fcRG5nFPcBzCmoXtQ:tnXBWu9rjnj5tBsr3Qi/smsj/3rZeqQjFcbGqhhxMJXmhfrE5E8ff7+y7ccOikCDDz3QYQGeIsJA7FMtfm6b9Q==", "Terrence35" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 91, "Faith", false, "Heathcote", "4bFug6fsR5iT4aFMz9ywHF7+4sCxJyWd:GQmUdWEDR3tLbsdHa/N6NKheEZaCD9GH7a+eCATcupwVoeq/oPsOKevSzsD9ZeTzS137g/22FesVaZH9dCcnnw==", "Faith_Heathcote20" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 90, "Dan", false, "Lemke", "dahYPsrGe5syE/JLFjM4rCP9Wg1gvrkA:C8OrGr6PKwTH9HoKaVia2a292DhgqTurl1hBDAKJJNbRcrmyt34fGlEd009FE7zXUL3IfbpScohNxNgjQQ0pBA==", "Dan_Lemke92" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 52, "Annette", false, "Simonis", "tGEyixtVucNu5qd29mH36p2ev9Rz8hOk:nHEOaONYAK16Nu8+3A0gueGNZsk52WgrKYSG095xHV9Gc4sLghTIWxibef5LYuT5aB3w0CFRDHoHi+q0Rszv5g==", "Annette0" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 89, "Michael", false, "Windler", "n7UPsnokw9SA5ScY5j+8cZ/bqRRuUamz:E+FZR4+nmPDE+MOQfqhz4JiGGZJlustJ1WFFKOnd/xvrjH4rPY1oDmKvgd7xDqWpSuRrMcJqCaU/Nm3WjbSZnw==", "Michael.Windler66" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 87, "Vera", false, "Nolan", "7rW9U+rotidplwPFugxv1z6M61ZSkY4x:Nip1BGWXLK2YsmAea4DNdlEoSV3BizEwysN/xyLB40pyJaOf5qfVq/6teODmMOLcf4wP6iVDe73rp6/9NFNxng==", "Vera35" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 86, "Wayne", false, "Beier", "2e2s6aATWxrBWQVHls4LIXxdOGJ1mcpE:wCN33WzMubAk0IAQZJ1j3jdhi5VskqwFbhra26FfrdCLAvf4F06yGNVjuYw5JYfgivnwpbzHJ9f90i6y6MUcTw==", "Wayne32" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 85, "Damon", false, "Kerluke", "GqVvBSp9w+pORchipCyu3G11FK37GK3X:FVf063rW1ilr+GrQnhrFR/vlZrgFZJEemA8SyOPcmjlQZ+WHXZGO0J/mTNocGOBL8P7FLCakPkr3VFrNriWtNA==", "Damon.Kerluke" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 84, "Maurice", false, "Kutch", "qQ5MrB4tql1jj6v06loou470Jwd2qaXS:TcTLrrxzcA+YvrO2X4rI5lJ0AYLldgaKz6r9qjCsuxQm3lhiRtyJGFtUZobBSo148T0XOcwLzLVALaicvtsFLQ==", "Maurice_Kutch2" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 83, "Kimberly", false, "Breitenberg", "oM7MNwlDih4b3d9JcBEN0X8Jxchxt5BP:9kXxa5oakQZXPdcQ3RG6cIGO7nm6DgHisnO0Jzw/9zhzgEbNnSUbOi6zr/a3Ex3ZVS1vmACJLuYXn7FKtwFfMg==", "Kimberly79" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 82, "Kara", false, "Block", "6Fyfe/ZsiGL309upBSdy/6hro5F6VJwt:M28r4s5ohAfHIyOVswtVK2rAReaqtvdDo4puxlzUZxAp4FszG58Q0Znu0GCcOsA8vDhk7NQTcbA0BkT63+FZrA==", "Kara95" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 81, "Keith", false, "Murray", "xn7XSnKbw8l3B/ytfMAgRXc85qSRlMvj:k8aXwKlj4a+1K2hwzHuqgE6G1st7J5w8xP0+Fbre9XMDkJ5IQ3z/3+aNSAkK3PD5Cj8wfF4tOYqsqumn8eytfg==", "Keith_Murray" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 80, "Beverly", false, "Thompson", "ShhfkqgSRsaVH+dLwhWyt/hLjMFaC/0V:ipTVdTR5/HeOrJFaP8AWG0D/mzkSQES9TNR+kFk3nVjQjhJI6b2y2EPB01PKHhaBmQ/7GxnbTJKil0g567K37g==", "Beverly8" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 79, "Lillian", false, "Rodriguez", "N4IGFyIfgCzDhM7BOczisJM3v7A3U33u:G/1gJB7pz1OS7LrEaQNtxmlCMk2FQKl+IVSGd2SHXXLNpoC07nMwEBrsgd788lXGC1OnlPANW4LFtULHiUqZSA==", "Lillian_Rodriguez" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 78, "Frank", false, "Ratke", "tViEFugbeNn1ud3EaLCVZ/mQ9HnrYb37:m3bVHj7C7DuvhFDd7UR2yoeRBbj7r34LG09SEg6NubFv2eGJMHFKv/9/8zSMQYFzY6kF5RTqdeWUehCZEy4/EQ==", "Frank_Ratke64" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 88, "Sabrina", false, "Leuschke", "6sYUDAdJ8E/XFHPp4wovn5OiW6/rppQC:rwllEkelPjNrl83V3Gw+A5W/nIE/tXL1EFmDSx27bLyD5htf0ktNO+NyFbf1Up0M7EQTli6fboIbRYwL6+3FXg==", "Sabrina.Leuschke53" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 100, "Kate", false, "McDermott", "16Mfy7/9HW/xxHt79gZqgo1SI66AAyFr:UzlxLNIbiIqKNdgs/Mn5tOY96ggaxAODMylAKqDxtd+YrqBoOTTPjeCq7ooeX0GQaDjAypkA4oJNUO1cuMJWYQ==", "Kate88" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 51, "Christopher", false, "Veum", "uQEzDPsvySMbLkug6ndBdApWQjuqnvq5:0eb1JQ7bnjwBFEsLgPvrkx7TZwV0P9HWx62Yw/QyNnPnP1Y0S9BnyE6AJUMITB6XeBJxP9WsKWHksf/nz+yu8Q==", "Christopher_Veum60" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 49, "June", false, "Wunsch", "3UcM8/QJ+qm7bpBdPOQy6SYKlXAWvV2G:3isCUabfOvn1w5HErhyeNXi728zgYeWwV+t28WpGCCMCVPtE/TDZyODyx3Sy4M8MKuGwCZC6LVZ6ynkyUnMbSw==", "June_Wunsch" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 22, "Kellie", false, "Murray", "Ln3XFE+qMoDRmJfqHtPwCO3C+dIBobmW:lUcM0r5X25mjCPn/DnxGzUgxpsVyQ+ffKrRZBf1NirRh89jatBOHySJ1H1tQ0pgSZT3QxQjzl5MN2HrtfCllZA==", "Kellie.Murray" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 21, "Sean", false, "Feil", "23eattgZjWdyUFIi6vtDSmdKsWpWoo9b:xWjmksO5jAh42pLFJwzWs73kjqXaO4mo8Z2dbyNYOzFE99bZLA/Ix+LMn2blwIZGXgNSvYrwsNDWYv582Ayblg==", "Sean_Feil" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 20, "Clara", false, "Conn", "G7AN04CODyY92K6+oqfoYwgRnyLnhjZ1:09eh3FbN2e0pj1Uw2OWqW1db+S8QGN6pLDusiyrNhXzTds5/FckbX+OEa36x7GzQsH66MbC56fSE3sFxjrNL3g==", "Clara.Conn79" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 19, "Timmy", false, "Sauer", "u4r90XxYqI7pLeoV2CV+PvTRzusjJOBq:WtfzrnhMwAFnbx6W67FBRSPf0xRpT9CcgHrAeChOGzN63kQioLAXyq7wXGG7OvgFnYrgJaylBph7lzLTxyqu4A==", "Timmy_Sauer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 18, "Carmen", false, "Kuhlman", "9qdCPtrq0Azdp/145uRhBVfzeKfk2SJB:OMeHK11T028rclnpiI82+IjvbtvHtIW6c0ri2EMdcrRsE4AKhF3O3Hri5xp+E7ug7MGFKolWPWfL5GZh2yZ14w==", "Carmen45" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 17, "Kristen", false, "Corkery", "NG944Dn1FygpKLlQKd4t9ynX2U3TQmeW:h29IDxkfxT9eeuRV0kOVN5QO0MJLh1vOIxMe7gBH1opsa7zDvmEivdzMzvncIhH0F073cqzYrO+RccLG/d2T3Q==", "Kristen_Corkery" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 16, "Ann", false, "Crist", "8HGIQuzblhsrtUuw5zNOXjUuQC1D6+NK:WP+sM48KY6SWZ0yQTsWQ1v7b99SL3+yB+dImbyNtc5u2btERuPEGTYXH4C/0lmAjxN9D4ae7ZNJQK59wi2cCSw==", "Ann_Crist" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 15, "Forrest", false, "O'Connell", "XypzAohUmGgG7NmoLm2pQM3jWlxVPD+9:ZHlNhdy9lpe0N8MHfW89y65ZqxEhOin8tFQmic4HoLz+eX2ekW57ruQSlE2ggV/kfLNmNUzYutVVpMAWJWCOTA==", "Forrest.OConnell" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 14, "Jackie", false, "Keebler", "+m3ckRU7HRPED0npSxKRRbzB/B/dIMSE:BLG3sGGCr1MiIcwNfLKDPvqx/h8jxSKpjcif5sHHLLRD9EjIsEfMvpOkWqoXBCNRDptc49AFdFTuv3JVJqfpdA==", "Jackie_Keebler49" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 13, "Lonnie", false, "Adams", "NG8PgvMIPAu3ferhTqtcglAcajx15bMC:nGV5bW7xmdHZipmGqYww3bpPo/3pOzyxYyfj40tkHLEYmTrYOXQKEyeknkMBDQ/jx74TBONlXwWcXWE0O+MjXA==", "Lonnie_Adams84" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 12, "Emily", false, "Little", "jHbsaAhxWhoCq3kQDXtHB0u/iBdAK9H0:bmpXiiXiTOLGlLZ5GIkUruGEnHcZhqHbpDdeb8XlWhiU2oYtY03xx/14rtf+8NxGEOAxFSS4BpejRabMuxgyOw==", "Emily_Little49" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 11, "Benjamin", false, "Koelpin", "MDiNUcMN5VyFvhYR2tFsXzU1THQ7SeHg:wopFXkSa/ubWdl15voWfhusA9nQfIWLG6gblyy2W5DnLv4+Qx5QtnpbIJmmKmSXoNbw9tM9VuhoMpZZMlySO0w==", "Benjamin.Koelpin41" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 10, "Caroline", false, "Dooley", "k1DiEX99RUrSnvcQI3OWPh69aKzE30qh:WRUJgiLw0ioE1HsLGUhAykAqXrpVcLSzl+QEF3it+UUeBml3hTUXoCx3bAedmeJtHQPZ36A893IAcO7ae57cpQ==", "Caroline_Dooley33" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 9, "Dewey", false, "Auer", "wWIK3VJnhxUsEAIVS9Q8qIm5bQV1Kz8W:PaTz+TkkrAuADtWQwDJtCEcruZ3PF2gWfr1jaUXx81Lxx0EwHpgc13DKaLoQ8BKm6pizxEnPmpYRWVBJswb+mg==", "Dewey78" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 8, "Victoria", false, "Walker", "2JPITmk0PXBWWMrxLIocXzGfi/FRRUZk:YNAzxgwOMkl9u4Re+UbgpO4nrAkeXOGnj5juT1OUgnbyh6PoRKLZYYUhhzReLbcFv1R9uCNZ9poXKxdUJPcfXg==", "Victoria_Walker43" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 7, "Kristen", false, "Grady", "WPpqWTTDEccNrMPzNGK2ihWaXCdC/CcQ:SwViP+IHw88hiqmEQIn8DR4XzAp1Oa19DEJ+CPelh5HqxXATo9bGI5e2LHUd4BMJrN9ZPOTuuqHZnlVppkWksQ==", "Kristen.Grady23" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 6, "Gladys", false, "Kreiger", "tGKXRJgpYNeZfF7oWTQwTcLyokXONqvg:DHNdF+FfYkt6W5H+SQCHFb7h39eCNDweWMalcKdzzlLshLk+O27vYI8LZsPp+L31SwFzc4npvjoSNe4tAikPgA==", "Gladys.Kreiger95" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 5, "Charlotte", false, "Predovic", "hjoDOknOrs72KSPVhcWQ+4IRzH5a14gr:EdF7s2i+vuGj03roe3LPFWn+dYaxJiOSaecdfpfiu6plbbI6uLqqSSPTprSm8M6HLklTbWXT3J8a5si2SNutvA==", "Charlotte70" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 4, "Charlene", false, "Pouros", "c/xdv9NcY1grVZYgyVEzarIpBwGjDDCg:p3+vt+2vHwiop7B2ySKuFDC27y6iMCRnj4YU0dWEGYhRHDdSAf7DwvR1haNnkRUJPj4jNoCWOyJCvFzppf/rUw==", "Charlene19" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 3, "Andres", false, "Padberg", "sSnLjIAw/Q7AEUuCRWP8Sn57MaZt/snt:46Pn6AMg04t1EJeV9IPYwvrrzlRxIO39WoWAeJS1rSCXaQMkplQpyby5OXfMZRnLesA2wjSuW9dWjzYtxJaiwA==", "Andres_Padberg88" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 2, "Melissa", false, "Mitchell", "5POEoz+b8/2NjeqpcB+xVUSBvJdgTWiq:TIV5q2hxwC+SwJvIO6+3d+0I/uNZYpkGKmhNeuPDeZTMbv0fENNFVKwdUCkmUQC81pnOCj9Rh9I/IER3bX8DIw==", "Melissa.Mitchell" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 23, "Dale", false, "Tromp", "M+iSSBAHeO9ByPW8pOyYsaOR93PMeKCk:hmSxMyuerQ9AGET/z+eX3tqUsSHddl2F8MAQ4mnWXsGon/QIvWztmW9vIP9eYyXPmnA7pPyVCm7GvkowASy2Bw==", "Dale24" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 24, "Caleb", false, "Hintz", "h8mjSWNNDdzGraSXlYoYpwU3LNoUW2dE:flDoWEDwC1RYew1GKNDqXvCnJu3ovQIyh4wuF8n4UMzvZMV2rxIOfnVrOOeuXOA2sFSaEnWdKIJrzwLJQZ6mQQ==", "Caleb.Hintz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 25, "Eduardo", false, "Huel", "/4pxDfrNnWdUomEJDRJyWdnbD1RhxuSR:Vn0naQ5xPopoyzuM1aLIEtNGLbln5afsXxJlUJLZvwbp79hJ562VWGPxR+54ikwCQKpRhPSs16pOOJo69b9Mhg==", "Eduardo.Huel87" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 26, "Cody", false, "Kuhic", "9akjwq8tVCVSGbWJVSPVB4TKMlFoIoAq:YRzDPD++pNkhT+XF53VJ03XW94o+VLN1W9Xgzm+NOBHUR4gmpLdux/DxJj3jeEsJavg6pM4yHSePQv4PbCXkrw==", "Cody85" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 48, "Timmy", false, "Tillman", "HLyWcQGCuESFNvTlgT2RbFrFgRkXx+0S:HuaU76u7ilqSVKIyYSelLwjSRGYYZrEQX5syc9IuUp86A7wYfMiPLrqmc0lew40fDJiW3IC0HqEZN4p7aEW+4Q==", "Timmy.Tillman8" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 47, "Tommie", false, "Hilpert", "UUYdrrO0R2YAZeIuWmY1Fe/CxHrTHVtb:R4JcQScE+wh9mRHyFnnxawgdXLfONNU/A8CEx5Eh7RyESucuZUw20DYJQDAfJgl8ozvwCPCvccpD+SSybAKsJQ==", "Tommie.Hilpert2" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 46, "Rogelio", false, "Rippin", "kYApdW/8x+u8Vomp3pMYGeBoaY+UOVt+:/bJEYNWBln1VUn6yEN6qbeX+okoPqjFT8arcbTHfK4JFEl8StwM7da1HGch6JOCNH9aIJ/sXIWJhHsY5z9Nm3Q==", "Rogelio18" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 45, "Herman", false, "Stokes", "Rld2u3Zfa0qnnKRsDNRkDwtIX/g0hFie:ivTcNu25TJeJnXJK86yVbpGD66bcfR4fuFHdsM1xDWiXa47TK1EfavRH1sxNKveQG+q4bX2XIiaulspKp6Y8lw==", "Herman_Stokes71" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 44, "Mandy", false, "Schowalter", "8aeQ2RVGgmKCwkFjJdtseTz9n91k0oAS:OZqwayq4j87TYUShWCY1HcBb3AT+OhyT/DGtyowbXy4BMj31r91a/hAbcdknhY0eBZTw4hDfwhp7N4GfmAKkgA==", "Mandy.Schowalter24" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 43, "Calvin", false, "Wisoky", "ai9Rq6MYfogtNFYKQZwVALywHDpePCFW:NUIQw265vY+FsNNAo3nksxaf7EiFDOXQvEf1+EfkE85D2Z+S+Z89azruTJwz64kJqyUAg/IafuOgsCEDb/QNUA==", "Calvin.Wisoky" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 42, "Debbie", false, "McLaughlin", "qKCC1hdJXJ7zGBCMzKkwUzTqbR+ZxbmM:D9cTfcXcnEkSxlCOWWckvqTt0bQ5hIE4qZq8Jb6MnrtYhl2kmKXutiNu/OLpkk/iTqo9vUkUq71Q+kPBrAmXxw==", "Debbie.McLaughlin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 41, "Jacqueline", false, "Bailey", "XCjsryAG4CDU6XpyH5ImYV0FmejUuPbz:6NHGUiFVAU2E/jXscW+INWKAx9ng992/cb+bKhZY0lYUwqXq7G/7U4iQJzcQtEiJ4rFFI6TNPN9gjflJ5orWdA==", "Jacqueline69" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 40, "Edmond", false, "Kohler", "vbbnKHtc/GhA4HIT5o3/RzBxvUPH/xuT:jBqc9tb7Rilixp/c10dQQs9dci4n5PUeayUVqdX0d93ReRx1JrKTmMMBUmeAl5oOq6tAc1Fpwm4p17qZ8rVYEQ==", "Edmond_Kohler47" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 39, "Freda", false, "Schoen", "3t6FN16T2ZuTgcpfZ+KGup2YF13QrVwW:q6qZ8LbH3SHHF6J/fOHAvedqiCkqh0WksgwQygYNwGhGqhK/5eT/68iSdJTcyMoKha+pt2V13+kCvwlYhnf26Q==", "Freda_Schoen" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 50, "Delbert", false, "Bauch", "jIt48puiicHhPMwnHM8YXAwQ5tYBba0d:xDEyb7hypCdwnIveTvrN0YjmkHilii+t4qi4eJtxxm7N3BXgIdGLoOmFBe9LTRn6NLbH1Bs1Hbte61k6uGokxw==", "Delbert.Bauch" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 38, "Laverne", false, "Lang", "JeJeNH2S69W2IRctbO3lA+/kpEEdqyhf:pIPHcraD+18rNFQCDB39s9Y47PJWn+DTOj5Hp5/pY8xHgojp7VFZIFHsm9uQsz5fet+g0Z8pZxz2dgVjXWpVYg==", "Laverne.Lang" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 36, "Marty", false, "Waelchi", "e20k1RQDdeq8zqlLj1bYZ+qBKRORzsLG:ZZLBEJTndWUiYi5QRkcIrydvj87VK0+mISoV3R0tLJW1gna7X1srUqRKiu/z5bT583elKSp20Y7/nTwtnzIQpA==", "Marty_Waelchi19" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 35, "Scott", false, "Jakubowski", "jeSrjdNybbRNQ37iQlVDsFZZYYO5/wNT:ETqoxHodYQ13JQUkhlhZT9OwCceWaSmVfumXuHExcfRrVVGhhnP9B8jD2GUc4RbJgwPpgdcQiXkcgbxlPamXpg==", "Scott_Jakubowski" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 34, "Cedric", false, "Brown", "w1cHYe5JKEnHzYwRko8PYDHMozG6PG3p:PD+0XVu1lApiXpzzo4qVcHn2yJBDxy6YY8y0mklY8fX0zKxQ8xJBSivmdJWjEc5Hsu2MeLo9VVHB87meLjRmaA==", "Cedric.Brown16" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 33, "Kristie", false, "Bergstrom", "3W/SniWssunpxbmXfU1ztn6Z3X924yvN:4HQuQVSMDP0IhlqS432a4qHGwUpuj5ost0XGQXbIPR73gtj0T/yD/kfNOT6KFIGCr4sWHgXGskrncxP1sxlM2g==", "Kristie71" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 32, "Dianne", false, "Bruen", "GfQqI6oI36pbQcSf5OkhN0cuLDrjZp6X:vL0/dKhSptV8hEyRFXfzxkki80ZlAgDHujSrIGFRh6YqgAHvf+C1d5oZal0+A8I4Qe4m44FsjGTZ4RLyBMgijA==", "Dianne.Bruen78" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 31, "Willie", false, "Walsh", "rLePcu/3OGiRkpKCQ/8LPIMZTVRRx/P8:Ke5JwNMDHC6cCGzXonEbRZleBbJkD8PrGOM/MfeL+l0Llf1eS5MKRZxvvIoMFzb9VY6GV+W4Fksvzzmj0PUJmg==", "Willie.Walsh" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 30, "Terry", false, "Fadel", "CYtTUXrcDaJqKw5iac71pZMrR597XImC:vS2O1/dkUroWRtFtAX4SRew70ewttSRFO+x3ket+H72PwoJuzAGpOyODG9r8yG5piDWLhiD35qlsjKOelOH72w==", "Terry.Fadel" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 29, "Mamie", false, "Spencer", "PXEtyi/nbYvQIOtqUOKK3z460mwthb2+:UdRnZIKlUC8HkAD0kZ7iEOXrQ215vOEh2Mai+4mi2edCGQh1wbUe4i5FyVSrZtpLXG3z6okXLsYeZ9sLankw+w==", "Mamie.Spencer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 28, "Elizabeth", false, "Nikolaus", "aP/87gaKWGDOtfcmC+nlV4EFq93Mxw9Q:5TW+v13tUK4fNr8o54/KKcH1V+jXcJ3pamsnTrXrx0LOdLhaxJPQ2ionUxcPnKy7kX97GLX+76+yBUlJB45/Og==", "Elizabeth_Nikolaus" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 27, "Dominick", false, "Lesch", "kiQ27BjoNss2GGLiiKn90inqmgygQCe2:3kP59M3CVqo/zNTt2//wqNTkqAE2OjP4oHCBJ1/qcREECnDZx3omIFtO60wslPXj23AfGWP1k6FuzpXR8Kn9UA==", "Dominick_Lesch92" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 37, "Sonya", false, "Stark", "WJ34Iaz77YPe4Y75mOc6QhNYG9VhlLjt:qaEMV9DZptnXUPW04LP0Q78NUhL7OVTzbS3G8jU6+IWx83bw4Qb7qT95TJcoqdY3tqUiP6uKP/zlDYnZYwzTzA==", "Sonya.Stark" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "IsAdmin", "LastName", "PasswordHash", "UserName" },
                values: new object[] { 101, "Mario", false, "Bogan", "YpDFknDT6wBrjR/l/RQepypK0/jgzixZ:f46WKh+EIe+wjXEXqBXdVcb95KFsECM3vB/dZ1tpEXeflGvPIll6lppcz8idmefd5fmGcsUl1YVpUXfdxRkEOA==", "Mario.Bogan1" });

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
