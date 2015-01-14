using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.EnvitomentMethods
{
    public static class UnixTimeConverter
    {
        public static double ToUnixTime(this DateTime dateTime)
        {
            return (dateTime - new DateTime(1970, 1, 1)).TotalSeconds;
        }

        public static DateTime FromUnixTime(this double unixTime)
        {
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTime).ToUniversalTime();
            return dtDateTime;
        }

        public static string ToMoySkladFormatDate(this double dateTime)
        {
            var dateInDtFormat = dateTime.FromUnixTime();
            return dateInDtFormat.ToString("yyyyMMddHHmmss");
        }

        public static string ToMoySkladFormatDate(this DateTime dateTime)
        {
            return dateTime.ToString("yyyyMMddHHmmss");
        }
    }
}
