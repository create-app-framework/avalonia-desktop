module MyNamespace.Source.App

open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Themes.Fluent
open MyNamespace.Source.View.MainWin
open MyNamespace.Source.View.MainWin.Main

module MyApplication =
    

    type App() =
        inherit Application()
    
        override this.Initialize() =
            this.Styles.Add(FluentTheme())
            this.RequestedThemeVariant <- Styling.ThemeVariant.Dark
        
        override this.OnFrameworkInitializationCompleted() =
            match this.ApplicationLifetime with
            | :? IClassicDesktopStyleApplicationLifetime as desktopLifetime ->
                desktopLifetime.MainWindow <- Main.MainWindow()
            | _ -> ()
        
