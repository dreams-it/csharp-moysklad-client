using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IGoodFolderClient
    {
        ResultOrError<List<GoodFolder>> SearchGoodFoldersById(List<Guid> ids);

        ResultOrError<List<GoodFolder>> SearchGoodFoldersByName(List<string> names);

        /// <summary>
        /// Поиск категорий продуктов, дата обновления которых больше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<GoodFolder>> SearchNewGoodFolders(string updated);

        /// <summary>
        /// Поиск категорий продуктов, дата удаления которых больше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<GoodFolder>> SearchDeletedGoodFolders(string deleted);

        /// <summary>
        /// Поиск категорий продуктов, дата обновления которых меньше указанной
        /// </summary>
        /// <param name="updated"></param>
        /// <returns></returns>
        ResultOrError<List<GoodFolder>> SearchOldGoodFolders(string updated);

        ResultOrError<List<GoodFolder>> SearchGoodFoldersByParams(List<string> names = null, List<Guid> ids = null);
    }
}
