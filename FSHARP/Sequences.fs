
//Creating a Sequence

//From a range expression
let integers = {1..1000}

//fromm a sequence expression
let integers = seq {for i in 1..1000 do yield i}
let integers = seq{for i in 1..1000 -> i}

//Using a function in the Seq module
let integers = Seq.init 1000 (fun i -> i+1)
let integers = Seq.initInfinite (fun i -> i+1)

//From an IEnumberable
let Extensions (dir : string) = 
   Directory.EnumerateFiles(dir)
   |> Seq.map (fun name -> Path.GetExtension(name))
   |> Seq.distinct

   //Seq.init
   
