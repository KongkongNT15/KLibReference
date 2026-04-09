using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace WebPages
{
    public class PageItem
    {
        public string Name { get; set; }

        public string FolderPath { get; }

        private PageItem? m_parent;

        public PageItem This => this;

        public PageItem? Parent => m_parent;

        public PageItem Root
        {
            get
            {
                PageItem? parent = m_parent;

                if (parent == null) return this;

                return parent.Root;
            }
        }

        public PageType Type { get; }

        public string Glyph { get; }

        public ObservableCollection<PageItem> Children { get; }

        public PageItem(string folderPath, PageType type)
        {
            m_parent = null;
            Name = string.Empty;
            FolderPath = folderPath;
            Type = type;
            Children = [];

            Children.CollectionChanged += Children_CollectionChanged;

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

        private void Children_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        int index = e.NewStartingIndex;
                        Children[index].m_parent = this;
                    }


                    break;

                case NotifyCollectionChangedAction.Remove:
                    {
                        if (e.OldItems != null)
                        {
                            int index = e.OldStartingIndex;
                            PageItem? item = (PageItem?)e.OldItems[index];

                            if (item != null)
                            {
                                item.m_parent = null;
                            }
                        }

                    }
                    break;

                default:
                    break;
            }
        }
    }
}
