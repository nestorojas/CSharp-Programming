using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton one = Singleton.GetInstance;
            one.GetDetails("From first call ");
            Singleton two = Singleton.GetInstance;
            two.GetDetails("From second call ");
        }
    }
}
