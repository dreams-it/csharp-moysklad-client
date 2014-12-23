using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.EnvitomentMethods
{
    public static class ConvertParamsInString<T>
    {
        public static string ConvertList(List<T> stringParams, string name)
        {
            string paramsInString = "";
            foreach (var stringParam in stringParams)
            {
                paramsInString = paramsInString + ";" + name + "=" + stringParam;
            }
            return paramsInString.Substring(1);
        }
    }
}
