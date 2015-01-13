using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IEnterClient
    {
        ResultOrError<List<Enter>> SearchNewEnter(string updated);

        ResultOrError<List<Enter>> SearchDeletedEnter(string deleted);
        /// <summary>
        /// Метод получения документов из API с помощью идентификатора инвентаризации
        /// </summary>
        /// <param name="internalOrderId"></param>
        /// <returns> Возвращает список объектов, с идентификатором инвентаризации полученный из API</returns>
        ResultOrError<List<Enter>> SearchByInternalOrder(List<Guid> internalOrderId);

       ResultOrError<List<Enter>> SearchByParameters(List<Guid> internalOrderIds = null, List<Guid> ids = null, List<string> updateds = null, List<string> names = null,
List<Guid> customerOrderIds = null, List<double> createds = null, List<string> createdBies = null, List<string> years = null, List<string> months = null,
List<string> days = null);
    }
}
