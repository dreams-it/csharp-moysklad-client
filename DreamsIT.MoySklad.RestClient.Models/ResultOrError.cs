using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class ResultOrError<T>
        where T:class
    {
        public T Result { get; set; }

        public string Error { get; set; }

        public bool Success { get; set; }
    }
}
