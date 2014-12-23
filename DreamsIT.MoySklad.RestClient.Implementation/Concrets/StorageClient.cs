using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
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
    public class StorageClient<T> : IStorageClient<T>
        where T : class
    {

        public StorageClient(string login, string password)
        {

        }

        private string login = "";
        private string password = "";
        private string host = "https://online.moysklad.ru/exchange/rest";

        public ResultOrError<T> Get(T type, Guid uuid)
        {
            string address = string.Format("{0}/ms/xml/{1}/{2}", host, type.ToString(), uuid.ToString());

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

            DataContractSerializer serializer = new DataContractSerializer(typeof(T));

            var ms = new MemoryStream(data);

            var result = serializer.ReadObject(ms) as T;

            return new ResultOrError<T>() { Result = result, Error = error };
        }

        public ResultOrError<T> Save(T type, T item)
        {
            string address = string.Format("{0}/ms/xml/{1}", host, type.ToString());

            DataContractSerializer serializer = new DataContractSerializer(typeof(T));

            var ms1 = new MemoryStream();
            serializer.WriteObject(ms1, item);

            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential(login, password);
            client.Headers.Add(HttpRequestHeader.ContentType, "application/xml");
            string error = "";
            byte[] data = null;
            try
            {
                data = client.UploadData(address, "PUT", ms1.ToArray());
            }
            catch (Exception exc)
            {
                error = exc.Message;
            }
            var ms = new MemoryStream(data);

            var result = serializer.ReadObject(ms) as T;

            return new ResultOrError<T>() { Result = result, Error = error };
        }

        public bool Delete(T type, Guid uuid)
        {
            string address = string.Format("{0}/ms/xml/{1}/{2}", host, type.ToString(), uuid.ToString());

            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential(login, password);
            client.Headers.Add(HttpRequestHeader.ContentType, "application/xml");
            string error = "";
            bool success = true;
            string data = "";
            try
            {
                data = client.UploadString(address, "DELETE", "");
            }
            catch (Exception exc)
            {
                success = false;
                error = exc.Message;
            }
            return success;
        }

        public ResultOrError<List<T>> GetList(T type)
        {
            string address = string.Format("{0}/ms/xml/{1}/list", host, type.ToString());

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

            return new ResultOrError<List<T>>() { Result = result, Error = error };
        }

        public List<ResultOrError<List<T>>> Save(T type, List<T> itemsForSave)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T type, List<Guid> uuids = null, List<string> names = null)
        {
            throw new NotImplementedException();
        }


    }
}
