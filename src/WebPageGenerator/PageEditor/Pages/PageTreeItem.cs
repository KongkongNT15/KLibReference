using Microsoft.UI.Xaml.Automation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageEditor.Pages
{
    public class PageTreeItem : TreeViewItem
    {
        private readonly TextBlock m_nameTextBlock = new();
        private readonly FontIcon m_icon = new();
        private PageType m_type;

        public string Title
        {
            get => m_nameTextBlock.Text;
            set => m_nameTextBlock.Text = value;
        }

        public PageType Type
        {
            get => m_type;
            set
            {
                if (value == m_type) return;
                m_type = value;

                m_icon.Glyph = value switch
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

        public PageTreeItem()
        {
            StackPanel panel = new() { Spacing = 12, Orientation = Orientation.Horizontal };
            var children = panel.Children;

            children.Add(m_icon);
            children.Add(m_nameTextBlock);

            Content = panel;
        }
    }
}
