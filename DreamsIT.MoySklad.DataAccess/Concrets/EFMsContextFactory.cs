using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.DataAccess.Abstracts;
using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DreamsIT.MoySklad.DataAccess.Concrets
{
    public class EFMsContextFactory : IMsContextFactory
    {
        private IDependencyResolver _dependencyResolver;
        public EFMsContextFactory(IDependencyResolver dependencyResolver)
        {
            _dependencyResolver = dependencyResolver;
        }
        
        private IRepository<Price, int> _prices;
        public IRepository<Price, int> Prices
        {
            get
            {
                return _prices ?? (_prices = _dependencyResolver.GetService<IRepository<Price, int>>());
            }
        }
        private IRepository<BankAccount, int> _bankAccounts;
        public IRepository<BankAccount, int> BankAccounts
        {
            get
            {
                return _bankAccounts ?? (_bankAccounts = _dependencyResolver.GetService<IRepository<BankAccount, int>>());
            }
        }
        private IRepository<Demand, int> _demands;
        public IRepository<Demand, int> Demands
        {
            get
            {
                return _demands ?? (_demands = _dependencyResolver.GetService<IRepository<Demand, int>>());
            }
        }
        private IRepository<CashOut, int> _cashOuts;
        public IRepository<CashOut, int> CashOuts
        {
            get
            {
                return _cashOuts ?? (_cashOuts = _dependencyResolver.GetService<IRepository<CashOut, int>>());
            }
        }
        private IRepository<Company, int> _companies;
        public IRepository<Company, int> Companies
        {
            get
            {
                return _companies ?? (_companies = _dependencyResolver.GetService<IRepository<Company, int>>());
            }
        }
        private IRepository<GoodFolder, int> _goodFolders;
        public IRepository<GoodFolder, int> GoodFolders
        {
            get
            {
                return _goodFolders ?? (_goodFolders = _dependencyResolver.GetService<IRepository<GoodFolder, int>>());
            }
        }
        private IRepository<Good, int> _goods;
        public IRepository<Good, int> Goods
        {
            get
            {
                return _goods ?? (_goods = _dependencyResolver.GetService<IRepository<Good, int>>());
            }
        }
        private IRepository<Contact, int> _contacts;
        public IRepository<Contact, int> Contacts
        {
            get
            {
                return _contacts ?? (_contacts = _dependencyResolver.GetService<IRepository<Contact, int>>());
            }
        }
        private IRepository<CustomerOrder, int> _customerOrders;
        public IRepository<CustomerOrder, int> CustomerOrders
        {
            get
            {
                return _customerOrders ?? (_customerOrders = _dependencyResolver.GetService<IRepository<CustomerOrder, int>>());
            }
        }
        private IRepository<Employee, int> _employees;
        public IRepository<Employee, int> Employees
        {
            get
            {
                return _employees ?? (_employees = _dependencyResolver.GetService<IRepository<Employee, int>>());
            }
            
        }
        private IRepository<Enter, int> _enters;
        public IRepository<Enter, int> Enters
        {
            get
            {
                return _enters ?? (_enters = _dependencyResolver.GetService<IRepository<Enter, int>>());
            }
            
        }
        private IRepository<EnterPosition, int> _enterPositions;
        public IRepository<EnterPosition, int> EnterPositions
        {
            get
            {
                return _enterPositions ?? (_enterPositions = _dependencyResolver.GetService<IRepository<EnterPosition, int>>());
            }
            
        }
        private IRepository<GoodRef, int> _goodRefs;
        public IRepository<GoodRef, int> GoodRefs
        {
            get
            {
                return _goodRefs ?? (_goodRefs = _dependencyResolver.GetService<IRepository<GoodRef, int>>());
            }
            
        }
        private IRepository<Loss, int> _losses;
        public IRepository<Loss, int> Losses
        {
            get
            {
                return _losses ?? (_losses = _dependencyResolver.GetService<IRepository<Loss, int>>());
            }
            
        }
        private IRepository<MyCompany, int> _myCompanies;
        public IRepository<MyCompany, int> MyCompanies
        {
            get
            {
                return _myCompanies ?? (_myCompanies = _dependencyResolver.GetService<IRepository<MyCompany, int>>());
            }
           
        }
        private IRepository<PurchaseOrderPosition, int> _purchaseOrderPositions;
        public IRepository<PurchaseOrderPosition, int> PurchaseOrderPositions
        {
            get
            {
                return _purchaseOrderPositions ?? (_purchaseOrderPositions = _dependencyResolver.GetService<IRepository<PurchaseOrderPosition, int>>());
            }
           
        }
        private IRepository<PaymentIn, int> _paymentIns;
        public IRepository<PaymentIn, int> PaymentIns
        {
            get
            {
                return _paymentIns ?? (_paymentIns = _dependencyResolver.GetService<IRepository<PaymentIn, int>>());
            }
            
        }
        private IRepository<PaymentOut, int> _paymentOuts;
        public IRepository<PaymentOut, int> PaymentOuts
        {
            get
            {
                return _paymentOuts ?? (_paymentOuts = _dependencyResolver.GetService<IRepository<PaymentOut, int>>());
            }
            
        }
        private IRepository<PurchaseOrder, int> _purchaseOrders;
        public IRepository<PurchaseOrder, int> PurchaseOrders
        {
            get
            {
                return _purchaseOrders ?? (_purchaseOrders = _dependencyResolver.GetService<IRepository<PurchaseOrder, int>>());
            }
            
        }
        private IRepository<Requisite, int> _requisites;
        public IRepository<Requisite, int> Requisites
        {
            get
            {
                return _requisites ?? (_requisites = _dependencyResolver.GetService<IRepository<Requisite, int>>());
            }
            
        }
        private IRepository<RetailDemand, int> _retailDemands;
        public IRepository<RetailDemand, int> RetailDemands
        {
            get
            {
                return _retailDemands ?? (_retailDemands = _dependencyResolver.GetService<IRepository<RetailDemand, int>>());
            }
            
        }
        private IRepository<RetailStore, int> _retailStores;
        public IRepository<RetailStore, int> RetailStores
        {
            get
            {
                return _retailStores ?? (_retailStores = _dependencyResolver.GetService<IRepository<RetailStore, int>>());
            }
            
        }
        private IRepository<ShipmentOut, int> _shipmentOuts;
        public IRepository<ShipmentOut, int> ShipmentOuts
        {
            get
            {
                return _shipmentOuts ?? (_shipmentOuts = _dependencyResolver.GetService<IRepository<ShipmentOut, int>>());
            }
           
        }
        private IRepository<StockTO, int> _stockTOs;
        public IRepository<StockTO, int> StockTOs
        {
            get
            {
                return _stockTOs ?? (_stockTOs = _dependencyResolver.GetService<IRepository<StockTO, int>>());
            }
            
        }
        private IRepository<CustomerOrderPosition, int> _customerOrderPositions;
        public IRepository<CustomerOrderPosition, int> CustomerOrderPositions
        {
            get
            {
                return _customerOrderPositions ?? (_customerOrderPositions = _dependencyResolver.GetService<IRepository<CustomerOrderPosition, int>>());
            }
            
        }
        private IRepository<Sum, int> _sums;
        public IRepository<Sum, int> Sums
        {
            get
            {
                return _sums ?? (_sums = _dependencyResolver.GetService<IRepository<Sum, int>>());
            }
            
        }
        private IRepository<Supply, int> _supplies;
        public IRepository<Supply, int> Supplies
        {
            get
            {
                return _supplies ?? (_supplies = _dependencyResolver.GetService<IRepository<Supply, int>>());
            }
            
        }
        private IRepository<Warehouse, int> _warehouses;
        public IRepository<Warehouse, int> Warehouses
        {
            get
            {
                return _warehouses ?? (_warehouses = _dependencyResolver.GetService<IRepository<Warehouse, int>>());
            }
            
        }
}
}