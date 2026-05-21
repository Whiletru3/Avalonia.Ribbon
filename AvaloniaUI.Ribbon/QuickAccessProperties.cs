using Avalonia;
using Avalonia.Controls;

namespace AvaloniaUI.Ribbon;
public class QuickAccessProperties : AvaloniaObject
{
    public static readonly AttachedProperty<bool> IsCheckedProperty =
        AvaloniaProperty.RegisterAttached<QuickAccessProperties, MenuItem, bool>("IsChecked");

    public static bool GetIsChecked(MenuItem element) => element.GetValue(IsCheckedProperty);
    public static void SetIsChecked(MenuItem element, bool value) => element.SetValue(IsCheckedProperty, value);
}

