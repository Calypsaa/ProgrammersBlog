using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 799, DateTimeKind.Local).AddTicks(9011), new DateTime(2022, 5, 9, 13, 33, 55, 799, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 5, 9, 13, 33, 55, 799, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 800, DateTimeKind.Local).AddTicks(1127), new DateTime(2022, 5, 9, 13, 33, 55, 800, DateTimeKind.Local).AddTicks(1125), new DateTime(2022, 5, 9, 13, 33, 55, 800, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 800, DateTimeKind.Local).AddTicks(1136), new DateTime(2022, 5, 9, 13, 33, 55, 800, DateTimeKind.Local).AddTicks(1135), new DateTime(2022, 5, 9, 13, 33, 55, 800, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 804, DateTimeKind.Local).AddTicks(3151), new DateTime(2022, 5, 9, 13, 33, 55, 804, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 804, DateTimeKind.Local).AddTicks(3193), new DateTime(2022, 5, 9, 13, 33, 55, 804, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 804, DateTimeKind.Local).AddTicks(3200), new DateTime(2022, 5, 9, 13, 33, 55, 804, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 807, DateTimeKind.Local).AddTicks(5682), new DateTime(2022, 5, 9, 13, 33, 55, 807, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 807, DateTimeKind.Local).AddTicks(5714), new DateTime(2022, 5, 9, 13, 33, 55, 807, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 807, DateTimeKind.Local).AddTicks(5719), new DateTime(2022, 5, 9, 13, 33, 55, 807, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 809, DateTimeKind.Local).AddTicks(3626), new DateTime(2022, 5, 9, 13, 33, 55, 809, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 33, 55, 816, DateTimeKind.Local).AddTicks(2979), new DateTime(2022, 5, 9, 13, 33, 55, 816, DateTimeKind.Local).AddTicks(2994) });
        }
    }
}
