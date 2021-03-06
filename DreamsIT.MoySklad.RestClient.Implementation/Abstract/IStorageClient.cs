﻿using DreamsIT.MoySklad.RestClient.Models;
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
        ResultOrError<T> Get(T type, Guid uuid);
        ResultOrError<T> Save(T type, T item);
        bool Delete(T type, Guid uuid);
        ResultOrError<List<T>> GetList(T type);
        ResultOrError<List<T>> Save(T type, List<T> itemsForSave);
        bool Delete(T type, List<Guid> uuids = null, List<string> names = null);
    }
}
