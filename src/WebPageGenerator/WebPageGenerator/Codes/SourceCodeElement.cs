using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Codes
{
    public sealed class SourceCodeElement
    {
        public static SourceCodeElement Space(int spaceCount)
        {
            return new SourceCodeElement(new string(' ', spaceCount));
        }

        public string Code;
        public WordType WordType;

        public SourceCodeElement(string code) : this(code, WordType.Other)
        {
        }

        public SourceCodeElement(string code, WordType type)
        {
            Code = code;
            WordType = type;
        }
    }
}
