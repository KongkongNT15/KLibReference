using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPages
{
    public abstract class PageData
    {
        private static int s_maxTag;
        public int Tag;

        public readonly ObservableCollection<PageData> Children;

        public string Name;

        private PageData? m_parent;
        public PageData? Parent => m_parent;

        protected PageData() : this(string.Empty)
        {
        }

        protected PageData(string name) : this(name, s_maxTag++)
        {
        }

        protected PageData(string name, int tag)
        {
            Name = name;
            Tag = tag;

            Children = [];

            Children.CollectionChanged += Children_CollectionChanged;
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
                            PageData? item = (PageData?)e.OldItems[index];

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

        protected virtual void DoInitialize()
        {
        }

        protected abstract void DoLoad(StreamReader sr);
        protected abstract void DoSave(StreamWriter sw);

        public void Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                using StreamReader sr = new(filePath);
                DoLoad(sr);
            }
            else
            {
                DoInitialize();
            }
        }

        public void Save(string filePath, bool discard = false)
        {
            if (!discard)
            {
                using StreamWriter sw = new(filePath);
                DoSave(sw);
            }
        }
    }
}
