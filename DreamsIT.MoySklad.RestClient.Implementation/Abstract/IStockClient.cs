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
        List<Product> StockBalance(StockMode stockMode = StockMode.ALL_STOCK, string moment = "",
Guid goodUuid = Guid.Empty, string goodName = "", Guid storeId = Guid.Empty, bool includeAboardOperations = false, bool showConsignments = false);

    }
}
