
let multipleOf5 n = [|for i in 1..n do if i%5=0 then yield i|]

let isPrime n =
    let rec check i = i > n/2 || (n%i<>0 && check (i+1))
    check 2

//lists all primes from 1 to n, and then squares them
let listPrimesSquared n = [|for i in 1..n do if isPrime(i) = true then yield i*i|]

let test2Problem3 n = Array.sort(Array.concat [multipleOf5(n); listPrimesSquared(n)])




let test1problem3 n =
  // Auxillary Functions
  let factors n = [|for i in 1..n do if n%i = 0 then yield i|]

  // test1problem3 main function code
  [|for i in 1..n do if (i % 5 = 0) || ((Array.length (factors i)) = 3) then yield i|]



  ////////////////////////////////////////////////////////
  
let test1problem4 n =
  // Auxillary Functions
  let factors n = [|for i in 1..n do if n%i = 0 then yield i|]
  
  // test1problem4 main function code
  [|for i in 1..n do if (i % 5 = 0) || ((Array.length (factors i)) = 3) then yield i|]