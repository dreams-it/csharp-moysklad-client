using DreamsIT.Data.BaseTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.DataFakes.Implementation
{

    public class BaseFakeRepository<TType, TKey> : IRepository<TType, TKey> where TType : class, IKeyItem<TKey>, new()
    {
        private readonly List<TType> _itemsList;

        public BaseFakeRepository(List<TType> itemsList)
        {
            _itemsList = itemsList;
        }

        protected IQueryable<TType> Items
        {
            get { return _itemsList.AsQueryable(); }
        }

        public IEnumerator<TType> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Items).GetEnumerator();
        }

        public Expression Expression
        {
            get { return Items.Expression; }
        }

        public Type ElementType
        {
            get { return Items.ElementType; }
        }

        public IQueryProvider Provider
        {
            get { return Items.Provider; }
        }

        public TType Add(TType entity)
        {
            var eventArg = new CancellationCrudEventArgs<TType> { Entity = entity };

            if (BeforeEntityAdding != null)
                BeforeEntityAdding(this, eventArg);

            if (!eventArg.Cancel)
            {
                _itemsList.Add(entity);

                if (EntityAdded != null)
                    EntityAdded(this, new ActionCompleteEventArgs<TType> { Entity = eventArg.Entity });
            }
            return entity;
        }

        void ICollection<TType>.Add(TType item)
        {
            Add(item);
        }

        public void Clear()
        {
            IQueryable<TKey> keys = Items.Select(x => x.Id);
            IEnumerator<TKey> iterator = keys.GetEnumerator();
            iterator.Reset();
            while (iterator.MoveNext())
            {
                Remove(iterator.Current);
            }
        }

        public bool Contains(TType item)
        {
            return Items.Any(i => i.Id.Equals(item.Id));
        }

        public void CopyTo(TType[] array, int arrayIndex)
        {
            int count = Count - arrayIndex;
            Array.Copy(Items.OrderBy(x => x.Id).Skip(arrayIndex).ToArray(), array, count < 0 ? 0 : count);
        }

        public bool Remove(TType item)
        {
            _itemsList.Remove(item);
            return true;
        }

        public int Count
        {
            get { return Items.Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public int IndexOf(TType item)
        {
            return 0;
        }

        public void Insert(int index, TType item)
        {

        }

        public void RemoveAt(int index)
        {
            Remove(Items.ElementAt(index));
        }

        public TType this[int index]
        {
            get { return Items.ElementAt(index); }
            set
            {
                if (!value.Id.Equals(default(TKey)))
                    Update(value);
                else
                    Add(value);
            }
        }

        public int CommitChanges()
        {
            return 0;
        }

        public TType FindById(TKey id)
        {
            return _itemsList.FirstOrDefault(x => x.Id.Equals(id));
        }


        public TType New()
        {
            return new TType();
        }


        public TType Update(TType entity)
        {
            if (entity != null)
            {
                var old = _itemsList.FirstOrDefault(x => x.Id.Equals(entity.Id));
                _itemsList.Remove(old);
                _itemsList.Add(entity);
            }
            return entity;
        }


        public bool Remove(TKey id)
        {
            _itemsList.RemoveAll(x => x.Id.Equals(id));
            return true;
        }

        public int Remove(params TKey[] ids)
        {
            _itemsList.RemoveAll(c => ids.Any(r => r.Equals(c.Id)));
            return 1;
        }

        public IEnumerable<TType> SqlQuery(string query, params object[] parameters)
        {
            return null;
        }

        public void Save(TType item)
        {
            var existedItem = _itemsList.FirstOrDefault(c => c.Id.Equals(item.Id));
            if (existedItem != null)
            {
                _itemsList.Remove(existedItem);
            }
            _itemsList.Add(item);
        }


        public event EventHandler<CancellationEventArgs> BeforeChangesCommit;

        public event EventHandler<CancellationCrudEventArgs<TType>> BeforeEntityAdding;

        public event EventHandler<CancellationCrudEventArgs<TType>> BeforeEntityRemoving;

        public event EventHandler<CancellationCrudEventArgs<TType>> BeforeEntityUpdating;

        public event EventHandler ChangesCommited;

        public event EventHandler<ActionCompleteEventArgs<TType>> EntityAdded;

        public event EventHandler<ActionCompleteEventArgs<TType>> EntityRemoved;

        public event EventHandler<ActionCompleteEventArgs<TType>> EntityUpdated;
    }
}
