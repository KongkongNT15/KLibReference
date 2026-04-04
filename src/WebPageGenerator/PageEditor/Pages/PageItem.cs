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

        public ObservableCollection<PageItem> Children { get; }

        public PageItem(string folderPath, PageType type)
        {
            Name = string.Empty;
            FolderPath = folderPath;
            Type = type;
            Children = [];
        }
    }
}
