using System;
using System.Threading;

public class PrintZeroEvenOdd
{
    private Semaphore even;
    private Semaphore odd;
    private Semaphore zero;
    private int n;

    public PrintZeroEvenOdd(int n)
    {
        this.n = n;
        this.even = new Semaphore(0, 1);
        this.odd = new Semaphore(0, 1);
        this.zero = new Semaphore(1, 1);
    }

    public void Zero(Action<int> printNumber)
    {
        for (int i = 0; i < n; i++)
        {
            zero.WaitOne();
            printNumber(0);
            if ((i & 1) == 0)
            {
                odd.Release();
            }
            else
            {
                even.Release();
            }
        }
    }

    public void Even(Action<int> printNumber)
    {
        for (int i = 2; i <= n; i += 2)
        {
            even.WaitOne();
            printNumber(i);
            zero.Release();
        }
    }

    public void Odd(Action<int> printNumber)
    {
        for (int i = 1; i <= n; i += 2)
        {
            odd.WaitOne();
            printNumber(i);
            zero.Release();
        }
    }

    public static void Main(string[] args)
    {
        int n = 2;

        PrintZeroEvenOdd printZeroEvenOdd = new PrintZeroEvenOdd(n);

        Thread t1 = new Thread(() => printZeroEvenOdd.Zero(Console.Write));
        Thread t2 = new Thread(() => printZeroEvenOdd.Even(Console.Write));
        Thread t3 = new Thread(() => printZeroEvenOdd.Odd(Console.Write));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
    }
}
