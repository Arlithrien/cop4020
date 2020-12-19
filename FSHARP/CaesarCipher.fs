
let inline let2nat n =  int(n) - int('a')


let nat2let n =char (n+97)
  
let shift (a: int) (b: char) = 
  match System.Char.IsLower(b) with
  | true -> (let2nat(b) + 3) % 26 |> nat2let
  | false -> b

let unshift (a: int) (b: char) = 
  match System.Char.IsLower(b) with
  | true -> (let2nat(b) - 3) % 26 |> nat2let
  | false -> b

let encode (a: int) (s: string) = 
    let (myArray: char[]) = s.ToCharArray()
    Array.map(fun x -> shift a x) (myArray) |> System.String.Concat


let decode (a: int) (s: string) =
  let (myArray: char[]) = s.ToCharArray()
  Array.map(fun x -> unshift a x) (myArray) |> System.String.Concat

let isLow (c: char) =
  match System.Char.IsLower(c) with
    | true -> 1
    | false -> 0

let isLower (str: string) =
  str.ToCharArray() |> Array.sumBy isLow

let count (s : string)(c : char) = 
    let rec loop i count =
        if i < s.Length then 
            if s.[i] = c then loop (i+1) (count+1)
            else loop (i+1) count
        else count
    loop 0 0

let percent (i: int) (j: int) = (i |> double) / (j |> double)
  




    
   



