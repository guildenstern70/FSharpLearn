(*

    FSharpLearn
    (C) 2026 Alessio Saltarin
    MIT License - see LICENSE

*)

module FSharpLearn.Functions


// This function adds two numbers and then multiplies the result by a third number.
// To call this function, you would use:
// - addAndMultiply 2 3 4
let addAndMultiply a b c = 
    let sum = a + b
    let product = sum * c
    product
    
    
// This function is similar to addAndMultiply but with explicit type annotations.
let typedAddAndMultiply (a: int) (b: int) (c: int) : int = 
    let sum = a + b
    let product = sum * c
    product
    
// The >> operator is the function composition operator in F#.
// It takes two functions as input and returns a new function that is the composition of the two.
// The output of the first function becomes the input of the second function.
// It applies functions from left to right.
let composedAddAndMultiply (a: int): int =
    let add2 a = a + 2
    let multiply3 a = a * 3 
    let composedFunction = add2 >> multiply3
    composedFunction a

// The pipeline operator |> is used to pass the result of one function as the input to another function.
// This function takes a list of integers, sorts them, and then prints each item.
let printSortedList itemsList =
    let sort (list: int list) = List.sort list
    let print (list: int list)= List.iter(fun x-> printfn $"item %i{x}") list
    itemsList
    |> sort
    |> print
    
// This function accepts and returns a tuple of two lists.
// tuple's first element is the deck.
// tuple's second element is the current hand.
// fst gets the first element of the tuple.
// snd gets the second element of the tuple.
// The functin returns: the remaining cards in deck, and the current hand.
let drawCard (tuple: int list * int list) = 
    let deck = fst tuple
    let draw = snd tuple
    let firstCard = deck.Head
    printfn $"Picked up: %i{firstCard}"
    let hand = 
        draw
        |> List.append [firstCard]
    (deck.Tail, hand)
