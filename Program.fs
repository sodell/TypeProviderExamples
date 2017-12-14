// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
// reference the type provider dll
open FSharp.Text.RegexProvider

// Let the type provider do its work
type PhoneRegex = Regex< @"(?<AreaCode>^\d{3})-(?<PhoneNumber>\d{3}-\d{4}$)" >


// now you have typed access to the regex groups and you can browse it via Intellisense
PhoneRegex().TypedMatch("425-123-2345").AreaCode.Value

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
