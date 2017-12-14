#r "packages/FSharp.Data.SqlClient.1.8.2/lib/net40/FSharp.Data.SqlClient.dll"
open FSharp.Data
open System.Linq

// This literal needs to be accessible at build time to generate the types
[<Literal>]
let connectionString = 
    @"Data Source=.;Initial Catalog=bts_development;Integrated Security=True"
    
type dbContext = SqlProgrammabilityProvider<connectionString>

// The connection string here can be different from the build one, for example, one pulled from config
let fetchCmd = new dbContext.Person.FetchPerson(connectionString)

// Nullable column
let birthDate = 
    use fetchCmd = new dbContext.Person.FetchPerson(connectionString)
    match fetchCmd.Execute(1388).First().BirthDate with
    | Some bd -> bd.ToShortDateString()
    | None -> "No birthdate"

// Now lets do some live coding against another table
