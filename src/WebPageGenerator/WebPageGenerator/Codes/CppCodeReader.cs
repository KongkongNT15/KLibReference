using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace WebPageGenerator.Codes
{
    public class CppCodeReader : SourceCodeReader
    {
        private static readonly string[] s_keywords = [
            "auto",
            "bool",
            "char",
            "char8_t",
            "char16_t",
            "char32_t",
            "class",
            "const",
            "consteval",
            "constexpr",
            "default",
            "delete",
            "double",
            "enum",
            "false",
            "final",
            "float",
            "goto",
            "inline",
            "int",
            "long",
            "namespace",
            "new",
            "noexcept",
            "override",
            "private",
            "protected",
            "public",
            "short",
            "signed",
            "static",
            "struct",
            "template",
            "true",
            "typename",
            "unsigned",
            "using",
            "virtual",
            "void",
            "wchar_t",
            "void",
        ];

        private static readonly string[] s_keywordsPurple = [
            "break",
            "case",
            "continue",
            "do",
            "for",
            "if",
            "return",
            "switch",
            "throw",
            "while",
        ];

        private static readonly List<string> s_classes = [];
        private static readonly List<string> s_enums = [];

        private enum CppStatus
        {
            Class,
            ClassMember,
            ClassName,
            EnumMember,
            EnumName,
            Namespace,
            NamespaceMember,
            None,
            Number,
            PreprocessBegin,
        }

        public static void AddWords(string path, WordType type)
        {
            static void load(string path, List<string> wordList)
            {
                using StreamReader reader = new(path);

                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Length == 0) continue;

                    wordList.Add(line);
                }
            }

            load(
                path,
                type switch
                {
                    WordType.Class or WordType.Struct => s_classes,
                    WordType.Enum => s_enums,
                    _ => throw new NotImplementedException($"この値はサポートされていません: WordType.{type}")
                }
            );
        }

        public override void Load(TextReader reader)
        {

            StringBuilder sb = new StringBuilder();

            char c;
            int tmp;

            List<CppStatus> statusList = [];

            void func(CppStatus status)
            {
                // 空白を除去
                while ((tmp = reader.Peek()) != -1)
                {
                    c = (char)tmp;
                    switch (c)
                    {
                        case ' ':
                        case '\r':
                        case '\n':
                        case '\t':
                            sb.Append(c);
                            _ = reader.Read();
                            break;

                        default:
                            m_elements.Add(new SourceCodeElement(sb.ToString()));
                            sb.Clear();
                            break;
                    }
                    
                }

                statusList.Add(status);

                switch (status)
                {
                    case CppStatus.ClassMember:

                        break;

                    case CppStatus.None:
                        // 数値だよ
                        if ('0' <= c && c <= '9')
                        {
                            func(CppStatus.Number);
                        }
                        else if (char.IsLetter(c) || c == '_')
                        {
                            while ((tmp = reader.Peek()) != -1)
                            {
                                c = (char)tmp;

                                // 名前に使える文字なら追加
                                if (char.IsLetterOrDigit(c) || c == '_')
                                {
                                    sb.Append(c);
                                    _ = reader.Read();
                                }
                                //名前に使えない文字が来たらそれまでが名前
                                else
                                {
                                    string word = sb.ToString();
                                    sb.Clear();

                                    if (s_classes.Contains(word))
                                    {
                                        m_elements.Add(new SourceCodeElement(word, WordType.Class));

                                        func(CppStatus.ClassName);
                                    }
                                    else if (s_enums.Contains(word))
                                    {
                                        m_elements.Add(new SourceCodeElement(word, WordType.Enum));

                                        func(CppStatus.EnumName);
                                    }
                                }
                            }
                        }
                        else if (c == '#')
                        {
                            sb.Append('#');
                            _ = reader.Read();

                            func(CppStatus.PreprocessBegin);
                        }
                        else if (c == '.')
                        {
                            throw new NotImplementedException();
                        }
                        else if (c == '-')
                        {
                            _ = reader.Read();

                        }
                        break;

                    case CppStatus.Number:
                        while ((tmp = reader.Peek()) != -1)
                        {
                            c = (char)tmp;

                            if (('0' <= c && c <= '9') || ('A' <= c && c <= 'Z') || c == '.' || c == '_')
                            {
                                sb.Append(c);
                                _ = reader.Read();
                            }
                            else
                            {
                                m_elements.Add(new SourceCodeElement(sb.ToString(), WordType.Number));
                                sb.Clear();
                                break;
                            }
                        }
                        break;

                        case CppStatus.PreprocessBegin:
                        break;

                    default: throw new NotSupportedException($"CppStatus値が不正です: {(int)status}");
                }

                // 最後に末尾のステータスを削除
                statusList.RemoveAt(statusList.Count - 1);

                throw new NotImplementedException();
            }

            while ((tmp = reader.Peek()) != -1)
            {
                c = (char)tmp;

                func(CppStatus.None);

                throw new NotImplementedException();
            }


        }
    }
}
