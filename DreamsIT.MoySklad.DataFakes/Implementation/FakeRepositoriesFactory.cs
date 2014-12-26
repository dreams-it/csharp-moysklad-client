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

        public IRepository<Price, Guid> Prices
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Demand, Guid> Demands
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.CashOut, Guid> CashOuts
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Company, Guid> Companies
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.GoodFolder, Guid> GoodFolders
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Good, Guid> Goods
        {
            get { throw new NotImplementedException(); }
        }


        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.CustomerOrder, Guid> CustomerOrders
        {
            get { throw new NotImplementedException(); }
        }


        private List<Employee> _employeeses = new List<Employee>(){
            new Employee(){
                Id=Guid.Parse("0c7f4b7e-456d-11e4-90a2-8eca0022bfab"), 
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                ChangeMode=ChangeMode.All, 
                Description="", 
                Email="061412@gmail.com", 
                ExternalCode="hsSOfC1diM62IbD4UUjn13", 
                FirstName="Станислав", 
                LastName="Медков", 
                MiddleName="Сергеевич", 
                Name="Медков С. С.", 
                Phone="8-911-702-23-91", 
                ReadMode=ReadMode.ALL, 
                Uid="stas@ооо нарджилия",
                Updated="2014-09-26T15:05:39.138+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("0c7f4b7e-456d-11e4-90a2-8eca0022bfab")
            },
            new Employee(){
                Id=Guid.Parse("1f5ac880-7f94-11e4-90a2-8ecb00259772"), 
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                ChangeMode=ChangeMode.All, 
                Description="", 
                Email="", 
                ExternalCode="NVugPUPQi-qrSODD75afj1", 
                FirstName="Вадим и Артем", 
                LastName="The LOFT СПБ", 
                MiddleName="", 
                Name="The LOFT СПБ В.", 
                Phone="", 
                ReadMode=ReadMode.ALL, 
                Uid="loft-spb@ооо нарджилия",
                Updated="2014-12-09T14:11:26.405+03:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("1f5ac880-7f94-11e4-90a2-8ecb00259772")
            },
            new Employee(){
                Id=Guid.Parse("be01fb87-1326-11e4-c801-002590a28eca"), 
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                ChangeMode=ChangeMode.All, 
                Description="Кладовщик-продавец", 
                Email="", 
                ExternalCode="BcxvDPR0iqiGFBKftqKqF0", 
                FirstName="Кирилл", 
                LastName="Федорищев", 
                MiddleName="Максимович", 
                Name="Федорищев К. М.", 
                Phone="8-981-839-34-88", 
                ReadMode=ReadMode.ALL, 
                Uid="klad.prod.@ооо нарджилия",
                Updated="2014-09-19T15:39:15.628+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("be01fb87-1326-11e4-c801-002590a28eca")
            }
        };

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Employee, Guid> Employees
        {
            get { return constructRepo("Employees", () => new BaseFakeRepository<Employee, Guid>(_employeeses)) as IRepository<Employee, Guid>; }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Enter, Guid> Enters
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.EnterPosition, Guid> EnterPositions
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.GoodRef, Guid> GoodRefs
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Loss, Guid> Losses
        {
            get { throw new NotImplementedException(); }
        }

        private List<MyCompany> _myCompanies = new List<MyCompany>()
        {
            new MyCompany()
            {
                Id=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"),
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                AutoDiscount=0.0, 
                ChangeMode=RestClient.Models.Enums.ChangeMode.SELF, 
                ReadMode=RestClient.Models.Enums.ReadMode.ALL, 
                ChiefAccountant="Медков С.С.", 
                Code="1", 
                CompanyType=RestClient.Models.Enums.CompanyType.Urli,
                Contact=new Contact(){Address="", Email="061412@gmail.com", Faxes="", Mobiles="", Phones=""}, 
                Created="2010-09-27T02:30:22.529+04:00", 
                Description="", 
                Director="Медков С.С.", 
                Discount=0.0, 
                DiscountCorrection=0.0, 
                ExternalCode="1", 
                Name="ооо нарджилия", 
                Requisite=new Requisite(){ActualAddress="190031, Спасский пер. д.11\\1", Inn=7838432080, Kpp=783801001, LegalAddress="190031, Спасский пер. д.11\\1", LegalTitle="Общество с ограниченной ответственностью \"Нарджилия\"", Okpo=62993750},
                Tags=null, 
                Updated="2010-09-27T02:30:22.529+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"),
                BankAccount=new BankAccount(){AccountNumber="", BankLocation="", BankName="", Bic="", ChangeMode=RestClient.Models.Enums.ChangeMode.All, CorrectspondentAccount="", IsDefault=true, ReadMode=RestClient.Models.Enums.ReadMode.ALL, Updated="2014-05-28T00:19:29.207+04:00", UpdatedBy="admin@ооо нарджилия"}
            }
        };
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.MyCompany, Guid> MyCompanies
        {
            get { return constructRepo("MyCompanies", () => new BaseFakeRepository<MyCompany, Guid>(_myCompanies)) as IRepository<MyCompany, Guid>; }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PurchaseOrderPosition, Guid> PurchaseOrderPositions
        {
            get { throw new NotImplementedException(); }
        }

        private List<PaymentIn> _paymentIns = new List<PaymentIn>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PaymentIn, Guid> PaymentIns
        {
            get { return constructRepo("PaymentIns", () => new BaseFakeRepository<PaymentIn, Guid>(_paymentIns)) as IRepository<PaymentIn, Guid>; }
        }

        private List<PaymentOut> _paymentOuts = new List<PaymentOut>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PaymentOut, Guid> PaymentOuts
        {
            get { return constructRepo("PaymentOuts", () => new BaseFakeRepository<PaymentOut, Guid>(_paymentOuts)) as IRepository<PaymentOut, Guid>; }
        }

        private List<PurchaseOrder> _purshseOrders = new List<PurchaseOrder>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PurchaseOrder, Guid> PurchaseOrders
        {
            get { return constructRepo("PurchaseOrders", () => new BaseFakeRepository<PurchaseOrder, Guid>(_purshseOrders)) as IRepository<PurchaseOrder, Guid>; }
        }
        
        private List<RetailDemand> _retailDemands = new List<RetailDemand>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.RetailDemand, Guid> RetailDemands
        {
            get { return constructRepo("RetailDemands", () => new BaseFakeRepository<RetailDemand, Guid>(_retailDemands)) as IRepository<RetailDemand, Guid>; }
        }

        private List<RetailStore> _retailStore = new List<RetailStore>(){
            new RetailStore()
            {
                Id=Guid.Parse("4870a47a-7f94-11e4-90a2-8ecb0025a5ab"),
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
                Id=Guid.Parse("afb8aace-1328-11e4-03e3-002590a28eca"),
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
                Id=Guid.Parse("d755aa8f-43c5-11e4-90a2-8eca002101ad"),
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
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.RetailStore, Guid> RetailStores
        {
            get { return constructRepo("RetailStores", () => new BaseFakeRepository<RetailStore, Guid>(_retailStore)) as IRepository<RetailStore, Guid>; }
        }

        private List<StockTO> _stockTOs = new List<StockTO>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.StockTO, Guid> StockTOs
        {
            get { return constructRepo("StockTOs", () => new BaseFakeRepository<StockTO, Guid>(_stockTOs)) as IRepository<StockTO, Guid>; }
        }

        private List<CustomerOrderPosition> _customerOrderPositions = new List<CustomerOrderPosition>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.CustomerOrderPosition, Guid> CustomerOrderPositions
        {
            get { return constructRepo("CustomerOrderPositions", () => new BaseFakeRepository<CustomerOrderPosition, Guid>(_customerOrderPositions)) as IRepository<CustomerOrderPosition, Guid>; }
        }

        private List<Supply> _supplies = new List<Supply>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Supply, Guid> Supplies
        {
            get { return constructRepo("Supplies", () => new BaseFakeRepository<Supply, Guid>(_supplies)) as IRepository<Supply, Guid>; }
        }

        private List<Warehouse> _warehouses = new List<Warehouse>()
            {
                new Warehouse()
                {
                    Id=Guid.Parse("570c7c96-7f91-11e4-90a2-8ecb0024f582"),
                    AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AgentUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                    Archived=false, 
                    ChangeMode=ChangeMode.SELF, 
                    Code="", 
                    Contact=new Contact(){ Phones="", Mobiles="", Faxes="", Email="", Address=""}, 
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
                    Id=Guid.Parse("79e2fd2c-4314-11e4-90a2-8eca000d33f3"),
                    AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AgentUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                    Archived=false, 
                    ChangeMode=ChangeMode.SELF, 
                    Code="", 
                    Contact=new Contact(){ Phones="", Mobiles="", Faxes="", Email="", Address=""}, 
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
                    Id=Guid.Parse("8036ce31-baed-48ff-b365-fcb86ad87fd8"),
                    AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AgentUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                    Archived=false, 
                    ChangeMode=ChangeMode.SELF, 
                    Code="1", 
                    Contact=new Contact(){ Phones="", Mobiles="", Faxes="", Email="", Address="Спб, Рубинштейна 30, лит. А"}, 
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
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Warehouse, Guid> Warehouses
        {
            get { return constructRepo("Warehouses", () => new BaseFakeRepository<Warehouse, Guid>(_warehouses)) as IRepository<Warehouse, Guid>; }
        }

        public IRepository<ShipmentIn, Guid> ShipmentIns
        {
            get { throw new NotImplementedException(); }
        }
    }
}