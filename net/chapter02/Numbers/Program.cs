using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means positive whole number, including 0
            uint naturalNumber = 23;

            // integer means negative or positive whole number, including 0
            int integerNumber = 23;

            // float means single-precision floating point
            // F sufix makes it a float literal
            float realNumber = 2.3F;

            // double means double-precision floating point
            double anotherRealNumber = 2.3;

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");

            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");

            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            Console.WriteLine("Using Doubles:");

            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3){
                Console.WriteLine($"{a} + {b} equals 0.3");
            }else{
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }

            Console.WriteLine("Using Decimals:");

            decimal c = 0.1M;
            decimal d = 0.2M;

            if (c + d == 0.3M){
                Console.WriteLine($"{c} + {d} equals 0.3");
            }else{
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }

        }
    }
}
