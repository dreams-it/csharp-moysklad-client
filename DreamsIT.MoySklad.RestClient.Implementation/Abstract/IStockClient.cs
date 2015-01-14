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
        /// <summary>
        /// Метод получения остатков на складе через API
        /// </summary>
        /// <param name="stockMode"> - режим выбора остатков</param>
        /// <param name="moment"> - дата на которую необходимо получить остатки</param>
        /// <param name="goodUuid"> - идентификатор товара или папки товаров, по которым необходимо получить остатки</param>
        /// <param name="goodName"> - Название товара</param>
        /// <param name="storeId"> - Идентификатор склада</param>
        /// <param name="includeAboardOperations"> - нужно ли подсчитывать остатки по не проведенных документах</param>
        /// <param name="showConsignments"> - группировать результаты по сериям</param>
        /// <returns>Возвращает остатки на складе, полученные из API за указанными параметрами</returns>
       ResultOrError<List<StockTO>> StockBalance(StockMode stockMode = StockMode.ALL_STOCK, string moment = "",
            Guid? goodUuid = null, string goodName = "", Guid? storeId = null, 
            bool includeAboardOperations = false, bool showConsignments = false);
    }
}
