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
        /// ALL_STOCK
        /// </summary>
        AllStock,
        /// <summary>
        /// POSITIVE_ONLY
        /// </summary>
        PositiveOnly,
        /// <summary>
        /// POSITIVE_INCLUDING_RESERVE_ONLY
        /// </summary>
        PositiveOnlyIncludingReserveOnly,
        /// <summary>
        /// NEGATIVE_ONLY
        /// </summary>
        NegativeOnly,
        /// <summary>
        /// NON_EMPTY
        /// </summary>
        NonEmpty,
        /// <summary>
        /// UNDER_MINIMUM_BALANCE_ONLY
        /// </summary>
        UnderMinimymBalanceOnly,
        /// <summary>
        /// USE_RESERVES
        /// </summary>
        UseReserves
    }
}
