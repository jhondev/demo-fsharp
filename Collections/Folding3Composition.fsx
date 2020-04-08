open System

type Result = bool * string

type Rule = string -> Result

let rules: Rule list =
    [ fun phrase -> (phrase.Split ' ').Length = 3, "Must be 3 words"
      fun phrase -> phrase.Length <= 30, "Max length is 30 characters"
      fun phrase ->
          phrase
          |> Seq.filter Char.IsLetter
          |> Seq.forall Char.IsUpper, "All letters must be caps" ]

[<Literal>]
let phrase = "THIS IS TEST g"

// VALIDATION USING COLLECTION FUNCTIONS
let validate phrase =
    let brokenRule =
        rules
        |> List.map (fun validationFn ->
            let result, error = validationFn phrase
            printfn "validation rule: %s" error
            result, error)
        |> List.tryFind (fun (result, _) -> not result)
    if brokenRule.IsSome then brokenRule.Value
    else true, "ok!"


let result, message = validate phrase

printfn "validation is: %A - text is: %s" result message

// VALIDATION USING REDUCE
let buildValidator (rules : Rule list) =
    rules
    |> List.reduce(fun firstRule secondRule ->
        fun phrase ->         
            let passed, error = firstRule phrase
            printfn "validation rule: %s" error
            if passed then            
                let passed, error = secondRule phrase
                printfn "validation rule: %s" error
                if passed then true, "" else false, error
            else false, error)
let validateR = buildValidator rules
let resultR, messageR = validateR phrase

printfn "validation is: %A - text is: %s" resultR messageR


