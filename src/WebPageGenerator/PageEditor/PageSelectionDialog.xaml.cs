using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using PageEditor.Pages;
using WebPages;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PageEditor;

public sealed partial class PageSelectionDialog : ContentDialog
{
    public PageSelectionDialog()
    {
        InitializeComponent();

        PageTypeComboBox.ItemsSource = Enum.GetValues(typeof(PageType));
        PageTypeComboBox.SelectedIndex = 0;
    }

    public PageSelectionDialog(Window window) : this(window.Content)
    {
    }

    public PageSelectionDialog(UIElement element) : this()
    {
        XamlRoot = element.XamlRoot;
    }

    public PageType SelectedType => (PageType)PageTypeComboBox.SelectedItem;
}
