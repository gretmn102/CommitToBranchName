module CommitToBranchName.Program
// todo: #r "nuget: Argu, 6.2.5"
open Lib

// todo: "-" -- stdin
[<EntryPoint>]
let main args =
    let commitName = stdin.ReadToEnd()
    escape commitName |> printfn "%s"
    0
