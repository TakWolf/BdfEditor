using Avalonia.Controls;
using BdfEditor.ViewModels.Windows;

namespace BdfEditor.Views.Windows;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}
