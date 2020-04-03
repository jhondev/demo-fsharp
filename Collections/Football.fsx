type FootballResult =
    { HomeTeam: string
      AwayTeam: string
      HomeGoals: int
      AwayGoals: int }

let newResult (homeTeam, homeGoals) (awayTeam, awayGoals) =
    { HomeTeam = homeTeam
      HomeGoals = homeGoals
      AwayTeam = awayTeam
      AwayGoals = awayGoals }

let results =
    [ newResult ("Messiville", 1) ("Ronaldo City", 2)
      newResult ("Messiville", 1) ("Bale Town", 3)
      newResult ("Bale Town", 3) ("Ronaldo City", 1)
      newResult ("Bale Town", 2) ("Messiville", 1)
      newResult ("Ronaldo City", 4) ("Messiville", 2)
      newResult ("Ronaldo City", 1) ("Bale Town", 2) ]

//  which teams won the most away games in the season.
let awayWinners =
    results
    |> List.filter (fun r -> r.AwayGoals > r.HomeGoals)
    |> List.groupBy (fun r -> r.AwayTeam)
    |> List.map (fun (r, i) ->
        {| name = r
           victories = i.Length |})
    |> List.sortByDescending (fun r -> r.victories)

printfn "%A" awayWinners
