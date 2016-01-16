using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrosvenorTextEditor.BusinessLogic
{
    public class CounterBase<T> : ICounter<T>
    {
        private bool _isCaseSensitive = false;

        protected CounterBase()
        {
            Items = new Dictionary<T, int>();
        }

        protected CounterBase(int capacity)
        {
            Items = new Dictionary<T, int>(capacity);
        }

        protected IDictionary<T, int> Items { get; private set; }

        public bool IsCaseSensitive
        {
            get { return _isCaseSensitive; }
            set
            {
                if (_isCaseSensitive == value) return;
                _isCaseSensitive = value;
                Reset();
            }
        }

        
        public virtual void Add(T key)
        {          
            if (Items.Keys.Contains(key))
            {                
                 Items[key] += 1;
            }
            else
            {
                Items.Add(key, 1);
            }
        }

        public virtual IDictionary<T, int> GetAll()
        {
            return Items;
        }

        public virtual int GetKeyValue(T key)
        {
            return Items[key];
        }
 
        public virtual int GetTotalSumOfValues()
        {
            return Items.Sum(x => x.Value);
        }

        public virtual void Remove(T key)
        {
            if (Items.Keys.Contains(key) && Items[key] > 1)
            {
                Items[key] -= 1;
            }
            else
            {
                Items.Remove(key);
            }            
        }

        public virtual void Reset()
        {
            Items.Clear();
        }    
    }
}
