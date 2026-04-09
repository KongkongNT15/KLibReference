using Microsoft.UI.Xaml;
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
        private async void MenuBar_MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            await CreateNewPageAsync();
        }
    }
}
