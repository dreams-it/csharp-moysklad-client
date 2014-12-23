using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DreamsIT.MoySklad.RestClient.Implementation.EnvitomentMethods
{
    public class RequestGenerator<T>
    {
        public RequestGenerator(string login, string password, string host)
        {
            _login = login;
            _password = password;
            _host = host;
        }


        private string _login = "";
        private string _password = "";
        private string _host = "";

        public ResultOrError<List<T>> getItemsFromAPI(string filterParams)
        {
            string encodedParams = HttpUtility.UrlEncode(filterParams);
            string address = string.Format("{0}/list?filter={1}", _host, encodedParams);

            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential(_login, _password);
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

            DataContractSerializer serializer = new DataContractSerializer(typeof(List<T>));

            var ms = new MemoryStream(data);

            var result = serializer.ReadObject(ms) as List<T>;

            return new ResultOrError<List<T>>() { Error = error, Result = result, Success = result != null && string.IsNullOrWhiteSpace(error) };
        }
    }
}
