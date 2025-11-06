using Avalonia.Controls;
using Avalonia.Controls.Templates;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BdfEditor;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? data) => data switch
    {
        null => null,
        _ => new TextBlock
        {
            Text = $"View Not Found: {data.GetType().Name}"
        }
    };

    public bool Match(object? data) => data is ObservableObject;
}
