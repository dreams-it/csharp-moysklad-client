using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models.Abstract
{
    public interface IResultModel
    {
        List<object> Items { get; set; }
    }
}
