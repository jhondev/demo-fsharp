type Customer =
    { Name: string
      SafetyScore: int option
      YearPassed: int }

let customers =
    [ { Customer.Name = "Fred Smith"
        SafetyScore = Some 550
        YearPassed = 1980 }
      { Name = "Jane Dunn"
        SafetyScore = None
        YearPassed = 1980 } ]

let calculateAnnualPremiumUsd customer =
    match customer.SafetyScore with
    | Some 0 -> 250, None
    | Some score when score < 0 -> 400, None
    | Some score when score > 0 -> 150, None
    | None ->
        300, Some "No score supplied! Using temporary premium."

let printscore name score =
    printfn "annual premium for %s is: %i" name score
let printmsg msg = printfn "%s" msg

let annual, msg = calculateAnnualPremiumUsd customers.[0]

msg |> Option.map printmsg

printscore customers.[0].Name annual

let annual2, msg2 = calculateAnnualPremiumUsd customers.[1]

msg2 |> Option.map printmsg

printscore customers.[1].Name annual2
