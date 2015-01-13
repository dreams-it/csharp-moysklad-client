using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.EnvitomentMethods
{
    public static class HeaderConverter
    {
        public static string GetAuthHeaders(string login, string password)
        {
            var bytes = Encoding.UTF8.GetBytes(login + ":" + password);
            return Convert.ToBase64String(bytes);
        }
    }
}
