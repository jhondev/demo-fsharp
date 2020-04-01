type Customer =
    { Name: string }

type CustomerFunc = string -> string

let trying (customerFunc: CustomerFunc) = customerFunc ("text")

let r4 = trying (fun name -> name + " testing")

printf "%s" r4
