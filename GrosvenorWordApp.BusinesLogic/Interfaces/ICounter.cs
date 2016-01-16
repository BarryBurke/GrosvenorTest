using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GrosvenorTextEditor.BusinessLogic
{
    public interface ICounter<T>
    {        
        bool IsCaseSensitive { get; set;  }

        void Add(T key);   
        IDictionary<T, int> GetAll();
        void Remove(T key);
        void Reset();
    }
}
