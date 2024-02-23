using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.API.Migrations
{
    /// <inheritdoc />
    public partial class addingentitiesinrentalagreementmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "70ec2f24-ae41-4aab-a547-227bc7233234" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "b97ac176-70fd-4967-a501-d50baed78595" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70ec2f24-ae41-4aab-a547-227bc7233234");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b97ac176-70fd-4967-a501-d50baed78595");

            migrationBuilder.AddColumn<string>(
                name: "CarMaker",
                table: "CarRentalAgreements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarModel",
                table: "CarRentalAgreements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarName",
                table: "CarRentalAgreements",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CarMaker",
                table: "CarRentalAgreements");

            migrationBuilder.DropColumn(
                name: "CarModel",
                table: "CarRentalAgreements");

            migrationBuilder.DropColumn(
                name: "CarName",
                table: "CarRentalAgreements");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ba1c9a46-7abf-4037-9225-a750b10527c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e155ac0e-670a-410d-9bfc-d21661169e43");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "70ec2f24-ae41-4aab-a547-227bc7233234", 0, "211111e8-63bf-471c-8ee7-325e33520aa0", "admin@test.com", false, false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAELBWlwKTpBjSA1FEwTjEUHzXKioIahjoUbOOb5Adcuh7qqwaBqAd6lDIpjHmA9lsjw==", null, false, "734d226a-ea5b-4ccb-ae9e-9520a64ca4f4", false, null },
                    { "b97ac176-70fd-4967-a501-d50baed78595", 0, "518463e2-8bb6-4ebf-990d-13e4a0281a1c", "user@test.com", false, false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEJTSw1e0grBO8kLPtVjgqG0Jdp3KMkq1OJmUID4X7CLMopiT+CETnwegiVkGUEGPHQ==", null, false, "a509e3df-fa59-4c76-8abc-25c538e4f1f7", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "70ec2f24-ae41-4aab-a547-227bc7233234" },
                    { "2", "b97ac176-70fd-4967-a501-d50baed78595" }
                });
        }
    }
}
