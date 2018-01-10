using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonMultithreading
{
    public sealed class Singleton
    {
        private static int count = 0;
        private Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
       // private static readonly object objLock = new object();
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());

        public static Singleton ReturnInstance
        {
            get
            {
                //if (instance == null)
                //{
                //    lock (objLock)
                //    {
                //        if (instance == null)
                //            instance = new Singleton();
                //    }
                //}
                return instance.Value;
            }
        }

        public void DisplayFunc(string text)
        {
            Console.WriteLine(text);
        }
    }
}
