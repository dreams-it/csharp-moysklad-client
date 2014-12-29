using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IGoodClient
    {
        ResultOrError<List<Good>> SearchGoodsByName(List<string> names);

        ResultOrError<List<Good>> SearchGoodsById(List<Guid> ids);

        /// <summary>
        /// Поиск продуктов, дата обновления которых больше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<Good>> SearchNewGoods(string updated);

        /// <summary>
        /// Поиск продуктов, дата удаления которых больше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<Good>> SearchDeletedGoods(string deleted);

        /// <summary>
        /// Поиск продуктов, дата обновления которых меньше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<Good>> SearchOldGoods(string updated);

        ResultOrError<List<Good>> SearchGoodsByParams(List<string> names=null, List<Guid> ids=null);
    }
}