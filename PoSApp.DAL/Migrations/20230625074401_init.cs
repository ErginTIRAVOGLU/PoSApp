using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PoSApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PriceTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DiscountTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Vat = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupplierAddress1 = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    SupplierAddress2 = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    SupplierPhone1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SupplierPhone2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SupplierManager = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SupplierTaxAdministrator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SupplierTaxNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SupplierNote = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayedAmount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    PriceTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PayedType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayedAmount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayedAmount_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductBarcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ProductVat = table.Column<int>(type: "int", nullable: false),
                    ProductUnitType = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockIns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockInRefNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StockInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockIns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockIns_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ProductUnit = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ProductUnitType = table.Column<int>(type: "int", nullable: false),
                    PriceTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vat = table.Column<int>(type: "int", nullable: false),
                    ProductDiscount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DiscountTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockInDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockInDetailUnit = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    StockInId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockInDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockInDetails_StockIns_StockInId",
                        column: x => x.StockInId,
                        principalTable: "StockIns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockInDetails_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreatedDate", "DeletedDate", "IsDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Marka 1", new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8276), null, false, null },
                    { 2, "Marka 2", new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8278), null, false, null },
                    { 3, "Marka 3", new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8279), null, false, null },
                    { 4, "Marka 4", new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8281), null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "IsDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Kategori 1", new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8443), null, false, null },
                    { 2, "Kategori 2", new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8445), null, false, null },
                    { 3, "Kategori 3", new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8446), null, false, null },
                    { 4, "Kategori 4", new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8448), null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "SupplierAddress1", "SupplierAddress2", "SupplierManager", "SupplierName", "SupplierNote", "SupplierPhone1", "SupplierPhone2", "SupplierTaxAdministrator", "SupplierTaxNumber", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8470), null, false, "Adres 11", "Adres 21", "Yönetici 1", "Tedarikçi 1", "Firma hakkında 1", "Phone 11", "Phone 21", "Vergi Dairesi 1", "Vergi Numarası 1", null },
                    { 2, new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8472), null, false, "Adres 21", "Adres 22", "Yönetici 2", "Tedarikçi 2", "Firma hakkında 2", "Phone 21", "Phone 22", "Vergi Dairesi 2", "Vergi Numarası 2", null },
                    { 3, new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8485), null, false, "Adres 31", "Adres 23", "Yönetici 3", "Tedarikçi 3", "Firma hakkında 3", "Phone 31", "Phone 23", "Vergi Dairesi 3", "Vergi Numarası 3", null },
                    { 4, new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8488), null, false, "Adres 41", "Adres 24", "Yönetici 4", "Tedarikçi 4", "Firma hakkında 4", "Phone 41", "Phone 24", "Vergi Dairesi 4", "Vergi Numarası 4", null }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "UpdatedDate", "WarehouseName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8540), null, false, null, "Depo 1" },
                    { 2, new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8541), null, false, null, "Depo 2" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryID", "CreatedDate", "DeletedDate", "IsDeleted", "ProductBarcode", "ProductCode", "ProductDescription", "ProductName", "ProductPrice", "ProductUnitType", "ProductVat", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8517), null, false, "12345", "PR001", "Ürün açıklaması 1", "Ürün 1", 10m, 0, 18, null },
                    { 2, 2, 2, new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8520), null, false, "12345", "PR002", "Ürün açıklaması 2", "Ürün 2", 20m, 0, 8, null },
                    { 3, 3, 3, new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8523), null, false, "12345", "PR003", "Ürün açıklaması 3", "Ürün 3", 30m, 0, 1, null },
                    { 4, 4, 4, new DateTime(2023, 6, 25, 10, 44, 1, 161, DateTimeKind.Local).AddTicks(8526), null, false, "12345", "PR004", "Ürün açıklaması 4", "Ürün 4", 40m, 0, 8, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CartId",
                table: "CartDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductId",
                table: "CartDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PayedAmount_CartId",
                table: "PayedAmount",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_StockInDetails_ProductId",
                table: "StockInDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockInDetails_StockInId",
                table: "StockInDetails",
                column: "StockInId");

            migrationBuilder.CreateIndex(
                name: "IX_StockInDetails_WarehouseId",
                table: "StockInDetails",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_StockIns_SupplierId",
                table: "StockIns",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropTable(
                name: "PayedAmount");

            migrationBuilder.DropTable(
                name: "StockInDetails");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "StockIns");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
