let test1question2 n =
  let fibSeq = Seq.unfold (fun (a, b) -> Some(a, (b, a + b))) (0, 1)

  let rec filter f list =
      match list with
      | x::xs when f x -> x::(filter f xs)
      | _::xs -> filter f xs
      | [] -> []

  Seq.takeWhile (fun x -> x <= n) fibSeq
  |> Seq.toList
  |> filter (fun n -> n % 10 = 3)

  //////////////////////////////////////////////////////
  
let test1Problem2 n = 
  let fibSeq = 
      Seq.unfold(fun (old, cur) -> Some(old, (cur, old + cur))) (0, 1)
  let fibList = 
      Seq.toList (Seq.takeWhile (fun x -> x <= n) fibSeq)
  let rec run xs =
      let h = List.head xs
      if List.length xs = 0 then [||]
      elif List.length xs = 1 then if h % 10 = 3 then [|h|] else [||]
      elif h % 10 = 3 then (Array.append [|h|] (run(List.tail xs)))
      else run(List.tail xs)
  run fibList

    //////////////////////////////////////////////////////
   
let rec fibonacci n =
  if n < 2 then 1
  else fibonacci (n-1) + fibonacci(n-2)
let rec test1Problem2Plus n i =
  let x = fibonacci i
  if x >  n then []
  elif (x % 10) = 3 then x :: test1Problem2Plus n (i + 1)
  else test1Problem2Plus n (i+1)

///////////////////////////////////////////////////////////////