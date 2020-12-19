
isqrt = floor . sqrt . fromIntegral

ip _ [] = True
ip n (x:xs)
    | n `mod` x == 0 = False
    | otherwise = True
isPrime n = ip n [2..(isqrt n)]

let {factorial 0 = 1; factorial n = n * factorial(n-1)}

let { fibonacci 1 = 1; fibonacci 2 = 1; fibonacci x = fibonacci(x-1) + fibonacci(x-2)}

