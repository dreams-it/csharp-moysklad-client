using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using DreamsIT.MoySklad.RestClient.Implementation.EnvitomentMethods;
using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Concrets
{
    public class PriceTypeClient:IPriceTypeClient
    {
        public PriceTypeClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<PriceTypeCollection>(login, password, host);
        }
        private RequestGenerator<PriceTypeCollection> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/PriceType";

        public ResultOrError<List<PriceType>> GetPriceTypes()
        {
            var result = requestGenerator.getItemsFromAPI();

            return new ResultOrError<List<PriceType>>() { Error = result.Error, Result = result.Result.PriceTypes, Success = result.Success };
        }
    }
}
