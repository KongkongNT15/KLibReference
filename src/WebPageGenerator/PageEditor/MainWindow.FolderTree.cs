using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using PageEditor.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPages;

namespace PageEditor
{
    public partial class MainWindow
    {
        private void FolderTree_SelectionChanged(TreeView sender, TreeViewSelectionChangedEventArgs args)
        {
            if (sender.SelectedItem == Tabs.SelectedItem) return;

            PageItem item = (PageItem)sender.SelectedItem;
        }

        private async void FolderTree_MenuFlyoutItem_Add_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuFlyoutItem)sender;

            await CreateNewPageAsync((PageItem)menuItem.Tag);
        }
    }
}
