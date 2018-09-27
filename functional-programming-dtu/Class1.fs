// Learn more about F# at http://fsharp.org

open System

// Exercise 1.


[<EntryPoint>] 
let main argv =
    // Print integers
    //printfn "%d" (multiplicity(4, [1; 2; 2; 4; 4; 2; 6; 4; 2]))

    // Print lists
    //mulc (3, [1; 2; 3; 4; 5; 6]) |> Seq.iter (printf "%d ")
    mulX ([1; 2; 3]) |> Seq.iter (printf "%d 8")
    0 // return an integer exit code