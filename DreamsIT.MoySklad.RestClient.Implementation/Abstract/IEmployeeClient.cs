using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IEmployeeClient
    {
        ResultOrError<List<Employee>> SearchEmployeesByName(List<string> names);

        ResultOrError<List<Employee>> SearchEmployeeById(List<Guid> ids);

        /// <summary>
        /// Поиск сотрудников, у которых дата обновления записи больше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<Employee>> SearchNewEmployees(DateTime updated);

        /// <summary>
        /// Поиск сотрудников, у которых дата удаления записи о них больше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<Employee>> SearchDeletedEmployees(DateTime deleted);

        /// <summary>
        /// Поиск сотрудников, у которых дата записи обновления меньше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<Employee>> SearchOldEmployees(DateTime updated);

        /// <summary>
        /// Поиск сотрудников по указанным параметрам
        /// </summary>
        /// <param name="names"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        ResultOrError<List<Employee>> SearchEmployeesByParams(List<string> names = null, List<Guid> ids = null);
    }
}
