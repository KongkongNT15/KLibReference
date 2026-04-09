using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPages.Primitives
{
    public class EnumPageElement
    {
        public string Name;
        public long Value;

        public EnumPageElement(string name, long value)
        {
            Name = name;
            Value = value;
        }

        public EnumPageElement(string name) : this(name, 0)
        {
        }

        public EnumPageElement(string name, EnumPageElement previusElement) : this(name, previusElement.Value + 1)
        {
        }
    }
}
