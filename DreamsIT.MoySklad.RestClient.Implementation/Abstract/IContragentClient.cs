using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    /// <summary>
    /// Интерфейс методом доступа к контрагентам
    /// </summary>
    public interface IContragentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="startDateUpdate"></param>
        /// <param name="endDateUpdate"></param>
        /// <param name="names"></param>
        /// <returns></returns>
        ResultOrError<List<Company>> GetContragent(List<Guid> ids = null, List<string> names = null);

        ResultOrError<List<Company>> GetNewContragent(string updated);

        ResultOrError<List<Company>> GetDeletedContragent(string deleted);

        ResultOrError<List<Company>> GetOldContragent(string updated);
    }
}
