using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace WebPageGenerator.Pages.CppReference
{
    public abstract class CppPage : Page
    {
        public readonly TextBlock Description;
        public string Name;

        protected CppPage() : this("NoName", new TextBlock())
        {
        }

        protected CppPage(string name, string description) : this(name, new TextBlock(description))
        {
        }

        protected CppPage(string name, TextBlock description) : base(new XElement(name))
        {
            Name = name;
            Description = description;
        }

        protected CppPage(XElement element) : base(element)
        {
            Name = string.Empty;
            Description = new();
        }
    }
}
