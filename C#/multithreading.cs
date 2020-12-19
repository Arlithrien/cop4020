// Multithreaded program that divides an array of integers into four "threads" to run the calculations function faster

static int[] data = new int[10000000];
static int numThreads = 4;

static void Main(string[] args)
{
  Thread[] thrds = new Thread[numThreads];
  int blockSize = data.Length / numThreads;
  
  // start timer
  DateTime start = DateTime.Now;
  // first, sequential call of calc function
  calc(0, data.Length);
  // end timer
  TimeSpan ts = DateTime.Now - start;
  Console.WriteLine("Sequentially, calc takes " + "{0}", (int)ts.TotalMilliseconds + " milliseconds to run.");
  
  // start a 2nd timer
  DateTime start2 = DateTime.Now;
  // second, multithreaded call of calc function
  for(int i = 0; i < numThreads; i++)
  {
    int j = i;
    thrds[i] = new Thread(() => calc(j * blockSize, blockSize));
	thrds[i].Start();
  }
   
   for(int i = 0 ; i < numThreads; i++)
   {
     thrds[i].Join();
  }
  // end 2nd timer
  TimeSpan ts2 = DateTime.Now - start2;
  Console.WriteLine("Multithreaded, calc takes " + "{0}", (int)ts2.TotalMilliseconds + " milliseconds to run.");
  
}

static void calc(int start, int len)
{
  // assign the data array from start to start + len, run the calculations
  for(int i = start; i<start+len; i++)
  {
    data[i] = (int)(Math.Atan(i) * Math.Acos(i) * Math.Cos(i)  * Math.Sin(i));
  }
}