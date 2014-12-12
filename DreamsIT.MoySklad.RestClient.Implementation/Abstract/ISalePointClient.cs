using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    /// <summary>
    /// Интерфейс клиента получения точек продажу 
    /// </summary>
    class ISalePointClient
    {
        /// <summary>
        /// Метод получения точек продажу через API
        /// </summary>
        /// <returns>Возвращает список точек продажу, полученные из API за указанными параметрами</returns>
        List<RetailStore> GetSalePoints();
        
    }
}
