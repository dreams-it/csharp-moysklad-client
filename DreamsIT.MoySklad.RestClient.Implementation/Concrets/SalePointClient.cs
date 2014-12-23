using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using DreamsIT.MoySklad.RestClient.Implementation.EnvitomentMethods;
using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Concrets
{
    public class SalePointClient : ISalePointClient
    {
        public SalePointClient(string login, string password)
        {
            _login = login;
            _password = password;
        }
        private string _login { get; set; }
        private string _password { get; set; }
        private string login = "";
        private string password = "";
        private string host = "https://online.moysklad.ru/exchange/rest";
        //{базовый адрес}/ms/xml/RetailStore/list
        public ResultOrError<List<RetailStore>> GetSalePoints()
        {
            string address = string.Format("{0}/ms/xml/RetailStore/list", host);
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential(login, password);
            client.Headers.Add(HttpRequestHeader.ContentType, "application/xml");
            string error = "";
            byte[] data = null;
            try
            {
                data = client.DownloadData(address);
            }
            catch (Exception exc)
            {
                error = exc.Message;
            }
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<RetailStore>));

            var ms = new MemoryStream(data);

            var result = serializer.ReadObject(ms) as List<RetailStore>;

            return new ResultOrError<List<RetailStore>>() { Result = result, Error = error, Success = result != null && string.IsNullOrWhiteSpace(error) };
        }
    }
}
