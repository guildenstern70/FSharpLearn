(*

    FSharpLearn
    (C) 2026 Alessio Saltarin
    MIT License - see LICENSE

*)


module FSharpLearn.Collections

// Lists
let cards = [
  "Ace"
  "King"
  "Queen"
]
let cardsInlineList = ["Ace"; "King"; "Queen"]

// Add to a list
let newList = "Jack" :: cards // "Jack", "Ace", "King", "Queen"

// Add a list to a list
let otherCardList = ["Jack"; "10"]
let fullList = cards @ otherCardList

// Get list item by index
let card = fullList.Item 2 // King

// List head
let firstCard = fullList.Head // "Ace"

// List tail
let remainingCards = fullList.Tail // "King", "Queen", "Jack", "10"

// Tuple of two lists
let tuple: string list * string list = ["Ace"; "King"; "Queen"], ["1"; "2"; "3"]

// Iterate list
let listIterator = List.iter(fun x-> printfn $"item %s{x}") remainingCards

// Map list
let mappedList = List.map(fun y -> $"%s{y};") remainingCards

// Filter list (the condition tells what to keep, not what to filter out)
let filteredList = List.filter(fun card -> card = "Jack") remainingCards

// Sum
let numbers = [1..50]
let sum = List.sum numbers // 1275

// Average
let floatNumbers = [1.0..50.0]
let average = List.average floatNumbers // 25.5