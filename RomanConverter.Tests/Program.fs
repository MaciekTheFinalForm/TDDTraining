﻿// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open Fuchu

[<EntryPoint>]
let main argv = 
    let result = defaultMainThisAssembly argv
    System.Console.ReadKey() |> ignore
    result
    

