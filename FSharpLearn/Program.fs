(*

    FSharpLearn
    (C) 2026 Alessio Saltarin
    MIT License - see LICENSE

*)

module Program

open FSharpLearn.Conditional
open FSharpLearn.Loops
open FSharpLearn.Functions
open FSharpLearn.Collections


let testConditionals =
    printfn "*** CONDITIONALS TEST"
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
    printfn "*** LOOPS TEST"
    let numbers = [1; 2; 3; 4; 5]
    printfn "Numbers in list: "
    printNumbersInList numbers
    classicForLoop 10
    whileLoop 7
    
let testFunctions =
    printfn "*** FUNCTIONS TEST"
    let first = addAndMultiply 2 3 4
    let second = typedAddAndMultiply 2 3 4
    let third = composedAddAndMultiply 5
    if first = second then
        if third = 21 then
            printfn "Functions test OK"
        else
            printfn $"Functions KO: %i{third}"
    printSortedList [5; 3; 8; 1; 4]
    let hand = [3]
    let deck = [1; 2; 3; 4; 5; 6; 7; 8]
    let draw = drawCard (deck, hand)
    let remainingDeck = fst draw
    let hand = snd draw
    printfn "Tail > "
    List.iter(fun card -> printf $"%i{card};") remainingDeck 
    printfn "\nHand > "
    List.iter(fun card -> printf $"%i{card};") hand
    printfn ""
    
let testCollections =
    printfn "*** COLLECTIONS TEST"
    let remainingCards = fullList.Tail // "King", "Queen", "Jack", "10"
    for card in remainingCards do
        printfn $"%s{card}"

           

[<EntryPoint>]
let main argv =
    testConditionals
    testLoops
    testFunctions
    testCollections
    0