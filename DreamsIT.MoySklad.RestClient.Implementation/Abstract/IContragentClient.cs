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
        List<Company> GetContragent(List<Guid> ids = null, double startDateUpdate = 0, double endDateUpdate = 0, List<string> names = null);
    }
}
