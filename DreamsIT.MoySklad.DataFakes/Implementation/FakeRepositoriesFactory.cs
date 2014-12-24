using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.DataAccess.Abstracts;
using DreamsIT.MoySklad.RestClient.Models;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace DreamsIT.MoySklad.DataFakes.Implementation
{
    public class FakeRepositoriesFactory : IMsContextFactory
    {
        private Cache _cache;

        public FakeRepositoriesFactory(HttpContext context)
        {
            _cache = context.Cache;
        }

        private object constructRepo(string name, Func<object> method)
        {
            var repo = _cache[name];
            if (repo == null)
            {
                repo = method();
                _cache.Insert(name, repo, null, Cache.NoAbsoluteExpiration, new TimeSpan(1, 1, 1, 1));
            }
            return repo;
        }

        private List<Price> _prices = new List<Price>();

        public IRepository<Price, int> Prices
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.BankAccount, int> BankAccounts
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Demand, int> Demands
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.CashOut, int> CashOuts
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Company, int> Companies
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.GoodFolder, int> GoodFolders
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Good, int> Goods
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Contact, int> Contacts
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.CustomerOrder, int> CustomerOrders
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Employee, int> Employees
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Enter, int> Enters
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.EnterPosition, int> EnterPositions
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.GoodRef, int> GoodRefs
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Loss, int> Losses
        {
            get { throw new NotImplementedException(); }
        }

        private List<MyCompany> _myCompanies = new List<MyCompany>()
        {
            new MyCompany()
            {
                Id=1, 
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                AutoDiscount=0.0, 
                ChangeMode=RestClient.Models.Enums.ChangeMode.SELF, 
                ReadMode=RestClient.Models.Enums.ReadMode.ALL, 
                ChiefAccountant="Медков С.С.", 
                Code="1", 
                CompanyType=RestClient.Models.Enums.CompanyType.Urli,
                Contact=new Contact(){Address="", Email="061412@gmail.com", Faxes="", Id=1, Mobiles="", Phones=""}, 
                Created="2010-09-27T02:30:22.529+04:00", 
                Description="", 
                Director="Медков С.С.", 
                Discount=0.0, 
                DiscountCorrection=0.0, 
                ExternalCode="1", 
                Name="ооо нарджилия", 
                Requisite=new Requisite(){Id=1, ActualAddress="190031, Спасский пер. д.11\\1", Inn=7838432080, Kpp=783801001, LegalAddress="190031, Спасский пер. д.11\\1", LegalTitle="Общество с ограниченной ответственностью \"Нарджилия\"", Okpo=62993750},
                Tags=null, 
                Updated="2010-09-27T02:30:22.529+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"),
                BankAccount=new BankAccount(){AccountNumber="", BankLocation="", BankName="", Bic="", ChangeMode=RestClient.Models.Enums.ChangeMode.All, CorrectspondentAccount="", Id=1, IsDefault=true, ReadMode=RestClient.Models.Enums.ReadMode.ALL, Updated="2014-05-28T00:19:29.207+04:00", UpdatedBy="admin@ооо нарджилия"}
            }
        };
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.MyCompany, int> MyCompanies
        {
            get { return constructRepo("MyCompanies", () => new BaseFakeRepository<MyCompany, int>(_myCompanies)) as IRepository<MyCompany, int>; }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PurchaseOrderPosition, int> PurchaseOrderPositions
        {
            get { throw new NotImplementedException(); }
        }

        private List<PaymentIn> _paymentIns = new List<PaymentIn>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PaymentIn, int> PaymentIns
        {
            get { return constructRepo("PaymentIns", () => new BaseFakeRepository<PaymentIn, int>(_paymentIns)) as IRepository<PaymentIn, int>; }
        }

        private List<PaymentOut> _paymentOuts = new List<PaymentOut>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PaymentOut, int> PaymentOuts
        {
            get { return constructRepo("PaymentOuts", () => new BaseFakeRepository<PaymentOut, int>(_paymentOuts)) as IRepository<PaymentOut, int>; }
        }

        private List<PurchaseOrder> _purshseOrders = new List<PurchaseOrder>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PurchaseOrder, int> PurchaseOrders
        {
            get { return constructRepo("PurchaseOrders", () => new BaseFakeRepository<PurchaseOrder, int>(_purshseOrders)) as IRepository<PurchaseOrder, int>; }
        }

        private List<Requisite> _requisites = new List<Requisite>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Requisite, int> Requisites
        {
            get { return constructRepo("Requisites", () => new BaseFakeRepository<Requisite, int>(_requisites)) as IRepository<Requisite, int>; }
        }

        private List<RetailDemand> _retailDemands = new List<RetailDemand>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.RetailDemand, int> RetailDemands
        {
            get { return constructRepo("RetailDemands", () => new BaseFakeRepository<RetailDemand, int>(_retailDemands)) as IRepository<RetailDemand, int>; }
        }

        private List<RetailStore> _retailStore = new List<RetailStore>(){
            new RetailStore()
            { 
                Id=1, 
                accountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                accountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Active=true, 
                address="", 
                ChangeMode=RestClient.Models.Enums.ChangeMode.SELF, 
                description="", 
                Externalcode="ETcWX1ASilKcdq-WNhvyj2", 
                myCompanyUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                name="The LOFT СПБ", 
                priceTypeUuid=Guid.Parse("5d441fe3-a9b0-4a52-b1f0-6d256f1d8a7e"), 
                ReadMode=RestClient.Models.Enums.ReadMode.SELF, 
                Updated="2014-12-09T14:12:35.335+03:00", 
                updatedBy="admin@ооо нарджилия", 
                uuid=Guid.Parse("4870a47a-7f94-11e4-90a2-8ecb0025a5ab"), 
                warehouseUuid=Guid.Parse("570c7c96-7f91-11e4-90a2-8ecb0024f582")
            },
            new RetailStore()
            {
                Id=2, 
                accountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                accountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Active=true, 
                address="Спб, Рубинштейна, д. 30, лит. А", 
                ChangeMode=RestClient.Models.Enums.ChangeMode.NONE, 
                description="", 
                Externalcode="QMMJBUAChlKbgVXCeomn-0", 
                myCompanyUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                name="THE OFFICE", 
                priceTypeUuid=Guid.Parse("5d441fe3-a9b0-4a52-b1f0-6d256f1d8a7e"), 
                ReadMode=RestClient.Models.Enums.ReadMode.NONE,
                Updated="2014-07-24T15:50:19.569+04:00", 
                updatedBy="admin@ооо нарджилия", 
                uuid=Guid.Parse("afb8aace-1328-11e4-03e3-002590a28eca"), 
                warehouseUuid=Guid.Parse("8036ce31-baed-48ff-b365-fcb86ad87fd8")
            },
            new RetailStore()
            {
                Id=3, 
                accountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                accountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Active=true, 
                address="", 
                ChangeMode=RestClient.Models.Enums.ChangeMode.SELF, 
                description="", 
                Externalcode="U3RZu-q8ibiVUoWIa2ycr0", 
                myCompanyUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                name="ОПТ", 
                priceTypeUuid=Guid.Parse("5ab3adfa-13fd-11e4-adb1-002590a28eca"), 
                ReadMode=RestClient.Models.Enums.ReadMode.SELF,
                Updated="2014-09-24T12:36:12.829+04:00", 
                updatedBy="admin@ооо нарджилия", 
                uuid=Guid.Parse("d755aa8f-43c5-11e4-90a2-8eca002101ad"), 
                warehouseUuid=Guid.Parse("8036ce31-baed-48ff-b365-fcb86ad87fd8")
            }
        };
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.RetailStore, int> RetailStores
        {
            get { return constructRepo("RetailStores", () => new BaseFakeRepository<RetailStore, int>(_retailStore)) as IRepository<RetailStore, int>; }
        }

        private List<ShipmentOut> _shipmentsOut = new List<ShipmentOut>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.ShipmentOut, int> ShipmentOuts
        {
            get { return constructRepo("ShipmentOuts", () => new BaseFakeRepository<ShipmentOut, int>(_shipmentsOut)) as IRepository<ShipmentOut, int>; }
        }

        private List<StockTO> _stockTOs = new List<StockTO>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.StockTO, int> StockTOs
        {
            get { return constructRepo("StockTOs", () => new BaseFakeRepository<StockTO, int>(_stockTOs)) as IRepository<StockTO, int>; }
        }

        private List<CustomerOrderPosition> _customerOrderPositions = new List<CustomerOrderPosition>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.CustomerOrderPosition, int> CustomerOrderPositions
        {
            get { return constructRepo("CustomerOrderPositions", () => new BaseFakeRepository<CustomerOrderPosition, int>(_customerOrderPositions)) as IRepository<CustomerOrderPosition, int>; }
        }

        private List<Sum> _sums = new List<Sum>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Sum, int> Sums
        {
            get { return constructRepo("Sums", () => new BaseFakeRepository<Sum, int>(_sums)) as IRepository<Sum, int>; }
        }

        private List<Supply> _supplies = new List<Supply>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Supply, int> Supplies
        {
            get { return constructRepo("Supplies", () => new BaseFakeRepository<Supply, int>(_supplies)) as IRepository<Supply, int>; }
        }

        private List<Warehouse> _warehouses = new List<Warehouse>()
            {
                new Warehouse()
                {
                    Id=1, 
                    AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AgentUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                    Archived=false, 
                    ChangeMode=ChangeMode.SELF, 
                    Code="", 
                    Contact=new Contact(){Id=1, Phones="", Mobiles="", Faxes="", Email="", Address=""}, 
                    Description="", 
                    ExternalCode="1QcYvIrkh76BiB2rIXYhk3", 
                    Name="The LOFT СПБ", 
                    ReadMode=ReadMode.SELF, 
                    Slots=null, 
                    Updated="2014-12-09T13:51:31.354+03:00", 
                    UpdatedBy="admin@ооо нарджилия", 
                    Uuid=Guid.Parse("570c7c96-7f91-11e4-90a2-8ecb0024f582"), 
                    ParentUuid=null
                },
                new Warehouse()
                {
                    Id=2, 
                    AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AgentUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                    Archived=false, 
                    ChangeMode=ChangeMode.SELF, 
                    Code="", 
                    Contact=new Contact(){Id=2, Phones="", Mobiles="", Faxes="", Email="", Address=""}, 
                    Description="", 
                    ExternalCode="eiIedzCSjlmhhwOnHvcJz3", 
                    Name="Владивосток Кацура", 
                    ReadMode=ReadMode.SELF, 
                    Slots=null, 
                    Updated="2014-09-23T15:26:35.128+04:00", 
                    UpdatedBy="admin@ооо нарджилия", 
                    Uuid=Guid.Parse("79e2fd2c-4314-11e4-90a2-8eca000d33f3"), 
                    ParentUuid=Guid.Parse("8036ce31-baed-48ff-b365-fcb86ad87fd8")
                },
                new Warehouse()
                {
                    Id=3, 
                    AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AgentUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                    Archived=false, 
                    ChangeMode=ChangeMode.SELF, 
                    Code="1", 
                    Contact=new Contact(){Id=3, Phones="", Mobiles="", Faxes="", Email="", Address="Спб, Рубинштейна 30, лит. А"}, 
                    Description="Склад", 
                    ExternalCode="1", 
                    Name="The Office", 
                    ReadMode=ReadMode.SELF, 
                    Slots=null, 
                    Updated="2014-07-24T15:37:58.270+04:00", 
                    UpdatedBy="admin@ооо нарджилия", 
                    Uuid=Guid.Parse("8036ce31-baed-48ff-b365-fcb86ad87fd8"), 
                    ParentUuid=null
                }
            };
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Warehouse, int> Warehouses
        {
            get { return constructRepo("Warehouses", () => new BaseFakeRepository<Warehouse, int>(_warehouses)) as IRepository<Warehouse, int>; }
        }
    }
}