using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            FloorTemperature(0);
        }
        public static void FloorTemperature(float degrees)
        {
            object degreesRef = degrees;
            var result = (int)(float)degreesRef;
            Console.WriteLine(result);
        }
    }
}
