using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PoSApp.Entities;
using PoSApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.DAL
{
    public class PosDbContext : DbContext
    {
         

        public sealed class Settings
        {
            
            public required string connectionString { get; set; }

        }
             
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //var cfg = new ConfigurationBuilder();           
            //var connectionString = configuration.GetConnectionString("PoSAppDatabase");
            //optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseSqlite(@"Data Source=PoSAppDB.db;");
            //optionsBuilder.UseSqlServer();
            var databaseSettingsFile = GetSettingsFile("App.config.json");
            IConfiguration Configuration = new ConfigurationBuilder()
              .AddJsonFile(databaseSettingsFile, optional: true, reloadOnChange: true)
              .AddEnvironmentVariables()
              .Build();


            Settings section = Configuration.GetSection("Settings").Get<Settings>();
            optionsBuilder.UseSqlServer(section.connectionString);
        }

        private string GetSettingsFile(string fileName)
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string userFilePath = Path.Combine(localAppData, "PoSApp");
            string destFilePath = Path.Combine(userFilePath, fileName);
            return destFilePath;
        }

        DbSet<Brand> Brands { get; set; }
        DbSet<Cart> Carts { get; set; }
        DbSet<CartDetail> CartDetails { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<PayedAmount> PayedAmount { get; set; }
        DbSet<Product> Products { get; set; }     
        DbSet<StockIn> StockIns { get; set; }
        DbSet<StockInDetail> StockInDetails { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Warehouse> Warehouse { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                 .HasOne(a => a.Brand)
                 .WithMany(b => b.Products);
            
            modelBuilder.Entity<Product>()
                 .HasOne(a => a.Category)
                 .WithMany(b => b.Products);

            Brand Marka1 = new Brand { Id = 1, BrandName = "Marka 1", CreatedDate = DateTime.Now, IsDeleted = false };
            Brand Marka2 = new Brand { Id = 2, BrandName = "Marka 2", CreatedDate = DateTime.Now, IsDeleted = false };
            Brand Marka3 = new Brand { Id = 3, BrandName = "Marka 3", CreatedDate = DateTime.Now, IsDeleted = false };
            Brand Marka4 = new Brand { Id = 4, BrandName = "Marka 4", CreatedDate = DateTime.Now, IsDeleted = false };


            modelBuilder.Entity<Brand>().HasData(
                new Brand[] { 
                    Marka1,
                    Marka2,
                    Marka3,
                    Marka4
                });

            Category Kategori1 = new Category { Id = 1, CategoryName = "Kategori 1", CreatedDate = DateTime.Now, IsDeleted = false };
            Category Kategori2 = new Category { Id = 2, CategoryName = "Kategori 2", CreatedDate = DateTime.Now, IsDeleted = false };
            Category Kategori3 = new Category { Id = 3, CategoryName = "Kategori 3", CreatedDate = DateTime.Now, IsDeleted = false };
            Category Kategori4 = new Category { Id = 4, CategoryName = "Kategori 4", CreatedDate = DateTime.Now, IsDeleted = false };

            modelBuilder.Entity<Category>().HasData(
                new Category[] { 
                    Kategori1, 
                    Kategori2, 
                    Kategori3, 
                    Kategori4 
                });

            Supplier Tedarikçi1 = new Supplier { Id = 1, SupplierName = "Tedarikçi 1", SupplierAddress1 = "Adres 11", SupplierAddress2 = "Adres 21", SupplierPhone1 = "Phone 11", SupplierPhone2 = "Phone 21", SupplierManager = "Yönetici 1", SupplierTaxAdministrator = "Vergi Dairesi 1", SupplierTaxNumber = "Vergi Numarası 1", SupplierNote = "Firma hakkında 1", CreatedDate = DateTime.Now, IsDeleted = false };
            Supplier Tedarikçi2 = new Supplier { Id = 2, SupplierName = "Tedarikçi 2", SupplierAddress1 = "Adres 21", SupplierAddress2 = "Adres 22", SupplierPhone1 = "Phone 21", SupplierPhone2 = "Phone 22", SupplierManager = "Yönetici 2", SupplierTaxAdministrator = "Vergi Dairesi 2", SupplierTaxNumber = "Vergi Numarası 2", SupplierNote = "Firma hakkında 2", CreatedDate = DateTime.Now, IsDeleted = false };
            Supplier Tedarikçi3 = new Supplier { Id = 3, SupplierName = "Tedarikçi 3", SupplierAddress1 = "Adres 31", SupplierAddress2 = "Adres 23", SupplierPhone1 = "Phone 31", SupplierPhone2 = "Phone 23", SupplierManager = "Yönetici 3", SupplierTaxAdministrator = "Vergi Dairesi 3", SupplierTaxNumber = "Vergi Numarası 3", SupplierNote = "Firma hakkında 3", CreatedDate = DateTime.Now, IsDeleted = false };
            Supplier Tedarikçi4 = new Supplier { Id = 4, SupplierName = "Tedarikçi 4", SupplierAddress1 = "Adres 41", SupplierAddress2 = "Adres 24", SupplierPhone1 = "Phone 41", SupplierPhone2 = "Phone 24", SupplierManager = "Yönetici 4", SupplierTaxAdministrator = "Vergi Dairesi 4", SupplierTaxNumber = "Vergi Numarası 4", SupplierNote = "Firma hakkında 4", CreatedDate = DateTime.Now, IsDeleted = false };

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier[]
                {
                    Tedarikçi1,
                    Tedarikçi2,
                    Tedarikçi3,
                    Tedarikçi4
                });

            Product Urun1 = new Product { Id = 1, ProductName = "Ürün 1", ProductBarcode = "12345", ProductCode = "PR001", ProductDescription = "Ürün açıklaması 1", ProductPrice = 10, ProductUnitType = ProductUnitType.Quantity, BrandId = Marka1.Id, CategoryID = Kategori1.Id, ProductVat = 18, CreatedDate = DateTime.Now, IsDeleted = false };
            Product Urun2 = new Product { Id = 2, ProductName = "Ürün 2", ProductBarcode = "12345", ProductCode = "PR002", ProductDescription = "Ürün açıklaması 2", ProductPrice = 20, ProductUnitType = ProductUnitType.Quantity, BrandId = Marka2.Id, CategoryID = Kategori2.Id, ProductVat = 8, CreatedDate = DateTime.Now, IsDeleted = false };
            Product Urun3 = new Product { Id = 3, ProductName = "Ürün 3", ProductBarcode = "12345", ProductCode = "PR003", ProductDescription = "Ürün açıklaması 3", ProductPrice = 30, ProductUnitType = ProductUnitType.Quantity, BrandId = Marka3.Id, CategoryID = Kategori3.Id, ProductVat = 1, CreatedDate = DateTime.Now, IsDeleted = false };
            Product Urun4 = new Product { Id = 4, ProductName = "Ürün 4", ProductBarcode = "12345", ProductCode = "PR004", ProductDescription = "Ürün açıklaması 4", ProductPrice = 40, ProductUnitType = ProductUnitType.Quantity, BrandId = Marka4.Id, CategoryID = Kategori4.Id, ProductVat = 8, CreatedDate = DateTime.Now, IsDeleted = false };

            modelBuilder.Entity<Product>().HasData(
               new Product[]
               {
                    Urun1,
                    Urun2,
                    Urun3,
                    Urun4
               });

            Warehouse Depo1 = new Warehouse { Id = 1, WarehouseName = "Depo 1" };
            Warehouse Depo2 = new Warehouse { Id = 2, WarehouseName = "Depo 2" };

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse[] {
                    Depo1,
                    Depo2
                });


        }
    }
}
