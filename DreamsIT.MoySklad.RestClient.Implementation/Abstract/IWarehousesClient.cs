using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IWarehousesClient
    {
        ResultOrError<List<Warehouse>> GetWarehousesByName(List<string> names);

        ResultOrError<List<Warehouse>> SearchWarehousesById(List<Guid> ids);

        /// <summary>
        /// Поиск складов, дата обновления которых больше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<Warehouse>> SearchNewWarehouses( DateTime updated);

        /// <summary>
        /// Поиск складов, дата удаления которых больше указанной
        /// </summary>
        /// <param name="deleted"></param>
        /// <returns></returns>
        ResultOrError<List<Warehouse>> SearchDeletedWarehouses(DateTime deleted);

        /// <summary>
        /// Поиск складов, дата обновления которых меньше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<Warehouse>> SearchOldWarehouses( DateTime updated);

        ResultOrError<List<Warehouse>> SearchWarehousesByParams(List<string> names = null, List<Guid> ids = null);
    }
}
