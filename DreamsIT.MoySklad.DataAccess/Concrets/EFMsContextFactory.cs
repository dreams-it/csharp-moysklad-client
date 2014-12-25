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


        private IRepository<PaymentOut, Guid> _paymentOuts;
        public IRepository<PaymentOut, Guid> PaymentOuts
        {
            get
            {
                return _paymentOuts ?? (_paymentOuts = _dependencyResolver.GetService<IRepository<PaymentOut, Guid>>());
            }
        }

        private IRepository<ShipmentIn, Guid> _shipmentIns;
        public IRepository<ShipmentIn, Guid> ShipmentIns
        {
            get
            {
                return _shipmentIns ?? (_shipmentIns = _dependencyResolver.GetService<IRepository<ShipmentIn, Guid>>());
            }
        }

        private IRepository<Price, Guid> _prices;
        public IRepository<Price, Guid> Prices
        {
            get
            {
                return _prices ?? (_prices = _dependencyResolver.GetService<IRepository<Price, Guid>>());
            }
        }
        private IRepository<Demand, Guid> _demands;
        public IRepository<Demand, Guid> Demands
        {
            get
            {
                return _demands ?? (_demands = _dependencyResolver.GetService<IRepository<Demand, Guid>>());
            }
        }
        private IRepository<CashOut, Guid> _cashOuts;
        public IRepository<CashOut, Guid> CashOuts
        {
            get
            {
                return _cashOuts ?? (_cashOuts = _dependencyResolver.GetService<IRepository<CashOut, Guid>>());
            }
        }
        private IRepository<Company, Guid> _companies;
        public IRepository<Company, Guid> Companies
        {
            get
            {
                return _companies ?? (_companies = _dependencyResolver.GetService<IRepository<Company, Guid>>());
            }
        }
        private IRepository<GoodFolder, Guid> _goodFolders;
        public IRepository<GoodFolder, Guid> GoodFolders
        {
            get
            {
                return _goodFolders ?? (_goodFolders = _dependencyResolver.GetService<IRepository<GoodFolder, Guid>>());
            }
        }
        private IRepository<Good, Guid> _goods;
        public IRepository<Good, Guid> Goods
        {
            get
            {
                return _goods ?? (_goods = _dependencyResolver.GetService<IRepository<Good, Guid>>());
            }
        }
        private IRepository<CustomerOrder, Guid> _customerOrders;
        public IRepository<CustomerOrder, Guid> CustomerOrders
        {
            get
            {
                return _customerOrders ?? (_customerOrders = _dependencyResolver.GetService<IRepository<CustomerOrder, Guid>>());
            }
        }
        private IRepository<Employee, Guid> _employees;
        public IRepository<Employee, Guid> Employees
        {
            get
            {
                return _employees ?? (_employees = _dependencyResolver.GetService<IRepository<Employee, Guid>>());
            }
            
        }
        private IRepository<Enter, Guid> _enters;
        public IRepository<Enter, Guid> Enters
        {
            get
            {
                return _enters ?? (_enters = _dependencyResolver.GetService<IRepository<Enter, Guid>>());
            }
            
        }
        private IRepository<EnterPosition, Guid> _enterPositions;
        public IRepository<EnterPosition, Guid> EnterPositions
        {
            get
            {
                return _enterPositions ?? (_enterPositions = _dependencyResolver.GetService<IRepository<EnterPosition, Guid>>());
            }
            
        }
        private IRepository<GoodRef, Guid> _goodRefs;
        public IRepository<GoodRef, Guid> GoodRefs
        {
            get
            {
                return _goodRefs ?? (_goodRefs = _dependencyResolver.GetService<IRepository<GoodRef, Guid>>());
            }
            
        }
        private IRepository<Loss, Guid> _losses;
        public IRepository<Loss, Guid> Losses
        {
            get
            {
                return _losses ?? (_losses = _dependencyResolver.GetService<IRepository<Loss, Guid>>());
            }
            
        }
        private IRepository<MyCompany, Guid> _myCompanies;
        public IRepository<MyCompany, Guid> MyCompanies
        {
            get
            {
                return _myCompanies ?? (_myCompanies = _dependencyResolver.GetService<IRepository<MyCompany, Guid>>());
            }
           
        }
        private IRepository<PurchaseOrderPosition, Guid> _purchaseOrderPositions;
        public IRepository<PurchaseOrderPosition, Guid> PurchaseOrderPositions
        {
            get
            {
                return _purchaseOrderPositions ?? (_purchaseOrderPositions = _dependencyResolver.GetService<IRepository<PurchaseOrderPosition, Guid>>());
            }
           
        }
        private IRepository<PaymentIn, Guid> _paymentIns;
        public IRepository<PaymentIn, Guid> PaymentIns
        {
            get
            {
                return _paymentIns ?? (_paymentIns = _dependencyResolver.GetService<IRepository<PaymentIn, Guid>>());
            }
            
        }
        private IRepository<PurchaseOrder, Guid> _purchaseOrders;
        public IRepository<PurchaseOrder, Guid> PurchaseOrders
        {
            get
            {
                return _purchaseOrders ?? (_purchaseOrders = _dependencyResolver.GetService<IRepository<PurchaseOrder, Guid>>());
            }
            
        }
        private IRepository<RetailDemand, Guid> _retailDemands;
        public IRepository<RetailDemand, Guid> RetailDemands
        {
            get
            {
                return _retailDemands ?? (_retailDemands = _dependencyResolver.GetService<IRepository<RetailDemand, Guid>>());
            }
            
        }
        private IRepository<RetailStore, Guid> _retailStores;
        public IRepository<RetailStore, Guid> RetailStores
        {
            get
            {
                return _retailStores ?? (_retailStores = _dependencyResolver.GetService<IRepository<RetailStore, Guid>>());
            }
            
        }
        private IRepository<CustomerOrderPosition, Guid> _customerOrderPositions;
        public IRepository<CustomerOrderPosition, Guid> CustomerOrderPositions
        {
            get
            {
                return _customerOrderPositions ?? (_customerOrderPositions = _dependencyResolver.GetService<IRepository<CustomerOrderPosition, Guid>>());
            }
            
        }
        private IRepository<Supply, Guid> _supplies;
        public IRepository<Supply, Guid> Supplies
        {
            get
            {
                return _supplies ?? (_supplies = _dependencyResolver.GetService<IRepository<Supply, Guid>>());
            }
            
        }
        private IRepository<Warehouse, Guid> _warehouses;
        public IRepository<Warehouse, Guid> Warehouses
        {
            get
            {
                return _warehouses ?? (_warehouses = _dependencyResolver.GetService<IRepository<Warehouse, Guid>>());
            }
            
        }

        private IRepository<StockTO, Guid> _stockTOs;

        public IRepository<StockTO, Guid> StockTOs
        {
            get
            {
                return _stockTOs ?? (_stockTOs = _dependencyResolver.GetService<IRepository<StockTO, Guid>>());
            }
        }
    }
}