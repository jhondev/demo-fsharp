#r @"../packages/Npgsql/lib/netstandard2.0/Npgsql.dll"
#r @"../packages/FSharp.Data.Npgsql/lib/netstandard2.0/FSharp.Data.Npgsql.dll"

let [<Literal>] Conn =
    "Host=localhost;Port=5003;Database=fluidcerts;Username=postgres;Password=postgres"     

type certsCmd = FSharp.Data.Npgsql.NpgsqlCommand<"SELECT id, name FROM certificates_templates", Conn>

let certificates = certsCmd.Create(Conn).Execute()

printfn "first name is %s" certificates.[0].name






