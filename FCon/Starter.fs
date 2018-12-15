open System

let test num =
    if num < 5 then "below five"
    elif num > 5 then "above five"
    else "was not a number"
 
let main() =
    Console.WriteLine("Number was {0}", (test 10))
    Console.ReadKey() |> ignore

main()