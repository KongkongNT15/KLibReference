using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPages.Primitives
{
    public class EnumPageElementCollection : List<EnumPageElement>
    {

        public EnumPageElementCollection(IEnumerable<EnumPageElement> list) : base(list)
        {
        }

        public EnumPageElementCollection()
        {
        }

        public void Add(string name)
        {
            if (Count == 0)
            {
                Add(new EnumPageElement(name));
            }
            else
            {
                Add(new EnumPageElement(name, this[^1]));
            }
        }

        public void Add(string name, long value)
        {
            Add(new EnumPageElement(name, value));
        }
    }
}
