using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.MVC.Migrations
{
    /// <inheritdoc />
    public partial class tableseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TableNumber",
                table: "Tables",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 45);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 644, DateTimeKind.Local).AddTicks(5856), "Consequuntur enim eaque ea qui cumque in.", new Guid("a731e55d-5158-43a0-8511-f4f5f9029dcb") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 644, DateTimeKind.Local).AddTicks(6018), "Ullam cupiditate enim dolorem id adipisci est.", new Guid("a614948d-40d3-4ff6-93c4-74da0f266e54") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 644, DateTimeKind.Local).AddTicks(6050), "Et aut tempore cupiditate.", new Guid("9fb09a34-8d64-48a7-818d-3bb0623d6912") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 644, DateTimeKind.Local).AddTicks(6063), "Saepe quia ut ipsum.", new Guid("2992ad64-01ec-4127-aba7-ab162d448b3f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 644, DateTimeKind.Local).AddTicks(6077), "Dolor iusto suscipit et voluptates minima itaque.", new Guid("28246d4f-423a-441d-aef5-b364633134c4") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 644, DateTimeKind.Local).AddTicks(6123), "Quaerat quis est commodi qui ipsam sapiente dicta.", new Guid("09e2e842-4618-4510-8b64-3c34e9653041") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 644, DateTimeKind.Local).AddTicks(6143), "At reiciendis nulla.", new Guid("d7a78f5c-1603-4915-911f-4acd83b4a1d6") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 644, DateTimeKind.Local).AddTicks(6154), "Reprehenderit id debitis.", new Guid("abefb9b8-45dc-4b1e-ab8e-90132ce67e5f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 644, DateTimeKind.Local).AddTicks(6163), "Molestiae animi quibusdam distinctio suscipit inventore.", new Guid("3c9f5c9d-3a23-4dfb-8391-4aa388823036") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 644, DateTimeKind.Local).AddTicks(6179), "Alias placeat tempora reiciendis eum aut doloremque et laboriosam dolorem.", new Guid("04743028-363d-4e8f-b91b-9b85ed20bbd6") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9657), new Guid("69d95566-d403-42ea-ab9c-8935230b3d47"), new DateTime(2023, 11, 27, 4, 54, 38, 647, DateTimeKind.Local).AddTicks(9666), 379.36m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9778), new Guid("cb331e92-e1bc-47ab-9527-1342751d9823"), new DateTime(2024, 2, 27, 2, 55, 49, 229, DateTimeKind.Local).AddTicks(2934), 20.95m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9787), new Guid("e4609c2d-2ca5-4bd9-8a39-510dda41aa89"), new DateTime(2024, 4, 22, 18, 17, 10, 221, DateTimeKind.Local).AddTicks(3062), 141.46m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9793), new Guid("b8507f81-e1f6-489a-8549-76a9e8464077"), new DateTime(2024, 8, 21, 22, 58, 24, 460, DateTimeKind.Local).AddTicks(9525), 127.24m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9799), new Guid("bf849f1a-90ef-459a-a17d-9a1337fcbae6"), new DateTime(2024, 5, 25, 23, 22, 52, 806, DateTimeKind.Local).AddTicks(9290), 106.32m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9813), new Guid("44843512-bf56-405b-a49b-8563c21366ce"), new DateTime(2024, 6, 27, 12, 31, 6, 305, DateTimeKind.Local).AddTicks(9965), 81.14m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9819), new Guid("1458ddf0-ef15-48f4-9f58-b4af5204403d"), new DateTime(2024, 8, 21, 9, 16, 1, 66, DateTimeKind.Local).AddTicks(7159), 427.30m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9825), new Guid("a921fd5f-c786-4a91-9b89-2bf269b16ca6"), new DateTime(2024, 4, 8, 1, 16, 6, 108, DateTimeKind.Local).AddTicks(4443), 463.13m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9830), new Guid("ea50c314-9183-456e-87f7-aca7d1a784a2"), new DateTime(2024, 2, 10, 23, 16, 15, 460, DateTimeKind.Local).AddTicks(2510), 316.31m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9835), new Guid("e510c7d3-a6d8-4648-b51c-442b83cf0a71"), new DateTime(2024, 7, 4, 6, 9, 21, 59, DateTimeKind.Local).AddTicks(5156), 427.51m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9840), new Guid("955d57bf-6f70-484b-a011-439debc5205b"), new DateTime(2024, 2, 10, 18, 29, 42, 58, DateTimeKind.Local).AddTicks(7510), 60.35m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9845), new Guid("4cd6e24f-5505-4d84-8e04-b0a3f69864d0"), new DateTime(2024, 1, 30, 21, 14, 50, 97, DateTimeKind.Local).AddTicks(7832), 258.78m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9850), new Guid("0a0f5f53-bc56-48e2-a9dc-258909ef3122"), new DateTime(2023, 11, 24, 5, 39, 34, 359, DateTimeKind.Local).AddTicks(1272), 399.58m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9857), new Guid("7f8f691c-edf8-48dc-a376-77810feb04e2"), new DateTime(2024, 4, 13, 11, 52, 2, 56, DateTimeKind.Local).AddTicks(9718), 243.88m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9861), new Guid("1a3cb060-5d38-47d0-a100-65dac3f511dd"), new DateTime(2023, 11, 18, 7, 42, 59, 286, DateTimeKind.Local).AddTicks(9232), 409.33m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9867), new Guid("addaf712-1628-4aa1-aeb9-ccca2759f7b7"), new DateTime(2024, 7, 7, 8, 0, 45, 896, DateTimeKind.Local).AddTicks(9034), 459.09m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9872), new Guid("b7c4dd63-fa0b-4a32-a42d-5dc3f205fc92"), new DateTime(2023, 12, 3, 1, 28, 22, 681, DateTimeKind.Local).AddTicks(1612), 225.94m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9877), new Guid("1579ed17-281e-4a72-bbd0-b48b54f8d534"), new DateTime(2024, 1, 29, 7, 15, 38, 944, DateTimeKind.Local).AddTicks(5477), 411.06m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9882), new Guid("792df04a-762f-40f2-8ffd-a103747805ac"), new DateTime(2024, 10, 6, 13, 15, 27, 743, DateTimeKind.Local).AddTicks(6144), 73.54m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 647, DateTimeKind.Local).AddTicks(9887), new Guid("92cc83a7-da5a-434c-b9c7-352beb12c408"), new DateTime(2024, 5, 10, 5, 43, 43, 251, DateTimeKind.Local).AddTicks(5896), 39.01m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 10, 17, 17, 57, 52, 645, DateTimeKind.Local).AddTicks(9841), 0.13, "https://picsum.photos/640/480/?image=80", new Guid("3e95d64b-08f9-4430-9a23-d1e85a14d6dd"), "Pie", 693.97m, (short)35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(4), 0.12, "https://picsum.photos/640/480/?image=940", new Guid("7db08738-1b4b-4c71-a943-1e00d6ffb64e"), "Cappuccino", 335.31m, (short)95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(17), 0.14999999999999999, "https://picsum.photos/640/480/?image=934", new Guid("c458ec87-ad94-4669-a690-347c7f660f99"), "Brownie", 968.04m, (short)86 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(25), 0.46999999999999997, "https://picsum.photos/640/480/?image=908", new Guid("e08801db-1d4a-4498-88af-3bd36beaca03"), "Flat White", 240.91m, (short)29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(33), 0.17999999999999999, "https://picsum.photos/640/480/?image=426", new Guid("f963e804-53a3-44a3-992d-25e9298d669b"), "Affogato", 172.77m, (short)92 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(40), 0.26000000000000001, "https://picsum.photos/640/480/?image=157", new Guid("863dc3f0-b136-45b4-ba46-1478f8138647"), "Espresso", 40.20m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(48), 0.46999999999999997, "https://picsum.photos/640/480/?image=951", new Guid("e1558dfe-d932-4468-a33c-a7c33e42e470"), "Cappuccino", 535.42m, (short)53 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(55), 0.11, "https://picsum.photos/640/480/?image=902", new Guid("d7cd22eb-8a78-4c74-a1f6-c183772e0800"), "Cappuccino", 355.94m, (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(87), 0.0, "https://picsum.photos/640/480/?image=586", new Guid("fd5d6c66-c42f-488c-ae0c-9e8f320b3af4"), "Espresso", 429.56m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(96), 0.42999999999999999, "https://picsum.photos/640/480/?image=289", new Guid("8461910a-8e7e-43aa-bc8c-6162307d4dda"), "Chocolate Fondue", 361.60m, (short)26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(104), 0.34000000000000002, "https://picsum.photos/640/480/?image=376", new Guid("1c68c471-dcce-4afc-80d5-eb510ef08b69"), "Tiramisu", 149.26m, (short)95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(111), 0.33000000000000002, "https://picsum.photos/640/480/?image=192", new Guid("15ab94ed-0393-42ec-85d3-3a6970beafd5"), "Macaron", 59.63m, (short)86 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(118), 0.45000000000000001, "https://picsum.photos/640/480/?image=50", new Guid("2f2c2759-460d-4e5a-8475-727346b03338"), "Frappé", 793.20m, (short)53 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(125), 0.0, "https://picsum.photos/640/480/?image=130", new Guid("d69bf803-5d07-42c6-8a27-5937ac848f6c"), "Brownie", 683.48m, (short)57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(132), 0.34999999999999998, "https://picsum.photos/640/480/?image=184", new Guid("95fe6f66-6aee-43cb-ab6f-ff3e3c51d334"), 308.90m, (short)73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(139), 0.40000000000000002, "https://picsum.photos/640/480/?image=1054", new Guid("8916cd1e-cbb2-4f4a-984b-f59231f63684"), "Frappé", 710.24m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(146), 0.14999999999999999, "https://picsum.photos/640/480/?image=740", new Guid("51d3ddd8-5d96-486f-b290-04ad15cd2242"), "Profiterole", 69.58m, (short)57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(156), 0.45000000000000001, "https://picsum.photos/640/480/?image=1068", new Guid("ea863934-2809-48cc-9f59-121a9b875100"), "Espresso Macchiato", 574.24m, (short)75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(162), 0.46000000000000002, "https://picsum.photos/640/480/?image=251", new Guid("42493a17-a0c1-4459-81f5-2708ac3c3353"), "Espresso", 963.90m, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 10, 17, 17, 57, 52, 646, DateTimeKind.Local).AddTicks(196), 0.37, "https://picsum.photos/640/480/?image=926", new Guid("7e4b2dde-b2a5-4016-9679-fef72b37d32c"), "Profiterole", 752.96m, (short)5 });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "ID", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "Status", "TableName", "TableNumber", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "DESKTOP-JSABNAD", new DateTime(2024, 10, 17, 17, 57, 52, 648, DateTimeKind.Local).AddTicks(6627), "192.168.1.1", true, new Guid("95606f45-7cdb-42a7-a03f-25a7de4f8fad"), 0, "Deniz Kenarı 1", "1", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "DESKTOP-JSABNAD", new DateTime(2024, 10, 17, 17, 57, 52, 648, DateTimeKind.Local).AddTicks(6669), "192.168.1.1", true, new Guid("a17eb20f-d043-4ff4-a1dd-f55b8f6baa1e"), 0, "Deniz Kenarı 2", "2", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "DESKTOP-JSABNAD", new DateTime(2024, 10, 17, 17, 57, 52, 648, DateTimeKind.Local).AddTicks(6674), "192.168.1.1", true, new Guid("8f637bf5-a956-427d-b79d-6b772b6de384"), 0, "Deniz Kenarı 3", "3", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "DESKTOP-JSABNAD", new DateTime(2024, 10, 17, 17, 57, 52, 648, DateTimeKind.Local).AddTicks(6677), "192.168.1.1", true, new Guid("65155892-11bd-4e82-8230-6971c5847be9"), 0, "Deniz Kenarı 4", "4", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "DESKTOP-JSABNAD", new DateTime(2024, 10, 17, 17, 57, 52, 648, DateTimeKind.Local).AddTicks(6679), "192.168.1.1", true, new Guid("5885a882-f70a-4110-9536-c534141bcdc0"), 0, "Deniz Kenarı 5", "5", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "DESKTOP-JSABNAD", new DateTime(2024, 10, 17, 17, 57, 52, 648, DateTimeKind.Local).AddTicks(6683), "192.168.1.1", true, new Guid("2d22bf56-b8d4-4685-8829-26b1f600aaa6"), 0, "Deniz Kenarı 6", "6", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "DESKTOP-JSABNAD", new DateTime(2024, 10, 17, 17, 57, 52, 648, DateTimeKind.Local).AddTicks(6686), "192.168.1.1", true, new Guid("81d5aa4f-9ab9-4333-a1e6-f2aeabd9bac6"), 0, "Deniz Kenarı 7", "7", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "DESKTOP-JSABNAD", new DateTime(2024, 10, 17, 17, 57, 52, 648, DateTimeKind.Local).AddTicks(6689), "192.168.1.1", true, new Guid("8c83a0e6-c00d-4b66-aa94-bee6d6e518ba"), 0, "Deniz Kenarı 8", "8", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "DESKTOP-JSABNAD", new DateTime(2024, 10, 17, 17, 57, 52, 648, DateTimeKind.Local).AddTicks(6697), "192.168.1.1", true, new Guid("2066750a-0093-4c41-9bb7-59ef8dab784a"), 0, "Deniz Kenarı 9", "9", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "DESKTOP-JSABNAD", new DateTime(2024, 10, 17, 17, 57, 52, 648, DateTimeKind.Local).AddTicks(6700), "192.168.1.1", true, new Guid("073e9f31-d08e-4583-9325-64dd8e09a18d"), 0, "Deniz Kenarı 10", "10", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "TableNumber",
                table: "Tables",
                type: "int",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(45)",
                oldMaxLength: 45);

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
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(902), new Guid("01f0ca49-b31b-4f83-b40e-2be2da6f06e8"), new DateTime(2024, 9, 4, 12, 13, 12, 278, DateTimeKind.Local).AddTicks(8223), 297.05m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(977), new Guid("a1ddb400-c3d0-4d80-a6c3-e38acb2bdaa3"), new DateTime(2024, 7, 22, 12, 47, 16, 586, DateTimeKind.Local).AddTicks(7602), 272.67m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(986), new Guid("f7ae01c8-2a35-4641-8a3f-c8f1b066923b"), new DateTime(2024, 5, 31, 12, 50, 13, 211, DateTimeKind.Local).AddTicks(3150), 113.91m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(992), new Guid("627beb58-dce0-4afd-a9a2-14c03afa1da3"), new DateTime(2024, 5, 22, 4, 12, 48, 639, DateTimeKind.Local).AddTicks(6878), 423.07m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(997), new Guid("7b2f081e-804a-4346-8da0-380ed1ca6b04"), new DateTime(2024, 9, 25, 6, 40, 4, 806, DateTimeKind.Local).AddTicks(6511), 198.47m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1003), new Guid("c91a2f70-d9e3-4912-9d90-046b70fb6efd"), new DateTime(2024, 4, 9, 0, 59, 43, 523, DateTimeKind.Local).AddTicks(7360), 435.61m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1013), new Guid("17380f70-40bf-40c0-8e82-e64216027e4c"), new DateTime(2023, 12, 3, 2, 10, 23, 705, DateTimeKind.Local).AddTicks(1626), 340.07m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1018), new Guid("483bb7c8-eae8-4825-8386-f34f373f6e31"), new DateTime(2024, 7, 14, 19, 1, 2, 407, DateTimeKind.Local).AddTicks(824), 249.75m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1023), new Guid("09dd6d2f-6817-4adc-afd3-f3c6a99133c9"), new DateTime(2024, 10, 6, 0, 22, 23, 782, DateTimeKind.Local).AddTicks(308), 285.22m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1029), new Guid("09cc64dd-87cb-40fd-b27a-82341ea56956"), new DateTime(2024, 7, 8, 1, 11, 23, 842, DateTimeKind.Local).AddTicks(1080), 356.77m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1033), new Guid("4d683f10-ceae-4aaa-abe3-f3d1e5c76326"), new DateTime(2024, 6, 28, 8, 52, 30, 731, DateTimeKind.Local).AddTicks(1459), 70.05m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1039), new Guid("3f333223-3e05-4be2-a6da-eea37898ca94"), new DateTime(2024, 6, 25, 21, 41, 22, 876, DateTimeKind.Local).AddTicks(2603), 292.28m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1043), new Guid("fef0537b-c2fe-44f9-8a01-d9b17d39cde6"), new DateTime(2024, 6, 30, 3, 27, 46, 959, DateTimeKind.Local).AddTicks(1051), 169.03m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1048), new Guid("7d470788-a332-45be-ba75-6c1de94f2184"), new DateTime(2024, 9, 11, 8, 38, 42, 707, DateTimeKind.Local).AddTicks(5238), 377.76m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1054), new Guid("f9fa7005-7ade-49df-8d38-b5cf5b5940de"), new DateTime(2023, 11, 12, 5, 1, 42, 872, DateTimeKind.Local).AddTicks(1485), 151.11m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1059), new Guid("0160ee3e-690c-4ca3-b86f-55c8c6be3980"), new DateTime(2024, 8, 8, 11, 29, 19, 800, DateTimeKind.Local).AddTicks(7328), 44.10m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1064), new Guid("932e526b-347c-4097-8170-420547c28be8"), new DateTime(2024, 1, 17, 12, 36, 23, 709, DateTimeKind.Local).AddTicks(4658), 475.16m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1070), new Guid("a88ec15b-116d-452e-9ac9-ea02e1316123"), new DateTime(2024, 4, 4, 16, 15, 8, 763, DateTimeKind.Local).AddTicks(7199), 410.50m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1074), new Guid("d65b8553-2498-4029-85f3-27c562895be2"), new DateTime(2024, 7, 12, 22, 8, 17, 231, DateTimeKind.Local).AddTicks(7495), 392.36m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 821, DateTimeKind.Local).AddTicks(1079), new Guid("c8fe3898-09e4-4ee6-9eab-e2b0c6a2afbb"), new DateTime(2024, 10, 14, 12, 19, 5, 723, DateTimeKind.Local).AddTicks(8520), 124.95m });

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
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8051), 0.13, "https://picsum.photos/640/480/?image=811", new Guid("91bba8d7-28ef-4c83-a32b-bf1a506ea3d4"), "Chai Tea Latte", 761.70m, (short)4 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8065), 0.059999999999999998, "https://picsum.photos/640/480/?image=864", new Guid("438318ca-9e6a-4106-8930-e8ceebc9f5e0"), "Brownie", 625.41m, (short)92 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8074), 0.20999999999999999, "https://picsum.photos/640/480/?image=654", new Guid("72617e2d-2d99-437a-927e-2ba0ec09fd36"), "Frappé", 357.74m, (short)21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8081), 0.45000000000000001, "https://picsum.photos/640/480/?image=457", new Guid("42468e65-c785-4e37-a507-3da7e5ade145"), "Muffin", 478.70m, (short)65 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8102), 0.02, "https://picsum.photos/640/480/?image=164", new Guid("3ef9db9a-bec8-49c6-8e6e-8dfb67cc2001"), 518.89m, (short)99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8108), 0.44, "https://picsum.photos/640/480/?image=946", new Guid("380c2fd3-4791-4c97-aa02-0fbfc6434cda"), "Iced Coffee", 397.79m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8115), 0.10000000000000001, "https://picsum.photos/640/480/?image=723", new Guid("91f350f5-d4ff-45d7-9903-d8826b5e55f4"), "Affogato", 765.02m, (short)27 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2024, 10, 17, 17, 51, 13, 819, DateTimeKind.Local).AddTicks(8164), 0.31, "https://picsum.photos/640/480/?image=502", new Guid("2003731c-1630-451a-985e-8624f7884dff"), "Americano", 622.74m, (short)40 });
        }
    }
}
