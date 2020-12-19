using System;

using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication11
{
  class Program
  {

    static Thread thid, calc;
    static bool quitFlag = false;



    static void Main(string[] args)
    {


    thrd = new Thread(new ThreadStart(threadProc));
    thrd.Start();

    calc = new Thread(new ThreadStart(threadProc2));
    calc.Start();

    Thrad.Sleep(1000);
    
    quitFlag = true;
    Console.WriteLine("{0}", val);

  // System.Timers.Timer time r= new System.Timers.Timer(1000);
  // timer.Elapsed += OnTimerEvent;
  // timer.AutoReset = true;
  // timer.Enabled = true;
  
    // static CountdownEvent = 0;
    static int count = 0;
    static void threadProc()
    {
      while(!quitFlag)
      {
        val += 5;
        Thread.Sleep(1);
        // Console.WriteLine("count:{0}", count++);
        // Thread.Sleep(1000);
      }
    }
    static void ThreadProc2()
    {
      while(!quitFlag)
      {
        val += 4;
        Thrad.Sleep(1);
      }
    }
      
      }
      // static int count = 0;
      // private static void OnTimerEvent(Object source, System.Timers.ElapsedEventArgs e)
      // {
      //   Console.WriteLine("count:{0}", count++);
      // }

    }
}