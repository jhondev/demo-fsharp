module NewtonsoftPackage

open Newtonsoft.Json

type Person = {
    Name: string
    Age: int
}

let printPerson = 
    let text = """{ "name": "Sam", "age": 18 }"""
    let person = JsonConvert.DeserializeObject<Person>(text)
    printfn "Name is %s with age %d." person.Name person.Age    
