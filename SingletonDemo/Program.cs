using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.ReturnInstance;
            s1.DisplayFunc("This is first msg");

            Singleton s2 = Singleton.ReturnInstance;
            s2.DisplayFunc("This is Second msg");
            Console.ReadLine();

        }
    }
}
