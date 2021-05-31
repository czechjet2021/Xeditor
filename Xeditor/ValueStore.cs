using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xeditor
{
    public class ValueStore<TKey,TValue,TList>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public TList List { get; set; }

        public ValueStore(TKey key, TValue value, TList list)   
        {
            Key = key;
            Value = value;
            List = list;
        }
    }
}
