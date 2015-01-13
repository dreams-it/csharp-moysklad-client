using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Concrets
{
    public class GoodClient:IGoodClient
    {
        public GoodClient(string login, string password)
        {

        }

        public Models.ResultOrError<List<Models.Good>> SearchGoodsByName(List<string> names)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Good>> SearchGoodsById(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Good>> SearchNewGoods(string updated)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Good>> SearchOldGoods(string updated)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Good>> SearchGoodsByParams(List<string> names, List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Good>> SearchDeletedGoods(string deleted)
        {
            throw new NotImplementedException();
        }
    }
}
