(*

    FSharpLearn
    (C) 2026 Alessio Saltarin
    MIT License - see LICENSE

*)

module FSharpLearn.Loops

// This function prints each number in a list
let printNumbersInList list =
    for i in list do
        printf $"%d{i} "
    printfn ""
  
// This function uses a classic for loop to print numbers from 1 to n
let classicForLoop n =
    for i = 1 to n do
        printf $"%d{i} "
    printfn ""
    
// This function uses a while loop to print numbers from 1 to n
let whileLoop n =
    let mutable i = 1
    while i <= n do
        printf $"%d{i} "
        i <- i + 1
    printfn ""
    