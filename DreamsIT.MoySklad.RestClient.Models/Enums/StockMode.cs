using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models.Enums
{
    public enum StockMode
    {
        /// <summary>
        /// все товары
        /// </summary>
        ALL_STOCK,
        /// <summary>
        /// только положительные остатки
        /// </summary>
        POSITIVE_ONLY,
        /// <summary>
        /// только положительные остатки, с учетом резерва
        /// </summary>
        POSITIVE_INCLUDING_RESERVE_ONLY,
        /// <summary>
        /// только отрицательные значения
        /// </summary>
        NEGATIVE_ONLY,
        /// <summary>
        /// отрицательные и положительные значения
        /// </summary>
        NON_EMPTY,
        /// <summary>
        /// ниже неснижаемого остатка
        /// </summary>
        UNDER_MINIMUM_BALANCE_ONLY,
        /// <summary>
        /// с учетом резерва
        /// </summary>
        USE_RESERVES
    }
}
