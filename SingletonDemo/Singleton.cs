using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int count=0;
        private Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
        private static Singleton instance = null;
        public static Singleton ReturnInstance
        {
            get {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        public void DisplayFunc(string text)
        {
            Console.WriteLine(text);
        }
    }
}
