using Avalonia.Controls;
using BdfEditor.ViewModels.Windows;

namespace BdfEditor.Views.Windows;

public partial class StartWindow : Window
{
    public StartWindow()
    {
        InitializeComponent();
        DataContext = new StartWindowViewModel();
    }
}
