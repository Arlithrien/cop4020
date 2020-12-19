
let multipleOf5 n = [|for i in 1..n do if i % 5 = 0 then yield i|]

printfn "Hello world"
let multipleOf7Or11 n = [|for i in 1..n do if i%7 = 0 || i%11 = 0 then yield i|]

let multipleOf3And7 n = [|for i in 1..n do if i%3=0 && i%7=0 then yield i|]

let IsPrime n =
    let rec check i = i > n/2 || (n%i<>0 && check (i+1))
    check 2

let rec factorial n =
  match n with
  | 0 -> 0
  | 1 -> 1
  | n -> n * factorial(n-1)

let rec fibonacci n =
  match n with 
  | 0 -> 0
  | 1 -> 1
  | 2 -> 1
  | n -> fibonacci(n-1) + fibonacci(n-2)
