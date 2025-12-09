using System;
using System.Collections.Generic;
using System.Text;
using WebPageGenerator.Codes;

namespace WebPageGenerator.Pages
{
    internal static class CssClasses
    {
        internal const string InlineCode = "inline-code";

        internal const string SourceTable = "source-table";
        internal const string SourceCode = "source-code";
        internal const string SourceClass = "source-class";
        internal const string SourceComment = "source-comment";
        internal const string SourceEnum = "source-enum";
        internal const string SourceField = "source-field";
        internal const string SourceFunction = "source-function";
        internal const string SourceInterface = "source-interface";
        internal const string SourceKeyword = "source-keyword";
        internal const string SourceKeywordPurple = "source-keyword-purple";
        internal const string SourceLocalVariable = "source-local-variable";
        internal const string SourceNumber = "source-number";
        internal const string SourcePreprocess = "source-preprocess";
        internal const string SourceString = "source-string";
        internal const string SourceStruct = "source-struct";

        internal static string FromWordType(WordType type)
        {
            return type switch
            {
                WordType.Class => SourceClass,
                WordType.Comment => SourceComment,
                WordType.Enum => SourceEnum,
                WordType.Field => SourceField,
                WordType.Function => SourceFunction,
                WordType.Interface => SourceInterface,
                WordType.Keyword => SourceKeyword,
                WordType.KeywordPurple => SourceKeywordPurple,
                WordType.LocalVariable => SourceLocalVariable,
                WordType.Number => SourceNumber,
                WordType.Preprocess => SourcePreprocess,
                WordType.String => SourceString,
                WordType.Struct => SourceStruct,
                WordType.Other => SourceCode,
                _ => SourceCode,
            };
        }

    }
}
