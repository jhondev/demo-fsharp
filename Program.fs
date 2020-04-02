// Learn more about F# at http://fsharp.org

let hello (argv: string []) =
    let mutable im = "testing"
    im <- "testing edited"
    printfn "Hello World from F#! edited %A" im
    printfn "%A %d" argv argv.Length

[<EntryPoint>]
let main argv =
    hello argv
    0 // return an integer exit code
