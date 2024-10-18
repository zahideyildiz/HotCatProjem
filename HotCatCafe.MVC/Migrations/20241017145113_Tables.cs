using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotCatCafe.MVC.Migrations
{
    /// <inheritdoc />
    public partial class Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNumber = table.Column<int>(type: "int", maxLength: 45, nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 818, DateTimeKind.Local).AddTicks(6010), "Recusandae ab qui similique animi debitis veritatis.", new Guid("fb56bde3-017c-4745-91ba-f1df02455bb0") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 818, DateTimeKind.Local).AddTicks(6172), "İncidunt repellat quaerat animi unde ut omnis hic in omnis.", new Guid("0cb68f36-02c1-41f1-b81e-9b68fb9dd08a") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 818, DateTimeKind.Local).AddTicks(6202), "İnventore tempora incidunt sint repellendus.", new Guid("126cf40d-7730-4480-8991-5e835c65f81d") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 818, DateTimeKind.Local).AddTicks(6217), "Perspiciatis quia nulla sunt ratione iure nihil accusantium adipisci saepe.", new Guid("f3e06cb0-d47a-44c9-a0c6-9aa3a61bc6c6") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 818, DateTimeKind.Local).AddTicks(6281), "Est voluptatem enim reiciendis quod.", new Guid("37bf577c-1d10-4cf0-84b6-9fedf1d7fb5c") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 818, DateTimeKind.Local).AddTicks(6299), "Veniam blanditiis qui aut aut minus.", new Guid("c2d81276-03d3-4634-9ab3-58f06fdc6c59") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 818, DateTimeKind.Local).AddTicks(6317), "Aut repellat rerum.", new Guid("e66a080a-ab4a-4c99-8f24-ca9edfdb4f3b") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 818, DateTimeKind.Local).AddTicks(6326), "Rem quia tempore nulla.", new Guid("70413b96-48f4-4bf1-8875-db03f891c526") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 818, DateTimeKind.Local).AddTicks(6338), "Delectus tempore temporibus rem vitae est.", new Guid("ee636159-7383-45ee-9413-632572591ccd") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 818, DateTimeKind.Local).AddTicks(6354), "Similique aut culpa qui deserunt.", new Guid("bf31dc0f-0002-40ee-af70-a39c9f411610") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(902), new Guid("01f0ca49-b31b-4f83-b40e-2be2da6f06e8"), new DateTime(2024, 9, 4, 12, 13, 12, 278, DateTimeKind.Local).AddTicks(8223), null, 297.05m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(977), new Guid("a1ddb400-c3d0-4d80-a6c3-e38acb2bdaa3"), new DateTime(2024, 7, 22, 12, 47, 16, 586, DateTimeKind.Local).AddTicks(7602), null, 272.67m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(986), new Guid("f7ae01c8-2a35-4641-8a3f-c8f1b066923b"), new DateTime(2024, 5, 31, 12, 50, 13, 211, DateTimeKind.Local).AddTicks(3150), null, 113.91m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(992), new Guid("627beb58-dce0-4afd-a9a2-14c03afa1da3"), new DateTime(2024, 5, 22, 4, 12, 48, 639, DateTimeKind.Local).AddTicks(6878), null, 423.07m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(997), new Guid("7b2f081e-804a-4346-8da0-380ed1ca6b04"), new DateTime(2024, 9, 25, 6, 40, 4, 806, DateTimeKind.Local).AddTicks(6511), null, 198.47m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1003), new Guid("c91a2f70-d9e3-4912-9d90-046b70fb6efd"), new DateTime(2024, 4, 9, 0, 59, 43, 523, DateTimeKind.Local).AddTicks(7360), null, 435.61m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1013), new Guid("17380f70-40bf-40c0-8e82-e64216027e4c"), new DateTime(2023, 12, 3, 2, 10, 23, 705, DateTimeKind.Local).AddTicks(1626), null, 340.07m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1018), new Guid("483bb7c8-eae8-4825-8386-f34f373f6e31"), new DateTime(2024, 7, 14, 19, 1, 2, 407, DateTimeKind.Local).AddTicks(824), null, 249.75m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1023), new Guid("09dd6d2f-6817-4adc-afd3-f3c6a99133c9"), new DateTime(2024, 10, 6, 0, 22, 23, 782, DateTimeKind.Local).AddTicks(308), null, 285.22m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1029), new Guid("09cc64dd-87cb-40fd-b27a-82341ea56956"), new DateTime(2024, 7, 8, 1, 11, 23, 842, DateTimeKind.Local).AddTicks(1080), null, 356.77m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1033), new Guid("4d683f10-ceae-4aaa-abe3-f3d1e5c76326"), new DateTime(2024, 6, 28, 8, 52, 30, 731, DateTimeKind.Local).AddTicks(1459), null, 70.05m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1039), new Guid("3f333223-3e05-4be2-a6da-eea37898ca94"), new DateTime(2024, 6, 25, 21, 41, 22, 876, DateTimeKind.Local).AddTicks(2603), null, 292.28m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1043), new Guid("fef0537b-c2fe-44f9-8a01-d9b17d39cde6"), new DateTime(2024, 6, 30, 3, 27, 46, 959, DateTimeKind.Local).AddTicks(1051), null, 169.03m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1048), new Guid("7d470788-a332-45be-ba75-6c1de94f2184"), new DateTime(2024, 9, 11, 8, 38, 42, 707, DateTimeKind.Local).AddTicks(5238), null, 377.76m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1054), new Guid("f9fa7005-7ade-49df-8d38-b5cf5b5940de"), new DateTime(2023, 11, 12, 5, 1, 42, 872, DateTimeKind.Local).AddTicks(1485), null, 151.11m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1059), new Guid("0160ee3e-690c-4ca3-b86f-55c8c6be3980"), new DateTime(2024, 8, 8, 11, 29, 19, 800, DateTimeKind.Local).AddTicks(7328), null, 44.10m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1064), new Guid("932e526b-347c-4097-8170-420547c28be8"), new DateTime(2024, 1, 17, 12, 36, 23, 709, DateTimeKind.Local).AddTicks(4658), null, 475.16m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1070), new Guid("a88ec15b-116d-452e-9ac9-ea02e1316123"), new DateTime(2024, 4, 4, 16, 15, 8, 763, DateTimeKind.Local).AddTicks(7199), null, 410.50m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1074), new Guid("d65b8553-2498-4029-85f3-27c562895be2"), new DateTime(2024, 7, 12, 22, 8, 17, 231, DateTimeKind.Local).AddTicks(7495), null, 392.36m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TableId", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1079), new Guid("c8fe3898-09e4-4ee6-9eab-e2b0c6a2afbb"), new DateTime(2024, 10, 14, 12, 19, 5, 723, DateTimeKind.Local).AddTicks(8520), null, 124.95m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(7847), 0.080000000000000002, "https://picsum.photos/640/480/?image=535", new Guid("e2d8a8ab-da32-4c0f-a90e-4f96aff8fd2f"), "Tiramisu", 1.97m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(7966), 0.48999999999999999, "https://picsum.photos/640/480/?image=39", new Guid("d8aba7a2-32a9-4168-86f0-9b8396f011ca"), "Turkish Coffee", 81.58m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(7984), 0.17999999999999999, "https://picsum.photos/640/480/?image=132", new Guid("e7e1539f-af8f-4ae0-94d8-a12497129680"), "Macaron", 544.96m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(7993), 0.33000000000000002, "https://picsum.photos/640/480/?image=783", new Guid("5193829f-aad2-407f-8434-8e9f43fa8284"), "Cappuccino", 200.70m, (short)44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8002), 0.40999999999999998, "https://picsum.photos/640/480/?image=657", new Guid("8fb1520b-8793-4ab4-a4b8-cf12c90c113a"), "Profiterole", 908.00m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8011), 0.41999999999999998, "https://picsum.photos/640/480/?image=52", new Guid("60fd8efe-5135-417f-8074-46cca764b480"), "Affogato", 416.89m, (short)16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8044), 0.31, "https://picsum.photos/640/480/?image=95", new Guid("e45fe5db-d2f5-43eb-83d5-2eae8a389b76"), "Turkish Coffee", 754.12m, (short)81 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8051), 0.13, "https://picsum.photos/640/480/?image=811", new Guid("91bba8d7-28ef-4c83-a32b-bf1a506ea3d4"), 761.70m, (short)4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8058), 0.080000000000000002, "https://picsum.photos/640/480/?image=932", new Guid("cac09994-cf17-4852-afd3-b17201ce41a8"), "Espresso Macchiato", 729.17m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8065), 0.059999999999999998, "https://picsum.photos/640/480/?image=864", new Guid("438318ca-9e6a-4106-8930-e8ceebc9f5e0"), "Brownie", 625.41m, (short)92 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8074), 0.20999999999999999, "https://picsum.photos/640/480/?image=654", new Guid("72617e2d-2d99-437a-927e-2ba0ec09fd36"), "Frappé", 357.74m, (short)21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8081), 0.45000000000000001, "https://picsum.photos/640/480/?image=457", new Guid("42468e65-c785-4e37-a507-3da7e5ade145"), 478.70m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8088), 0.40000000000000002, "https://picsum.photos/640/480/?image=264", new Guid("6526557f-efce-4b9a-a245-ba7638cd064a"), "Cookie", 106.33m, (short)23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8095), 0.26000000000000001, "https://picsum.photos/640/480/?image=284", new Guid("6bb7f35a-20d1-4147-85dc-2308489cfd07"), "Turkish Coffee", 127.44m, (short)35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8102), 0.02, "https://picsum.photos/640/480/?image=164", new Guid("3ef9db9a-bec8-49c6-8e6e-8dfb67cc2001"), "Frappé", 518.89m, (short)99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8108), 0.44, "https://picsum.photos/640/480/?image=946", new Guid("380c2fd3-4791-4c97-aa02-0fbfc6434cda"), 397.79m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8115), 0.10000000000000001, "https://picsum.photos/640/480/?image=723", new Guid("91f350f5-d4ff-45d7-9903-d8826b5e55f4"), "Affogato", 765.02m, (short)27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8147), 0.12, "https://picsum.photos/640/480/?image=502", new Guid("74a8dc26-b7d6-4f7f-ac1b-66ef6c146c0e"), "Cheesecake", 33.80m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8156), 0.070000000000000007, "https://picsum.photos/640/480/?image=745", new Guid("8d9fc3e7-9a38-4c1c-a2e2-094258769e68"), "Chai Tea Latte", 2.97m, (short)76 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8164), 0.31, "https://picsum.photos/640/480/?image=502", new Guid("2003731c-1630-451a-985e-8624f7884dff"), 622.74m, (short)40 });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableId",
                table: "Orders",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 314, DateTimeKind.Local).AddTicks(6238), "Et perferendis qui voluptatibus molestias quis sit beatae.", new Guid("f8308d25-5a68-4969-b4f2-4efc71f6401f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 314, DateTimeKind.Local).AddTicks(6469), "Reprehenderit praesentium voluptas aut qui corrupti.", new Guid("0919726f-5b7c-4e93-8431-ccb89c579a19") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 314, DateTimeKind.Local).AddTicks(6566), "Est aut eum et aut ad necessitatibus quam minus autem.", new Guid("0ccfaaa7-21f2-4ae1-ab71-dafefe50cc2c") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 314, DateTimeKind.Local).AddTicks(6602), "Deserunt ipsum nam aut error sed tempore laborum.", new Guid("49321e2e-c984-4c4c-8885-de6017a0cf3f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 314, DateTimeKind.Local).AddTicks(6629), "Amet nisi et.", new Guid("1979834b-6c69-495b-9512-37853e6e37ed") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 314, DateTimeKind.Local).AddTicks(6645), "Dolor iusto qui ipsam pariatur modi aspernatur.", new Guid("8b540b38-5f46-496c-9559-98f7a47247d5") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 314, DateTimeKind.Local).AddTicks(6667), "Eos quia temporibus eaque possimus voluptates nesciunt dolor et incidunt.", new Guid("585cced2-4340-4aee-a560-698f78f001dc") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 314, DateTimeKind.Local).AddTicks(6697), "Est dolorem sit beatae sunt dignissimos aliquam.", new Guid("26aaa4cb-5ba2-4097-a76a-815c8ec154a3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 314, DateTimeKind.Local).AddTicks(6718), "Hic error eos ipsum animi.", new Guid("33dd49f3-b860-44ae-accc-268fa674b35d") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 314, DateTimeKind.Local).AddTicks(6768), "İste itaque corrupti vero nam aspernatur animi.", new Guid("cb22704f-cf7c-4656-be3a-2265259852b3") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9231), new Guid("2fa7baff-a459-4832-9f0a-4053d40089e9"), new DateTime(2023, 11, 23, 11, 18, 34, 204, DateTimeKind.Local).AddTicks(2103), 121.44m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9326), new Guid("b3126753-69e3-4eca-9316-db065a3c0ded"), new DateTime(2024, 10, 1, 13, 31, 59, 131, DateTimeKind.Local).AddTicks(4803), 45.93m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9342), new Guid("6933d215-7394-4115-8964-114bd11fd81c"), new DateTime(2023, 12, 4, 8, 5, 51, 480, DateTimeKind.Local).AddTicks(1456), 490.77m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9355), new Guid("3f8e0fac-4363-4d69-b2d9-221da7b58a24"), new DateTime(2024, 1, 30, 10, 54, 11, 558, DateTimeKind.Local).AddTicks(9627), 372.76m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9361), new Guid("da55ef0b-cca5-45d8-9fff-253ee7934591"), new DateTime(2023, 10, 23, 20, 37, 9, 939, DateTimeKind.Local).AddTicks(7082), 223.32m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9369), new Guid("29eddddc-9789-4127-a724-d8c0a2aa90de"), new DateTime(2023, 12, 26, 12, 19, 3, 178, DateTimeKind.Local).AddTicks(6349), 185.65m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9375), new Guid("9884cf1f-9f47-4a9f-a574-82f325e7dcb4"), new DateTime(2023, 11, 4, 22, 34, 40, 797, DateTimeKind.Local).AddTicks(6953), 153.47m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9380), new Guid("e35ebd2b-ad0e-435c-a598-31a70f9345d6"), new DateTime(2023, 12, 26, 1, 32, 56, 204, DateTimeKind.Local).AddTicks(5803), 53.47m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9387), new Guid("995b6f50-1c0d-4dba-b6e6-fe21e6c8e5d4"), new DateTime(2024, 2, 21, 10, 19, 13, 276, DateTimeKind.Local).AddTicks(7504), 288.55m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9393), new Guid("b82f5627-e399-47d3-9200-45c10818b981"), new DateTime(2024, 6, 1, 22, 20, 48, 808, DateTimeKind.Local).AddTicks(4559), 426.08m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9399), new Guid("821deab5-4f52-49d1-a8ab-2ded56d96bfa"), new DateTime(2024, 8, 1, 9, 58, 49, 827, DateTimeKind.Local).AddTicks(4767), 469.60m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9407), new Guid("a3524f74-dd16-4797-b9b4-5425269c00a9"), new DateTime(2024, 5, 11, 1, 1, 17, 724, DateTimeKind.Local).AddTicks(9947), 376.89m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9412), new Guid("efa03914-8aeb-4a3d-86a9-35dace15103e"), new DateTime(2023, 11, 24, 18, 23, 18, 696, DateTimeKind.Local).AddTicks(2163), 209.28m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9418), new Guid("d5352c56-4811-456d-b78f-370252e6e0b4"), new DateTime(2024, 7, 9, 4, 20, 14, 364, DateTimeKind.Local).AddTicks(2593), 327.87m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9423), new Guid("39df12f1-4943-46ca-b958-e9f1bdc072c2"), new DateTime(2024, 7, 5, 13, 43, 0, 931, DateTimeKind.Local).AddTicks(887), 484.35m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9457), new Guid("c67e8d01-caf5-4877-90b2-06d3e1b60e23"), new DateTime(2024, 1, 2, 9, 17, 10, 133, DateTimeKind.Local).AddTicks(1768), 252.53m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9462), new Guid("a7e0b99a-9806-415a-8f7e-8ed93b614b5e"), new DateTime(2024, 8, 9, 3, 4, 52, 505, DateTimeKind.Local).AddTicks(4791), 216.68m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9469), new Guid("2fd93622-34e9-4ff6-8fab-420cef96ae2a"), new DateTime(2023, 12, 6, 15, 3, 44, 110, DateTimeKind.Local).AddTicks(7062), 268.41m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9474), new Guid("a50c93b2-129c-4175-9bb7-90855e0d468c"), new DateTime(2024, 6, 14, 14, 46, 3, 995, DateTimeKind.Local).AddTicks(3911), 472.93m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 317, DateTimeKind.Local).AddTicks(9481), new Guid("e0e3b310-265b-43aa-b808-4cec53331684"), new DateTime(2023, 12, 2, 6, 27, 24, 215, DateTimeKind.Local).AddTicks(55), 365.56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2611), 0.20999999999999999, "https://picsum.photos/640/480/?image=212", new Guid("cc2809cf-e2c0-467c-ae82-0c34a6b9d203"), "Macaron", 393.94m, (short)29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2761), 0.02, "https://picsum.photos/640/480/?image=387", new Guid("09b31461-573f-4518-ac95-09a07b56e502"), "Chai Tea Latte", 864.98m, (short)25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2809), 0.02, "https://picsum.photos/640/480/?image=323", new Guid("c43457dc-5415-4cd1-9b00-6ad25ea44b77"), "Cappuccino", 54.24m, (short)22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2822), 0.25, "https://picsum.photos/640/480/?image=715", new Guid("256aa692-2173-4f4e-b6fd-548b5a5fa36e"), "Flat White", 502.32m, (short)81 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2832), 0.12, "https://picsum.photos/640/480/?image=995", new Guid("7833e5fa-5d0e-4387-8ee6-84b972f6fe19"), "Iced Coffee", 632.15m, (short)98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2845), 0.12, "https://picsum.photos/640/480/?image=1016", new Guid("9ba6b106-4168-400c-9b05-a960095515d2"), "Muffin", 7.67m, (short)41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2856), 0.25, "https://picsum.photos/640/480/?image=801", new Guid("49370894-85e3-405d-8708-f4bbf3043050"), "Americano", 846.36m, (short)62 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2871), 0.23000000000000001, "https://picsum.photos/640/480/?image=651", new Guid("51c0eb49-2867-4ff3-9ce2-3a3c65a79e95"), 170.11m, (short)61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2878), 0.45000000000000001, "https://picsum.photos/640/480/?image=878", new Guid("a3409f77-00cc-4052-aca3-60a10641b112"), "Frappé", 271.73m, (short)74 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2886), 0.28000000000000003, "https://picsum.photos/640/480/?image=234", new Guid("646945c1-2151-4212-881e-aaf48962dc4a"), "Affogato", 159.33m, (short)82 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2893), 0.0, "https://picsum.photos/640/480/?image=893", new Guid("0540a0c0-f7cc-47c8-910a-c051bccf1d62"), "Waffle", 622.21m, (short)40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2901), 0.040000000000000001, "https://picsum.photos/640/480/?image=726", new Guid("2d331869-1f09-410a-9e2d-7edd3752007f"), 491.25m, (short)3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2907), 0.20000000000000001, "https://picsum.photos/640/480/?image=759", new Guid("93f888cf-f8fd-417c-9294-52cf8f40a80b"), "Americano", 456.11m, (short)51 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2939), 0.42999999999999999, "https://picsum.photos/640/480/?image=344", new Guid("84ac1e67-fec3-46ca-b184-6c7e3d5a8c7f"), "Frappé", 313.76m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2948), 0.20999999999999999, "https://picsum.photos/640/480/?image=588", new Guid("7872f8fd-ee7f-4c56-8688-d08b6e37a3a2"), "Waffle", 238.56m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2957), 0.28999999999999998, "https://picsum.photos/640/480/?image=517", new Guid("194c8948-63a3-4a53-a90a-58f7ffc6c64e"), 673.66m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2964), 0.41999999999999998, "https://picsum.photos/640/480/?image=18", new Guid("a71af0b8-d1bb-404a-b0dc-658e03b58951"), "Latte", 960.84m, (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2972), 0.5, "https://picsum.photos/640/480/?image=728", new Guid("c88dff51-2caf-4ae0-bf0f-d41dcf9d041e"), "Muffin", 367.14m, (short)90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2979), 0.25, "https://picsum.photos/640/480/?image=40", new Guid("e83d63db-206b-49c1-aa1a-7177862f1e4f"), "Cappuccino", 66.91m, (short)56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2986), 0.11, "https://picsum.photos/640/480/?image=784", new Guid("ec9d5b33-f968-4c13-b595-01781cde45be"), 291.77m, (short)44 });
        }
    }
}
