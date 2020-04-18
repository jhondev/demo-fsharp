#r "../packages/SQLProvider/lib/netstandard2.0/FSharp.Data.SqlProvider.dll"

[<Literal>]
let Conn =
    "Host=localhost;Database=fluidcerts;Username=postgres;Password=test"

[<Literal>]
let vendor = FSharp.Data.Sql.Common.DatabaseProviderTypes.POSTGRESQL

[<Literal>]
let resPath = "/home/jhondev/repos/repos-fsharp/fsharp_hello/packages/Npgsql/lib/netstandard2.1"

// type db = FSharp.Data.Sql.SqlDataProvider<DatabaseVendor=vendor, ConnectionString=Conn, ResolutionPath=resPath, UseOptionTypes=true>

// let context = db.GetDataContext()
