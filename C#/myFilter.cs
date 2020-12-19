// Implement a function called myFilter that does the following:
// - Takes a sequence of integers with values 0 to 100
// - First remove all multiples of 5 greater than 50
// - Then cube each number
// - Finally, remove any resulting integer that is even



public class Problem1
{
  public static IEnumerable<int> myFilter(IEnumerable<int> input)
  {
  	return input.Where(x => x <= 50 || (x > 50 && x % 5 != 0)).Select(y => y * y * y ).Where(z => z % 2 != 0).ToList();
  }
}
static void Main(string[] args)
{
  Random rnd = new Random(5); // Important to seed with 5 for repeatability.
  var listForProblem =
    Enumerable.Range(1,100).Select(i => rnd.Next() % 101);
  var answer = Problem1.myFilter( listForProblem );
  foreach( int i in answer )
  {
    Console.WriteLine(i);
  }
}