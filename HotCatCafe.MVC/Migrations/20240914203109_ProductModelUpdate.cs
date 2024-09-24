using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.MVC.Migrations
{
    /// <inheritdoc />
    public partial class ProductModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
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
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: true),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitsInStock = table.Column<short>(type: "smallint", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_OrderDetails", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Coffees", "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8509), "192.168.1.1", "Aliquid id nesciunt sed eum.", true, new Guid("e51334ff-9bb0-4922-b620-b8490b83ea5b"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Teas", "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8692), "192.168.1.1", "Harum officiis placeat aliquam illo quis sapiente voluptatem nulla.", true, new Guid("798b9383-ac68-4bae-9f77-27f8652df117"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Cold Beverages", "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8721), "192.168.1.1", "Repellendus quia voluptatibus odit qui eligendi aperiam voluptatem molestiae ipsum.", true, new Guid("cb61d77c-3dcb-4936-b93c-ce7a7a869f82"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Breakfast", "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8747), "192.168.1.1", "Quia eligendi qui voluptatem et ipsum consectetur est.", true, new Guid("5a66b6d3-efa6-4af7-a0a0-984133461652"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Salads", "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8765), "192.168.1.1", "Repellendus ipsam itaque sapiente facere.", true, new Guid("a9d6d23d-1789-4aba-b293-4da68e771531"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Burgers", "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8779), "192.168.1.1", "İllo dolore quos.", true, new Guid("63f697fe-f4d5-484f-a3b9-1e886e274281"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "Pizzas", "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8798), "192.168.1.1", "Cupiditate temporibus sed accusantium.", true, new Guid("d24dc5d2-f325-4aa4-b9ab-a16d49ad79f5"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "Desserts", "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8809), "192.168.1.1", "Consectetur sed est temporibus.", true, new Guid("a300e9d1-d8b9-4c37-8146-b8ad6dab0b94"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "Cakes", "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8819), "192.168.1.1", "Ad sint architecto et qui incidunt dolorem molestiae magni.", true, new Guid("4012495b-789e-461d-85c1-9ca6af5ea9ce"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "Ice Creams", "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 851, DateTimeKind.Local).AddTicks(8867), "192.168.1.1", "Saepe rerum illum.", true, new Guid("77abab2b-cc1a-4a2a-8d77-113edb207324"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "AppUserId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "CustomerName", "DiscountId", "IsActive", "MasterId", "OrderDate", "Status", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 854, DateTimeKind.Local).AddTicks(7253), "192.168.1.1", "Brendan Hintz", null, true, new Guid("3e2e8014-25e6-40b0-ba88-a6a5eb485660"), new DateTime(2024, 1, 17, 22, 13, 45, 694, DateTimeKind.Local).AddTicks(1404), 0, 499.67m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(694), "192.168.1.1", "Brendan Hintz", null, true, new Guid("2a857a4e-cf93-4b0d-8a3a-344d2ffc8789"), new DateTime(2023, 9, 16, 11, 50, 30, 371, DateTimeKind.Local).AddTicks(5531), 0, 378.77m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(770), "192.168.1.1", "Brendan Hintz", null, true, new Guid("d2ce1315-dcd8-4a80-9091-fea8297d2266"), new DateTime(2024, 5, 1, 11, 49, 9, 254, DateTimeKind.Local).AddTicks(2844), 0, 65.57m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(777), "192.168.1.1", "Brendan Hintz", null, true, new Guid("0b49faac-6f3f-4437-87b6-840bfd8e9955"), new DateTime(2024, 8, 15, 7, 45, 40, 660, DateTimeKind.Local).AddTicks(9268), 0, 337.69m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(783), "192.168.1.1", "Brendan Hintz", null, true, new Guid("0449aa43-9e2f-4cc3-959c-a0ef375f7780"), new DateTime(2024, 6, 6, 5, 9, 11, 859, DateTimeKind.Local).AddTicks(1340), 0, 102.28m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(789), "192.168.1.1", "Brendan Hintz", null, true, new Guid("25e30e57-9f70-4066-9638-bdbeb4d99a6d"), new DateTime(2024, 7, 10, 18, 57, 51, 415, DateTimeKind.Local).AddTicks(4388), 0, 291.87m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(799), "192.168.1.1", "Brendan Hintz", null, true, new Guid("c36c7424-ba44-4746-97a7-da1b2298174d"), new DateTime(2023, 10, 9, 10, 5, 49, 420, DateTimeKind.Local).AddTicks(9534), 0, 280.05m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(805), "192.168.1.1", "Brendan Hintz", null, true, new Guid("7b35a7c6-02be-4f66-b949-d75fecd620ed"), new DateTime(2024, 6, 26, 0, 55, 48, 237, DateTimeKind.Local).AddTicks(9204), 0, 440.11m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(810), "192.168.1.1", "Brendan Hintz", null, true, new Guid("f305c34e-5a37-438a-a5e6-e42331487618"), new DateTime(2024, 4, 7, 6, 32, 7, 832, DateTimeKind.Local).AddTicks(1570), 0, 357.61m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(847), "192.168.1.1", "Brendan Hintz", null, true, new Guid("83ce24a3-d196-48d2-abf5-4960f7711967"), new DateTime(2023, 11, 26, 14, 22, 44, 15, DateTimeKind.Local).AddTicks(7969), 0, 188.23m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(853), "192.168.1.1", "Brendan Hintz", null, true, new Guid("1c99ff79-640b-4740-8cd8-64e29796ba6e"), new DateTime(2023, 10, 13, 22, 47, 15, 566, DateTimeKind.Local).AddTicks(8097), 0, 366.97m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(858), "192.168.1.1", "Brendan Hintz", null, true, new Guid("f9954099-12a2-4fa9-9363-f57fed36dead"), new DateTime(2024, 7, 22, 9, 53, 3, 74, DateTimeKind.Local).AddTicks(9420), 0, 226.27m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(862), "192.168.1.1", "Brendan Hintz", null, true, new Guid("415cb647-ab5c-4889-a00e-b0cd8e0dc9f4"), new DateTime(2024, 1, 13, 8, 3, 5, 252, DateTimeKind.Local).AddTicks(1664), 0, 37.25m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(867), "192.168.1.1", "Brendan Hintz", null, true, new Guid("b6a6e84c-b334-40df-99fd-6bb3c6368b3a"), new DateTime(2024, 9, 8, 9, 44, 19, 101, DateTimeKind.Local).AddTicks(7200), 0, 216.47m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(874), "192.168.1.1", "Brendan Hintz", null, true, new Guid("95022164-2fad-4b81-a7fe-bf3e18b32387"), new DateTime(2023, 10, 21, 11, 43, 25, 886, DateTimeKind.Local).AddTicks(6669), 0, 290.57m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(879), "192.168.1.1", "Brendan Hintz", null, true, new Guid("b210a6f6-20be-4b62-87bb-6ff4b52b6935"), new DateTime(2024, 9, 11, 18, 23, 8, 410, DateTimeKind.Local).AddTicks(2575), 0, 465.28m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(883), "192.168.1.1", "Brendan Hintz", null, true, new Guid("c5d1e010-3c05-46ba-a9e8-dc584fdd05a6"), new DateTime(2024, 2, 15, 10, 30, 41, 962, DateTimeKind.Local).AddTicks(7583), 0, 421.05m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(889), "192.168.1.1", "Brendan Hintz", null, true, new Guid("106a9788-f8b1-4186-b02c-1fec3c495e86"), new DateTime(2023, 12, 27, 22, 48, 19, 949, DateTimeKind.Local).AddTicks(6553), 0, 375.03m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(894), "192.168.1.1", "Brendan Hintz", null, true, new Guid("f18baeb8-9b8e-4492-9fde-e8d167fe7de7"), new DateTime(2024, 9, 3, 16, 41, 36, 666, DateTimeKind.Local).AddTicks(3438), 0, 370.27m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, null, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 855, DateTimeKind.Local).AddTicks(899), "192.168.1.1", "Brendan Hintz", null, true, new Guid("f5f2a505-6264-4bd8-ba95-0cb4ca0c7bed"), new DateTime(2023, 9, 21, 10, 23, 43, 286, DateTimeKind.Local).AddTicks(2275), 0, 163.35m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Discount", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, 8, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2171), "192.168.1.1", 0.20999999999999999, "https://picsum.photos/640/480/?image=1023", true, new Guid("386e9795-e028-413c-a759-65cc46d0bc65"), "Frappé", 0, 216.69m, (short)79, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 3, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2328), "192.168.1.1", 0.02, "https://picsum.photos/640/480/?image=981", true, new Guid("1f861580-3227-43a0-8ea2-385a8fa9077f"), "Tiramisu", 0, 181.61m, (short)37, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 9, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2349), "192.168.1.1", 0.40999999999999998, "https://picsum.photos/640/480/?image=960", true, new Guid("86b3cc5f-d735-4d33-af51-8346bedece7c"), "Muffin", 0, 963.09m, (short)61, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 6, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2358), "192.168.1.1", 0.19, "https://picsum.photos/640/480/?image=111", true, new Guid("fdb083c3-fea9-4fa6-971d-69ecc2476ead"), "Latte", 0, 309.79m, (short)52, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 8, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2366), "192.168.1.1", 0.070000000000000007, "https://picsum.photos/640/480/?image=757", true, new Guid("a7abaab2-b6e6-4500-b1e1-3a2c744e0757"), "Frappé", 0, 742.03m, (short)100, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 5, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2386), "192.168.1.1", 0.11, "https://picsum.photos/640/480/?image=373", true, new Guid("255f964d-1c4a-4558-9022-8b1511c4c427"), "Espresso", 0, 773.12m, (short)80, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 3, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2393), "192.168.1.1", 0.02, "https://picsum.photos/640/480/?image=799", true, new Guid("c7f2e8ea-1fa2-43f5-a436-d5d5c6bb1c14"), "Cheesecake", 0, 856.00m, (short)46, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 6, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2400), "192.168.1.1", 0.23000000000000001, "https://picsum.photos/640/480/?image=853", true, new Guid("e16a35a8-f852-4ba7-a1c9-6f49dd90265b"), "Espresso Macchiato", 0, 929.43m, (short)7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 9, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2407), "192.168.1.1", 0.40999999999999998, "https://picsum.photos/640/480/?image=564", true, new Guid("1306faec-32fb-4a28-b248-b43265af3afd"), "Iced Coffee", 0, 262.30m, (short)60, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 1, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2415), "192.168.1.1", 0.42999999999999999, "https://picsum.photos/640/480/?image=154", true, new Guid("e6cafd3b-4bf6-47ab-b020-d600a563e01a"), "Cold Brew", 0, 302.53m, (short)43, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 1, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2425), "192.168.1.1", 0.5, "https://picsum.photos/640/480/?image=1024", true, new Guid("7fb36b7a-0cc3-4f71-bcd1-10851203baca"), "Cold Brew", 0, 132.29m, (short)97, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 5, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2433), "192.168.1.1", 0.10000000000000001, "https://picsum.photos/640/480/?image=75", true, new Guid("6e3d3b5d-3550-4233-bf50-4e3359e4ecdb"), "Profiterole", 0, 935.47m, (short)20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 4, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2441), "192.168.1.1", 0.070000000000000007, "https://picsum.photos/640/480/?image=791", true, new Guid("92836d30-1b2e-41eb-98f2-305c48da2625"), "Profiterole", 0, 101.53m, (short)65, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 3, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2472), "192.168.1.1", 0.38, "https://picsum.photos/640/480/?image=258", true, new Guid("c5aa72ea-e54f-4485-97a2-2550957ba3e7"), "Profiterole", 0, 657.41m, (short)91, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 3, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2479), "192.168.1.1", 0.040000000000000001, "https://picsum.photos/640/480/?image=610", true, new Guid("ceb25fe3-c0e1-48a6-a7b7-330bef204d15"), "Americano", 0, 136.98m, (short)4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 6, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2487), "192.168.1.1", 0.42999999999999999, "https://picsum.photos/640/480/?image=81", true, new Guid("c78d7a46-6c2b-4905-b1ff-382a9452dfa9"), "Waffle", 0, 3.90m, (short)93, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 3, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2495), "192.168.1.1", 0.20999999999999999, "https://picsum.photos/640/480/?image=783", true, new Guid("4bc9af1c-3037-4179-985c-ad34670548b4"), "Profiterole", 0, 96.30m, (short)38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 10, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2504), "192.168.1.1", 0.23999999999999999, "https://picsum.photos/640/480/?image=524", true, new Guid("bdc6b014-7fc2-4405-8d54-3021223d65d1"), "Flat White", 0, 524.99m, (short)37, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 6, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2513), "192.168.1.1", 0.22, "https://picsum.photos/640/480/?image=670", true, new Guid("49427daa-0783-4cfc-a460-d96e192b4ee8"), "Latte", 0, 818.56m, (short)68, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 2, "DESKTOP-JSABNAD", new DateTime(2024, 9, 14, 23, 31, 9, 853, DateTimeKind.Local).AddTicks(2520), "192.168.1.1", 0.25, "https://picsum.photos/640/480/?image=212", true, new Guid("4a73c52b-db66-4272-85ca-5b90e3210c5d"), "Profiterole", 0, 836.93m, (short)97, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
