using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.DataAccess.Abstracts
{
    public interface IMsContextFactory
    {
        IRepository<Price, Guid> Prices { get; }
        //IRepository<BankAccount,Guid> BankAccounts { get; }
        IRepository<Demand,Guid> Demands { get; }
        IRepository<CashOut , Guid> CashOuts { get; }
        IRepository<Company , Guid> Companies { get; }
        IRepository<GoodFolder , Guid> GoodFolders { get; }
        IRepository<Good , Guid> Goods { get; }
        //IRepository<Contact , Guid> Contacts { get; }
        IRepository<CustomerOrder , Guid> CustomerOrders { get; }
        IRepository<Employee , Guid> Employees { get; }
        IRepository<Enter , Guid> Enters { get; }
        IRepository<EnterPosition , Guid> EnterPositions { get; }
        //IRepository<GoodRef , Guid> GoodRefs { get; }
        IRepository<Loss , Guid> Losses { get; }
        IRepository<MyCompany , Guid> MyCompanies { get; }
        IRepository<PurchaseOrderPosition , Guid> PurchaseOrderPositions { get; }
        IRepository<PaymentIn , Guid> PaymentIns { get; }
        IRepository<PaymentOut , Guid> PaymentOuts { get; }
        IRepository<PurchaseOrder , Guid> PurchaseOrders { get; }
        //IRepository< Requisite, Guid> Requisites { get; }
        IRepository<RetailDemand , Guid> RetailDemands { get; }
        IRepository<RetailStore , Guid> RetailStores { get; }
        //IRepository<ShipmentOut , Guid> ShipmentOuts { get; }
        IRepository<StockTO , Guid> StockTOs { get; }
        IRepository<CustomerOrderPosition , Guid> CustomerOrderPositions { get; }
        //IRepository<Sum , Guid> Sums { get; }
        IRepository<Supply , Guid> Supplies { get; }
        IRepository<Warehouse, Guid> Warehouses { get; }
        IRepository<ShipmentIn, Guid> ShipmentIns { get; }
        IRepository<LossPosition, Guid> LossPositions { get; }
        
        IRepository<PriceType,Guid> PriceTypes { get; }
        IRepository<Barcode, Guid> Barcodes { get; }
       
    }
}
