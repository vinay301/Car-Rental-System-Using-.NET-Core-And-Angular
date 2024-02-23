using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.API.Migrations
{
    /// <inheritdoc />
    public partial class addingisRentedentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "998db33a-64d6-40c5-adad-dfaa317e3f72" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "cc53f04d-3175-4ad9-be53-f9f3839579a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "998db33a-64d6-40c5-adad-dfaa317e3f72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc53f04d-3175-4ad9-be53-f9f3839579a9");

            migrationBuilder.AddColumn<bool>(
                name: "isRented",
                table: "CarRentalAgreements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c5a44895-2281-43dd-895e-d65f1dea97ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "befb354b-0b33-4865-a63d-533f23b5bba1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ea1e07b-492c-4a62-8b58-7a699cc3517c", 0, "4c8f5a7d-8562-4d49-812c-95a99918e23f", "user@test.com", false, false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEOVDAHgZhqY5pk4OWvjlYFN4kMf/ukmJJi7pkxvLfaPfxvvelJNp3JpycbAZYm1Drg==", null, false, "028d62c9-74de-49c5-ab45-624fff3f4d0b", false, null },
                    { "6d8da658-533d-4d7d-92a7-c4e7f4f05f13", 0, "2bbb4173-ecf1-4d74-a790-2f7c49c76c71", "admin@test.com", false, false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEPpcJYVKvgugAoRRAwqP2rumOtmloTEMZRJR1bcEIz1UJegb6gnq393jZqLOTBUUyw==", null, false, "982b7290-f50f-4dcc-b8c2-161f0fae1398", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "0ea1e07b-492c-4a62-8b58-7a699cc3517c" },
                    { "1", "6d8da658-533d-4d7d-92a7-c4e7f4f05f13" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "0ea1e07b-492c-4a62-8b58-7a699cc3517c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "6d8da658-533d-4d7d-92a7-c4e7f4f05f13" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ea1e07b-492c-4a62-8b58-7a699cc3517c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d8da658-533d-4d7d-92a7-c4e7f4f05f13");

            migrationBuilder.DropColumn(
                name: "isRented",
                table: "CarRentalAgreements");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5f55365f-9662-4f82-9ba8-1df848cb44d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "0cf7b181-de17-4088-af27-c9af39d23e8e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "998db33a-64d6-40c5-adad-dfaa317e3f72", 0, "e0092cc8-9fc8-4ec2-a91d-ce45bb601671", "user@test.com", false, false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAECjlchYxes8mxGC69Gz2EDJW8SVpxs4GaKKQmIEjMGWnh19cM08I8bTERn0MGRRcgg==", null, false, "9342b4a2-4419-4cb9-b7b6-ad13fc142f4a", false, null },
                    { "cc53f04d-3175-4ad9-be53-f9f3839579a9", 0, "d1834ba3-23ad-4c97-9b4f-68824e7aeb73", "admin@test.com", false, false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAECqBgwqclep9xkgPzt75jXrLVkY0YVCJgLsaNNgzzzhgN/kjdnZkouSBZbsg/vk9Nw==", null, false, "809ad232-65d8-4f8d-8ea9-8f90a6c0577f", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "998db33a-64d6-40c5-adad-dfaa317e3f72" },
                    { "1", "cc53f04d-3175-4ad9-be53-f9f3839579a9" }
                });
        }
    }
}
