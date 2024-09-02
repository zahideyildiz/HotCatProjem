using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCat.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
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
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountId = table.Column<int>(type: "int", nullable: true),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "OrderDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_OrderDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Coffees", "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9430), "192.168.1.1", "Velit iure aliquam fugiat corrupti veniam.", true, new Guid("20fb1f8d-c3ec-4b80-bf78-fc78e13c22f8"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Teas", "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9594), "192.168.1.1", "Qui et optio et rerum cum est.", true, new Guid("5f8a5f21-2e40-4f1f-b3f2-01984d2d94f0"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Cold Beverages", "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9617), "192.168.1.1", "Velit nesciunt incidunt vel eligendi eveniet modi excepturi est hic.", true, new Guid("29ae6535-34ce-4ae5-961d-99e765b0a830"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Breakfast", "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9642), "192.168.1.1", "Aperiam voluptas necessitatibus debitis occaecati.", true, new Guid("f7791d64-5b7b-4dfb-b253-cf82808f1625"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Salads", "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9657), "192.168.1.1", "Quisquam sint ea aperiam molestiae.", true, new Guid("e92130f9-16af-46d2-8070-2d6679123668"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Burgers", "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9761), "192.168.1.1", "Harum ratione voluptatum deserunt ut dolor soluta quam.", true, new Guid("99ca6d4c-bd07-4b07-8463-26ee9d7c845f"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "Pizzas", "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9789), "192.168.1.1", "Nesciunt ut incidunt.", true, new Guid("36da5c29-576c-405a-ad41-e585a33d16c4"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "Desserts", "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9797), "192.168.1.1", "Molestias ut fuga et.", true, new Guid("d4cceaeb-9082-41d0-8ef2-1c6412b916d0"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "Cakes", "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9807), "192.168.1.1", "Ullam in cumque eaque mollitia architecto porro repudiandae.", true, new Guid("94f80b30-651e-4034-ae3b-c0703d26bb65"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "Ice Creams", "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 829, DateTimeKind.Local).AddTicks(9822), "192.168.1.1", "Labore esse illo optio fuga.", true, new Guid("5c149d78-8a70-4880-ba8f-6a39d5c04930"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Discount", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, 3, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8495), "192.168.1.1", 0.33000000000000002, "https://picsum.photos/640/480/?image=955", true, new Guid("9d378910-ce9b-45ce-b7ab-7e2eb7ac462e"), "Cookie", 0, 354.52m, (short)83, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 6, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8615), "192.168.1.1", 0.0, "https://picsum.photos/640/480/?image=418", true, new Guid("d2fa1ea7-3db5-4d9c-9ca0-f3983e2d43d8"), "Latte", 0, 225.66m, (short)68, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 5, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8626), "192.168.1.1", 0.070000000000000007, "https://picsum.photos/640/480/?image=147", true, new Guid("b31f0c2c-e434-4072-a52c-b663fe3983c4"), "Flat White", 0, 884.02m, (short)79, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 6, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8641), "192.168.1.1", 0.19, "https://picsum.photos/640/480/?image=749", true, new Guid("b41ac594-61d5-4a1a-ab9f-e63547ced5d4"), "Flat White", 0, 303.33m, (short)88, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 10, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8649), "192.168.1.1", 0.40000000000000002, "https://picsum.photos/640/480/?image=418", true, new Guid("96ff49b9-3edf-42b7-9523-6c40223df7b4"), "Cold Brew", 0, 47.03m, (short)99, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 7, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8658), "192.168.1.1", 0.17999999999999999, "https://picsum.photos/640/480/?image=155", true, new Guid("4d86920d-d877-4de2-bfe3-02221ff764bb"), "Frappé", 0, 209.64m, (short)79, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 2, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8666), "192.168.1.1", 0.47999999999999998, "https://picsum.photos/640/480/?image=833", true, new Guid("c798cdd7-d829-433e-84e9-f88f700a65f2"), "Waffle", 0, 555.11m, (short)5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 9, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8673), "192.168.1.1", 0.42999999999999999, "https://picsum.photos/640/480/?image=860", true, new Guid("86922286-0587-482c-9d37-6a2e6898859c"), "Cheesecake", 0, 814.27m, (short)18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 3, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8681), "192.168.1.1", 0.33000000000000002, "https://picsum.photos/640/480/?image=725", true, new Guid("12d3c1a9-6d0e-4270-b0b5-54da06d8ee30"), "Frappé", 0, 927.63m, (short)89, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 1, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8694), "192.168.1.1", 0.34000000000000002, "https://picsum.photos/640/480/?image=826", true, new Guid("7256efe6-8d0b-41a9-b3c4-c24961813c4a"), "Flat White", 0, 508.45m, (short)0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 3, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8701), "192.168.1.1", 0.31, "https://picsum.photos/640/480/?image=278", true, new Guid("7763b271-ce2f-49f7-a51f-4c78b0122348"), "Cookie", 0, 556.01m, (short)12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 2, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8709), "192.168.1.1", 0.48999999999999999, "https://picsum.photos/640/480/?image=375", true, new Guid("26236afe-9aae-4216-bea0-05e47f28aeb2"), "Tiramisu", 0, 769.83m, (short)21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 2, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8716), "192.168.1.1", 0.10000000000000001, "https://picsum.photos/640/480/?image=59", true, new Guid("b81703e9-9f32-4135-b9cc-27cf11fabc9f"), "Brownie", 0, 373.62m, (short)32, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 6, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8723), "192.168.1.1", 0.35999999999999999, "https://picsum.photos/640/480/?image=449", true, new Guid("07804a19-1be5-485a-89d8-8485fd5650cf"), "Cappuccino", 0, 773.56m, (short)38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 6, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8730), "192.168.1.1", 0.19, "https://picsum.photos/640/480/?image=911", true, new Guid("1c21a1d0-87ec-4f1c-af06-2a66cc8db4c0"), "Espresso", 0, 531.29m, (short)65, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 8, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8736), "192.168.1.1", 0.089999999999999997, "https://picsum.photos/640/480/?image=780", true, new Guid("8f84ab23-c391-45b1-a633-66fd335b4c60"), "Muffin", 0, 789.27m, (short)65, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 6, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8742), "192.168.1.1", 0.070000000000000007, "https://picsum.photos/640/480/?image=730", true, new Guid("ef677912-5663-4dda-a843-f106f446858b"), "Frappé", 0, 968.80m, (short)13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 1, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8750), "192.168.1.1", 0.34999999999999998, "https://picsum.photos/640/480/?image=813", true, new Guid("87881dac-8462-4d1d-8d30-f63ff28f00f7"), "Cold Brew", 0, 999.36m, (short)85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 4, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8756), "192.168.1.1", 0.46000000000000002, "https://picsum.photos/640/480/?image=488", true, new Guid("81c4b3b1-b874-4fc6-85b1-5502047df851"), "Chocolate Fondue", 0, 874.87m, (short)46, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 3, "DESKTOP-JSABNAD", new DateTime(2024, 9, 2, 1, 43, 14, 830, DateTimeKind.Local).AddTicks(8764), "192.168.1.1", 0.20999999999999999, "https://picsum.photos/640/480/?image=172", true, new Guid("43e9faf0-04bf-4994-921c-d2904917cbac"), "Macaron", 0, 859.67m, (short)100, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

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
                name: "OrderDetail");

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
