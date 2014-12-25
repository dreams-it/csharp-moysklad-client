using DreamsIT.MoySklad.DataAccess.Abstracts;
using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.DataAccess.DataDbContext
{
    public class MsRestApiDbContext : DbContext, IMsRestApiDbContext
    {
        public DbSet<Good> Goods { get; set; }
        public DbSet<CashOut> CashOut { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CustomerOrder> CustomerOrder { get; set; }
        public DbSet<Demand> Demand { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Enter> Enter { get; set; }
        public DbSet<EnterPosition> EnterPosition { get; set; }
        public DbSet<GoodFolder> GoodFolder { get; set; }
        public DbSet<GoodRef> GoodRef { get; set; }
        public DbSet<Loss> Loss { get; set; }
        public DbSet<MyCompany> MyCompany { get; set; }
        public DbSet<PaymentIn> PaymentIn { get; set; }
        public DbSet<PaymentOut> PaymentOut { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderPosition> PurchaseOrderPosition { get; set; }
        public DbSet<RetailDemand> RetailDemand { get; set; }
        public DbSet<RetailStore> RetailStore { get; set; }
        public DbSet<Supply> Supply { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<CustomerOrderPosition> CustomerOrderPosition { get; set; }

        public DbSet<ShipmentIn> ShipmentIns { get; set; }
    }
}
