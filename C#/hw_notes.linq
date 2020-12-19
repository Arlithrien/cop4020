<Query Kind="Expression" />

static void Main(string[] args)
		{
			Random rnd = new Random(5);
			var randomValues = Enumerable.Range(1,100).Select(_ => rnd.Next() % 101);
			
			var csvString = new Func<IEnumerable<int>, string>(values =>
				{
					return String.Join(",", values.Select(v => v.ToString()).ToArray();
				});
				
			foreach(var s in randomValues)
			{
				console.WriteLine(s);
			}
			
		}
		
		
		
		
		static void Main(string[] args)
		{
			string = "This is a test";
			Console.WriteLine*s.Reverse().ToArray());
		
		}