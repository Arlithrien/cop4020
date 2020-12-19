import Data.Char
import Data.List

let2nat str = ord str - 97

nat2let n = chr (n + 97)

shift x y 
        | isLower y = (nat2let((let2nat(y) + x) `mod` 26))
        |otherwise = y

encode x str =  map(\c -> shift x c) str

unshift x y
        | isLower y = (nat2let((let2nat(y) - x) `mod` 26))
        |otherwise = y

decode x str = map(\c -> unshift x c) str

lowers  st = sum[1 | c <- st, c `elem` ['a'..'z']] 

count x str = sum[1 | c <- str, c `elem` [x]]

percent a b = (fromIntegral a) / (fromIntegral b)

rotate x xs = zipWith const (drop x (cycle xs)) xs

position x xs = elemIndex x xs
