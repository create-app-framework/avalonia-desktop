module MyNamespace.Source.Program

open Avalonia
open MyNamespace.Source.App

module Program =

    [<EntryPoint>]
    let main(args: string[]) =
        AppBuilder
            .Configure<MyApplication.App>()
            .UsePlatformDetect()
            .UseSkia()
            .StartWithClassicDesktopLifetime(args)