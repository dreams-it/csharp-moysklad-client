using DreamsIT.MoySklad.RestClient.Models;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IStockClient
    {
        List<StockTO> StockBalance(StockMode stockMode = StockMode.AllStock, string moment = "",
            Guid? goodUuid = null, string goodName = "", Guid? storeId = null, 
            bool includeAboardOperations = false, bool showConsignments = false);
    }
}
