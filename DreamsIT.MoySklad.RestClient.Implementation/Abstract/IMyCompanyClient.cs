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
        ResultOrError<List<MyCompany>> GetMyCompanies(List<Guid> ids = null, List<string> names = null);

        ResultOrError<List<MyCompany>> GetDeletedMyCompanies( DateTime deleted);

        ResultOrError<List<MyCompany>> GetNewMyCompanies( DateTime updated);
    }
}