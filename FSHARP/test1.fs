

let test1Problem1 n =
  let IsPrime n =
      let rec check i = i > n/2 || (n%i<>0 && check (i+1))
      check 2
  let primeList n = List.filter (IsPrime) ([2..n])
  [|for i in [0..2..(n*2-1)] do yield primeList(n*n).[i]|]

////////////////////////////////////////////////////////////
let isPrime n =
    let rec check i = i > n/2 || (n%i<>0 && check (i+1))
    check 2
let Test2Problem1 n = [|for i in 2..n do if isPrime(i) then yield i|]


let rec fibonacci n =
  match n with 
  | 0 -> 0
  | 1 -> 1
  | 2 -> 2
  | n -> fibonacci(n-1) + fibonacci(n-2)

let rec fib n =
  match n with
  | 0 -> 0
  | 1 -> 1
  | 2 -> 2
  | n -> fib(n-1) + fib(n-2)

let test2Problem2 n = [|for i in 3..n do if fibonacci(i) = true then yield fibonacci(i)|]
// let testProblem2 n =
//   let isPrime n =
//     let rec isPrimeRec n i =
//       if i = 1 then true
//       else if n % i = 0 then false
//       else isPrimeRec n (i-1)
//     if n > 1 isPrimeRec n (n-1) else false
//   let primeList n = List.filter (isPrime) ([2..n])

//   [|for i in [0..2..(n*2-1)] do yield primeList(n*n).[i]|]


let printHello2 n =
  seq { 1 .. n }
  |> Seq.iter (fun _ -> printfn "Hello World")