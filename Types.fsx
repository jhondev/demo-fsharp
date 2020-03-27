type Address =
    { City: string
      Country: string }

let address =
    { Address.City = "Medellin"
      Country = "CO" }

let address2 =
    { Address.City = "dddf"
      Country = "todo" }

let updatedAddress = { address with City = "Envigado" }

printfn "%A" address
printfn "%A" updatedAddress
