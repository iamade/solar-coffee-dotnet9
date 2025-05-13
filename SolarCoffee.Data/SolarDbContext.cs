using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolarCoffee.Data.Models;

namespace SolarCoffee.Data;

public class SolarDbContext : IdentityDbContext
{
    public SolarDbContext() { }
    public SolarDbContext(DbContextOptions options) : base(options) { }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<ProductInventory> ProductInventory { get; set; }
    public virtual DbSet<ProductInventorySnapshot> ProductInventorySnapshot { get; set; }
    public virtual DbSet<SalesOrder> SalesOrder { get; set; }
    public virtual DbSet<SalesOrderItem> SalesOrderItem { get; set; }

}
