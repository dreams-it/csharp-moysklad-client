using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.DataAccess.Abstracts
{
    public interface IMsRestApiDbContext
    {
        DbSet<Good> Goods { get; set; }
        DbSet<CashOut> CashOut { get; set; }
        DbSet<Company> Company { get; set; }
        DbSet<CustomerOrder> CustomerOrder { get; set; }
        DbSet<Demand> Demand { get; set; }
        DbSet<Employee> Employee { get; set; }
        DbSet<Enter> Enter { get; set; }
        DbSet<EnterPosition> EnterPosition { get; set; }
        DbSet<GoodFolder> GoodFolder { get; set; }
        //DbSet<GoodRef> GoodRef { get; set; }
        DbSet<Loss> Loss { get; set; }
        DbSet<MyCompany> MyCompany { get; set; }
        DbSet<PaymentIn> PaymentIn { get; set; }
        DbSet<PaymentOut> PaymentOut { get; set; }
        DbSet<Price> Price { get; set; }
        DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        DbSet<PurchaseOrderPosition> PurchaseOrderPosition { get; set; }
        DbSet<RetailDemand> RetailDemand { get; set; }
        DbSet<RetailStore> RetailStore { get; set; }
        DbSet<Supply> Supply { get; set; }
        DbSet<Warehouse> Warehouse { get; set; }
        DbSet<CustomerOrderPosition> CustomerOrderPosition { get; set; }

        DbSet<ShipmentIn> ShipmentIns { get; set; }
    }
}
