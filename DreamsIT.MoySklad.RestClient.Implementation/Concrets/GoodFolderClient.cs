using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Concrets
{
    public class GoodFolderClient:IGoodFolderClient
    {
        public GoodFolderClient(string login, string password)
        {

        }


        public Models.ResultOrError<List<Models.GoodFolder>> SearchGoodFoldersById(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.GoodFolder>> SearchGoodFoldersByName(List<string> names)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.GoodFolder>> SearchNewGoodFolders( DateTime updated)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.GoodFolder>> SearchDeletedGoodFolders( DateTime deleted)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.GoodFolder>> SearchOldGoodFolders( DateTime updated)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.GoodFolder>> SearchGoodFoldersByParams(List<string> names = null, List<Guid> ids = null)
        {
            throw new NotImplementedException();
        }
    }
}
