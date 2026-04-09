using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Input;
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
        private void Tabs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PageItem item = (PageItem)Tabs.SelectedItem;
        }

        private async void Tabs_AddTabButtonClick(TabView sender, object args)
        {
            await CreateNewPageAsync();
        }
    }
}
