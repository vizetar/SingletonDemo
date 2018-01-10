using System;
using System.Threading.Tasks;

namespace SingletonMultithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => FirstFunc(),
                            () => SecondFunc());

            Console.ReadLine();
        }

        private static void SecondFunc()
        {
            Singleton s2 = Singleton.ReturnInstance;
            s2.DisplayFunc("This is Second msg");
        }

        private static void FirstFunc()
        {
            Singleton s1 = Singleton.ReturnInstance;
            s1.DisplayFunc("This is first msg");
        }
    }
}
