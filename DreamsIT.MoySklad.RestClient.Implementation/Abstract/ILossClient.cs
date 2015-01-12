using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface ILossClient
    {
        /// <summary>
        /// Метод получения документов из API с помощью идентификатора инвентаризации
        /// </summary>
        /// <param name="inentoryIds"></param>
        /// <returns>Возвращает список объектов, с идентификатором инвентаризации полученный из API</returns>
        ResultOrError<List<Loss>> SearchByInventoryId(List<Guid> inentoryIds);

        ResultOrError<List<Loss>> SearchByParameters(List<Guid> inentoryIds = null, List<Guid> ids = null, List<string> updateds = null, 
            List<string> names = null, List<Guid> customerOrderIds = null, List<double> createds = null, 
            List<string> createdBies = null, List<string> years = null, List<string> months = null, List<string> days = null);
    }
}
