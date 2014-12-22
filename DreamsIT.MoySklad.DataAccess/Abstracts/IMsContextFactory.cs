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
        public IRepository<Price, int> Prices { get; set; }
        public IRepository<BankAccount,int> BankAccounts { get; set; }
        public IRepository<Demand,int> Demands { get; set; }
        public IRepository<CashOut , int> CashOuts { get; set; }
        public IRepository<Company , int> Companies { get; set; }
        public IRepository<GoodFolder , int> GoodFolders { get; set; }
        public IRepository<Good , int> Goods { get; set; }
        public IRepository<Contact , int> Contacts { get; set; }
        public IRepository<CustomerOrder , int> CustomerOrders { get; set; }
        public IRepository<Employee , int> Employees { get; set; }
        public IRepository<Enter , int> Enters { get; set; }
        public IRepository<EnterPosition , int> EnterPositions { get; set; }
        public IRepository<GoodRef , int> GoodRefs { get; set; }
        public IRepository<Loss , int> Losses { get; set; }
        public IRepository<MyCompany , int> MyCompanies { get; set; }
        public IRepository<PurchaseOrderPosition , int> PurchaseOrderPositions { get; set; }
        public IRepository<PaymentIn , int> PaymentIns { get; set; }
        public IRepository<PaymentOut , int> PaymentOuts { get; set; }
        public IRepository<PurchaseOrder , int> PurchaseOrders { get; set; }
        public IRepository< Requisite, int> Requisites { get; set; }
        public IRepository<RetailDemand , int> RetailDemands { get; set; }
        public IRepository<RetailStore , int> RetailStores { get; set; }
        public IRepository<ShipmentOut , int> ShipmentOuts { get; set; }
        public IRepository<StockTO , int> StockTOs { get; set; }
        public IRepository<CustomerOrderPosition , int> CustomerOrderPositions { get; set; }
        public IRepository<Sum , int> Sums { get; set; }
        public IRepository<Supply , int> Supplies { get; set; }
        public IRepository<Warehouse,int> Warehouses { get; set; }
       
    }
}
