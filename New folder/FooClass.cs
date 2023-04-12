using System;
using System.Threading;

public class Foo {
  private ManualResetEvent firstEvent = new ManualResetEvent(false);
  private ManualResetEvent secondEvent = new ManualResetEvent(false);

  public void first() {
   
    Console.WriteLine("first");
    
    firstEvent.Set();
  }

  public void second() {
    
  
   
    Console.WriteLine("second");
    
    secondEvent.Set();
  }

  public void third() {
  
   
    Console.WriteLine("third");
  }
}

public class Program {
  static void Main(string[] args) {
    Foo foo = new Foo();
    int[] order = { 2,3,1 }; 
    Thread[] threads = new Thread[3];
    for (int i = 0; i < order.Length; i++) {
      int index = order[i] - 1;
      if (index == 0) {
        threads[index] = new Thread(new ThreadStart(foo.first));
      } else if (index == 1) {
        threads[index] = new Thread(new ThreadStart(foo.second));
      } else if (index == 2) {
        threads[index] = new Thread(new ThreadStart(foo.third));
      }
    }
    
    for (int i = 0; i < threads.Length; i++) {
      threads[i].Start();
    }
    // wait for all threads to complete
    for (int i = 0; i < threads.Length; i++) {
      threads[i].Join();
    }
    
    for (int i = 0; i < order.Length; i++) {
      int index = order[i] - 1;
      if (index == 0) {
        Console.Write("one");
      } else if (index == 1) {
        Console.Write("two");
      } else if (index == 2) {
        Console.Write("three");
      }
    }
  }
}
