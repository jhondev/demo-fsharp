let sum inputs =
    (0, inputs) ||> Seq.fold (fun state input -> state + input)

let length inputs =
    (0, inputs) ||> Seq.fold (fun state _ -> state + 1)

let max inputs =
    (0, inputs)
    ||> Seq.fold (fun state input ->
            if input > state then input
            else state)

let collection = [ 1; 7; 6; 10; 2; 5 ]

printfn "sum: %A" (sum collection)
printfn "length: %A" (length collection)
printfn "max: %A" (max collection)
