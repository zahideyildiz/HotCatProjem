using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotCatCafe.MVC.Migrations
{
    /// <inheritdoc />
    public partial class orderAndOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Orders");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 6, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2871), 0.23000000000000001, "https://picsum.photos/640/480/?image=651", new Guid("51c0eb49-2867-4ff3-9ce2-3a3c65a79e95"), "Chai Tea Latte", 170.11m, (short)61 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 5, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2886), 0.28000000000000003, "https://picsum.photos/640/480/?image=234", new Guid("646945c1-2151-4212-881e-aaf48962dc4a"), "Affogato", 159.33m, (short)82 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2901), 0.040000000000000001, "https://picsum.photos/640/480/?image=726", new Guid("2d331869-1f09-410a-9e2d-7edd3752007f"), "Muffin", 491.25m, (short)3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2907), "https://picsum.photos/640/480/?image=759", new Guid("93f888cf-f8fd-417c-9294-52cf8f40a80b"), "Americano", 456.11m, (short)51 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 2, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2939), 0.42999999999999999, "https://picsum.photos/640/480/?image=344", new Guid("84ac1e67-fec3-46ca-b184-6c7e3d5a8c7f"), "Frappé", 313.76m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2948), 0.20999999999999999, "https://picsum.photos/640/480/?image=588", new Guid("7872f8fd-ee7f-4c56-8688-d08b6e37a3a2"), "Waffle", 238.56m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2957), 0.28999999999999998, "https://picsum.photos/640/480/?image=517", new Guid("194c8948-63a3-4a53-a90a-58f7ffc6c64e"), 673.66m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 7, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2964), 0.41999999999999998, "https://picsum.photos/640/480/?image=18", new Guid("a71af0b8-d1bb-404a-b0dc-658e03b58951"), "Latte", 960.84m, (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2972), 0.5, "https://picsum.photos/640/480/?image=728", new Guid("c88dff51-2caf-4ae0-bf0f-d41dcf9d041e"), "Muffin", 367.14m, (short)90 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 10, new DateTime(2024, 10, 12, 18, 22, 46, 316, DateTimeKind.Local).AddTicks(2986), 0.11, "https://picsum.photos/640/480/?image=784", new Guid("ec9d5b33-f968-4c13-b595-01781cde45be"), "Americano", 291.77m, (short)44 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Orders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DiscountId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

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
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(1394), "Hope Parker", null, new Guid("397924f6-0263-4113-a34c-59031bba343a"), new DateTime(2023, 11, 8, 6, 5, 28, 528, DateTimeKind.Local).AddTicks(1038), 433.79m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6116), "Hope Parker", null, new Guid("06eb7e40-392e-4773-a75a-6847535aa838"), new DateTime(2023, 11, 26, 0, 27, 2, 16, DateTimeKind.Local).AddTicks(3964), 107.36m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6190), "Hope Parker", null, new Guid("8b01261b-f2e1-494b-81f9-546987e3b77f"), new DateTime(2024, 7, 26, 12, 3, 26, 473, DateTimeKind.Local).AddTicks(1408), 153.42m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6198), "Hope Parker", null, new Guid("d0c8d0f8-476e-4e09-9f1c-e3fabc84273f"), new DateTime(2024, 1, 2, 6, 17, 41, 962, DateTimeKind.Local).AddTicks(8195), 63.93m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6205), "Hope Parker", null, new Guid("f1561eb6-e31b-438b-bd28-84a766071826"), new DateTime(2024, 2, 19, 23, 47, 29, 113, DateTimeKind.Local).AddTicks(4533), 495.90m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6213), "Hope Parker", null, new Guid("e4b70faf-8e36-4d75-a2d8-00e9cbf4634b"), new DateTime(2024, 3, 6, 13, 30, 20, 690, DateTimeKind.Local).AddTicks(4522), 132.85m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6220), "Hope Parker", null, new Guid("e1201eb7-615a-4b4e-8c01-8e9ed276aff1"), new DateTime(2023, 10, 7, 19, 59, 50, 401, DateTimeKind.Local).AddTicks(7885), 153.53m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6225), "Hope Parker", null, new Guid("1170b1cc-deb0-4458-a7a7-dc43b82d5411"), new DateTime(2024, 3, 10, 16, 16, 8, 412, DateTimeKind.Local).AddTicks(2123), 35.75m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6230), "Hope Parker", null, new Guid("b44d5c04-fc4d-4a02-8e3a-f638857f6d0b"), new DateTime(2024, 1, 7, 12, 22, 0, 458, DateTimeKind.Local).AddTicks(9233), 453.93m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6236), "Hope Parker", null, new Guid("ffd57a0f-86d4-4f9d-9d87-a123c179dc1b"), new DateTime(2024, 3, 10, 18, 34, 19, 983, DateTimeKind.Local).AddTicks(6093), 156.58m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6242), "Hope Parker", null, new Guid("2370a11e-efdd-43a8-91f3-6a48e6b9b0bd"), new DateTime(2024, 4, 15, 3, 1, 9, 875, DateTimeKind.Local).AddTicks(2831), 90.94m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6247), "Hope Parker", null, new Guid("24d96ff8-fd3e-4929-91b2-f01015c82d0a"), new DateTime(2023, 11, 8, 23, 59, 27, 246, DateTimeKind.Local).AddTicks(5673), 58.95m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6252), "Hope Parker", null, new Guid("9b4a1b84-4e11-44ab-a906-41e948085312"), new DateTime(2024, 7, 10, 4, 48, 0, 696, DateTimeKind.Local).AddTicks(8072), 196.07m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6257), "Hope Parker", null, new Guid("8da91f15-b2c5-4f93-b758-5d1560528fe0"), new DateTime(2024, 6, 15, 5, 32, 28, 332, DateTimeKind.Local).AddTicks(6642), 325.03m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6295), "Hope Parker", null, new Guid("9134f6ce-dc29-42d5-888c-1475ddc6f086"), new DateTime(2024, 9, 9, 12, 38, 53, 664, DateTimeKind.Local).AddTicks(4432), 80.44m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6300), "Hope Parker", null, new Guid("645aded7-2f85-445f-950c-c51a1e4335b1"), new DateTime(2023, 10, 4, 1, 38, 54, 93, DateTimeKind.Local).AddTicks(6146), 315.11m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6306), "Hope Parker", null, new Guid("6778c811-d742-4d05-9f8d-c2338f4d3873"), new DateTime(2024, 8, 11, 21, 18, 30, 298, DateTimeKind.Local).AddTicks(6921), 184.94m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6313), "Hope Parker", null, new Guid("b35ece17-9ef6-40d7-b4a8-49c006b2d0a8"), new DateTime(2023, 10, 26, 11, 8, 41, 169, DateTimeKind.Local).AddTicks(7645), 15.28m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6319), "Hope Parker", null, new Guid("a59a6f76-a2b6-4f19-8064-efebc765cb2c"), new DateTime(2024, 2, 2, 18, 30, 2, 568, DateTimeKind.Local).AddTicks(4781), 415.15m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "CustomerName", "DiscountId", "MasterId", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 720, DateTimeKind.Local).AddTicks(6324), "Hope Parker", null, new Guid("cdfb2087-368c-4be0-be1b-fc7132394e4a"), new DateTime(2023, 10, 21, 16, 13, 32, 36, DateTimeKind.Local).AddTicks(1642), 492.10m });

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
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5100), 0.16, "https://picsum.photos/640/480/?image=1021", new Guid("ad176ba8-e151-48af-a040-53781e5ec9b2"), "Macaron", 956.09m, (short)76 });

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
                columns: new[] { "CategoryId", "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 1, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5114), "https://picsum.photos/640/480/?image=659", new Guid("d1c15546-9413-48eb-b109-f211e4c201ec"), "Macaron", 811.98m, (short)84 });

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
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5128), 0.040000000000000001, "https://picsum.photos/640/480/?image=225", new Guid("40398039-9241-452d-bf7f-3f76a5292a54"), "Turkish Coffee", 2.32m, (short)19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5158), 0.11, "https://picsum.photos/640/480/?image=68", new Guid("18e3a0e4-d75f-4771-9d11-177be15fd572"), 233.26m, (short)43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { 3, new DateTime(2024, 9, 16, 0, 6, 39, 718, DateTimeKind.Local).AddTicks(5167), 0.47999999999999998, "https://picsum.photos/640/480/?image=499", new Guid("caa78ac8-db3a-4f95-910b-6f6a588b0d20"), "Americano", 455.62m, (short)56 });

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
    }
}
