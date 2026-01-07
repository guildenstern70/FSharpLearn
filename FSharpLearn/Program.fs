(*

    FSharpLearn
    (C) 2026 Alessio Saltarin
    MIT License - see LICENSE

*)

module Program

open FSharpLearn.Conditional
open FSharpLearn.Loops
open FSharpLearn.Functions


let testConditionals =
    checkEvenOdd 15
    checkEvenOdd 42
    let minusOne = getSign -1
    let zero = getSign 0
    let seven = getSign 7
    printfn $"-1 => %s{minusOne}"
    printfn $" 0 => %s{zero}"
    printfn $" 7 = > %s{seven}"
    let cardDesc1 = getCardDescription 1
    let cardDesc11 = getCardDescription 11
    let cardDesc7 = getCardDescription 7
    printfn $"Card 1  => %s{cardDesc1}"
    printfn $"Card 11 => %s{cardDesc11}"
    printfn $"Card 7  => %s{cardDesc7}"
    
let testLoops =
    let numbers = [1; 2; 3; 4; 5]
    printfn "Numbers in list: "
    printNumbersInList numbers
    classicForLoop 10
    whileLoop 7
    
let testFunctions =
    let first = addAndMultiply 2 3 4
    let second = typedAddAndMultiply 2 3 4
    let third = composedAddAndMultiply 5
    if first = second then
        if third = 21 then
            printfn "Functions test OK"
        else
            printfn $"Functions KO: %i{third}"
           

[<EntryPoint>]
let main argv =
    testConditionals
    testLoops
    testFunctions
    0