// Learn more about F# at http://fsharp.org

open System

// Exercise 1.
let rec f n =
    match n with
    | 0 -> 0
    | n -> n + f(n-1)

// Exercise 2.
let rec sum (m, n) = 
    match (m, n) with
    | (m, 0) -> m
    | (m, n) -> m + sum(m+1, n-1)

// Exercise 3.
let rec bin (n, k) = 
    match (n, k) with
    | (_, 0) | (0, _) -> 1
    | (n, k) when n = k -> 1
    | (n, k) when n > k -> bin(n-1, k-1) + bin(n-1, k)
    | (n, k) -> -1

// Exercise 4.
let rec multiplicity (x, ys) =
    match ys with
    | [] -> 0
    | y :: tail when y = x -> 1 + multiplicity (x, tail)
    | y :: tail -> multiplicity (x, tail)

// Exercise 5.
let rec mulc (x, ys) = 
    match ys with
    | [] -> []
    | y :: tail -> y*x::mulc (x, tail)

// Exercise 6.
let rec addE (xs, ys) = 
    match (xs, ys) with
    | ([], _) -> ys
    | (_, []) -> xs
    | (x::xtail, y::ytail) -> x+y::addE(xtail, ytail)

// Exercise 7.
// (a)
let rec mulX (xs) = 0::xs

// (b)
let rec mul (xs, ys) =
    match (xs) with
    | ([], _)

    | x :: tail -> addE (mulc(x, ys), mul(tail, ys)

[<EntryPoint>] 
let main argv =
    // Print integers
    //printfn "%d" (multiplicity(4, [1; 2; 2; 4; 4; 2; 6; 4; 2]))

    // Print lists
    //mulc (3, [1; 2; 3; 4; 5; 6]) |> Seq.iter (printf "%d ")
    mulX ([1; 2; 3]) |> Seq.iter (printf "%d 8")
    0 // return an integer exit code