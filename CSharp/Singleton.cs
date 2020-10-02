using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public sealed class Singleton
    {
        private static int counter = 0;
        public static readonly Lazy<Singleton> _lazy = new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance
        {
            get
            {
                return _lazy.Value;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Constructor invoked " + counter.ToString() + " times.");
        }
        public void GetDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
