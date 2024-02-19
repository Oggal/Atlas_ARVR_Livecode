using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

class Program
    {
        static void Main(string[] args)
        {
            Counter.Countdown(10);

            Console.WriteLine("Goodbye World!");
        }

    }

class Counter
{
    int count;
    public static void Countdown(int startValue)
    {
        for (int index = startValue; index > 0; index--)
        {
            Console.WriteLine("{0} is a cool number", index);
        }
    } 

    public void Increment(int value = 1)
    {
        count += value;
        Console.WriteLine("Count is now: {0}", count);
    }

}

