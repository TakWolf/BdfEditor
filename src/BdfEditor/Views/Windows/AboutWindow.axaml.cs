using Avalonia.Controls;
using BdfEditor.ViewModels.Windows;

namespace BdfEditor.Views.Windows;

public partial class AboutWindow : Window
{
    public AboutWindow()
    {
        InitializeComponent();
        DataContext = new AboutWindowViewModel();
    }
}
