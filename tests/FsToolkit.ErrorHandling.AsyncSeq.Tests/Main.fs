module FsToolkit.ErrorHandling.AsyncSeq.Tests

#if FABLE_COMPILER
open Fable.Mocha
#else
open Expecto

[<Tests>] //needed for `dotnet test` to work
#endif
let allTests = testList "All Tests" [ AsyncSeq.allTests ]

[<EntryPoint>]
let main argv =
#if FABLE_COMPILER
    Mocha.runTests allTests
#else
    Tests.runTestsWithArgs defaultConfig argv allTests
#endif
