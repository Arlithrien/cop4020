using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ___Lesson_2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>()
            {
                new Person("Tod", "Vachev", 1, 180, 26, Gender.Male),
                new Person("John", "Johnson", 2, 170, 21, Gender.Male),
                new Person("Anna", "Maria", 3, 150, 22, Gender.Female),
                new Person("Kyle", "Wilson", 4, 164, 29, Gender.Male),
                new Person("Anna", "Williams", 5, 164, 28, Gender.Male),
                new Person("Maria", "Ann", 6, 160, 19, Gender.Female),
                new Person("John", "Jones", 7, 160, 22, Gender.Female),
                new Person("Samba", "TheLion", 8, 175, 23, Gender.Male),
                new Person("Aaron", "Myers", 9, 182, 21, Gender.Male),
                new Person("Aby", "Wood", 10, 165, 20, Gender.Female),
                new Person("Maddie","Lewis",  11, 160, 19, Gender.Female),
                new Person("Lara", "Croft", 12, 162, 23, Gender.Female)
            };

			List<Buyer> buyers = new List<Buyer>()
            {
                new Buyer() { Name = "Johny", District = "Fantasy District", Age = 22},
                new Buyer() { Name = "Peter", District = "Scientists District", Age = 40},
                new Buyer() { Name = "Paul", District = "Fantasy District", Age = 30 },
                new Buyer() { Name = "Maria", District = "Scientists District", Age = 35 },
                new Buyer() { Name = "Joshua", District = "Scientists District", Age = 40 },
                new Buyer() { Name = "Sylvia", District = "Developers District", Age = 22 },
                new Buyer() { Name = "Rebecca", District = "Scientists District", Age = 30 },
                new Buyer() { Name = "Jaime", District = "Developers District", Age = 35 },
                new Buyer() { Name = "Pierce", District = "Fantasy District", Age = 40 }
            };

			List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier() { Name = "Harrison", District = "Fantasy District", Age = 22 },
                new Supplier() { Name = "Charles", District = "Developers District", Age = 40 },
                new Supplier() { Name = "Hailee", District = "Scientists District", Age = 35 },
                new Supplier() { Name = "Taylor", District = "EarthIsFlat District", Age = 30 }
            };

			List<Warrior> warriors = new List<Warrior>()
			{
				new Warrior() { Height = 100 },
				new Warrior() { Height = 80 },
				new Warrior() { Height = 100 },
				new Warrior() { Height = 70 }
			};

			string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
			List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };
			int[] arrayOfNumbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };
			object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 2, 3, 4 }, "dd", 's', "Hello Kitty", 1, 2, 3, 4, };

#if CRAP
			var groupJoin = suppliers.GroupJoin(buyers,
												s => s.District,
												b => b.District,
												(s, buyersGroup) => new
												{
													s.Name,
													s.District,
													Buyers = buyersGroup
												});

			foreach(var grp in groupJoin)
			{
				Console.WriteLine("{0} District:{1}", grp.Name, grp.District);
				foreach( var item in grp.Buyers )
				{
					Console.WriteLine("  {0}", item.Name);
				}
			}


			var matching = from s in suppliers
						   orderby s.District
						   join b in buyers on s.District equals b.District into buyersGroup
						   select new
						   {
							   s.Name,
							   s.District,
							   Buyers = buyersGroup
						   };
#endif

#if CRAP
			var innerJoin = suppliers.Join( buyers,
											s => s.District,
											b => b.District, 
											(s, b) => new 
											{ 
												SupplierName = s.Name,
												BuyerName = b.Name,
												District = s.District 
											});

			foreach( var grp in innerJoin )
			{
				Console.WriteLine("{0}, {1}, {2}", grp.District, grp.SupplierName, grp.BuyerName );
			}

			Console.WriteLine("------------");

			var compositeJoin = suppliers.Join(buyers,
											s => new { s.District, s.Age }, // must be
											b => new { b.District, b.Age }, // identical
											(s, b) => new
											{
												SupplierName = s.Name,
												BuyerName = b.Name,
												District = s.District,
												Age = s.Age
											});

			foreach (var grp in compositeJoin)
			{
				Console.WriteLine("{0} {1}", grp.District, grp.Age);
				Console.WriteLine("  Supplier:{0}", grp.SupplierName);
				Console.WriteLine("  Buyer:{0}", grp.BuyerName);
			}
#endif

#if CRAP
			var evenOrOddNumbers = arrayOfNumbers.OrderBy(n => n).GroupBy(n => (n % 2 == 0) ? "Even" : "Odd").OrderBy(n => n.Count());
			foreach(var grp in evenOrOddNumbers)
			{
				Console.WriteLine("{0}", grp.Key);
				foreach( var n in grp )
				{
					Console.WriteLine(" {0}", n);
				}
			}

			var ageGroups = people.GroupBy(p => p.Age < 20  
													? "Young" : 
													p.Age >= 20 && p.Age < 22 
														? "Adult" : "Senior");

			Console.WriteLine("------------------");

			var howManyOfEachGroup = people.GroupBy(p => p.Gender)
											.Select(g => new
											{
												Gender = g.Key,
												numPeople = g.Count()
											});

			foreach( var grp in howManyOfEachGroup )
			{
				Console.WriteLine("{0}", grp.Gender);
				Console.WriteLine("  {0}", grp.numPeople);
			}
#endif

#if CRAP
			var simpleGrouping = people.Where(p => p.Age > 20).GroupBy(p => p.Gender);
			foreach (var grp in simpleGrouping)
			{
				Console.WriteLine("{0}", grp.Key);
				foreach (var p in grp)
				{
					Console.WriteLine("  {0} {1} - Age:{2}", p.FirstName, p.LastName, p.Age);
				}
			}

			Console.WriteLine("-------------------");

			var alphabeticalGroup = people.OrderBy(p => p.FirstName).GroupBy(p => p.FirstName[0] );
			foreach( var grp in alphabeticalGroup )
			{
				Console.WriteLine("{0}", grp.Key);
				foreach( var p in grp )
				{
					Console.WriteLine("  {0} {1}", p.FirstName, p.LastName);
				}
			}

			Console.WriteLine("-------------------");

			var multiKey = people.GroupBy(p => new { p.Gender, p.Age }).OrderBy(p => p.Count());
			foreach( var grp in multiKey)
			{
				Console.WriteLine("{0}", grp.Key);
				foreach( var p in grp )
				{
					Console.WriteLine("  {0} {1}", p.FirstName, p.LastName);
				}
			}
#endif

#if CRAP
			var oddNumbers = from n in numbers
							 where n % 2 == 1
							 select n;

			Console.WriteLine(string.Join(", ", oddNumbers));

			Console.WriteLine("----------------");

			var oddNumbers2 = numbers.Where(n => (n % 2 == 1));

			Console.WriteLine(string.Join(", ", oddNumbers2));

			Console.WriteLine("----------------");

			var shortWarriors = warriors.Where(wh => (wh.Height == 100));

			var shortWarriors2 = warriors.Where(wh => (wh.Height == 100))
										.Select(wh => wh.Height);

			List<int> shortWarriors3 = warriors.Where(wh => (wh.Height == 100))
										.Select(wh => wh.Height)
										.ToList();

			warriors.ForEach(w => Console.WriteLine(w.Height));
			shortWarriors3.ForEach(sw => Console.WriteLine(sw));
#endif

#if CRAP
			var peopleByAge = from p in people
							  group p by p.Age into ageGroup
							  orderby ageGroup.Key
							  select ageGroup;

			foreach( var grp in peopleByAge )
			{
				Console.WriteLine("{0}", grp.Key);
				foreach( var p in grp )
				{
					Console.WriteLine("{0}", p.Age);
				}
			}

			Console.WriteLine("------------------");

			var multipleKeys = from p in people
							   group p by new { p.Gender, p.Age } into multiKeysGroup
							   orderby multiKeysGroup.Count()
							   select multiKeysGroup;

			foreach( var grp in multipleKeys )
			{
				Console.WriteLine("Gender:{0},Age:{1}", grp.Key.Gender, grp.Key.Age );
				foreach( var p in grp )
				{
					Console.WriteLine("{0} {1}", p.FirstName, p.LastName );
				}
			}

			Console.WriteLine("------------------");

			int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

			var evenOrOddNumbers = from n in numbers
								   orderby n
								   let evenOrOdd = (n % 2 == 0) ? "Even" : "Odd"
								   group n by evenOrOdd into nums
								   orderby nums.Count()
								   select nums;

			foreach( var grp in evenOrOddNumbers )
			{
				Console.WriteLine("{0}", grp.Key);
				foreach( var n in grp )
				{
					Console.WriteLine("{0}", n);
				}
			}

			Console.WriteLine("------------------");

			var peopleWithMultipleGrouping = from p in people
											 let ageSelection = p.Age < 20 ? 
												"Young" : 
												p.Age >= 20 && p.Age <= 22 ? 
													"Adult" : 
													"Senior"
											orderby p.FirstName,p.LastName
											 group p by ageSelection;

			foreach (var grp in peopleWithMultipleGrouping)
			{
				Console.WriteLine("{0}", grp.Key);
				foreach (var p in grp)
				{
					Console.WriteLine("  {0} {1}", p.FirstName, p.LastName);
				}
			}

			Console.WriteLine("------------------");

			var howManyOfEachGroup = from p in people
									 group p by p.Gender into g
									 select new {Gender=g.Key,NumPeople=g.Count()};

			foreach( var item in howManyOfEachGroup )
			{
				Console.WriteLine("Gender:{0} ({1})", item.Gender, item.NumPeople);
			}
#endif

#if CRAP
			var multipleKeys = from p in people
							   group p by new { p.Gender, p.Age };

			foreach (var grp in multipleKeys)
			{
				Console.WriteLine("{0}", grp.Key);
				foreach (var p in grp)
				{
					Console.WriteLine("  {0} {1}", p.FirstName, p.LastName);
				}
			}

			Console.WriteLine("--------------------------------------------");

			var orderedKeys = from p in multipleKeys
						  orderby p.Count()
						  select p;

			foreach (var grp in orderedKeys)
			{
				Console.WriteLine("Gender:{0}, Age:{1}", grp.Key.Gender, grp.Key.Age );
				foreach (var p in grp)
				{
					Console.WriteLine("  {0} {1}", p.FirstName, p.LastName);
				}
			}
#endif

#if CRAP
			var genderGroup = from p in people
							  group p by p.Gender; // Returns IEnumerable<IGrouping

			foreach( var grp in genderGroup )
			{
				Console.WriteLine("{0}", grp.Key);
				foreach( var p in grp )
				{
					Console.WriteLine("  {0} {1}", p.FirstName, p.LastName );
				}
			}

			var groupWithConditions = from p in people
									  where p.Age > 20
									  group p by p.Age;

			foreach (var grp in groupWithConditions)
			{
				Console.WriteLine("{0}", grp.Key);
				foreach (var p in grp)
				{
					Console.WriteLine("  {0} {1} - {2}", p.FirstName, p.LastName, p.Age);
				}
			}

			var alphabeticalGroup = from p in people
									group p by p.FirstName[0];

			foreach (var grp in alphabeticalGroup)
			{
				Console.WriteLine("{0}", grp.Key);
				foreach (var p in grp)
				{
					Console.WriteLine("  {0} {1}", p.FirstName, p.LastName);
				}
			}

			var alphabeticalGroup2 = from p in people
									 orderby p.FirstName
									group p by p.FirstName[0];

			foreach (var grp in alphabeticalGroup2)
			{
				Console.WriteLine("{0}", grp.Key);
				foreach (var p in grp)
				{
					Console.WriteLine("  {0} {1}", p.FirstName, p.LastName);
				}
			}
#endif

		}

		static int[] stringToIntArray(string data)
		{
			int[] arrayFromString = data.Split(' ')
										.Select(element => int.Parse(element))
										.ToArray();

			return (arrayFromString);
		}

	}

	internal class Person
	{
		private string firstName;
		private string lastName;
		private int id;
		private int height;
		private int age;

		private Gender gender;

		public string FirstName
		{
			get
			{
				return this.firstName;
			}
			set
			{
				this.firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return this.lastName;
			}
			set
			{
				this.lastName = value;
			}
		}

		public int ID
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		public int Height
		{
			get
			{
				return this.height;
			}
			set
			{
				this.height = value;
			}
		}

		public int Age
		{
			get
			{
				return this.age;
			}
			set
			{
				this.age = value;
			}
		}

		public Gender Gender
		{
			get
			{
				return this.gender;
			}
			set
			{
				this.gender = value;
			}
		}

		public Person(string firstName, string lastName, int id, int height, int age, Gender gender)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = id;
			this.Height = height;
			this.Age = age;
			this.Gender = gender;
		}
	}

	internal enum Gender
	{
		Male,
		Female
	}

	internal class Warrior
	{
		public int Height { get; set; }
	}

	internal class Supplier
	{
		public string Name { get; set; }
		public string District { get; set; }
		public int Age { get; set; }
	}

	internal class Buyer
	{
		public string Name { get; set; }
		public string District { get; set; }
		public int Age { get; set; }
	}

}
