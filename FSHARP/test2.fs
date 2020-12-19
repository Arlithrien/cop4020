

let Test2Problem1 n =
  let isPrime n =
      let rec check i = i > n/2 || (n%i<>0 && check (i+1))
      check 2
  let primeList n = List.filter (isPrime) ([2..n])
  [|for i in [0..2..(n*2-1)] do yield primeList(n*n).[i]|]




let fibSeq = Seq.unfold (fun (current, next) -> Some(current, (next, current + next))) (0,1)
let fib n = Seq.takeWhile (fun x -> x < n) fibSeq
let endsIn3 n = if n % 10 = 3 then true else false

let test2Problem2 n = 
  let rec filter f list =
      match list with
      | x::xs when f x -> x::(filter f xs)
      | _::xs -> filter f xs 
      | [] -> []
  fib n 
  |> Seq.toList
  |> filter (endsIn3)



