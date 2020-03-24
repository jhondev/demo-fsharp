// Learn more about F# at http://fsharp.org


[<EntryPoint>]
let main argv =
    let mutable im = "testing"
    im <- "tesing edited"
    printfn "Hello World from F#! edited %A" im
    printfn "%A %d" argv argv.Length
    0 // return an integer exit code
