using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 730, DateTimeKind.Local).AddTicks(877), new DateTime(2022, 5, 9, 13, 45, 31, 729, DateTimeKind.Local).AddTicks(9932), new DateTime(2022, 5, 9, 13, 45, 31, 730, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 730, DateTimeKind.Local).AddTicks(2226), new DateTime(2022, 5, 9, 13, 45, 31, 730, DateTimeKind.Local).AddTicks(2224), new DateTime(2022, 5, 9, 13, 45, 31, 730, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 730, DateTimeKind.Local).AddTicks(2233), new DateTime(2022, 5, 9, 13, 45, 31, 730, DateTimeKind.Local).AddTicks(2232), new DateTime(2022, 5, 9, 13, 45, 31, 730, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 732, DateTimeKind.Local).AddTicks(4078), new DateTime(2022, 5, 9, 13, 45, 31, 732, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 732, DateTimeKind.Local).AddTicks(4100), new DateTime(2022, 5, 9, 13, 45, 31, 732, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 732, DateTimeKind.Local).AddTicks(4105), new DateTime(2022, 5, 9, 13, 45, 31, 732, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 734, DateTimeKind.Local).AddTicks(1957), new DateTime(2022, 5, 9, 13, 45, 31, 734, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 734, DateTimeKind.Local).AddTicks(1979), new DateTime(2022, 5, 9, 13, 45, 31, 734, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 734, DateTimeKind.Local).AddTicks(1984), new DateTime(2022, 5, 9, 13, 45, 31, 734, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 735, DateTimeKind.Local).AddTicks(5729), new DateTime(2022, 5, 9, 13, 45, 31, 735, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 45, 31, 740, DateTimeKind.Local).AddTicks(6033), new DateTime(2022, 5, 9, 13, 45, 31, 740, DateTimeKind.Local).AddTicks(6043) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 587, DateTimeKind.Local).AddTicks(9223), new DateTime(2022, 5, 9, 13, 41, 59, 587, DateTimeKind.Local).AddTicks(8278), new DateTime(2022, 5, 9, 13, 41, 59, 587, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 588, DateTimeKind.Local).AddTicks(583), new DateTime(2022, 5, 9, 13, 41, 59, 588, DateTimeKind.Local).AddTicks(581), new DateTime(2022, 5, 9, 13, 41, 59, 588, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 588, DateTimeKind.Local).AddTicks(590), new DateTime(2022, 5, 9, 13, 41, 59, 588, DateTimeKind.Local).AddTicks(589), new DateTime(2022, 5, 9, 13, 41, 59, 588, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 590, DateTimeKind.Local).AddTicks(2780), new DateTime(2022, 5, 9, 13, 41, 59, 590, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 590, DateTimeKind.Local).AddTicks(2802), new DateTime(2022, 5, 9, 13, 41, 59, 590, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 590, DateTimeKind.Local).AddTicks(2807), new DateTime(2022, 5, 9, 13, 41, 59, 590, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 591, DateTimeKind.Local).AddTicks(9489), new DateTime(2022, 5, 9, 13, 41, 59, 591, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 591, DateTimeKind.Local).AddTicks(9512), new DateTime(2022, 5, 9, 13, 41, 59, 591, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 591, DateTimeKind.Local).AddTicks(9516), new DateTime(2022, 5, 9, 13, 41, 59, 591, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 593, DateTimeKind.Local).AddTicks(3191), new DateTime(2022, 5, 9, 13, 41, 59, 593, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 41, 59, 598, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 5, 9, 13, 41, 59, 598, DateTimeKind.Local).AddTicks(3457) });
        }
    }
}
