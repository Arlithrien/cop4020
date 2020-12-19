//Implement a function called merge that does the following:
// Takes three sequences of numbers from 1 to 15
// Merge the list with members that adhere to the following requirements
// Any multiple of 3
// Is a member of all three lists


public class TestProblem2{ public static IEnumerable<int> merge(IEnumerable<int> input1,
 IEnumerable<int> input2, IEnumerable<int> input3)
  {
  	
		
	IEnumerable<int> answer = Enumerable.Range(1, 10);
    input1 = input1.Where(x => (x % 3 == 0)).ToList();
	input2 = input2.Where(x => (x % 3 == 0)).ToList();
	input3 = input3.Where(x => (x % 3 == 0)).ToList();
	answer = answer.Where( x => (input1.Contains(x) && input2.Contains(x) && input3.Contains(x)));
	
    return answer;
  }
}
   
static void Main(string[] args)
{
    Random rnd = new Random();  
    var list1 = Enumerable.Range(1,10).Select(i => (rnd.Next() % 15)+1);  
    var list2 = Enumerable.Range (1,10).Select(i => (rnd.Next() % 15)+1);  
    var list3 = Enumerable.Range (1,10).Select(i => (rnd.Next() % 15)+1);  
    var answer = TestProblem2.merge(list1,list2,list3);  
    foreach( int i in answer )  
    {    
      Console.WriteLine(i);  
    }
}