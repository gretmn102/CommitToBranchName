#!/usr/bin/env -S dotnet fsi
#r "nuget: Expecto, 10.2.3"
#load "./Lib.fsx"
open Expecto

open Lib

[<Tests>]
let escapeTest =
    testList "escapeTest" [
        testCase "1" <| fun () ->
            Expect.equal
                (escape "#!/usr/bin/env -S dotnet fsi")
                "-usr-bin-env--S-dotnet-fsi"
                ""
        testCase "2" <| fun () ->
            Expect.equal
                (escape "refactor(Statement.exec): `RemoveObjectFromLocation` wrap to `Result.builder`")
                "refactorStatement-exec-RemoveObjectFromLocation-wrap-to-Result-builder"
                ""
        testCase "3" <| fun () ->
            Expect.equal
                (escape "fix(Statement.exec)!: return `LocationNotFound` error in `RemoveObjectFromLocation`")
                "fixStatement-exec-return-LocationNotFound-error-in-RemoveObjectFromLocation"
                ""
    ]

exit (
    runTestsWithCLIArgs [] fsi.CommandLineArgs[1..] escapeTest
)
