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
    public static class RequestGenerator<T>
    {
        public static ResultOrError<List<T>> getItemsFromAPI(string login, string password, string host, string filterParams)
        {
            string encodedParams = HttpUtility.UrlEncode(filterParams);
            string address = string.Format("{0}/list?filter={1}", host, encodedParams);

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

            DataContractSerializer serializer = new DataContractSerializer(typeof(List<T>));

            var ms = new MemoryStream(data);

            var result = serializer.ReadObject(ms) as List<T>;

            return new ResultOrError<List<T>>() { Error = error, Result = result, Success = result != null && string.IsNullOrWhiteSpace(error) };
        }
    }
}
