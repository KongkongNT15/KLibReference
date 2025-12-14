using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class Run : Text
    {
        public override Run DeepCopy => new(InlineText);
        public Run() { }

        public Run(string value) : base(value) { }
    }
}
