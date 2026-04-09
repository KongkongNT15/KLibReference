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
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WebPages;
using Windows.UI.Text;
using Microsoft.UI.Text;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PageEditor
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private readonly ObservableCollection<PageItem> m_items = [];
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<PageItem> items = m_items;

            {
                var item = new PageItem("", PageType.Namespace) { Name = "page" };
                items.Add(item);

                item.Children.Add(new PageItem("", PageType.Class) { Name = "page" });
            }

            
            items.Add(new PageItem("", PageType.Function) { Name = "page" });
            items.Add(new PageItem("", PageType.Enum) { Name = "page" });

            FolderTree.ItemsSource = items;
        }

        private async Task CreateNewPageAsync(ObservableCollection<PageItem> items)
        {
            PageSelectionDialog dialog = new(this);

            var result = await dialog.ShowAsync();

            switch (result)
            {
                case ContentDialogResult.Primary:
                    PageType type = dialog.SelectedType;
                    break;

                default:
                    break;
            }
        }

        private Task CreateNewPageAsync(PageItem? parent)
        {
            if (parent != null)
            {
                return CreateNewPageAsync(parent.Children);
            }
            else
            {
                return CreateNewPageAsync(m_items);
            }
        }

        private Task CreateNewPageAsync()
        {
            return CreateNewPageAsync(FolderTree.SelectedItem as PageItem);
        }

        

        
    }
}
