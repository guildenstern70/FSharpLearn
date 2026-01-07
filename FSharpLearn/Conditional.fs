(*

    FSharpLearn
    (C) 2026 Alessio Saltarin
    MIT License - see LICENSE

*)

module FSharpLearn.Conditional

// This function checks if a number is even or odd
let checkEvenOdd number =
    if number % 2 = 0 then
        printfn $"%d{number} is even"
    else
        printfn $"%d{number} is odd"


// This is a conditional expression that returns a value
let getSign number =
    if number > 0 then
        "Positive"
    elif number < 0 then
        "Negative"
    else
        "Zero"

// This function returns a description of a playing card based on its number
// Remember that indentation is significant in F#.
// Also, in F# equality is tested with a single '=' sign (!!!)
let getCardDescription cardNo =  
   if cardNo = 1 || cardNo = 14 then "Ace"
   elif cardNo = 11 then "Jack"
   elif cardNo = 12 then "Queen"
   elif cardNo = 13 then "King"
   else string cardNo
        
