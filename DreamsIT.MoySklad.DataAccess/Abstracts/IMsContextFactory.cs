using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.DataAccess.Abstracts
{
    interface IMsContextFactory
    {
        IRepository<Price, int> Prices { get; }
        IRepository<BankAccount,int> BankAccounts { get; }
        IRepository<Demand,int> Demands { get; }
        IRepository<CashOut , int> CashOuts { get; }
        IRepository<Company , int> Companies { get; }
        IRepository<GoodFolder , int> GoodFolders { get; }
        IRepository<Good , int> Goods { get; }
        IRepository<Contact , int> Contacts { get; }
        IRepository<CustomerOrder , int> CustomerOrders { get; }
        IRepository<Employee , int> Employees { get; }
        IRepository<Enter , int> Enters { get; }
        IRepository<EnterPosition , int> EnterPositions { get; }
        IRepository<GoodRef , int> GoodRefs { get; }
        IRepository<Loss , int> Losses { get; }
        IRepository<MyCompany , int> MyCompanies { get; }
        IRepository<PurchaseOrderPosition , int> PurchaseOrderPositions { get; }
        IRepository<PaymentIn , int> PaymentIns { get; }
        IRepository<PaymentOut , int> PaymentOuts { get; }
        IRepository<PurchaseOrder , int> PurchaseOrders { get; }
        IRepository< Requisite, int> Requisites { get; }
        IRepository<RetailDemand , int> RetailDemands { get; }
        IRepository<RetailStore , int> RetailStores { get; }
        IRepository<ShipmentOut , int> ShipmentOuts { get; }
        IRepository<StockTO , int> StockTOs { get; }
        IRepository<CustomerOrderPosition , int> CustomerOrderPositions { get; }
        IRepository<Sum , int> Sums { get; }
        IRepository<Supply , int> Supplies { get; }
        IRepository<Warehouse,int> Warehouses { get; }
       
    }
}
