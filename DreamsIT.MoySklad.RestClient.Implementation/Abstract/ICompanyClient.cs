using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    /// <summary>
    /// Интерфейс доступа к юр. лицам
    /// </summary>
    public interface IMyCompanyClient
    {
        List<MyCompany> GetMyCompanies(List<Guid> ids = null, double startDateUpdate = 0, double endDateUpdate = 0, List<string> names = null);
    }
}
