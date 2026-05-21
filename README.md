# AvaloniaRibbon — Avalonia 12 Migration

This is a fork of [AvaloniaRibbon by Sachith Liyanagama](https://github.com/SachiHarshitha/Avalonia.Ribbon), migrated to **Avalonia 12**.

For full documentation, controls list, and usage examples refer to the original repository.

## What changed in this fork

- Migrated all XAML styles and templates from Avalonia 11 to Avalonia 12
- Replaced removed `TitleBar`, `CaptionButtons` and `ChromeOverlayLayer` controls
- Replaced `SystemDecorations` with `WindowDecorations`
- Removed `ExtendClientAreaChromeHints` (removed in Avalonia 12)
- Fixed compiled bindings (`{Binding}` → `{ReflectionBinding}` where `x:DataType` is unavailable)
- Added `<Setter.Value>` wrappers required by Avalonia 12 compiler
- Fixed cross-assembly dependency for `QuickAccessToolbar.IsChecked` via new `QuickAccessProperties` class
- Updated all xmlns prefixes for custom types as required by Avalonia 12

## How to Use

Add styles to `App.axaml`:

```xml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceInclude Source="avares://AvaloniaUI.Ribbon/Locale/en-ca.axaml" />
            <ResourceInclude Source="avares://AvaloniaUI.Ribbon/Themes/Accents/Fluent.axaml" />
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>

<Application.Styles>
    <FluentTheme />
    <StyleInclude Source="avares://AvaloniaUI.Ribbon.Desktop/Styles/Fluent/AvaloniaRibbon.axaml" />
</Application.Styles>
```

## License

MIT License — see [LICENSE](LICENSE) file.
Original work by Alban Mazerolles, Rubal Walia, Sachith Liyanagama.
Avalonia 12 migration by Vadim Belov (2026).
