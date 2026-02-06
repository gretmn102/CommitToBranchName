#!/usr/bin/env -S dotnet fsi
// todo: #r "nuget: Argu, 6.2.5"
open "Lib.fsx"

// todo: "-" -- stdin
exit (
    let commitName = stdin.ReadToEnd()
    escape commitName |> printfn "%s"
    System.Environment.ExitCode
)
