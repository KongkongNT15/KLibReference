using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageEditor.Pages
{
    public class PageItem
    {
        public string Name { get; set; }

        public string FolderPath { get; }

        public PageType Type { get; }

        public string Glyph { get; }

        public ObservableCollection<PageItem> Children { get; }

        public PageItem(string folderPath, PageType type)
        {
            Name = string.Empty;
            FolderPath = folderPath;
            Type = type;
            Children = [];

            Glyph = type switch
            {
                PageType.Class => "\uF158",
                PageType.Enum => "\uE8FD",
                PageType.Field => "\uEA86",
                PageType.Function => "\uE74C",
                PageType.Method => "\uE74C",
                PageType.Namespace => "\uE8B7",
                PageType.Operator => "\uE948",
                _ => "\uE9CE",
            };
        }
    }
}
