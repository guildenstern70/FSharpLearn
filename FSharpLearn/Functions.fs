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
    
    