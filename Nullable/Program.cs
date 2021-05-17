using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = 10.0;
            double? y = null; // double? é o mesmo que Nullable<double>

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
