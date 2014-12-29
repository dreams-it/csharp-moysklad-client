using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.IntegrationService.EnviromentServices
{
    public static class UnixDateTimeConverter
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
            //2011 05 01 01 0000
            //1 мая 2011
            return dateInDtFormat.Year.ToString() + dateInDtFormat.Month.ToString() + dateInDtFormat.Day.ToString() + dateInDtFormat.Hour.ToString() + dateInDtFormat.Minute.ToString() + dateInDtFormat.Second.ToString();// "0000";
        }

        public static string ToMoySkladFormatDate(this DateTime dateTime)
        {
            return dateTime.Year.ToString() + dateTime.Month.ToString() + dateTime.Day.ToString() + dateTime.Hour.ToString() + dateTime.Minute.ToString() + dateTime.Second.ToString();//"0000";
        }
    }
}
