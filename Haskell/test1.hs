isPrime 0 = False
isPrime 1 = False
isPrime n = ip n [2..(n `div` 2)]

ip _ [] = True
ip n (x:xs) | n `mod` x==0 = False | otherwise = ip n xs
 
fib 0 = 0
fib 1 = 1
fib n = fib(n-1) + fib(n-2)

test1Problem1 n = take n [i | i <- [2..], isPrime i]

test1Problem2 n = [x | ]

test1Problem3 n = [x | x <- [1..n], (x `mod` 5 == 0 || (generatePrimes x^2))]
