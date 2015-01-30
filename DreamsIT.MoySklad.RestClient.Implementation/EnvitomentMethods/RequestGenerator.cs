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
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Implementation.EnvitomentMethods
{
    public class RequestGenerator<T>
        where T:class
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

        public ResultOrError<T> getItemsFromAPI(string filterParams="")
        {
            string encodedParams = HttpUtility.UrlEncode(filterParams);
            string address = string.Format("{0}/list", _host);
            if (!string.IsNullOrWhiteSpace(filterParams))
            {
                address = string.Format("{0}/list?filter={1}", _host, encodedParams);
            }

            WebClient client = new WebClient();

            var authHeader = HeaderConverter.GetAuthHeaders(_login, _password);
            client.Headers.Add("Authorization: Basic " + authHeader);

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
            var ms = new MemoryStream(data);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            var result = xmlSerializer.Deserialize(ms) as T;

            return new ResultOrError<T>() { Error = error, Result = result, Success = result != null && string.IsNullOrWhiteSpace(error) };
        }
    }
}
