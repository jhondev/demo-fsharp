#r @"../packages/FSharp.Data/lib/netstandard2.0/FSharp.Data.dll"
#r @"../packages/Newtonsoft.Json/lib/netstandard2.0/Newtonsoft.Json.dll"
#r @"../packages/Google.DataTable.Net.Wrapper/lib/netstandard2.0/Google.DataTable.Net.Wrapper.dll"
#r @"../packages/XPlot.GoogleCharts/lib/netstandard2.0/XPlot.GoogleCharts.dll"

open XPlot.GoogleCharts

type Football = FSharp.Data.CsvProvider< @"../data/FootballResults.csv">
let data = Football.GetSample().Rows |> Seq.toArray

data |> Seq.filter(fun r -> r.``Full Time Home Goals`` > r.``Full Time Away Goals``)
     |> Seq.countBy(fun r-> r.``Home Team``)
     |> Seq.sortByDescending snd
     |> Seq.take 10
     |> Chart.Column
     |> Chart.Show