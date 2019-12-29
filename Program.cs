using System;

namespace nullable_value_types_ar
{
    class Program
    {
        bool x;//default false
        static void Main(string[] args)
        {
            //nullable value types
            /*bool? agree = true;
            Nullable<bool> y = null;
            Console.WriteLine(agree);
            //declaration and assignment of nullable value types

            double? pi = 3.14;
            char? letter = 'a';
            Console.WriteLine(letter);
            int m2 = 10;
            int? m = m2;
            bool? flag = null;
            //an array of a nullable types
            int?[] arr = new int?[3];
            arr[0] = 2;
            arr[1] = null;
            arr[2] = null;*/
            //examination of an instance of a nullable value type

            /*
            int? a = null;
            if (a is int v)
                Console.WriteLine($"a is {v}");
            else
                Console.WriteLine("a does not have a value");
            */
            //HasValue
            /*
            int? b = null;
            if (b.HasValue)
                Console.WriteLine($"b is {b.Value}");
            else
                Console.WriteLine("b deos not have a value");
                */

            /*int? c = 7;
            if (c != null)
                Console.WriteLine($" c is {c.Value}");
            else
                Console.WriteLine("c does not have a value");*/

            //conversion from a nullable value type to an underlying type
            int? a = 28;
            int b = a ?? 4;
            Console.WriteLine($"b is {b}");// output 28

            int? c = null;
            int d = c ?? -1; //coalescing operator
            Console.WriteLine($" d is {d}");//output  is -1
            // explicit cast  a nullable value type to non nullable type
            int? n = null;
            //int m1 = n;//desn't compile
            int n2 = (int) n;// compile but throws exception if n  is null
            Console.WriteLine(n2);
        }
    }
}
