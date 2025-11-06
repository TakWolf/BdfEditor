using Avalonia.Controls;
using BdfEditor.ViewModels;

namespace BdfEditor.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}
