using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using PageEditor.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PageEditor
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            {
                var titleBar = AppWindow.TitleBar;
                titleBar.ExtendsContentIntoTitleBar = true;

                titleBar.BackgroundColor = ColorHelper.FromArgb(0, 0, 0, 0);
                titleBar.InactiveBackgroundColor = ColorHelper.FromArgb(0, 0, 0, 0);
            }

            ObservableCollection<PageItem> items = [];

            {
                var item = new PageItem("", PageType.Namespace) { Name = "page" };
                items.Add(item);

                item.Children.Add(new PageItem("", PageType.Class) { Name = "page" });
            }

            
            items.Add(new PageItem("", PageType.Function) { Name = "page" });
            items.Add(new PageItem("", PageType.Enum) { Name = "page" });

            FolderTree.ItemsSource = items;
        }

        private void FolderTree_SelectionChanged(TreeView sender, TreeViewSelectionChangedEventArgs args)
        {
            PageItem item = (PageItem)sender.SelectedItem;

            
        }
    }
}
