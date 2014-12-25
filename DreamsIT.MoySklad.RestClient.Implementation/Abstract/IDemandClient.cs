using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{

    public interface IDemandClient
    {
        /// <summary>
        /// Метод получения документов из API с помощью идентификатора заказа
        /// </summary>
        /// <param name="customerOrderIds">идентификаторы заказов</param>
        /// <returns>Возвращает список объектов, с идентификатором заказа полученный из API</returns>
        ResultOrError<List<Demand>> SearchByCustomerOrder(List<Guid> customerOrderIds);

        ResultOrError<List<Demand>> SearchByParameters(List<Guid> uuids = null, List<string> updated = null, List<string> names = null,
            List<Guid> customerOrderIds = null, List<double> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null,
            List<string> days = null);
    }
}
