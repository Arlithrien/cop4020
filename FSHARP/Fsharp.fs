//Learn more about F# at http://fsharp.net
// See the 'F# tutorial' project for more help.

printfn "Hello F# world" 

//Forward Pipe Examples (|>):

let CircleArea r = System.Math.PI * r ** 2

let RoundedCircleArea r = CircleArea r |> Round

//Tuple Examples
let position = (1.0, 3.5, 9.2)

let MyTyple = (1, "two")

//you can add
let x,y = MyTuple //and get
val y: string = "two"

//Records - a type with field names and types
//easy to instantiate, structural equality
//Record examples
let MyAccount = 
    {  
        Number = "XYZ123"
        Name = "Rick Leineacker"
    }

//Arrays
//creating an array
// from a literal
let primes = [|1; 3; 5; 7; 11|]
//from a comprehension
let someNumbers = [|1000..1020|]
let smallEvens = [|for i in 1..100 do
                    if i%2 = 0 then yield i|]
//using a function from the array module
Array.create
Array.instantiate
//With zero-valued elements
Array.zeroCreate
//From anoher array or IEnumerable

//more creating arrays
let names = 
    [|
        "Ringo"
        "John"
        "George"
        "Paul"
    |]
let smallEvens = [|for i in 1..100 do if i%2 = 0 then yield i |]

let lastDays year =
    [|
    for i in 1..12 do
        let firstDay = DateTime(year, i, 1)
        let lastDay = firstDay.AddDays(float(DateTime.DaysInMonth(year, i)-1))
        yield lastDay.DateTime
    |]
//even more about arrays
let emptyStrings = Array.zeroCreate 100 //DOES NOT WORK
let emptyStrings : string[] = Array.zeroCreate 100 //DOES WORK

//One more array creation
let files = System.IO.Directory.EnumerateFiles(@"d:\work")
//or
let files = System.IO.Directory.EnumerateFiles(@"d:\work")

//Accessing Array Elements
let myValue = myArray.[3]

//update elemtns with
myArray.[3]

//using Array.map

let fruits = [|"apples"; "oranges"; "pears"|]

let InitCap str =
    if String.IsNullOrEmpty str then
        str
    else
        str.[0].ToString().ToUpperInvariant() + str.[1..]




        




























