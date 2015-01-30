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
    public class BarcodeClient:IBarcodeClient
    {
        public BarcodeClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<BarcodeCollection>(login, password, host);
        }

        private RequestGenerator<BarcodeCollection> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/Barcode";

        public Models.ResultOrError<List<Barcode>> GetBarcodes()
        {
            var requestResult = requestGenerator.getItemsFromAPI();

            return new Models.ResultOrError<List<Barcode>>() { Error = requestResult.Error, Success = requestResult.Success, Result = requestResult.Result.Barcodes };
        }
    }
}
