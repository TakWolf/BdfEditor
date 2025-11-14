using Avalonia.Controls;
using BdfEditor.ViewModels.Windows;

namespace BdfEditor.Views.Windows;

public partial class SettingsWindow : Window
{
    public SettingsWindow()
    {
        InitializeComponent();
        DataContext = new SettingsWindowViewModel();
    }
}
