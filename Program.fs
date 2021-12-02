open System
open Day1
open Day2

[<EntryPoint>]
let main argv =

    performDay1Operations ()
    performDay2Operation ()

    Console.ReadLine() |> ignore

    // Exit code is the number of increased cases
    0
