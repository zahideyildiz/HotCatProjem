using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCat.DAL.Migrations
{
    /// <inheritdoc />
    public partial class migorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Orders_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Products_ProductId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "OrderDetail");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Orders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "ProductId", "OrderId" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 305, DateTimeKind.Local).AddTicks(2825), "Maxime modi atque ipsa voluptatem beatae consequatur atque molestiae.", new Guid("4aceb8d3-8c88-4a4e-bc7a-bd735265a5ca") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 305, DateTimeKind.Local).AddTicks(3016), "Voluptatem hic est asperiores non.", new Guid("53ecf42d-8109-4222-b333-7f0c2a6f7e46") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 305, DateTimeKind.Local).AddTicks(3040), "Et necessitatibus dolorem.", new Guid("28ac829d-a1c3-4a2c-8b74-83c2210ad610") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 305, DateTimeKind.Local).AddTicks(3055), "Ullam quam omnis nihil.", new Guid("983a1649-2c21-4eb1-8b22-7d301b98f03f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 305, DateTimeKind.Local).AddTicks(3071), "Consequatur exercitationem sit sequi et voluptas mollitia nihil qui.", new Guid("d1e396a3-3ba8-47f5-8585-fee7c3e71ff4") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 305, DateTimeKind.Local).AddTicks(3106), "Possimus ut aut aspernatur voluptas omnis sit dignissimos repudiandae fugiat.", new Guid("acae8bce-935d-42fe-b726-38629cd32686") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 305, DateTimeKind.Local).AddTicks(3131), "Ut dolorem facere veritatis enim molestiae facilis corrupti.", new Guid("f1d13b30-ba59-4185-9a98-ba025fd1e15b") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 305, DateTimeKind.Local).AddTicks(3151), "Laudantium repellat et nesciunt voluptates iste qui.", new Guid("1d550bee-4ba4-4dc8-9c97-aeee90b3856a") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 305, DateTimeKind.Local).AddTicks(3177), "Dolorem neque eaque.", new Guid("8229d829-f0d6-45cb-89d6-d22e1cbbb80f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 305, DateTimeKind.Local).AddTicks(3189), "Maxime animi provident facere iusto nam dolor.", new Guid("94beed30-0a77-4b8d-84ca-a9aa2902b219") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "AppUserId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CustomerName", "DiscountId", "IsActive", "MasterId", "OrderDate", "Status", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 308, DateTimeKind.Local).AddTicks(3979), "192.168.1.1", "Floyd Carter", null, true, new Guid("185824ca-3eaf-43eb-b632-5ba7e539eff3"), new DateTime(2024, 7, 9, 21, 42, 19, 153, DateTimeKind.Local).AddTicks(7987), 0, 395.05m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3012), "192.168.1.1", "Floyd Carter", null, true, new Guid("b9cf0eb7-7e52-424e-aa1f-1313dc7d80f5"), new DateTime(2024, 4, 19, 12, 47, 33, 504, DateTimeKind.Local).AddTicks(2092), 0, 200.97m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3100), "192.168.1.1", "Floyd Carter", null, true, new Guid("e73a1737-5adc-46bd-b0d0-182daec54c3b"), new DateTime(2024, 5, 15, 16, 46, 14, 656, DateTimeKind.Local).AddTicks(4246), 0, 111.65m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3110), "192.168.1.1", "Floyd Carter", null, true, new Guid("d18a6879-0451-4390-b380-f7658e362d94"), new DateTime(2024, 3, 4, 3, 9, 18, 514, DateTimeKind.Local).AddTicks(3508), 0, 436.55m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3118), "192.168.1.1", "Floyd Carter", null, true, new Guid("0e87f2c9-647c-4abb-bbef-36d8c70573d4"), new DateTime(2023, 10, 28, 1, 49, 42, 673, DateTimeKind.Local).AddTicks(4245), 0, 277.46m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3128), "192.168.1.1", "Floyd Carter", null, true, new Guid("e2957b88-90e4-4c17-88ce-36057170f1a0"), new DateTime(2024, 7, 21, 3, 36, 7, 188, DateTimeKind.Local).AddTicks(3552), 0, 483.56m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3135), "192.168.1.1", "Floyd Carter", null, true, new Guid("d70a302f-aaa7-484e-9654-79fc8ce74818"), new DateTime(2024, 2, 28, 11, 45, 0, 661, DateTimeKind.Local).AddTicks(9294), 0, 216.25m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3143), "192.168.1.1", "Floyd Carter", null, true, new Guid("ccc7c4d3-78c9-43f2-a081-8387e3e6eca6"), new DateTime(2024, 7, 6, 21, 16, 0, 465, DateTimeKind.Local).AddTicks(543), 0, 274.21m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3157), "192.168.1.1", "Floyd Carter", null, true, new Guid("1ffbf271-66a7-46a4-9213-40e9c33166c1"), new DateTime(2024, 9, 1, 5, 51, 33, 59, DateTimeKind.Local).AddTicks(8838), 0, 396.11m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3165), "192.168.1.1", "Floyd Carter", null, true, new Guid("c358d1fa-93ce-42b4-b3d3-176ba7d6a99a"), new DateTime(2023, 10, 3, 3, 17, 48, 836, DateTimeKind.Local).AddTicks(7704), 0, 237.94m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3173), "192.168.1.1", "Floyd Carter", null, true, new Guid("cf87d2ce-4569-41c1-8bc0-24021ad11b0f"), new DateTime(2023, 10, 2, 22, 55, 23, 705, DateTimeKind.Local).AddTicks(4476), 0, 398.65m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3180), "192.168.1.1", "Floyd Carter", null, true, new Guid("4d3d1239-afb3-4d6a-b1d9-d27cf9c4ed90"), new DateTime(2024, 7, 17, 3, 8, 48, 767, DateTimeKind.Local).AddTicks(3402), 0, 245.18m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3186), "192.168.1.1", "Floyd Carter", null, true, new Guid("dc993c6d-dad7-4ff9-b651-5d81a7e17f43"), new DateTime(2023, 11, 17, 14, 28, 8, 455, DateTimeKind.Local).AddTicks(9588), 0, 336.09m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3192), "192.168.1.1", "Floyd Carter", null, true, new Guid("c0f06cf3-7cf6-4630-a8ae-912168113e36"), new DateTime(2023, 9, 14, 19, 57, 34, 315, DateTimeKind.Local).AddTicks(6546), 0, 81.34m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3200), "192.168.1.1", "Floyd Carter", null, true, new Guid("2b7ef402-2b7f-4742-ab6c-6a143ffd785f"), new DateTime(2023, 9, 19, 6, 32, 35, 337, DateTimeKind.Local).AddTicks(3417), 0, 353.27m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3207), "192.168.1.1", "Floyd Carter", null, true, new Guid("267e8db8-35a1-4190-9827-d1a20a6773ca"), new DateTime(2024, 7, 12, 23, 41, 4, 609, DateTimeKind.Local).AddTicks(8579), 0, 246.70m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3214), "192.168.1.1", "Floyd Carter", null, true, new Guid("14c6aa83-6016-459e-89a1-bf60aa126d4f"), new DateTime(2024, 7, 29, 13, 5, 3, 315, DateTimeKind.Local).AddTicks(7678), 0, 426.45m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3222), "192.168.1.1", "Floyd Carter", null, true, new Guid("e074cfcb-396a-4b3a-b336-cae338097901"), new DateTime(2023, 10, 20, 14, 20, 35, 938, DateTimeKind.Local).AddTicks(8116), 0, 132.86m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3230), "192.168.1.1", "Floyd Carter", null, true, new Guid("1f4f8cf1-3036-4482-8b87-898b465ae66c"), new DateTime(2023, 9, 21, 19, 26, 49, 163, DateTimeKind.Local).AddTicks(8769), 0, 403.17m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 2, 25, 1, 309, DateTimeKind.Local).AddTicks(3237), "192.168.1.1", "Floyd Carter", null, true, new Guid("bb87dbd6-8484-434e-a0de-8ac2ef87ff97"), new DateTime(2024, 1, 24, 19, 26, 1, 688, DateTimeKind.Local).AddTicks(8413), 0, 368.62m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5147), 0.32000000000000001, "https://picsum.photos/640/480/?image=750", new Guid("19fa76cf-f07e-48b4-afd4-b03a4e096abe"), "Profiterole", 814.91m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5290), 0.34000000000000002, "https://picsum.photos/640/480/?image=413", new Guid("db8e1096-06c3-4235-b68a-8163c18dbc37"), "Espresso Macchiato", 821.70m, (short)23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5305), 0.23000000000000001, "https://picsum.photos/640/480/?image=1065", new Guid("f260211b-f0f1-479b-91e8-ea8a4fab6b6a"), 484.57m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5315), 0.40999999999999998, "https://picsum.photos/640/480/?image=871", new Guid("8964a0ec-8416-44d9-a244-2c8c6ef1f647"), "Waffle", 182.48m, (short)27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5325), 0.070000000000000007, "https://picsum.photos/640/480/?image=233", new Guid("7aa902c7-5089-423e-8c41-d0a4e63ca225"), "Latte", 231.02m, (short)36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5336), 0.14000000000000001, "https://picsum.photos/640/480/?image=84", new Guid("3afb5887-9ae5-4d18-b232-84d559df8815"), "Iced Coffee", 383.59m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5352), 0.40999999999999998, "https://picsum.photos/640/480/?image=594", new Guid("1162cbe4-daac-4857-8135-1bad4ee469f9"), "Espresso Macchiato", 740.05m, (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5368), 0.02, "https://picsum.photos/640/480/?image=912", new Guid("343a0da9-923c-47d3-a895-919fb807e51b"), "Tiramisu", 870.63m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5379), 0.42999999999999999, "https://picsum.photos/640/480/?image=56", new Guid("3fe450ee-4ea8-4f20-b519-7e8f7aeb0773"), "Pie", 243.31m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5391), 0.46000000000000002, "https://picsum.photos/640/480/?image=696", new Guid("5583dad7-39fe-4c58-a7e9-2b551365e6c3"), "Profiterole", 351.80m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5400), 0.17000000000000001, "https://picsum.photos/640/480/?image=1071", new Guid("c1494b8d-6716-45b8-9436-dd8272a1c29b"), "Affogato", 462.36m, (short)73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5408), 0.029999999999999999, "https://picsum.photos/640/480/?image=42", new Guid("45db397d-9708-45b9-a1fd-2a83641f2e2e"), "Frappé", 328.59m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5417), 0.029999999999999999, "https://picsum.photos/640/480/?image=659", new Guid("52f28031-d079-4351-8abc-877e6da1231c"), "Profiterole", 452.57m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5426), 0.41999999999999998, "https://picsum.photos/640/480/?image=681", new Guid("25725137-218b-45c3-96b5-6eee5c9be2d8"), "Espresso", 267.49m, (short)63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5438), 0.17999999999999999, "https://picsum.photos/640/480/?image=835", new Guid("e22a85f4-385e-43f5-b4af-a049bedab7c6"), "Brownie", 271.36m, (short)30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5447), 0.050000000000000003, "https://picsum.photos/640/480/?image=973", new Guid("34587df6-48ef-4344-b0ea-bd004726342d"), "Cappuccino", 547.84m, (short)15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5456), 0.38, "https://picsum.photos/640/480/?image=956", new Guid("96397f37-8ce0-448e-a3f9-6c94c1fbb671"), 844.58m, (short)56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5466), 0.40999999999999998, "https://picsum.photos/640/480/?image=741", new Guid("f57b49ea-2e40-47ed-9ae1-409619cb56c8"), 278.96m, (short)50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5480), 0.22, "https://picsum.photos/640/480/?image=938", new Guid("8584d271-5ab5-4deb-901b-5ac9030fb057"), "Flat White", 241.69m, (short)16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 9, 2, 2, 25, 1, 306, DateTimeKind.Local).AddTicks(5491), 0.10000000000000001, "https://picsum.photos/640/480/?image=871", new Guid("fea8b4cb-f2cd-4254-9500-845b5e3a0db7"), "Chocolate Fondue", 976.67m, (short)46 });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9430), "Velit iure aliquam fugiat corrupti veniam.", new Guid("20fb1f8d-c3ec-4b80-bf78-fc78e13c22f8") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9594), "Qui et optio et rerum cum est.", new Guid("5f8a5f21-2e40-4f1f-b3f2-01984d2d94f0") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9617), "Velit nesciunt incidunt vel eligendi eveniet modi excepturi est hic.", new Guid("29ae6535-34ce-4ae5-961d-99e765b0a830") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9642), "Aperiam voluptas necessitatibus debitis occaecati.", new Guid("f7791d64-5b7b-4dfb-b253-cf82808f1625") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9657), "Quisquam sint ea aperiam molestiae.", new Guid("e92130f9-16af-46d2-8070-2d6679123668") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9761), "Harum ratione voluptatum deserunt ut dolor soluta quam.", new Guid("99ca6d4c-bd07-4b07-8463-26ee9d7c845f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9789), "Nesciunt ut incidunt.", new Guid("36da5c29-576c-405a-ad41-e585a33d16c4") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9797), "Molestias ut fuga et.", new Guid("d4cceaeb-9082-41d0-8ef2-1c6412b916d0") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9807), "Ullam in cumque eaque mollitia architecto porro repudiandae.", new Guid("94f80b30-651e-4034-ae3b-c0703d26bb65") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9822), "Labore esse illo optio fuga.", new Guid("5c149d78-8a70-4880-ba8f-6a39d5c04930") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8495), 0.33000000000000002, "https://picsum.photos/640/480/?image=955", new Guid("9d378910-ce9b-45ce-b7ab-7e2eb7ac462e"), "Cookie", 354.52m, (short)83 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8615), 0.0, "https://picsum.photos/640/480/?image=418", new Guid("d2fa1ea7-3db5-4d9c-9ca0-f3983e2d43d8"), "Latte", 225.66m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8626), 0.070000000000000007, "https://picsum.photos/640/480/?image=147", new Guid("b31f0c2c-e434-4072-a52c-b663fe3983c4"), 884.02m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8641), 0.19, "https://picsum.photos/640/480/?image=749", new Guid("b41ac594-61d5-4a1a-ab9f-e63547ced5d4"), "Flat White", 303.33m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8649), 0.40000000000000002, "https://picsum.photos/640/480/?image=418", new Guid("96ff49b9-3edf-42b7-9523-6c40223df7b4"), "Cold Brew", 47.03m, (short)99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8658), 0.17999999999999999, "https://picsum.photos/640/480/?image=155", new Guid("4d86920d-d877-4de2-bfe3-02221ff764bb"), "Frappé", 209.64m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8666), 0.47999999999999998, "https://picsum.photos/640/480/?image=833", new Guid("c798cdd7-d829-433e-84e9-f88f700a65f2"), "Waffle", 555.11m, (short)5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8673), 0.42999999999999999, "https://picsum.photos/640/480/?image=860", new Guid("86922286-0587-482c-9d37-6a2e6898859c"), "Cheesecake", 814.27m, (short)18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8681), 0.33000000000000002, "https://picsum.photos/640/480/?image=725", new Guid("12d3c1a9-6d0e-4270-b0b5-54da06d8ee30"), "Frappé", 927.63m, (short)89 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8694), 0.34000000000000002, "https://picsum.photos/640/480/?image=826", new Guid("7256efe6-8d0b-41a9-b3c4-c24961813c4a"), "Flat White", 508.45m, (short)0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8701), 0.31, "https://picsum.photos/640/480/?image=278", new Guid("7763b271-ce2f-49f7-a51f-4c78b0122348"), "Cookie", 556.01m, (short)12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8709), 0.48999999999999999, "https://picsum.photos/640/480/?image=375", new Guid("26236afe-9aae-4216-bea0-05e47f28aeb2"), "Tiramisu", 769.83m, (short)21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8716), 0.10000000000000001, "https://picsum.photos/640/480/?image=59", new Guid("b81703e9-9f32-4135-b9cc-27cf11fabc9f"), "Brownie", 373.62m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8723), 0.35999999999999999, "https://picsum.photos/640/480/?image=449", new Guid("07804a19-1be5-485a-89d8-8485fd5650cf"), "Cappuccino", 773.56m, (short)38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8730), 0.19, "https://picsum.photos/640/480/?image=911", new Guid("1c21a1d0-87ec-4f1c-af06-2a66cc8db4c0"), "Espresso", 531.29m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8736), 0.089999999999999997, "https://picsum.photos/640/480/?image=780", new Guid("8f84ab23-c391-45b1-a633-66fd335b4c60"), "Muffin", 789.27m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8742), 0.070000000000000007, "https://picsum.photos/640/480/?image=730", new Guid("ef677912-5663-4dda-a843-f106f446858b"), 968.80m, (short)13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8750), 0.34999999999999998, "https://picsum.photos/640/480/?image=813", new Guid("87881dac-8462-4d1d-8d30-f63ff28f00f7"), 999.36m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8756), 0.46000000000000002, "https://picsum.photos/640/480/?image=488", new Guid("81c4b3b1-b874-4fc6-85b1-5502047df851"), "Chocolate Fondue", 874.87m, (short)46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8764), 0.20999999999999999, "https://picsum.photos/640/480/?image=172", new Guid("43e9faf0-04bf-4994-921c-d2904917cbac"), "Macaron", 859.67m, (short)100 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Orders_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Products_ProductId",
                table: "OrderDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
