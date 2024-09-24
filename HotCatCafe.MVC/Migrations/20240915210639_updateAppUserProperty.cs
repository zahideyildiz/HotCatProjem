using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotCatCafe.MVC.Migrations
{
    /// <inheritdoc />
    public partial class updateAppUserProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 717, DateTimeKind.Local).AddTicks(203), "Fugit et commodi qui dolore facilis quae ab.", new Guid("d046ad26-db0e-4c46-98f8-8dafb1559c4a") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 717, DateTimeKind.Local).AddTicks(384), "Voluptatem vel eos ab accusantium itaque.", new Guid("052e3274-e45b-41a7-94f3-878020f9f051") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 717, DateTimeKind.Local).AddTicks(416), "Dolor qui accusantium et ut officiis ab.", new Guid("bf760b5d-fddc-4b36-bca5-3cfb512eb4f0") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 717, DateTimeKind.Local).AddTicks(433), "Et dolorem suscipit quis qui tenetur cum ea.", new Guid("aa1904c6-5e2b-4e02-b30a-11487420ede3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 717, DateTimeKind.Local).AddTicks(480), "Fugit tempora doloremque et neque consectetur consequuntur eius exercitationem ea.", new Guid("e2b556c4-cfe3-4551-9a24-d9a6c12f48bf") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 717, DateTimeKind.Local).AddTicks(508), "Consequatur ab aut est quod officia totam quis.", new Guid("e30b8b68-1ef2-4e31-a1c5-148a4cd19b62") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 717, DateTimeKind.Local).AddTicks(530), "Aut fugiat inventore ad reiciendis rerum ipsa nemo incidunt.", new Guid("3fd7328a-1024-448d-b8bd-615cb6868f03") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 717, DateTimeKind.Local).AddTicks(553), "Et expedita ea sint tempore inventore accusantium consectetur eveniet ut.", new Guid("52cee3bc-1262-4653-9a7f-d20f093ba5c3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 717, DateTimeKind.Local).AddTicks(577), "Praesentium odit eum vitae.", new Guid("a1f1e55c-62cf-45db-b2ff-2b1aed30fc3e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 717, DateTimeKind.Local).AddTicks(589), "Vel maiores aperiam voluptas praesentium vel molestiae molestiae error.", new Guid("02189191-b66d-4c46-acb7-5d478ca7c134") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(1394), "Hope Parker", new Guid("397924f6-0263-4113-a34c-59031bba343a"), new DateTime(2023, 11, 8, 6, 5, 28, 528, DateTimeKind.Local).AddTicks(1038), 433.79m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6116), "Hope Parker", new Guid("06eb7e40-392e-4773-a75a-6847535aa838"), new DateTime(2023, 11, 26, 0, 27, 2, 16, DateTimeKind.Local).AddTicks(3964), 107.36m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6190), "Hope Parker", new Guid("8b01261b-f2e1-494b-81f9-546987e3b77f"), new DateTime(2024, 7, 26, 12, 3, 26, 473, DateTimeKind.Local).AddTicks(1408), 153.42m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6198), "Hope Parker", new Guid("d0c8d0f8-476e-4e09-9f1c-e3fabc84273f"), new DateTime(2024, 1, 2, 6, 17, 41, 962, DateTimeKind.Local).AddTicks(8195), 63.93m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6205), "Hope Parker", new Guid("f1561eb6-e31b-438b-bd28-84a766071826"), new DateTime(2024, 2, 19, 23, 47, 29, 113, DateTimeKind.Local).AddTicks(4533), 495.90m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6213), "Hope Parker", new Guid("e4b70faf-8e36-4d75-a2d8-00e9cbf4634b"), new DateTime(2024, 3, 6, 13, 30, 20, 690, DateTimeKind.Local).AddTicks(4522), 132.85m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6220), "Hope Parker", new Guid("e1201eb7-615a-4b4e-8c01-8e9ed276aff1"), new DateTime(2023, 10, 7, 19, 59, 50, 401, DateTimeKind.Local).AddTicks(7885), 153.53m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6225), "Hope Parker", new Guid("1170b1cc-deb0-4458-a7a7-dc43b82d5411"), new DateTime(2024, 3, 10, 16, 16, 8, 412, DateTimeKind.Local).AddTicks(2123), 35.75m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6230), "Hope Parker", new Guid("b44d5c04-fc4d-4a02-8e3a-f638857f6d0b"), new DateTime(2024, 1, 7, 12, 22, 0, 458, DateTimeKind.Local).AddTicks(9233), 453.93m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6236), "Hope Parker", new Guid("ffd57a0f-86d4-4f9d-9d87-a123c179dc1b"), new DateTime(2024, 3, 10, 18, 34, 19, 983, DateTimeKind.Local).AddTicks(6093), 156.58m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6242), "Hope Parker", new Guid("2370a11e-efdd-43a8-91f3-6a48e6b9b0bd"), new DateTime(2024, 4, 15, 3, 1, 9, 875, DateTimeKind.Local).AddTicks(2831), 90.94m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6247), "Hope Parker", new Guid("24d96ff8-fd3e-4929-91b2-f01015c82d0a"), new DateTime(2023, 11, 8, 23, 59, 27, 246, DateTimeKind.Local).AddTicks(5673), 58.95m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6252), "Hope Parker", new Guid("9b4a1b84-4e11-44ab-a906-41e948085312"), new DateTime(2024, 7, 10, 4, 48, 0, 696, DateTimeKind.Local).AddTicks(8072), 196.07m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6257), "Hope Parker", new Guid("8da91f15-b2c5-4f93-b758-5d1560528fe0"), new DateTime(2024, 6, 15, 5, 32, 28, 332, DateTimeKind.Local).AddTicks(6642), 325.03m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6295), "Hope Parker", new Guid("9134f6ce-dc29-42d5-888c-1475ddc6f086"), new DateTime(2024, 9, 9, 12, 38, 53, 664, DateTimeKind.Local).AddTicks(4432), 80.44m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6300), "Hope Parker", new Guid("645aded7-2f85-445f-950c-c51a1e4335b1"), new DateTime(2023, 10, 4, 1, 38, 54, 93, DateTimeKind.Local).AddTicks(6146), 315.11m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6306), "Hope Parker", new Guid("6778c811-d742-4d05-9f8d-c2338f4d3873"), new DateTime(2024, 8, 11, 21, 18, 30, 298, DateTimeKind.Local).AddTicks(6921), 184.94m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6313), "Hope Parker", new Guid("b35ece17-9ef6-40d7-b4a8-49c006b2d0a8"), new DateTime(2023, 10, 26, 11, 8, 41, 169, DateTimeKind.Local).AddTicks(7645), 15.28m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6319), "Hope Parker", new Guid("a59a6f76-a2b6-4f19-8064-efebc765cb2c"), new DateTime(2024, 2, 2, 18, 30, 2, 568, DateTimeKind.Local).AddTicks(4781), 415.15m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6324), "Hope Parker", new Guid("cdfb2087-368c-4be0-be1b-fc7132394e4a"), new DateTime(2023, 10, 21, 16, 13, 32, 36, DateTimeKind.Local).AddTicks(1642), 492.10m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(4839), 0.46999999999999997, "https://picsum.photos/640/480/?image=994", new Guid("67c2b364-6797-460e-bd47-112cb404193e"), "Cookie", 817.89m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(4994), 0.16, "https://picsum.photos/640/480/?image=425", new Guid("4a56bfba-cd92-4132-93b4-4b925b733044"), "Frappé", 183.40m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5005), 0.47999999999999998, "https://picsum.photos/640/480/?image=973", new Guid("817269fa-6788-477c-ada1-19cb3c959f9c"), "Brownie", 262.32m, (short)87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5013), 0.42999999999999999, "https://picsum.photos/640/480/?image=191", new Guid("018d141c-b80b-41bc-8f09-6caa50c5ba56"), "Turkish Coffee", 893.38m, (short)57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5048), 0.40000000000000002, "https://picsum.photos/640/480/?image=440", new Guid("5d9bb6f0-fe91-43ff-a2b5-7177d781f62e"), "Cookie", 494.51m, (short)4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5056), 0.23999999999999999, "https://picsum.photos/640/480/?image=45", new Guid("a5d6feba-161f-4a1f-94a6-de2fce14778a"), "Cookie", 871.31m, (short)91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5063), 0.41999999999999998, "https://picsum.photos/640/480/?image=105", new Guid("f6b259b5-f418-418d-b48a-7f9c8d0e5820"), "Latte", 5.39m, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5072), 0.12, "https://picsum.photos/640/480/?image=490", new Guid("a2795191-77bc-44ab-84c3-ee28d0e65907"), "Macaron", 107.73m, (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5085), 0.47999999999999998, "https://picsum.photos/640/480/?image=655", new Guid("9994e48a-7bf4-47fe-b38c-6d84c24bec56"), "Cold Brew", 507.26m, (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5092), 0.34000000000000002, "https://picsum.photos/640/480/?image=497", new Guid("da36566f-43a5-421d-8aaa-742e34878644"), "Latte", 917.79m, (short)86 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5100), 0.16, "https://picsum.photos/640/480/?image=1021", new Guid("ad176ba8-e151-48af-a040-53781e5ec9b2"), "Macaron", 956.09m, (short)76 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5106), 0.37, "https://picsum.photos/640/480/?image=29", new Guid("27accde3-b1f9-4aeb-8d02-c8346110eccb"), "Brownie", 279.05m, (short)26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5114), 0.20000000000000001, "https://picsum.photos/640/480/?image=659", new Guid("d1c15546-9413-48eb-b109-f211e4c201ec"), "Macaron", 811.98m, (short)84 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5121), 0.050000000000000003, "https://picsum.photos/640/480/?image=1070", new Guid("fa9cd7f9-2584-40c7-a0ba-a53bb13489d6"), "Brownie", 709.69m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5128), "https://picsum.photos/640/480/?image=225", new Guid("40398039-9241-452d-bf7f-3f76a5292a54"), "Turkish Coffee", 2.32m, (short)19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5158), 0.11, "https://picsum.photos/640/480/?image=68", new Guid("18e3a0e4-d75f-4771-9d11-177be15fd572"), "Iced Coffee", 233.26m, (short)43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5167), 0.47999999999999998, "https://picsum.photos/640/480/?image=499", new Guid("caa78ac8-db3a-4f95-910b-6f6a588b0d20"), "Americano", 455.62m, (short)56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5176), 0.44, "https://picsum.photos/640/480/?image=737", new Guid("4c1577c5-c44d-417b-bf69-f356591c7bc4"), "Brownie", 864.55m, (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5182), 0.32000000000000001, "https://picsum.photos/640/480/?image=251", new Guid("ad523262-03f2-4611-9478-eacee845fefa"), "Chai Tea Latte", 245.27m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5189), 0.059999999999999998, "https://picsum.photos/640/480/?image=880", new Guid("783495e2-fe3d-4192-98bf-1c600cb7c654"), "Affogato", 212.04m, (short)29 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8509), "Aliquid id nesciunt sed eum.", new Guid("e51334ff-9bb0-4922-b620-b8490b83ea5b") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8692), "Harum officiis placeat aliquam illo quis sapiente voluptatem nulla.", new Guid("798b9383-ac68-4bae-9f77-27f8652df117") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8721), "Repellendus quia voluptatibus odit qui eligendi aperiam voluptatem molestiae ipsum.", new Guid("cb61d77c-3dcb-4936-b93c-ce7a7a869f82") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8747), "Quia eligendi qui voluptatem et ipsum consectetur est.", new Guid("5a66b6d3-efa6-4af7-a0a0-984133461652") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8765), "Repellendus ipsam itaque sapiente facere.", new Guid("a9d6d23d-1789-4aba-b293-4da68e771531") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8779), "İllo dolore quos.", new Guid("63f697fe-f4d5-484f-a3b9-1e886e274281") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8798), "Cupiditate temporibus sed accusantium.", new Guid("d24dc5d2-f325-4aa4-b9ab-a16d49ad79f5") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8809), "Consectetur sed est temporibus.", new Guid("a300e9d1-d8b9-4c37-8146-b8ad6dab0b94") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8819), "Ad sint architecto et qui incidunt dolorem molestiae magni.", new Guid("4012495b-789e-461d-85c1-9ca6af5ea9ce") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8867), "Saepe rerum illum.", new Guid("77abab2b-cc1a-4a2a-8d77-113edb207324") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 854, DateTimeKind.Local).AddTicks(7253), "Brendan Hintz", new Guid("3e2e8014-25e6-40b0-ba88-a6a5eb485660"), new DateTime(2024, 1, 17, 22, 13, 45, 694, DateTimeKind.Local).AddTicks(1404), 499.67m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(694), "Brendan Hintz", new Guid("2a857a4e-cf93-4b0d-8a3a-344d2ffc8789"), new DateTime(2023, 9, 16, 11, 50, 30, 371, DateTimeKind.Local).AddTicks(5531), 378.77m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(770), "Brendan Hintz", new Guid("d2ce1315-dcd8-4a80-9091-fea8297d2266"), new DateTime(2024, 5, 1, 11, 49, 9, 254, DateTimeKind.Local).AddTicks(2844), 65.57m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(777), "Brendan Hintz", new Guid("0b49faac-6f3f-4437-87b6-840bfd8e9955"), new DateTime(2024, 8, 15, 7, 45, 40, 660, DateTimeKind.Local).AddTicks(9268), 337.69m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(783), "Brendan Hintz", new Guid("0449aa43-9e2f-4cc3-959c-a0ef375f7780"), new DateTime(2024, 6, 6, 5, 9, 11, 859, DateTimeKind.Local).AddTicks(1340), 102.28m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(789), "Brendan Hintz", new Guid("25e30e57-9f70-4066-9638-bdbeb4d99a6d"), new DateTime(2024, 7, 10, 18, 57, 51, 415, DateTimeKind.Local).AddTicks(4388), 291.87m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(799), "Brendan Hintz", new Guid("c36c7424-ba44-4746-97a7-da1b2298174d"), new DateTime(2023, 10, 9, 10, 5, 49, 420, DateTimeKind.Local).AddTicks(9534), 280.05m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(805), "Brendan Hintz", new Guid("7b35a7c6-02be-4f66-b949-d75fecd620ed"), new DateTime(2024, 6, 26, 0, 55, 48, 237, DateTimeKind.Local).AddTicks(9204), 440.11m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(810), "Brendan Hintz", new Guid("f305c34e-5a37-438a-a5e6-e42331487618"), new DateTime(2024, 4, 7, 6, 32, 7, 832, DateTimeKind.Local).AddTicks(1570), 357.61m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(847), "Brendan Hintz", new Guid("83ce24a3-d196-48d2-abf5-4960f7711967"), new DateTime(2023, 11, 26, 14, 22, 44, 15, DateTimeKind.Local).AddTicks(7969), 188.23m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(853), "Brendan Hintz", new Guid("1c99ff79-640b-4740-8cd8-64e29796ba6e"), new DateTime(2023, 10, 13, 22, 47, 15, 566, DateTimeKind.Local).AddTicks(8097), 366.97m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(858), "Brendan Hintz", new Guid("f9954099-12a2-4fa9-9363-f57fed36dead"), new DateTime(2024, 7, 22, 9, 53, 3, 74, DateTimeKind.Local).AddTicks(9420), 226.27m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(862), "Brendan Hintz", new Guid("415cb647-ab5c-4889-a00e-b0cd8e0dc9f4"), new DateTime(2024, 1, 13, 8, 3, 5, 252, DateTimeKind.Local).AddTicks(1664), 37.25m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(867), "Brendan Hintz", new Guid("b6a6e84c-b334-40df-99fd-6bb3c6368b3a"), new DateTime(2024, 9, 8, 9, 44, 19, 101, DateTimeKind.Local).AddTicks(7200), 216.47m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(874), "Brendan Hintz", new Guid("95022164-2fad-4b81-a7fe-bf3e18b32387"), new DateTime(2023, 10, 21, 11, 43, 25, 886, DateTimeKind.Local).AddTicks(6669), 290.57m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(879), "Brendan Hintz", new Guid("b210a6f6-20be-4b62-87bb-6ff4b52b6935"), new DateTime(2024, 9, 11, 18, 23, 8, 410, DateTimeKind.Local).AddTicks(2575), 465.28m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(883), "Brendan Hintz", new Guid("c5d1e010-3c05-46ba-a9e8-dc584fdd05a6"), new DateTime(2024, 2, 15, 10, 30, 41, 962, DateTimeKind.Local).AddTicks(7583), 421.05m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(889), "Brendan Hintz", new Guid("106a9788-f8b1-4186-b02c-1fec3c495e86"), new DateTime(2023, 12, 27, 22, 48, 19, 949, DateTimeKind.Local).AddTicks(6553), 375.03m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(894), "Brendan Hintz", new Guid("f18baeb8-9b8e-4492-9fde-e8d167fe7de7"), new DateTime(2024, 9, 3, 16, 41, 36, 666, DateTimeKind.Local).AddTicks(3438), 370.27m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "CustomerName", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(899), "Brendan Hintz", new Guid("f5f2a505-6264-4bd8-ba95-0cb4ca0c7bed"), new DateTime(2023, 9, 21, 10, 23, 43, 286, DateTimeKind.Local).AddTicks(2275), 163.35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2171), 0.20999999999999999, "https://picsum.photos/640/480/?image=1023", new Guid("386e9795-e028-413c-a759-65cc46d0bc65"), "Frappé", 216.69m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2328), 0.02, "https://picsum.photos/640/480/?image=981", new Guid("1f861580-3227-43a0-8ea2-385a8fa9077f"), "Tiramisu", 181.61m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2349), 0.40999999999999998, "https://picsum.photos/640/480/?image=960", new Guid("86b3cc5f-d735-4d33-af51-8346bedece7c"), "Muffin", 963.09m, (short)61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2358), 0.19, "https://picsum.photos/640/480/?image=111", new Guid("fdb083c3-fea9-4fa6-971d-69ecc2476ead"), "Latte", 309.79m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 8, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2366), 0.070000000000000007, "https://picsum.photos/640/480/?image=757", new Guid("a7abaab2-b6e6-4500-b1e1-3a2c744e0757"), "Frappé", 742.03m, (short)100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2386), 0.11, "https://picsum.photos/640/480/?image=373", new Guid("255f964d-1c4a-4558-9022-8b1511c4c427"), "Espresso", 773.12m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2393), 0.02, "https://picsum.photos/640/480/?image=799", new Guid("c7f2e8ea-1fa2-43f5-a436-d5d5c6bb1c14"), "Cheesecake", 856.00m, (short)46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2400), 0.23000000000000001, "https://picsum.photos/640/480/?image=853", new Guid("e16a35a8-f852-4ba7-a1c9-6f49dd90265b"), "Espresso Macchiato", 929.43m, (short)7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 9, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2407), 0.40999999999999998, "https://picsum.photos/640/480/?image=564", new Guid("1306faec-32fb-4a28-b248-b43265af3afd"), "Iced Coffee", 262.30m, (short)60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2415), 0.42999999999999999, "https://picsum.photos/640/480/?image=154", new Guid("e6cafd3b-4bf6-47ab-b020-d600a563e01a"), "Cold Brew", 302.53m, (short)43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2425), 0.5, "https://picsum.photos/640/480/?image=1024", new Guid("7fb36b7a-0cc3-4f71-bcd1-10851203baca"), "Cold Brew", 132.29m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2433), 0.10000000000000001, "https://picsum.photos/640/480/?image=75", new Guid("6e3d3b5d-3550-4233-bf50-4e3359e4ecdb"), "Profiterole", 935.47m, (short)20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 4, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2441), 0.070000000000000007, "https://picsum.photos/640/480/?image=791", new Guid("92836d30-1b2e-41eb-98f2-305c48da2625"), "Profiterole", 101.53m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2472), 0.38, "https://picsum.photos/640/480/?image=258", new Guid("c5aa72ea-e54f-4485-97a2-2550957ba3e7"), "Profiterole", 657.41m, (short)91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2479), "https://picsum.photos/640/480/?image=610", new Guid("ceb25fe3-c0e1-48a6-a7b7-330bef204d15"), "Americano", 136.98m, (short)4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2487), 0.42999999999999999, "https://picsum.photos/640/480/?image=81", new Guid("c78d7a46-6c2b-4905-b1ff-382a9452dfa9"), "Waffle", 3.90m, (short)93 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2495), 0.20999999999999999, "https://picsum.photos/640/480/?image=783", new Guid("4bc9af1c-3037-4179-985c-ad34670548b4"), "Profiterole", 96.30m, (short)38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2504), 0.23999999999999999, "https://picsum.photos/640/480/?image=524", new Guid("bdc6b014-7fc2-4405-8d54-3021223d65d1"), "Flat White", 524.99m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2513), 0.22, "https://picsum.photos/640/480/?image=670", new Guid("49427daa-0783-4cfc-a460-d96e192b4ee8"), "Latte", 818.56m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2520), 0.25, "https://picsum.photos/640/480/?image=212", new Guid("4a73c52b-db66-4272-85ca-5b90e3210c5d"), "Profiterole", 836.93m, (short)97 });
        }
    }
}
