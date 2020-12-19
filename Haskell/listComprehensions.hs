
multipleOf5 n = [x | x <- [1..n], x `mod` 5 == 0]


multipleOf7Or11 n = [x | x <- [1..n], ((x `mod` 7 == 0) || (x 'mod' 11 == 0))]


multipleOf3And7 n = [x | x <- [1..n], ((x `mod` 3 == 0) && (x `mod` 7 == 0))]