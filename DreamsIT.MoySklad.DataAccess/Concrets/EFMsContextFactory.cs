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

        private IRepository<BankAccount, int> _bankAccounts;

        public IRepository<BankAccount, int> BankAccounts
        {
            get { return _bankAccounts ?? (_bankAccounts = _dependencyResolver.GetService<IRepository<BankAccount, int>>()); }
        }

        private IRepository<Demand, int> _demand;

        public IRepository<Demand, int> Demand
        {
            get { return _demand ?? (_demand = _dependencyResolver.GetService<IRepository<Demand, int>>()); }
        }
        private IRepository<CashOut, int> _cashOut;

        public IRepository<CashOut, int> CashOut
        {
            get { return _cashOut ?? (_cashOut = _dependencyResolver.GetService<IRepository<CashOut, int>>()); }
        }
        private IRepository<Company, int> _company;

        public IRepository<Company, int> Company
        {
            get { return _company ?? (_company = _dependencyResolver.GetService<IRepository<Company, int>>()); }
        }
        private IRepository<GoodFolder, int> _goodFolder;

        public IRepository<GoodFolder, int> GoodFolder
        {
            get { return _goodFolder ?? (_goodFolder = _dependencyResolver.GetService<IRepository<GoodFolder, int>>()); }
        }
        private IRepository<Good, int> _good;

        public IRepository<Good, int> Good
        {
            get { return _good ?? (_good = _dependencyResolver.GetService<IRepository<Good, int>>()); }
        }
        private IRepository<Contact, int> _contact;

        public IRepository<Contact, int> Contact
        {
            get { return _contact ?? (_contact = _dependencyResolver.GetService<IRepository<Contact, int>>()); }
        }
        private IRepository<CustomerOrder, int> _customerOrder;

        public IRepository<CustomerOrder, int> CustomerOrder
        {
            get { return _customerOrder ?? (_customerOrder = _dependencyResolver.GetService<IRepository<CustomerOrder, int>>()); }
        }
        private IRepository<Employee, int> _employee;

        public IRepository<Employee, int> Employee
        {
            get { return _employee ?? (_employee = _dependencyResolver.GetService<IRepository<Employee, int>>()); }
        }
        private IRepository<Enter, int> _enter;

        public IRepository<Enter, int> Enter
        {
            get { return _enter ?? (_enter = _dependencyResolver.GetService<IRepository<Enter, int>>()); }
        }
        private IRepository<EnterPosition, int> _enterPosition;

        public IRepository<EnterPosition, int> EnterPosition
        {
            get { return _enterPosition ?? (_enterPosition = _dependencyResolver.GetService<IRepository<EnterPosition, int>>()); }
        }
        private IRepository<GoodRef, int> _goodRef;

        public IRepository<GoodRef, int> GoodRef
        {
            get { return _goodRef ?? (_goodRef = _dependencyResolver.GetService<IRepository<GoodRef, int>>()); }
        }
        private IRepository<Loss, int> _loss;

        public IRepository<Loss, int> Loss
        {
            get { return _loss ?? (_loss = _dependencyResolver.GetService<IRepository<Loss, int>>()); }
        }
        private IRepository<MyCompany, int> _myCompany;

        public IRepository<MyCompany, int> MyCompany
        {
            get { return _myCompany ?? (_myCompany = _dependencyResolver.GetService<IRepository<MyCompany, int>>()); }
        }
        private IRepository<PurchaseOrderPosition, int> _purchaseOrderPosition;

        public IRepository<PurchaseOrderPosition, int> PurchaseOrderPosition
        {
            get { return _purchaseOrderPosition ?? (_purchaseOrderPosition = _dependencyResolver.GetService<IRepository<PurchaseOrderPosition, int>>()); }
        }
        private IRepository<PaymentIn, int> _paymentIn;

        public IRepository<PaymentIn, int> PaymentIn
        {
            get { return _paymentIn ?? (_paymentIn = _dependencyResolver.GetService<IRepository<PaymentIn, int>>()); }
        }
        private IRepository<PaymentOut, int> _paymentOut;

        public IRepository<PaymentOut, int> PaymentOut
        {
            get { return _paymentOut ?? (_paymentOut = _dependencyResolver.GetService<IRepository<PaymentOut, int>>()); }
        }
        private IRepository<PurchaseOrder, int> _purchaseOrder;

        public IRepository<PurchaseOrder, int> PurchaseOrder
        {
            get { return _purchaseOrder ?? (_purchaseOrder = _dependencyResolver.GetService<IRepository<PurchaseOrder, int>>()); }
        }
        private IRepository<Requisite, int> _requisite;

        public IRepository<Requisite, int> Requisite
        {
            get { return _requisite ?? (_requisite = _dependencyResolver.GetService<IRepository<Requisite, int>>()); }
        }
        private IRepository<RetailDemand, int> _retailDemand;

        public IRepository<RetailDemand, int> RetailDemand
        {
            get { return _retailDemand ?? (_retailDemand = _dependencyResolver.GetService<IRepository<RetailDemand, int>>()); }
        }
        private IRepository<RetailStore, int> _etailStore;

        public IRepository<RetailStore, int> RetailStore
        {
            get { return _etailStore ?? (_etailStore = _dependencyResolver.GetService<IRepository<RetailStore, int>>()); }
        }
        private IRepository<ShipmentOut, int> _shipmentOut;

        public IRepository<ShipmentOut, int> ShipmentOut
        {
            get { return _shipmentOut ?? (_shipmentOut = _dependencyResolver.GetService<IRepository<ShipmentOut, int>>()); }
        }
        private IRepository<StockTO, int> _stockTO;

        public IRepository<StockTO, int> StockTO
        {
            get { return _stockTO ?? (_stockTO = _dependencyResolver.GetService<IRepository<StockTO, int>>()); }
        }
        private IRepository<CustomerOrderPosition, int> _customerOrderPosition;

        public IRepository<CustomerOrderPosition, int> CustomerOrderPosition
        {
            get { return _customerOrderPosition ?? (_customerOrderPosition = _dependencyResolver.GetService<IRepository<CustomerOrderPosition, int>>()); }
        }
        private IRepository<Sum, int> _sum;

        public IRepository<Sum, int> Sum
        {
            get { return _sum ?? (_sum = _dependencyResolver.GetService<IRepository<Sum, int>>()); }
        }
        private IRepository<Supply, int> _supply;

        public IRepository<Supply, int> Supply
        {
            get { return _supply ?? (_supply = _dependencyResolver.GetService<IRepository<Supply, int>>()); }
        }
        private IRepository<Warehouse, int> _warehouse;

        public IRepository<Warehouse, int> Warehouse
        {
            get { return _warehouse ?? (_warehouse = _dependencyResolver.GetService<IRepository<Warehouse, int>>()); }
        }

    }
}
