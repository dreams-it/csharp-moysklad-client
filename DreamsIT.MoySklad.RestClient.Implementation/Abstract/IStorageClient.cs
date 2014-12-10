using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IStorageClient<T>
        where T:class
    {
        T Get(T type, Guid uuid);
        T Save(T type, T item);
        bool Delete(T type, Guid uuid);
        T GetList(T type);
        List<T> Save(T type, List<T> itemsForSave);
        bool Delete(T type, List<Guid> uuids = null, List<string> names = null);
    }
}
