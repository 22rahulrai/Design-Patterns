using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public sealed class Singleton // sealed class is used to prevent inheritance
    {
        private static int counter = 0; //used to how many constructor is called


        //private static readonly object obj = new object(); //it is used to lock the object
        //private static Singleton instance = null;
        //--- public property is used to return only one instance of the class
        //public static Singleton Getinstance
        //{
        //    get
        //    {
        //        lock (obj) //it run only one thread at a time
        //        {
        //            if (instance == null)
        //            {
        //                instance = new Singleton();
        //            }
        //        }

        //        return instance;
        //    }
        //}


        //private static readonly Singleton instance = new Singleton(); //eager loading  Instance is created at class loading time
        //public static Singleton Getinstance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}

        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Getinstance
        {
            get
            {
                return instance.Value;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void Printdetails(string message) //public
        {
            Console.WriteLine(message);
        }
    }
}
