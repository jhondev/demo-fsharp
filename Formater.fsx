open System

let parse (person: String) =
    let values = person.Split(' ')
    values.[0], values.[1], int (values.[2])

let name, game, score = parse ("Mary Asteroids 2500")

printf "name: %s - game: %s - score: %i" name game score
